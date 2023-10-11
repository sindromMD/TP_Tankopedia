import { Characteristics } from "./Characteristics";
import { Nation } from "./Nation";
import { StrategicRole } from "./StrategicRole";
import { TankModule } from "./TankModule";
import { TypeTank } from "./TypeTank";

export class Tank {

    constructor(
        public id : number,
        public name : string,
        public description : string,
        public yearOfCreation: number,
        public imageURL : string,
        public nationID : number,
        public typeID: number,
        public strategicRoleId:number,
        public tankModules : TankModule[] = [],
        public nation ?: Nation,
        public typeTank ?: TypeTank,
        public strategicRole ?: StrategicRole,
        public characteristics ?: Characteristics
    ){}
  }