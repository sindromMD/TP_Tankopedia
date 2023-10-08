export class Characteristics{
    constructor(
       public id: number,
       public weight: number,//tonne
       public enginePower: number,//hp
       public topSpeed: number,// km/h
       public rateOfFire: number,//tours/min
       public aimingTime: number,//sec
       public amoCapacity: number,//pcs
       public reloadTime: number, //sec
       public hullArmor: number, // mm
       public tankId: number         
    ){}
}