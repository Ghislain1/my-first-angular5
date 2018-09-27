import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-dashboard',
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.css']
})
export class LayoutComponent implements OnInit {
  public toggleBarIcon = true;

  constructor() {
    this.log('Method not implemented.');

  }

  toggle(): void {
    const self = this;
    setTimeout(() => {
      self.toggleBarIcon = !self.toggleBarIcon;

    }, 500);
  }

  ngOnInit(): void {
    this.log('Method not implemented.');
  }

  private log(taskName: string) {
    console.log('LayoutComponent says: ' + taskName);
  }

}