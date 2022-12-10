import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import {parent} from '../model/parent';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ParentServiceService {
 // url="https://localhost:7159/api/Parents";
  url="https://localhost:449";
  urlAssemble?:string

  constructor(private http:HttpClient) { }

  public getParentsList() : Observable<parent[]>{
      this.urlAssemble=this.url + "/api/Parents";
      console.log("Pot je: ", this.urlAssemble);
      return this.http.get<parent[]>(`${this.urlAssemble}`);
  }

  public getParent(ParentId:number) : Observable<parent>{
    this.urlAssemble=this.url + "/api/Parents/"+ParentId;
    console.log("Pot je: ", this.urlAssemble);
    return this.http.get<parent>(`${this.urlAssemble}`);
}

}
