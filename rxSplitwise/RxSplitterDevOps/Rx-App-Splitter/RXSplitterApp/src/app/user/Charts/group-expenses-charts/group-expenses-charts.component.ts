import { Component, OnInit } from '@angular/core';
import { chartDataGroupExpenses } from 'src/app/model/chartDataGroupExpense';
import { ReportServicesService } from 'src/app/services/report-services.service';

@Component({
  selector: 'app-group-expenses-charts',
  templateUrl: './group-expenses-charts.component.html',
  styleUrls: ['./group-expenses-charts.component.css']
})
export class GroupExpensesChartsComponent implements OnInit {

  constructor(public reportServices : ReportServicesService) { }
  groupId : number
  ngOnInit(): void {
    debugger;
    this.reportServices.GetGroupExpensesChart(this.groupId).subscribe((res: any) => {
      debugger;
     // console.log('****GetAllExpenseCharts*****', res.response);
      this.saleData=res.response
      console.log('****GetGroupExpensesChart*****', this.saleData);
    });
  }
  saleData : chartDataGroupExpenses[] =[] 
}
