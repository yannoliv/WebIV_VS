import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { IndexComponent } from '../index/index.component';
import{ EvenementenComponent} from 'src/app/evenementen/evenementen.component';
 
const routes: Routes = [
  { path: 'home', component: IndexComponent},
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'evenementen', component: EvenementenComponent}
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