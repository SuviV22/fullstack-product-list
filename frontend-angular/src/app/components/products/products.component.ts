import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Product } from '../../models/product';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrl: './products.component.css'
})
export class ProductsComponent implements OnInit {
  URL_PRODUCT_LIST = '/api/product/list';
  api = 'https://localhost:7249';

  products: Product[] = [];

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.loadProductList();
  }

  loadProductList() {
    const url = new URL(this.URL_PRODUCT_LIST, this.api).toString();
    this.http.get<Product[]>(url).subscribe(res => {
      this.products = res;
    })
  }
}
