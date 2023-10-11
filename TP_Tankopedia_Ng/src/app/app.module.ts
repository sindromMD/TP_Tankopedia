import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClient, HttpClientModule} from '@angular/common/http'


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { HomeComponent } from './home/home.component';
import { RouterModule } from '@angular/router';
import { ListOfTanksComponent } from './list-of-tanks/list-of-tanks.component';
import { DateFormattingPipe } from './pipes/date-formatting.pipe';
import { DatePipe } from '@angular/common';

@NgModule({
  declarations: [
    AppComponent,
    DateFormattingPipe,
    HomeComponent,
    ListOfTanksComponent,
    DateFormattingPipe,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    AppRoutingModule,
    RouterModule.forRoot([
      {path: "", redirectTo : "/home", pathMatch:"full"},
      {path: "home", component: HomeComponent},
      {path: "list-of-tanks-by-nation/:nationId", component: ListOfTanksComponent },
      {path: "list-of-tanks-by-type/:typeId", component: ListOfTanksComponent },
      {path: "list-of-all-tanks", component: ListOfTanksComponent },
    ])
  ],
  providers: [
    DatePipe
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
