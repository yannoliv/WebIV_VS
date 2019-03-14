import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms'

import {EvenementService} from '../shared/evenement.service'

@Component({
  selector: 'app-evenement',
  templateUrl: './evenement.component.html',
  styleUrls: ['./evenement.component.css']
})
export class EvenementComponent implements OnInit {

  constructor(private evenementService: EvenementService) { }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null)
      form.reset();
    this.evenementService.selectedEvenement = {
      Id:0,
      Titel:'Test',
      Beschrijving:'',
      Categorie:null,
      Locatie:'',
      Datum:null
    }
  }

}
