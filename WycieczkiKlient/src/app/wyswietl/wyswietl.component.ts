import { UserService } from './../shared/user.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-wyswietl',
  templateUrl: './wyswietl.component.html',
  styles: [
  ]
})
export class WyswietlComponent implements OnInit {

  constructor(public service: UserService) { }

  listaWycieczek;

  ngOnInit(): void {
    this.service.listaWycieczek().subscribe(
      res => {
        this.listaWycieczek = res;
        console.log(res);
      },
      err => {
        console.log(err);
      }
    );
  }
}
