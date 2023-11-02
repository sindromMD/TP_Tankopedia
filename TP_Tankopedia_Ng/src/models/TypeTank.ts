import { Tank } from "./Tank";

export class TypeTank {
    constructor(
        public id: number,
        public name: string,
        public imageURL: string,
        public tanks: Tank[] = []
    ) { }
}