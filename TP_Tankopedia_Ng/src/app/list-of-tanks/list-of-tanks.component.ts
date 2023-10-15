import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router, Params } from '@angular/router';
import { DataApiService } from '../services/data-api.service';
import { Tank } from 'src/models/Tank';
import { Nation } from 'src/models/Nation';
import { TypeTank } from 'src/models/TypeTank';
import { StrategicRole } from 'src/models/StrategicRole';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

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
  newTank:Tank = new Tank(0,'','',0,0,0);
  // fb=this.formBuilder.group(this.formBuilder.group({
  //   name:['',[Validators.required,Validators.maxLength(25)]],
  //   description:['',[Validators.required,Validators.maxLength(600)]],
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
      
      (params['nationId'] === undefined && params['typeId'] === undefined)
      ? await this.getAllTanksRequest()
      : (params['nationId'] !== undefined)
      ? await this.getNationWithListOfTanksRequest(params['nationId'])
      : await this.getTypeWithListOfTanksRequest(params['typeId']);
      //Récupération des données pour les 3 listes de sélection du formulaire modal CreateNewTank
      await this.getAllNationRequest();
      await this.getAllTypesOfTanksRequest();
      await this.getAllStrategicRolesRequest();
    });
    
  }

  async getNationWithListOfTanksRequest(nationId:number):Promise<void> {
    await this.dataApiService.getListOfTanksByNation(nationId).subscribe(n => {
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

  async addNewTank(newTank:Tank):Promise<void>{
    await this.dataApiService.addTank(newTank).subscribe(nt =>{
      console.log('New tank:', nt);
      this.navigateToTankDetails(nt.id);
    })
  }
  navigateToTankDetails(tankId:number):void {
    this.router.navigate(['/tank-details', tankId])
  }
}
