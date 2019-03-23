import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { IndexComponent } from '../index/index.component';
import{ EvenementenComponent} from 'src/app/evenementen/evenementen.component';
import{ EvenementComponent} from 'src/app/evenementen/evenement/evenement.component';
import { NotFoundComponent } from '../error-pages/not-found/not-found.component';
import { ServerErrorComponent } from '../error-pages/server-error/server-error.component';
 
const routes: Routes = [
  { path: 'home', component: IndexComponent},
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: '404', component: NotFoundComponent}, 
  { path: '500', component: ServerErrorComponent },
  { path: 'evenementen', component: EvenementenComponent},
  { path: 'evenement', component: EvenementComponent},
  { path: 'evenement/:id', component: EvenementComponent, pathMatch: 'full'},
  { path: '**', redirectTo: '/404', pathMatch: 'full'}
];
 
@NgModule({
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  exports: [
    RouterModule
  ],
  declarations: []
})
export class RoutingModule { }