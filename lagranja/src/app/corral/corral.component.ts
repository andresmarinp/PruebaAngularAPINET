import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormArray, FormControl } from '@angular/forms';
import { Corral } from '../models/corral.model';
import { ApiService } from '../services/api.service';

@Component({
  selector: 'app-corral',
  templateUrl: './corral.component.html',
  styleUrls: ['./corral.component.css']
})
export class CorralComponent implements OnInit {
  title = "Corrales";
  corrales: Corral[] = [];
  nombrecorral:string="";
  capacidad:string="";

  constructor(private apiService:ApiService){ }

  registrarCorral(){
    const corral = new Corral('0',this.nombrecorral,this.capacidad);
    this.apiService.addCorral(corral).subscribe(resp => {
      console.log(resp); 
     }); 
  }
  
  ngOnInit(){
    
    
    this.apiService.getAllCorrales().subscribe(data => {
      console.log(data);
     this.corrales = data;
    });
    
 
  }
    
 

}
