import { Component, OnInit } from '@angular/core';

import {EvenementService} from './shared/evenement.service';
import { Categorie } from './shared/categorie.model';
import { EVENEMENTEN } from './shared/mock-evenementen';

@Component({
  selector: 'app-evenementen',
  templateUrl: './evenementen.component.html',
  styleUrls: ['./evenementen.component.css'],
  providers:[EvenementService]
})
export class EvenementenComponent implements OnInit {
  evenementen = EVENEMENTEN;
  Categorie=Categorie;

  geselecteerdeCategorie: string = Categorie[Categorie.Alles];
  beginGeselecteerdeCategorie:Categorie;
  categories: string[] = ["Alles","Klassiek","Pop","RockAndMetal","VoorDeHeleFamilie"];
  constructor(private evenementService : EvenementService) { }

  ngOnInit() {
  }
}
