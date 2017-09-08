import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'young-needles',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
    constructor(
        private router: Router
    ) {}

    //Public Methods
    goTo(route: string) {
        this.router.navigate([route]);
    }
}
