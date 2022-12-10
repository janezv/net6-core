import { Component, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ParentComponent } from './parent/parent.component';
import { ChildComponent } from './child-component/child-component.component';
import { ParentListComponent } from './parent-list/parent-list.component';
import { HttpClientModule } from '@angular/common/http';

import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [
    AppComponent,
    ParentComponent,
    ChildComponent,
    ParentListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserModule,
    RouterModule.forRoot([
      {path: 'parent-list', component: ParentListComponent},
      {path: 'child', component: ChildComponent},
      {path: 'parent', component: ParentComponent},
    ]),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
