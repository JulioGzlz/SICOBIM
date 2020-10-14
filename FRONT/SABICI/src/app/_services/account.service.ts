import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { environment } from '@environments/environment';
import { User } from '@app/_models';

@Injectable({ providedIn: 'root' })
export class AccountService {
    private userSubject: BehaviorSubject<User>;
    public user: Observable<User>;

    constructor(
        private router: Router,
        private http: HttpClient
    ) {
        this.userSubject = new BehaviorSubject<User>(null);
        this.user = this.userSubject.asObservable();
    }

    public get userValue(): User {
        return this.userSubject.value;
    }

    login(username: string, password: string) {
        return this.http.post<User>(`${environment.apiUrl}/users/authenticate`, { username, password },{withCredentials: true})
            .pipe(map(user => {
            //Se remueve el localStorage esto para consumir el servicio directo de autenticar y este generar token

                this.userSubject.next(user);
                this.startRefreshTokenTimer();
                console.log(user);
                return user;
            }));
    }

    logout() {

      this.http.post<any>(`${environment.apiUrl}/users/revoke-token`,{},{withCredentials: true}).subscribe();
      this.stopRefreshTokenTimer();
      this.userSubject.next(null);
       //Se remueve el remove.localStorage, esto para consumir el servicio directo de remover token
        this.router.navigate(['/account/login']);
    }
    refreshToken() {
      return this.http.post<any>(`${environment.apiUrl}/users/refresh-token`, {}, { withCredentials: true })
          .pipe(map((user) => {
              this.userSubject.next(user);
              this.startRefreshTokenTimer();
              return user;
          }));
  }

    register(user: User) {
        console.log("AccountService");

        console.log(user);
        return this.http.post(`${environment.apiUrl}/users/register`, user);
    }

    getAll() {
        return this.http.get<User[]>(`${environment.apiUrl}/users`);
    }

    getById(id: string) {
        return this.http.get<User>(`${environment.apiUrl}/users/${id}`);
    }

    update(id, params) {
        return this.http.put(`${environment.apiUrl}/users/${id}`, params)
            .pipe(map(x => {
                // update stored user if the logged in user updated their own record
                if (id == this.userValue.id) {
                    // update local storage
                    const user = { ...this.userValue, ...params };
                    localStorage.setItem('user', JSON.stringify(user));

                    // publish updated user to subscribers
                    this.userSubject.next(user);
                }
                return x;
            }));
    }

    delete(id: string) {
        return this.http.delete(`${environment.apiUrl}/users/${id}`)
            .pipe(map(x => {
                // auto logout if the logged in user deleted their own record
                if (id == this.userValue.id) {
                    this.logout();
                }
                return x;
            }));
    }

    private refreshTokenTimeout;

    private startRefreshTokenTimer() {
      // parse json object from base64 encoded jwt token
      const jwtToken = JSON.parse(atob(this.userValue.jwtToken.split('.')[1]));

      // set a timeout to refresh the token a minute before it expires
      const expires = new Date(jwtToken.exp * 1000);
      const timeout = expires.getTime() - Date.now() - (60 * 1000);
      this.refreshTokenTimeout = setTimeout(() => this.refreshToken().subscribe(), timeout);
  }

  private stopRefreshTokenTimer()
  {
    clearTimeout(this.refreshTokenTimeout);
  }
}
