import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ReportServicesService {

  constructor(private _http: HttpClient) { }
   
  grpList: any
  
  auth_token =  JSON.parse(localStorage.getItem('Token') || '{}').value
 
  
  headers = new HttpHeaders({
    'Content-Type': 'application/json',
    'Authorization': `Bearer ${this.auth_token}`
  });

link="https://rxsplitterapis.azurewebsites.net/api/v1/"



GetAllExpenseCharts()
{
   return this._http.get(this.link+"Report/getExpensesChart",{
   headers: this.headers
   })
 }

 GetGroupExpensesChart(groupId : number)
{
  //https://localhost:7228/api/v1/Report/GetGroupExpensesChart?groupId=220
   return this._http.get(this.link+"Report/GetGroupExpensesChart"  + groupId,{
   headers: this.headers
   })
 }

}
