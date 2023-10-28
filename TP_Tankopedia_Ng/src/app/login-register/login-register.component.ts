import { Component, OnInit } from '@angular/core';
import { DataApiService } from '../services/data-api.service';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { User } from 'src/models/User';
import { IdentityService } from '../services/identity.service';

@Component({
  selector: 'app-login-register',
  templateUrl: './login-register.component.html',
  styleUrls: ['./login-register.component.css']
})
export class LoginRegisterComponent implements OnInit{
  

  constructor(
    public route: ActivatedRoute,
    public router: Router,
    private dataApiService: DataApiService,
    private identityService :IdentityService
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
  user : User =new User();
  errorMessage: string = '';


  loginActive : boolean = false;
  public changeRegisterOnClick(): void{
    this.registerActive = !this.registerActive;
  }

  public changeLoginOnClick(): void{
    this.loginActive = !this.loginActive;
  }
  async registerNewUser(newUser:User):Promise<void>{
    await this.identityService.registerUser(newUser).subscribe(
      { next:(nu) =>{
      // console.log('User:', nu,newUser);
      this.navigateToLogin()
    },
    error:(err) => {
        console.error('We have an error :' + err.error.message , err);
        if(err && err.message){
          this.errorMessage = err.error.message;
        }else{
          this.errorMessage="Unknown error"
        }
      }
    })
  }
  navigateToLogin():void {
    this.router.navigate(['/app-login/', 'login'])
  }
  
}
