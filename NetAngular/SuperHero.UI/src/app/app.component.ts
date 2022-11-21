import { Component } from '@angular/core';
import { SuperHero } from './models/super-heros';
import {SuperHeroService} from './services/super-hero.service'
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'SuperHero.UI';
  heroes: SuperHero[]=[];
  heroToEdit?: SuperHero;

  constructor(private superHeroService: SuperHeroService){}

  ngOnInit():void{
    this.superHeroService
      .getSuperHeroes()
      .subscribe((result: SuperHero[])=>(this.heroes=result));
    console.log(this.heroes)
  }

  updateHeroList(heroes:SuperHero[]){
    this.heroes = heroes;
  }

  initNewHero(){
    this.heroToEdit=new SuperHero();
  }

  editHero(hero: SuperHero){
    this.heroToEdit=hero;
  }

}
