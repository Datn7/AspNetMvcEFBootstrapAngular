import { Component, OnInit } from '@angular/core';
import { DataServiceService } from './data-service.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  
    title = 'my-app';

    constructor(private data: DataServiceService) {

    }
    ngOnInit(): void {
        this.data.loadProducts().subscribe(success => {
            if (success) {
                this.products = this
                    .data.products;
            }
        });
    }

    public products = [];
}
