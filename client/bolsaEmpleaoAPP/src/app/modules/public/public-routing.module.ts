import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LandingComponent } from './components/landing/landing.component';

const routes: Routes = [
  { path: '', pathMatch: 'full', redirectTo: '/info' },
  { path: 'info', component: LandingComponent },
  // { path: 'landing', loadChildren: () => import('./modules/public/public.module').then(m => m.PublicModule) }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PublicRoutingModule { }
