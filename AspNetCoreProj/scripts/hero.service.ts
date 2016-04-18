import {Injectable} from 'angular2/core';
import {Hero} from './hero';
//import {HEROES} from './mock-heroes';
import {Http} from 'angular2/http';

import 'rxjs/add/operator/map'
import 'rxjs/add/operator/toPromise'

@Injectable()
export class HeroService {
    constructor(public http: Http) {
        this.http = http;
    }
    getHeroes() {
        return this.http.get("/Heroes/GetList")
            .map(res => res.json())
            .map((tasks: Array<any>) => {
                let result: Array<Hero> = [];
                if (tasks) {
                    tasks.forEach((task) => {
                        result.push(task);
                    });
                }
                return result;
            }).toPromise();
        //return Promise.resolve(HEROES);
    }
}
