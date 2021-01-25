import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from "@angular/common/http";
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AgregarEditarComentarioComponent } from './componentes/agregar-editar-comentario/agregar-editar-comentario.component';
import { ListComentariosComponent } from './componentes/list-comentarios/list-comentarios.component';
import { NavBarComponent } from './componentes/nav-bar/nav-bar.component';
import { VerComentarioComponent } from './componentes/ver-comentario/ver-comentario.component';

@NgModule({
  declarations: [
    AppComponent,
    AgregarEditarComentarioComponent,
    ListComentariosComponent,
    NavBarComponent,
    VerComentarioComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
