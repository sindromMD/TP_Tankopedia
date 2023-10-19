import { Component, OnInit } from '@angular/core';
import { DataApiService } from '../services/data-api.service';
import { ActivatedRoute, Params } from '@angular/router';

@Component({
  selector: 'app-login-register',
  templateUrl: './login-register.component.html',
  styleUrls: ['./login-register.component.css']
})
export class LoginRegisterComponent implements OnInit{

  constructor(
    public route: ActivatedRoute,
    private dataApiService: DataApiService
  ){}
  async ngOnInit(): Promise<void> {
    this.route.params.subscribe(async(params:Params)=>{
      this.loginOuRegistration = params['register'] || params['login'];
    })
  }

  registerActive : boolean = false;
  username:string = "";
  email:string = "";
  password:string = "";
  passwordConfirm:string = "";
  loginOuRegistration :string = '';


  loginActive : boolean = false;
  public changeRegisterOnClick(): void{
    this.registerActive = !this.registerActive;
  }

  public changeLoginOnClick(): void{
    this.loginActive = !this.loginActive;
  }

}
