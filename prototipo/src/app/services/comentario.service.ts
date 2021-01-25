import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Comentario} from "../models/comentarios"
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class ComentarioService {
myAppUrl= "https://localhost:44380/";
myApiUrl= "api/Comentarios";
httpOptions={
  headers: new Headers({
    'content-type':'application/json'
  })
}
  constructor(private http:HttpClient) { 

  }
  getListComentario():Observable<Comentario[]>{
    return this.http.get<Comentario[]>(this.myAppUrl +this.myApiUrl);
  }
}
