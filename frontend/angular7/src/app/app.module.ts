import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './modules/routing/app-routing.module';
import { AppComponent } from './app.component';
import { MainHeaderNavComponent } from './components/navs/main-header/main.header';
import { MainHostComponent } from './components/hosts/main-host/main.host';
import { ImportanceUrgencyListComponent } from './components/importance-urgency-list/imp.urgency.list.component';
import { TasksService } from './services/tasks/Tasks.service';

@NgModule({
  declarations: [
    AppComponent,
    MainHostComponent,
    MainHeaderNavComponent,
    ImportanceUrgencyListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
    
  ],
  providers: [
    TasksService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
