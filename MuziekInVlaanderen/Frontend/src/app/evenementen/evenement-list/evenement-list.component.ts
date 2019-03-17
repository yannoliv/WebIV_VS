import { Component, OnInit, Input } from '@angular/core';

import {EvenementService} from '../shared/evenement.service'
import { Categorie } from '../shared/categorie.model';

@Component({
  selector: 'app-evenement-list',
  templateUrl: './evenement-list.component.html',
  styleUrls: ['./evenement-list.component.css']
})
export class EvenementListComponent implements OnInit {

  Categorie=Categorie;
  @Input() geselecteerdeCategorie: Categorie;

  constructor(private evenementService: EvenementService) { }

  ngOnInit() {
    this.evenementService.getEvenementenLijst();
  } 

}
function getCategorie(){
  return this.geselecteerdeCategorie==null?Categorie.Alles:this.geselecteerdeCategorie;
}
