import { Component, OnInit } from '@angular/core';
import { DataApiService } from '../services/data-api.service';
import { ActivatedRoute, Params } from '@angular/router';
import { Tank } from 'src/models/Tank';
import { Nation } from 'src/models/Nation';
import { TypeTank } from 'src/models/TypeTank';
import { StrategicRole } from 'src/models/StrategicRole';

@Component({
  selector: 'app-tank-details',
  templateUrl: './tank-details.component.html',
  styleUrls: ['./tank-details.component.css']
})
export class TankDetailsComponent implements OnInit{

  tank! : Tank
  tankId?: number;
  allNations: Nation[] = [];
  allTypesOfTanks: TypeTank[] = [];
  allStrategicRoles : StrategicRole[] = [];
  // isModalOpen : boolean = false; 

  constructor(public route: ActivatedRoute,
    private dataApiService: DataApiService){}

  async ngOnInit(): Promise<void> {
    this.route.params.subscribe(async(params:Params)=>{
      this.tankId = params['tankId'];
      await this.dataApiService.getTankById(params['tankId']).subscribe(t =>{
        console.log(`Tank with id=${params['tankId']}`, t);
        this.tank = t;
      })
      await this.getAllNationRequest();
      await this.getAllTypesOfTanksRequest();
      await this.getAllStrategicRolesRequest();
    });
  }

  async getAllNationRequest():Promise<void>{
    await this.dataApiService.getNations().subscribe(n=>{
      console.log('List of nations :', n);
      this.allNations = n;
    })
  }
  async getAllTypesOfTanksRequest():Promise<void>{
    await this.dataApiService.getTankTypes().subscribe(tt=>{
      console.log('All types of tanks :', tt);
      this.allTypesOfTanks = tt;
    })
  }
  async getAllStrategicRolesRequest():Promise<void>{
    await this.dataApiService.getAllStrategicRoles().subscribe(sr=>{
      console.log('All strategic Roles:', sr);
      this.allStrategicRoles = sr;
    })
  }

  async modifyTank(tankId:number, editedTank:Tank):Promise<void>{
    await this.dataApiService.editTank(tankId,editedTank).subscribe(t=>{
      console.log('Edited tank :', t);
      this.ngOnInit();
    })
  }

  ConfirmUpdate(){
    if(this.tankId != null){
      if(this.tank != null){
         this.modifyTank(this.tankId, this.tank)
        //  this.changeOnClick();
      }
    }
  }
  // public changeOnClick(): void{
  //   this.isModalOpen = !this.isModalOpen;
  // }
//  async getTankByIdRequest(tankId:number):Promise<void> {
//   await this.dataApiService.getTankById(tankId).subscribe(t =>{
//     console.log(`Tank with id=${tankId}`, t);
//     this.tank = t;
//   });
//  }
}
