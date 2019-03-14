import { Injectable } from '@angular/core';

import{Evenement} from './evenement.model';
import { Categorie } from './categorie.model';

@Injectable({
  providedIn: 'root' 
})
export class EvenementService {

  selectedEvenement : Evenement;
  evenementen : Evenement[];

  constructor() { }

  getEvenementenLijst(){
    this.evenementen = [
       {
        Id:1,
        Titel:"Musique à là Mule",
        Categorie:Categorie.Pop,
        Locatie:"Popstraat 61",
        Beschrijving:"Een typisch festival! Wat fijn.",
        Datum: new Date('2002-11-16T00:00:00')
      },
      {
        Id:2,
        Titel:"Heavy Rock and roll",
        Categorie:Categorie.RockAndMetal,
        Locatie:"ZwareStraat 42",
        Beschrijving:"Enkel voor de echte...",
        Datum: new Date('2005-11-16T00:00:00')
      }
    ]
    
    
  }
}
