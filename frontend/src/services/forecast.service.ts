import { Injectable } from '@angular/core';
import { Client, GetForecastInputDto, GetForecastOutputDto } from '../api-client';

@Injectable({
  providedIn: 'root'
})
export class ForecastService {


  client: Client;

  constructor() { 
    this.client = new Client();
  }

  getForecast(city: string, duration: number): Promise<GetForecastOutputDto>{
    
    var requestDto = new GetForecastInputDto();
    requestDto.city = city;
    requestDto.days = duration;

    return this.client.getWeatherForecast(requestDto);  
  }
}
