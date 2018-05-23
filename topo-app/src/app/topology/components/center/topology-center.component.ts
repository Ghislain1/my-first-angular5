

import { Component, OnInit } from '@angular/core';
import { LoggingService } from '../../../shared/services/logging.service';
 

@Component({
  selector: 'app-topology-center',
  templateUrl: './topology-center.component.html',
  styleUrls: ['./topology-center.component.css']
})
export class TopologyCenterComponent implements OnInit {

  constructor(private loggingService: LoggingService) { }

  ngOnInit() {
    //this.loggingService.showAlert(" -------Topo Parent Component----------");
  }
}

