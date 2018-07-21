import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'dp-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

  @Output() toggleSideNav = new EventEmitter<void>();
  constructor() { }

  ngOnInit() {
  }

}
