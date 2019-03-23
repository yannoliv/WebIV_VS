import {Categorie} from "./categorie.model";
import { Plaats } from './plaats.model';
export class Evenement {
    Id:number;
    Titel:string;
    Categorie:Categorie;
    Locatie:Plaats;
    Beschrijving:string;
    Datum:Date;
    File:string;
    constructor(
        _id:number,
        _titel:string,
        _categorie:Categorie,
        _locatie:Plaats,
        _beschrijving:string,
        _datum:Date,
        _file:string
    ){
        this.Id = _id;
        this.Titel = _titel;
        this.Categorie = _categorie;
        this.Locatie = _locatie;
        this.Beschrijving = _beschrijving;
        this.Datum = _datum;
        this.File = _file;
    }

    static fromJSON(json: any): Evenement {
        const rec = new Evenement(json.Id, json.Titel, json.Categorie, json.Locatie, json.Beschrijving,
            json.Datum,json.File);
        return rec;
    }
    

}

