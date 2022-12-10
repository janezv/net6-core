import { Component } from '@angular/core';
import { parent } from '../model/parent';
import {ParentServiceService} from '../services/parent-service.service'

@Component({
  selector: 'app-parent-list',
  templateUrl: './parent-list.component.html',
  styleUrls: ['./parent-list.component.css']
})
export class ParentListComponent {
  Parents:parent[]=[]

constructor(private ParentListService:ParentServiceService){}

ngOnInit():void{
  this.ParentListService.getParentsList().subscribe((result)=> (this.Parents=result))
}

}
