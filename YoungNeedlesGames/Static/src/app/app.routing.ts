import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
    { path: '', loadChildren: './home/home.module#HomeModule'},
    { path: 'tools', loadChildren: './tools/tools.module#ToolsModule'},
    { path: 'products', loadChildren: './products/products.module#ProductsModule'}
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }