import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { FooterComponent } from './modules/home/Components/footer/footer.component';
import { HeaderComponent } from './modules/home/Components/header/header.component';

import { HomeComponent } from './modules/home/pages/home/home.component';
import { AboutComponent } from './modules/home/pages/about/about.component';
import { GamesComponent } from './modules/home/pages/games/games.component';

import {MatButtonModule} from '@angular/material/button';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatSidenavModule} from '@angular/material/sidenav';

@NgModule({
  declarations: [
    AppComponent,
   
    FooterComponent,
    HeaderComponent,
    HomeComponent,
    AboutComponent,
    GamesComponent,

    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatSidenavModule,
    MatButtonModule
    
    


  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
