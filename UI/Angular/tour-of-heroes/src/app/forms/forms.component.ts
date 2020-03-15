import { Component, OnInit } from '@angular/core';
import { IHero } from '../models/IHero';

@Component({
  selector: 'app-forms',
  templateUrl: './forms.component.html',
  styleUrls: ['./forms.component.css']
})
export class FormsComponent implements OnInit {

  hero: IHero = {id:0, name:""};
  constructor() { }

  ngOnInit(): void {
  }

}
