import { Component, OnInit } from '@angular/core';

@Component({
  // tslint:disable-next-line:component-selector
  selector: 'body',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  ngOnInit(): void {
    this.log('Method ------------------------------------------------  ngOnInit() .');
  }

  private log(taskName: string) {
    console.log('AppComponent says: ' + taskName);
  }
}