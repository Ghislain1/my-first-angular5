

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoggingService } from './services/logging.service';
import { HttpErrorHandler } from './services/http-error-handler.service';
import { MessageService } from './services/message.service';
import { HttpClientModule } from '@angular/common/http';
import { ConfigService } from './services/config-service';
import { TopologyService } from './services/topology.service';
import { Safe } from './pipes/safe';
import { DeviceService } from './services/device.service';
import { LinkService } from './services/link.service';
import { FileSaveService } from './utils/file-save.service';
import { NodeService } from './services/node.service';


/**
 * The module that includes all the basic Topology elemente like {@link Device}, {@link Link}, ...
 *
 * @stable
 */
@NgModule({
  imports: [
    CommonModule,
    HttpClientModule,
  ],
  declarations: [Safe],
  exports: [Safe],
  providers: [Safe, NodeService, LoggingService, FileSaveService, ConfigService, TopologyService, LinkService, DeviceService, HttpErrorHandler, MessageService]
})
export class CoreModule { }
