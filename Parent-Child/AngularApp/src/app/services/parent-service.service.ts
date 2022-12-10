import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import {parent} from '../model/parent';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ParentServiceService {
  url="https://localhost:7159/api/Parents"

  constructor(private http:HttpClient) { }

  public getParentsList() : Observable<parent[]>{
    return this.http.get<parent[]>(`${this.url}`);
  }

}
