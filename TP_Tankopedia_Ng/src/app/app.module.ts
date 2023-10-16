import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClient, HttpClientModule} from '@angular/common/http';
// import { ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { HomeComponent } from './home/home.component';
import { RouterModule } from '@angular/router';
import { ListOfTanksComponent } from './list-of-tanks/list-of-tanks.component';
import { DateFormattingPipe } from './pipes/date-formatting.pipe';
import { DatePipe } from '@angular/common';
import { TankDetailsComponent } from './tank-details/tank-details.component';
import { LoginRegisterComponent } from './login-register/login-register.component';
import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [
    AppComponent,
    DateFormattingPipe,
    HomeComponent,
    ListOfTanksComponent,
    DateFormattingPipe,
    TankDetailsComponent,
    LoginRegisterComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    // ReactiveFormsModule,
    HttpClientModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot({
      timeOut: 4000,
      positionClass: 'toast-bottom-right',
      preventDuplicates: true,
    }), // ToastrModule added
    RouterModule.forRoot([
      {path: "", redirectTo : "/home", pathMatch:"full"},
      {path: "home", component: HomeComponent},
      {path: "list-of-tanks-by-nation/:nationId", component: ListOfTanksComponent },
      {path: "list-of-tanks-by-type/:typeId", component: ListOfTanksComponent },
      {path: "list-of-all-tanks", component: ListOfTanksComponent },
      {path: "tank-details/:tankId", component: TankDetailsComponent},
      {path: "app-register/:register", component: LoginRegisterComponent},
      {path: "app-login/:login", component: LoginRegisterComponent}
    ])
  ],
  providers: [
    DatePipe
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
