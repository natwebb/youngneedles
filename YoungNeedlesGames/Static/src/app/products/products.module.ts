import { NgModule } from '@angular/core';

import { ProductsRoutingModule, ComponentsList } from './products.routing';

@NgModule({
    imports: [
        ProductsRoutingModule
    ],
    declarations: [
        ComponentsList
    ],
    providers: []
})
export class ProductsModule { }