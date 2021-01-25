import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AgregarEditarComentarioComponent } from './componentes/agregar-editar-comentario/agregar-editar-comentario.component';
import { ListComentariosComponent } from './componentes/list-comentarios/list-comentarios.component';
import { VerComentarioComponent } from './componentes/ver-comentario/ver-comentario.component';

const routes: Routes = [
  {path:'agregar',component:AgregarEditarComentarioComponent},
  {path:'editar/:id',component:AgregarEditarComentarioComponent},
  {path:'ver/:id',component:VerComentarioComponent},
  {path:'',component:ListComentariosComponent,pathMatch:'full'},
  {path:'**', redirectTo:'/'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
