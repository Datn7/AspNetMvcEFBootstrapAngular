import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { APP_BASE_HREF } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListItemComponent } from './list-item/list-item.component';
import { DataServiceService } from './data-service.service';


@NgModule({
  declarations: [
    AppComponent,
    ListItemComponent
  ],
  imports: [
    BrowserModule,
      AppRoutingModule,
        HttpClientModule
    ],
    providers: [{ provide: APP_BASE_HREF, useValue: '/my/app' }, DataServiceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
