import { Component, OnInit } from '@angular/core';

import {EvenementService} from './shared/evenement.service';

@Component({
  selector: 'app-evenementen',
  templateUrl: './evenementen.component.html',
  styleUrls: ['./evenementen.component.css'],
  providers:[EvenementService]
})
export class EvenementenComponent implements OnInit {

  constructor(private evenementService : EvenementService) { }

  ngOnInit() {
  }

}
