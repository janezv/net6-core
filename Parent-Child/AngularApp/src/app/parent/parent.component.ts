import { Component } from '@angular/core';
import { child } from '../model/child';
import { parent } from '../model/parent';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.css']
})
export class ParentComponent {
  Parent:parent={id:3, firstName:"hardcode first Name", lastName:"hardcode second Name "};
  Children:child[]=[
    {id:0, fistName:"1 first name hCoded", lastName:"last name 1 hd"},
    {id:1, fistName:"2 first name hCoded", lastName:"last name 2 hd"},
    {id:3, fistName:"3 first name hCoded", lastName:"last name 3 hd"}
  ]
}
