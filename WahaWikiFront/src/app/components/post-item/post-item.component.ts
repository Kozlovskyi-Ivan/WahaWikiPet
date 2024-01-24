import { Component, Input, OnInit } from '@angular/core';
import { AbilityEntety } from '../enteties/UnitEntetyCRUD';

@Component({
  selector: 'app-post-item',
  templateUrl: './post-item.component.html',
  styleUrls: ['./post-item.component.css']
})

export class PostItemComponent implements OnInit {

  @Input() id: number | undefined = 0;
  @Input() title: string = "";
  @Input() description: string = "";
  @Input() ability!:AbilityEntety;
  @Input() editOnClick!:((ability:AbilityEntety)=> void)
  @Input() deleteOnClick!: ((id: number) => void);
  

  constructor() { }

  ngOnInit(): void {
  }
}
