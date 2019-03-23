import { Component, OnInit, Input } from '@angular/core';

import { Categorie } from '../shared/categorie.model';
import { EVENEMENTEN } from '../shared/mock-evenementen';
import { Router } from '@angular/router';
import { Evenement } from '../shared/evenement.model';
import { Plaats } from '../shared/plaats.model';

@Component({
  selector: 'app-evenement-list',
  templateUrl: './evenement-list.component.html',
  styleUrls: ['./evenement-list.component.css']
})
export class EvenementListComponent implements OnInit {
  @Input() evenementen:Evenement[];

  /* De onderstaande declaraties dienen voor het sorteren. De enums moeten gedeclareerd worden, anders kent de html ze enums niet*/
  Categorie=Categorie;
  Plaats=Plaats;
  
  @Input() geselecteerdeCategorie: Categorie;

  constructor(private router: Router) { 

    console.log("Deze evenementen krijgen we binnen: ");console.log(this.evenementen)  
  }

  ngOnInit() {
  } 

  public gotoProductDetails(url, id) {
    this.router.navigate([url, id]).then( (e) => {
      if (e) {
        console.log("Navigation is successful!",url + " " + id);
      } else {
        console.log("Navigation has failed!");
      }
    });
}

}
function getCategorie(){
  return this.geselecteerdeCategorie==null?Categorie.Alles:this.geselecteerdeCategorie;
}
