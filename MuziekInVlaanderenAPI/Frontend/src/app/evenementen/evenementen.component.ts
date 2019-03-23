import { Component, OnInit, Pipe, PipeTransform } from '@angular/core';

import { Categorie } from './shared/categorie.model';
import { Plaats } from './shared/plaats.model';
import { Subject, Observable } from 'rxjs';
import { distinctUntilChanged, debounceTime, map, filter } from 'rxjs/operators';
import { EvenementDataService } from './shared/evenementen.data.service';
import { Evenement } from './shared/evenement.model';
import { EVENEMENTEN } from './shared/mock-evenementen';

@Component({
  selector: 'app-evenementen',
  templateUrl: './evenementen.component.html',
  styleUrls: ['./evenementen.component.css']
})
export class EvenementenComponent implements OnInit {

  //Het onderstaande dient voor de connectie tussen de klasse en de html
  Categorie=Categorie;
  Plaats=Plaats;

  // sorteren op categorie
  geselecteerdeCategorie: string = Categorie[Categorie.Alles];
  categories: string[] = ["Alles","Klassiek","Pop","RockAndMetal","VoorDeHeleFamilie"];
  
  //filter
  public filterEvenementName: string;
  public filterEvenement$ = new Subject<string>();

  //sidenav
  events: string[] = [];
  opened: boolean;
  shouldRun = [/(^|\.)plnkr\.co$/, /(^|\.)stackblitz\.io$/]
    .some(h => h.test(window.location.host));

  // observable
  private _fetchEvenementen$: Observable<Evenement[]> = this.evenementenDataService.evenementen$;

  //get evenementen via observer
  get evenementen$(): Observable<Evenement[]> {
    return this._fetchEvenementen$;
  }

  constructor(private evenementenDataService : EvenementDataService) { 
    this.filterEvenement$
    .pipe(
      distinctUntilChanged(),
      debounceTime(400),
      map(val => val.toLowerCase())
    )
    .subscribe(val => this.filterEvenementName = val);
  }

  ngOnInit() {
  }
}

//enum naar array pipe
@Pipe({
  name: 'enumToArray'
})
export class EnumToArrayPipe implements PipeTransform {
  transform(data: Object) {
    const keys = Object.keys(data);
    return keys.slice(keys.length / 2);
  }
}
