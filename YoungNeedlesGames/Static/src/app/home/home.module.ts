import { NgModule } from '@angular/core';

import { HomeRoutingModule, ComponentsList } from './home.routing';

@NgModule({
    imports: [
        HomeRoutingModule
    ],
    declarations: [
        ComponentsList
    ],
    providers: []
})
export class HomeModule { }