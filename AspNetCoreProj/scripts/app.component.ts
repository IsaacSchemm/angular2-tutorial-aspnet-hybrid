import { Component }          from 'angular2/core';
import { HeroService }        from './hero.service';
import { HeroesComponent }    from './heroes.component';
import { DashboardComponent } from './dashboard.component';
import { HeroDetailComponent } from './hero-detail.component';

import {RouteConfig, ROUTER_DIRECTIVES, ROUTER_PROVIDERS} from 'angular2/router';

@Component({
    selector: 'my-app',
    template: `
        <h1>{{title}}</h1>
        <nav>
          <a [routerLink]="['Dashboard']">Dashboard</a>
          <a [routerLink]="['Heroes']">Heroes</a>
        </nav>
        <router-outlet></router-outlet>
      `,
    directives: [ROUTER_DIRECTIVES],
    providers: [
        ROUTER_PROVIDERS,
        HeroService
    ]
})
@RouteConfig([
    {
        path: '/Heroes/Dashboard',
        name: 'Dashboard',
        component: DashboardComponent,
        useAsDefault: true
    },
    {
        path: '/Heroes/Heroes',
        name: 'Heroes',
        component: HeroesComponent
    },
    {
        path: '/Heroes/:id',
        name: 'HeroDetail',
        component: HeroDetailComponent
    }
])
export class AppComponent {
    title = 'Tour of Heroes';
}


/*
Copyright 2016 Google Inc. All Rights Reserved.
Use of this source code is governed by an MIT-style license that
can be found in the LICENSE file at http://angular.io/license
*/
