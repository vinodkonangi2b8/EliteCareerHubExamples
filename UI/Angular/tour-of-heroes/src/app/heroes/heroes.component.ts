import { Component, OnInit } from "@angular/core";
import { IHero } from "../models/IHero";
import { HeroService } from "../services/hero.service";

@Component({
  selector: "app-heroes",
  templateUrl: "./heroes.component.html",
  styleUrls: ["./heroes.component.css"]
})
export class HeroesComponent implements OnInit {
  selectedHero: IHero;

  heroes: IHero[];

  constructor(private heroSer: HeroService) {
  }

  ngOnInit(): void {
    this.heroes = this.heroSer.getHeroes();
  }

  onSelect(h: IHero) {
    this.selectedHero = h;
  }
}
