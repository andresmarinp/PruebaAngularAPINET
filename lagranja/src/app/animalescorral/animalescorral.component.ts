import { Component, OnInit } from '@angular/core';
import { Corral } from '../models/corral.model';
import { ApiService } from '../services/api.service';

@Component({
  selector: 'app-animalescorral',
  templateUrl: './animalescorral.component.html',
  styleUrls: ['./animalescorral.component.css']
})
export class AnimalescorralComponent implements OnInit {
  title = "Animales por Corral";
  corrales: Corral[] = [];
  idcorral:string="";
  constructor(private apiService:ApiService){ }

  ngOnInit(): void {
    this.apiService.getAllCorrales().subscribe(data => {
      console.log(data);
     this.corrales = data;
    });
  }

}
