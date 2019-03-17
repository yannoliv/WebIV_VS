import {Categorie} from "./categorie.model";
export class Evenement {
    constructor(
        _id:number,
        _titel:string,
        _categorie:Categorie,
        _locatie:string,
        _beschrijving:string,
        _datum:Date,
        _file:string
    ){}

    static fromJSON(json: any): Evenement {
        const rec = new Evenement(json.id, json.titel, json.categorie, json.locatie, json.beschrijving,
            json.datum,json.file);
        return rec;
    }
    

}

