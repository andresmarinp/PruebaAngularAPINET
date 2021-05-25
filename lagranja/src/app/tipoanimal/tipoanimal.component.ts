import { Component, OnInit } from '@angular/core';
import { TipoAnimal } from '../models/tipoanimal.model';
import { ApiService } from '../services/api.service';

@Component({
  selector: 'app-tipoanimal',
  templateUrl: './tipoanimal.component.html',
  styleUrls: ['./tipoanimal.component.css']
})
export class TipoanimalComponent implements OnInit {
  title = "Tipos de Animal";
  tiposanimales: TipoAnimal[] = [];
  nombre:string="";
  peligrosidad:string="";

  constructor(private apiService:ApiService){ }

  registrarTipoAnimal(){

  }

  ngOnInit(): void {
    this.apiService.getAllTiposAnimales().subscribe(data => {
      console.log(data);
     this.tiposanimales = data;
    });
  }
}
