import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { SuperHero } from '../models/super-heros';

@Injectable({
  providedIn: 'root'
})
export class SuperHeroService {
  url="https://localhost:7295/api/SuperHero"

  constructor(private http:HttpClient) { }

  public getSuperHeroes() : Observable<SuperHero[]>{
    return this.http.get<SuperHero[]>(`${this.url}`);
  }

  public updateHero(hero: SuperHero) : Observable<SuperHero[]>{
    return this.http.put<SuperHero[]>(`${this.url}`, hero);
  }

  public createHero(hero: SuperHero) : Observable<SuperHero[]>{
    return this.http.post<SuperHero[]>(`${this.url}`, hero);
  }

  public delteSuperHero(hero: SuperHero) : Observable<SuperHero[]>{
    return this.http.delete<SuperHero[]>(`${this.url}/${hero.id}`);
  }


}
