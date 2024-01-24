import { Component, Input, OnInit, OnChanges } from '@angular/core';

@Component({
  selector: 'app-my-modal',
  templateUrl: './my-modal.component.html',
  styleUrls: ['./my-modal.component.css']
})
export class MyModalComponent implements OnInit {

  @Input() visible: boolean = false;
  @Input() setVisible!: (visible: boolean) => void;

  constructor() {
  }

  ngOnInit(): void {
  }

  onEvent = (e:any) => {
    e.stopPropagation();
  }
}
