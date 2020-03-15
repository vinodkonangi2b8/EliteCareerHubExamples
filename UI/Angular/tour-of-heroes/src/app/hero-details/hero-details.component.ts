import { Component, OnInit, Input, OnChanges, SimpleChanges } from '@angular/core';
import { IHero } from '../models/IHero';

@Component({
  selector: 'app-hero-details',
  templateUrl: './hero-details.component.html',
  styleUrls: ['./hero-details.component.css']
})
export class HeroDetailsComponent implements OnInit, OnChanges {

@Input() hero: IHero;

  constructor() { 
  }
  ngOnChanges(changes: SimpleChanges): void {
    console.log(1);
    console.log(changes);
  }

  ngOnInit(): void {
    console.log(2);
  }

}
