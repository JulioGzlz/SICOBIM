import { Component, OnInit } from '@angular/core';
import { User } from '../_models';
import { first } from 'rxjs/operators';
import { UserService } from '../_services';

@Component({ 
  templateUrl: './admin.component.html'
})
export class AdminComponent implements OnInit {
  loading = false;
  users: User[] = [];

  constructor(private userService: UserService) { }

  ngOnInit() {
      this.loading = true;
      this.userService.getAll().pipe(first()).subscribe(users => {
          this.loading = false;
          this.users = users;
      });
  }
}
