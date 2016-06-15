import {Injectable} from '@angular/core';
import {Hero} from './hero';
//import {HEROES} from './mock-heroes';
import {Http, Headers} from '@angular/http';

import 'rxjs/add/operator/map'
import 'rxjs/add/operator/toPromise'

@Injectable()
export class HeroService {
    constructor(public http: Http) {
        this.http = http;
    }
    getHeroes() : Promise<Hero[]> {
        return this.http.get("/Heroes/Api")
            .toPromise()
            .then(response => response.json())
            .catch(this.handleError);
    }
    getHero(id: number): Promise<Hero> {
        return this.http.get("/Heroes/Api/" + id)
            .toPromise()
            .then(response => response.json())
            .catch(this.handleError);
    }

    // Add new Hero
    private post(hero: Hero): Promise<Hero> {
        let headers = new Headers({
            'Content-Type': 'application/json'
        });

        return this.http
            .post("/Heroes/Api", JSON.stringify(hero), { headers: headers })
            .toPromise()
            .then(res => res.json())
            .catch(this.handleError);
    }

    // Update existing Hero
    private put(hero: Hero) {
        let headers = new Headers();
        headers.append('Content-Type', 'application/json');

        return this.http
            .put("/Heroes/Api/" + hero.id, JSON.stringify(hero), { headers: headers })
            .toPromise()
            .then(() => hero)
            .catch(this.handleError);
    }

    save(hero: Hero): Promise<Hero> {
        if (hero.id) {
            return this.put(hero);
        }
        return this.post(hero);
    }

    delete(hero: Hero) {
        let headers = new Headers();
        headers.append('Content-Type', 'application/json');

        return this.http
            .delete("/Heroes/Api/" + hero.id, headers)
            .toPromise()
            .catch(this.handleError);
    }

    private handleError(error: any) {
        console.error('An error occurred', error);
        return Promise.reject(error.message || error);
    }
}
