import { Tank } from "./Tank";

export class StrategicRole {
    constructor(
        public id : number,
        public name : string,
        public imageURL : string,
        public tanks : Tank[] = []
    ){}
}