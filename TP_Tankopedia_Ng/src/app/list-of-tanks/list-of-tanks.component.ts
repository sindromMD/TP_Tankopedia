import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router, Params } from '@angular/router';
import { DataApiService } from '../services/data-api.service';
import { Tank } from 'src/models/Tank';
import { Nation } from 'src/models/Nation';
import { TypeTank } from 'src/models/TypeTank';
import { StrategicRole } from 'src/models/StrategicRole';
// import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-list-of-tanks',
  templateUrl: './list-of-tanks.component.html',
  styleUrls: ['./list-of-tanks.component.css']
})
export class ListOfTanksComponent implements OnInit {
  
  // nationId! : number;
  nation ?: Nation;
  typeTank ?: TypeTank;
  allTanks: Tank[]=[];
  allNations: Nation[] = [];
  allTypesOfTanks: TypeTank[] = [];
  allStrategicRoles : StrategicRole[] = [];
  counter ?: number;
  errorMessage: string='';
  newTank:Tank = new Tank(0,'','',0,0,0);
  // formCreate = this.formBuilder.group(this.formBuilder.group({
  //   name:[null,[Validators.required,Validators.maxLength(25)]],
  //   description:['',[Validators.required,Validators.maxLength(600)]],
  //   yearOfCreation:[0],
  //   nationID:[0,[Validators.required]],
  //   strategicRoleId:[0,[Validators.required]],
  //   typeID:[0,[Validators.required]]
  // }));

  constructor(
    public route: ActivatedRoute,
    public router: Router,
    private dataApiService: DataApiService,
    // private formBuilder:FormBuilder
  ){
}

  async ngOnInit(): Promise<void>{
    this.route.params.subscribe(async(params : Params)=>{
      console.log('params',params['nationId'], params['typeId'], params['roleId']);
      (params['nationId'] === undefined && params['typeId'] === undefined)
      ? await this.getAllTanksRequest()
      : (params['nationId'] !== undefined && params['roleId'] !== undefined)
      ? await this.getNationWithListOfTanksRequest(params['nationId'], params['roleId'])
      : await this.getTypeWithListOfTanksRequest(params['typeId']);
      //Récupération des données pour les 3 listes de sélection du formulaire modal CreateNewTank
      await this.getAllNationRequest();
      await this.getAllTypesOfTanksRequest();
      await this.getAllStrategicRolesRequest();
    });
    
  }


  async getNationWithListOfTanksRequest(nationId:number, roleId:number):Promise<void> {
    await this.dataApiService.getListOfTanksByNation(nationId, roleId).subscribe(n => {
      console.log('nation :',n);
      this.nation = n;
      this.counter = n.tanks.length;
    })
  }

  async getTypeWithListOfTanksRequest(typeId:number):Promise<void> {
    await this.dataApiService.getListOfTanksByType(typeId).subscribe(t => {
      console.log('type : ',t);
      this.typeTank = t;
      this.counter = t.tanks.length;
    })
  }
  async getAllTanksRequest():Promise<void>{
    await this.dataApiService.getAllTanks().subscribe(t=>{
      console.log('alltanks: ',t);
      this.allTanks=t;
      this.counter=t.length;
    })
  }
  // toggleNationSelection(nation: Nation) {
  //   if (this.selectedNations.includes(nation)) {
  //     this.selectedNations = this.selectedNations.filter((n) => n !== nation);
  //   } else {
  //     this.selectedNations.push(nation);
  //   }

  // }
  
  //Récupération des données pour les 3 listes de sélection du formulaire modal CreateNewTank
  async getAllNationRequest():Promise<void>{
    await this.dataApiService.getNations().subscribe(n=>{
      this.allNations = n;
    })
  }
  async getAllTypesOfTanksRequest():Promise<void>{
    await this.dataApiService.getTankTypes().subscribe(tt=>{
      this.allTypesOfTanks = tt;
    })
  }
  async getAllStrategicRolesRequest():Promise<void>{
    await this.dataApiService.getAllStrategicRoles().subscribe(sr=>{
      this.allStrategicRoles = sr;
    })
  }

  // newTankGen(form:FormGroup) {
  //   console.log(form.valid);
  //   console.log( form.value.name)
  //     return new Tank(
  //       0,
  //       form.value.name,
  //       form.value.description,
  //       form.value.yearOfCreation,
  //       form.value.nationID,
  //       form.value.strategicRoleId,
  //       form.value.typeID
  //     );
  //   } 
  
  async addNewTank(newTank:Tank):Promise<void>{
    await this.dataApiService.addTank(newTank).subscribe(
      { next:(nt) =>{
      console.log('New tank:', nt);
      this.navigateToTankDetails(nt.id);
    },
    error:(err) => {
      console.error('We have an error :',err.message);
      if(err && err.message){
        this.errorMessage = err.message;
      }else{
        this.errorMessage="Unknown error"
      }
    }
    })
  }
  navigateToTankDetails(tankId:number):void {
    this.router.navigate(['/tank-details/', tankId])
  }
}
