import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductsComponent } from './components/products/products.component';
import { LayoutMainComponent } from './components/layout-main/layout-main.component';

const routes: Routes = [
  {
    path: '',
    title: 'Shop',
    component: LayoutMainComponent,
    children: [
      { path: '', redirectTo: '/products', pathMatch: 'full' },
      {
        path: 'products',
        component: ProductsComponent
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
