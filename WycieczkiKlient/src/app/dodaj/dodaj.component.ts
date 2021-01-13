import { UserService } from './../shared/user.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-dodaj',
  templateUrl: './dodaj.component.html',
  styles: []
})
export class DodajComponent implements OnInit {

  imageUrl: string;
  videoUrl: string;

  constructor(public service: UserService) { }

  ngOnInit(): void {
  }

  onSubmit() {
    this.service.dodajWycieczke().subscribe(
      (res: any) => {
        this.service.formModel.reset();
        console.log("Dodano wycieczkę")
      },
      err => {
        console.log(err);
      }
    );
  }
  imgShow() {
    this.imageUrl = this.service.formModel.value.zdjecie;
  }

  videoShow() {
    this.videoUrl = this.service.formModel.value.video;
  }
}
