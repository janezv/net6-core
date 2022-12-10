import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { child } from '../model/child';
import { parent } from '../model/parent';
import {ParentServiceService} from '../services/parent-service.service'

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.css']
})
export class ParentComponent {
  Parent:parent={id:0, firstName:"hardcode first Name-Get metoda ne dela", lastName:"hardcode second Name-Get metoda ne dela "};
  Children:child[]=[
    {id:0, fistName:"1 first name hCoded", lastName:"last name 1 hd"},
    {id:1, fistName:"2 first name hCoded", lastName:"last name 2 hd"},
    {id:3, fistName:"3 first name hCoded", lastName:"last name 3 hd"}
  ]

  constructor(private route: ActivatedRoute,
          private ParentListService:ParentServiceService) {}

  ngOnInit() {
    // get param
    let param1 = this.route.snapshot.queryParams["param1"];
    console.log("Parameterj je: ",param1);
    this.ParentListService.getParent(param1).subscribe((result)=>(this.Parent=result))

}

}
