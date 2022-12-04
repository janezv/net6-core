import { Component, Input } from '@angular/core';
import { child } from '../model/child';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-child-component',
  templateUrl: './child-component.component.html',
  styleUrls: ['./child-component.component.css']
})
export class ChildComponentComponent {

  @Input() childComponent : child ={id:0,name:"ahoj",count:4};

  constructor(){}

  ngOnInit(){
    console.log(this.childComponent.name)
    console.log(this.childComponent.count)
  }

}
