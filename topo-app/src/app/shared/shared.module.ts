import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NaviComponent } from './navi/navi.component';

import { RouterModule } from '@angular/router';

@NgModule({
  imports: [
    RouterModule,
    CommonModule
      
  ],
  declarations: [NaviComponent],
  exports:[NaviComponent]
})
export class SharedModule { }
