﻿import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { first } from 'rxjs/operators';
import {MatSelectModule} from '@angular/material/select';
import { AccountService, AlertService } from '@app/_services';
import { serviceCatalogo } from '@app/_services/service_cat/serviceCatalogos';
import { Observable } from 'rxjs';

@Component({ templateUrl: 'register.component.html' })
export class RegisterComponent implements OnInit {
    form: FormGroup;
    loading = false;
    submitted = false;
    tipoSexo = null;
    constructor(
        private formBuilder: FormBuilder,
        private route: ActivatedRoute,
        private router: Router,
        private accountService: AccountService,
        private alertService: AlertService,
        private _serviceCat: serviceCatalogo
    ) { }

    ngOnInit() {
        this.form = this.formBuilder.group({
            firstName: ['', Validators.required],
            lastName: ['', Validators.required],
            apellidodos: ['', Validators.required],
            sexo: ['', Validators.required],
            username: ['', Validators.required],
            rfc: ['', Validators.required],
            plaza: ['', Validators.required],
            numeroempleado: ['', Validators.required],
            cargo: ['', Validators.required],
            turno: ['', Validators.required],
            tipocontrato: ['', Validators.required],
            servicio: ['', Validators.required],
            password: ['', [Validators.required, Validators.minLength(6)]]
        });

        //cargar los catalogos
          this._serviceCat.getSexo()
          .pipe(first())
          .subscribe(catalogosexo => this.tipoSexo = catalogosexo);

    }


    // convenience getter for easy access to form fields
    get f() { return this.form.controls; }

    onSubmit() {
        this.submitted = true;

        // reset alerts on submit
        this.alertService.clear();

        // stop here if form is invalid
        if (this.form.invalid) {
            return;
        }

        this.loading = true;
        this.accountService.register(this.form.value)
            .pipe(first())
            .subscribe(
                data => {
                    this.alertService.success('Registro exitoso', { keepAfterRouteChange: true });
                    this.router.navigate(['../login'], { relativeTo: this.route });
                },
                error => {
                    this.alertService.error(error);
                    this.loading = false;
                });
    }
}
