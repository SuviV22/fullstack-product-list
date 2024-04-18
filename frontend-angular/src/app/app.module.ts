import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {
  HttpClientModule,
} from '@angular/common/http';
import { MatCardModule } from '@angular/material/card';
import { MatSidenavModule } from '@angular/material/sidenav';
import {
  MatIconModule,
  MAT_ICON_DEFAULT_OPTIONS,
} from '@angular/material/icon';
import { MatTreeModule } from '@angular/material/tree';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductsComponent } from './components/products/products.component';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import { LayoutMainComponent } from './components/layout-main/layout-main.component';

@NgModule({
  declarations: [
    AppComponent,
    ProductsComponent,
    LayoutMainComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    MatCardModule,
    MatSidenavModule,
    MatIconModule,
    MatTreeModule,
  ],
  providers: [
    provideAnimationsAsync(),
    {
      provide: MAT_ICON_DEFAULT_OPTIONS,
      useValue: { fontSet: 'material-symbols-rounded' },
    },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
