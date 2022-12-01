import { Component } from '@angular/core';
import { child } from '../model/child';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.css']
})
export class ParentComponent {
  children:child[]=[
    {id:0, name:"ena", count:1},
    {id:1, name:"dva", count:2},
    {id:3, name:"tri", count:3}
  ]
}
