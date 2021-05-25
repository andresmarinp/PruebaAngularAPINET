import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Corral } from '../models/corral.model';
import { TipoAnimal } from '../models/tipoanimal.model';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  
  url:string = "http://localhost:64504/api/";
  
  constructor(private http:HttpClient) { }

  addCorral(data:Corral):Observable<Corral[]>{
    return this.http.post<Corral[]>(this.url + "corral/addcorral",data);
  }

  getAllCorrales():Observable<Corral[]>{
     return this.http.get<Corral[]>(this.url + "corral");     
  }
  getAllTiposAnimales():Observable<TipoAnimal[]>{
    return this.http.get<TipoAnimal[]>(this.url + "tipoanimal");     
 }
}
