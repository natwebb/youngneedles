import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

//Components
import { ToolsComponent } from './tools.component';
export const ComponentsList = [ToolsComponent];

const routes: Routes = [
    { path: '', component: ToolsComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ToolsRoutingModule { }