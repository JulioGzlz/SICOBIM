import { Injectable } from '@angular/core';
import { from } from 'rxjs';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from '@environments/environment';
import { CatSexo } from '@app/_models/catSexo';


@Injectable({ providedIn: 'root' })
export class serviceCatalogo {
  private catSubject: BehaviorSubject<CatSexo>;
  private catsexo: Observable<CatSexo>;


  constructor(
    private router: Router,
    private http: HttpClient
  ) {
    this.catSubject = new BehaviorSubject<CatSexo>(null);
    this.catsexo = this.catSubject.asObservable();

  }
  public get catValue(): CatSexo {
    return this.catSubject.value;
  }

  getSexo() {
    return this.http.get<CatSexo[]>(`${environment.apiUrl}/CatPerfil/obtenerSexo`);
  }

}

