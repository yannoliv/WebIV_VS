import { Component, OnInit, Input } from '@angular/core';
import { EVENEMENTEN } from '../shared/mock-evenementen';
import { ActivatedRoute } from '@angular/router';
import { Evenement } from '../shared/evenement.model';
import { ErrorHandlerService } from '../../shared/error-handler.service';

@Component({
  selector: 'app-evenement',
  templateUrl: './evenement.component.html',
  styleUrls: ['./evenement.component.css']
})
export class EvenementComponent implements OnInit {
  
  Id: number;
  evenement: Evenement;
  constructor(private route: ActivatedRoute, private errorService: ErrorHandlerService) { 
    this.route.params.subscribe( params => {this.Id = +params.id; console.log(params.id)},
    (error) => {
      this.errorService.handleError(error);
    });
    this.evenement = EVENEMENTEN.find(e => e.Id == this.Id) as Evenement;
  }

  /*
this.repoService.getData('api/owner')
    .subscribe(res => {
      this.dataSource.data = res as Owner[];
    },
    (error) => {
      this.errorService.handleError(error);
    })
  */

  ngOnInit() {
  }
}