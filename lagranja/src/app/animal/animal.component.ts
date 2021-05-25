import { Component, OnInit } from '@angular/core';
import { Corral } from '../models/corral.model';
import { TipoAnimal } from '../models/tipoanimal.model';
import { ApiService } from '../services/api.service';

@Component({
  selector: 'app-animal',
  templateUrl: './animal.component.html',
  styleUrls: ['./animal.component.css']
})
export class AnimalComponent implements OnInit {
  title = "Animales";
  corrales: Corral[] = [];
  tiposanimales: TipoAnimal[] = [];
  idtipoanimal:string="";
  idcorral:string="";
  fechanacimiento:string="";
  constructor(private apiService:ApiService){ }

  ngOnInit(): void {
    this.apiService.getAllCorrales().subscribe(data => {
      console.log(data);
     this.corrales = data;
    });

    this.apiService.getAllTiposAnimales().subscribe(data => {
      console.log(data);
     this.tiposanimales = data;
    });
  }

}
