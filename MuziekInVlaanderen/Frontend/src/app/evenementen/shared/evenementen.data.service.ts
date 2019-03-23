import { Evenement } from './evenement.model';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
    providedIn: 'root'
  })
  export class EvenementDataService {
    constructor(private http: HttpClient) {}
  
    get evenementen$(): Observable<Evenement[]> {
        return this.http.get(`${environment.apiUrl}/evenementen/`).pipe(
            map(
              (list: any[]): Evenement[] => list.map(Evenement.fromJSON)              
            )
          );
    }
  }