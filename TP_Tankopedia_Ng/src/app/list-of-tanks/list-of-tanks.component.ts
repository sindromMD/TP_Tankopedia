import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, Router, Params } from '@angular/router';
import { DataApiService } from '../services/data-api.service';
import { Tank } from 'src/models/Tank';
import { Nation } from 'src/models/Nation';
import { TypeTank } from 'src/models/TypeTank';
import { StrategicRole } from 'src/models/StrategicRole';
import { HttpEventType } from '@angular/common/http';
import { IdentityService } from '../services/identity.service';
// import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-list-of-tanks',
  templateUrl: './list-of-tanks.component.html',
  styleUrls: ['./list-of-tanks.component.css']
})
export class ListOfTanksComponent implements OnInit {
  @ViewChild("image", { static: false }) image?: ElementRef;

  fileupload: any;
  nation?: Nation;
  listOfTanksNation: Tank[] = []
  listOfTanksType: Tank[] = []
  allTanks: Tank[] = [];
  allNations: Nation[] = [];
  allTypesOfTanks: TypeTank[] = [];
  allStrategicRoles: StrategicRole[] = [];
  counter: number = 0;
  errorMessage: string = '';
  varPictureId?: number; //Id image ajoutée
  progress: number = 0; //progress bar
  newTank: Tank = new Tank(0, '', '', 0, 0, 0);
  role: string = '';
  constructor(
    public route: ActivatedRoute,
    public router: Router,
    private dataApiService: DataApiService,
    private identityService: IdentityService
  ) {
  }

  async ngOnInit(): Promise<void> {
    this.route.params.subscribe(async (params: Params) => {

      console.log('params', params['nationId'], params['typeId'], params['roleId']);

      (params['nationId'] === undefined && params['typeId'] === undefined && params['roleId'] === undefined)
        ? await this.getAllTanksRequest()
          : (params['nationId'] !== undefined && params['roleId'] !== undefined)
           ? await this.getNationWithListOfTanksRequest(params['nationId'], params['roleId'])
             : await this.getTypeWithListOfTanksRequest(params['typeId'], params['roleId']);

      //Récupération des données pour les 3 listes de sélection du formulaire modal CreateNewTank
      await this.getAllNationRequest();
      await this.getAllTypesOfTanksRequest();
      await this.getAllStrategicRolesRequest();
      this.role = this.identityService.getRoleFromToken();
    });

  }


  async getNationWithListOfTanksRequest(nationId: number, roleId: number): Promise<void> {
    await this.dataApiService.getTanksFileredByNationAndOrRole(nationId, roleId).subscribe(
      {
        next: (n) => {
          console.log('nation :', n);
          this.listOfTanksNation = n;
          this.counter = n.length;
        },
        error: (err) => {
          console.error('We have an error :', err.message);
          if (err && err.message) {
            this.errorMessage = err.message;
          } else {
            this.errorMessage = "Unknown error"
          }
        }
      })
  }

  async getTypeWithListOfTanksRequest(typeId: number, roleId: number): Promise<void> {
    await this.dataApiService.getTanksFileredByTypeAndOrRole(typeId, roleId).subscribe(
      {
        next: (t) => {
          console.log('List of tanks 2 or 1 param : ', t);
          this.listOfTanksType = t;
          this.counter = t.length;
        },
        error: (err) => {
          console.error('We have an error :', err.message);
          if (err && err.message) {
            this.errorMessage = err.message;
          } else {
            this.errorMessage = "Unknown error"
          }
        }
      })
  }


  async getAllTanksRequest(): Promise<void> {
    await this.dataApiService.getAllTanks().subscribe(t => {
      console.log('alltanks: ', t);
      this.allTanks = t;
      this.counter = t.length;
    })
  }

  //Récupération des données pour les 3 listes de sélection du formulaire modal CreateNewTank
  async getAllNationRequest(): Promise<void> {
    await this.dataApiService.getNations().subscribe(n => {
      this.allNations = n;
    })
  }

  async getAllTypesOfTanksRequest(): Promise<void> {
    await this.dataApiService.getTankTypes().subscribe(tt => {
      this.allTypesOfTanks = tt;
    })
  }

  async getAllStrategicRolesRequest(): Promise<void> {
    await this.dataApiService.getAllStrategicRoles().subscribe(sr => {
      this.allStrategicRoles = sr;
    })
  }

  async addNewTank(newTank: Tank): Promise<void> {
    await this.dataApiService.addTank(newTank).subscribe(
      {
        next: (nt) => {
          console.log('New tank:', nt);
          this.navigateToTankDetails(nt.id);
        },
        error: (err) => {
          console.error('We have an error :', err.message);
          if (err && err.message) {
            this.errorMessage = err.message;
          } else {
            this.errorMessage = "Unknown error"
          }
          if (newTank.pictureId) {
            this.dataApiService.deleteOldImage(newTank.pictureId)
          }
        }
      })
  }

  navigateToTankDetails(tankId: number): void {
    this.router.navigate(['/tank-details/', tankId])
  }

  //upload image
  uploadViewChild(): void {
    if (this.image != undefined) {
      let file = this.image.nativeElement.files[0];
      this.dataApiService.uploadImage(file).subscribe(
        p => {
          if (p != undefined) {
            if (p.type === HttpEventType.UploadProgress && p.total != undefined) {
              this.progress = Math.round(100 * p.loaded / p.total);
            }
            else if (p.type === HttpEventType.Response) {
              console.log("photo chargée !", p.body);
              this.progress = 100;
              this.varPictureId = p.body.pictureId;
              this.newTank.pictureId = this.varPictureId;
              this.addNewTank(this.newTank);
            }
          }
        });
    }
  }
}
