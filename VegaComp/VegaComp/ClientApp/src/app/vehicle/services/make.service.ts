import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';
import { SaveMake, Make } from '../../shared/models/vehicle';

@Injectable({
  providedIn: 'root'
})
export class MakeService {

  private readonly makesEndpoint = '/api/makes';

  constructor(private httpClient: HttpClient) {


  }

  create(make: SaveMake): any {
    return this.httpClient.post(this.makesEndpoint, make);
  }

  update(make: SaveMake): any {
    return this.httpClient.put(this.makesEndpoint + '/' + make.id, make)

  }


  getMake(id: number): any {
    return this.httpClient.get(this.makesEndpoint + '/' + id)
  }


  getMakes(): Observable<Make[]> {

    const res = this.httpClient.get<Make[]>(this.makesEndpoint);

    return res;
  }


}
