import { Component } from '@angular/core';
import { GetForecastOutputDto } from 'src/api-client';
import { ForecastService } from 'src/services/forecast.service';

@Component({
  selector: 'app-forecast',
  templateUrl: './forecast.component.html',
  styleUrls: ['./forecast.component.scss']
})
export class ForecastComponent {

  public cities = ['Tampa', 'Reno', 'Austin']; // list of cities
  public selectedCity = 'Tampa'; // selected city
  public cityForecast: GetForecastOutputDto | null = null; // forecast data for selected city

  currentPage: number = 1;
  itemsPerPage: number = 5;


  constructor(private forecastService: ForecastService){

  }

  // public selectedCity = "tampa";
  public days = 14;

  ngOnInit(): void {
    this.getCityForecast();
  }

  public onCityChange(city: any){
    this.selectedCity = city.target.value
    this.getCityForecast();
  }
  

  public getCityForecast() {
    this.forecastService.getForecast(this.selectedCity, this.days).then(res => {
        this.cityForecast = res;
      },
      error => {
        console.log(error);
      }
    );
  }

  public mayMoveForward(): boolean{
    if(!this.cityForecast?.weather?.forecast?.forecastday?.length){
      return false;
    }
    return this.currentPage == Math.ceil(this.cityForecast?.weather?.forecast?.forecastday?.length / this.itemsPerPage)
  }
  

}
