import { Component, OnInit }    from '@angular/core';
import { Router }               from '@angular/router';

import { HeroService } from './hero.service';

import { Hero } from './hero';

@Component({
    moduleId: module.id,
    selector: 'my-heroes',
    templateUrl: 'heroes.component.html',
    styleUrls: [ 'heroes.component.css' ],
  providers: [HeroService]
})

export class HeroesComponent implements OnInit {
    title = 'Tour of Heroes';
    selectedHero: Hero;

    hero: Hero = {
        id: 1,
        name: 'Windstorm'
    };

    heroes: Hero[];

    constructor(private heroService: HeroService, private router: Router) { }

    ngOnInit(): void {
        this.getHeroes();
    }

    getHeroes(): void {
        this.heroService.getHeroes().then(heroes => {
            this.heroes = heroes;
        });
    }

    onSelect(hero: Hero): void {
        this.selectedHero = hero;
    }

    gotoDetail(): void {
        this.router.navigate(['/detail', this.selectedHero.id]);
    }
}