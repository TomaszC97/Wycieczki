import { HttpClient } from '@angular/common/http';
import { Injectable } from "@angular/core";
import { FormBuilder } from "@angular/forms";

@Injectable({
  providedIn: 'root'
})
export class UserService {

  readonly BaseURL = 'https://localhost:44333/api';
  constructor(private fb: FormBuilder, private http: HttpClient) { }

  formModel = this.fb.group({
    poczatekTrasy: [''],
    konieTrasy: [''],
    dataWycieczki: [''],
    pokonanyDystans: [''],
    liczbaDni: [''],
    zdjecie: [''],
    video: ['']
  });

  dodajWycieczke() {
    var body = {
      poczatekTrasy: this.formModel.value.poczatekTrasy,
      konieTrasy: this.formModel.value.konieTrasy,
      dataWycieczki: this.formModel.value.dataWycieczki,
      pokonanyDystans: this.formModel.value.pokonanyDystans,
      liczbaDni: this.formModel.value.liczbaDni,
      zdjecie: this.formModel.value.zdjecie,
      video: this.formModel.value.video,
    };
    return this.http.post(this.BaseURL + '/Wycieczki', body);
  }

  listaWycieczek() {
    return this.http.get(this.BaseURL + '/Wycieczki');
  }
}
