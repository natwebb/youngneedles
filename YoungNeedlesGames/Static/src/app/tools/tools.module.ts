import { NgModule } from '@angular/core';

import { ToolsRoutingModule, ComponentsList } from './tools.routing';

@NgModule({
    imports: [
        ToolsRoutingModule
    ],
    declarations: [
        ComponentsList
    ],
    providers: []
})
export class ToolsModule { }