import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatButtonModule, MatToolbarModule, MatSidenavModule, MatIconModule, MatListModule, MatMenuModule, MatDividerModule, MatCardModule } from '@angular/material';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { IndexComponent } from './index/index.component'
import { LayoutModule } from '@angular/cdk/layout';
import { RoutingModule } from './routing/routing.module';
import { HeaderComponent } from './navigation/header/header.component';
import { FlexLayoutModule } from "@angular/flex-layout";
import { SidenavListComponent } from './navigation/sidenav-list/sidenav-list.component';
import { FooterComponent } from './navigation/footer/footer.component';
import { EvenementenComponent } from './evenementen/evenementen.component';
import { EvenementComponent } from './evenementen/evenement/evenement.component';
import { EvenementListComponent } from './evenementen/evenement-list/evenement-list.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    IndexComponent,
    SidenavListComponent,
    FooterComponent,
    EvenementenComponent,
    EvenementComponent,
    EvenementListComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MatButtonModule,
    LayoutModule,
    MatToolbarModule,
    MatSidenavModule,
    MatIconModule,
    MatListModule,
    MatMenuModule,
    MatDividerModule,
    MatCardModule,
    FormsModule,
    RoutingModule,
    FlexLayoutModule
  ],
  bootstrap: [AppComponent],
  providers: []
})
export class AppModule { }
