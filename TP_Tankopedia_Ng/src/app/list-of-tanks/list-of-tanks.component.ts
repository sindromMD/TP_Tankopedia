import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { DataApiService } from '../services/data-api.service';
import { Tank } from 'src/models/Tank';
import { Nation } from 'src/models/Nation';
import { TypeTank } from 'src/models/TypeTank';

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
  counter ?: number;
  
  constructor(
    public route: ActivatedRoute,
    private dataApiService: DataApiService
  ){}
  
  async ngOnInit(): Promise<void>{
    this.route.params.subscribe(async(params : Params)=>{
      // (params['nationId'] != null)? this.getNationWithListOfTanksRequest(params['nationId']): this.getTypeWithListOfTanksRequest(params['typeId']);
      (params['nationId'] === undefined && params['typeId'] === undefined)
      ? await this.getAllTanksRequest()
      : (params['nationId'] !== undefined)
      ? await this.getNationWithListOfTanksRequest(params['nationId'])
      : await this.getTypeWithListOfTanksRequest(params['typeId']);
      // if (params['nationId'] === undefined && params['typeId'] === undefined) {
      //   await this.getAllTanksRequest();
      // } else if (params['nationId'] !== undefined) {
      //   await this.getNationWithListOfTanksRequest(params['nationId']);
      // } else if (params['typeId'] !== undefined) {
      //   await this.getTypeWithListOfTanksRequest(params['typeId']);
      // }

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
}
