import { Component, OnInit } from '@angular/core';

import {EvenementService} from '../shared/evenement.service'

@Component({
  selector: 'app-evenement-list',
  templateUrl: './evenement-list.component.html',
  styleUrls: ['./evenement-list.component.css']
})
export class EvenementListComponent implements OnInit {

  constructor(private evenementService: EvenementService) { }

  ngOnInit() {
    this.evenementService.getEvenementenLijst();
  }

}
