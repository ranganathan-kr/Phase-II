import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';


import { AppComponent } from './app.component';
import { CheckComponent } from './check/check.component';
import { MortgageComponent } from './mortgage/mortgage.component';

@NgModule({
  declarations: [
    AppComponent,
    CheckComponent,
    MortgageComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
