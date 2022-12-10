import { Component, Input } from '@angular/core';
import { child } from '../model/child';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-child-component',
  templateUrl: './child-component.component.html',
  styleUrls: ['./child-component.component.css']
})
export class ChildComponentComponent {

  @Input() childComponent : child ={id:0,fistName:"ahoj",lastName:"l ahoj"};

  constructor(){}

  ngOnInit(){
    console.log(this.childComponent.fistName)
    console.log(this.childComponent.lastName)
  }

}
