import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DefaultViewComponentComponent } from './default-view-component/default-view-component.component';
import { LoginComponent } from './login/login.component';
import { DashboardComponent } from './Core/dashboard/dashboard.component';
import { DashElementsComponent } from './Core/dash-elements/dash-elements.component';
import { InvoiceComponent } from './Core/invoice/invoice.component';
import { CompaniesComponent } from './Core/companies/companies.component';
import { EmployeesComponent } from './Core/employees/employees.component';
import { SalaryComponent } from './Core/salary/salary.component';
import { ExpensesComponent } from './Core/expenses/expenses.component';
import { DocumentComponent } from './Core/document/document.component';


const routes: Routes = [
{path:'',component:DefaultViewComponentComponent},
{path:'login',component:LoginComponent},
{path:'dashboard',component:DashboardComponent, pathMatch: 'prefix',
children:[{path:'', component:DashElementsComponent},
{path:'invoice', component:InvoiceComponent},
{path:'companies',component:CompaniesComponent},
{path:'employees',component:EmployeesComponent},
{path:'salary',component:SalaryComponent},
{path:'expenses',component:ExpensesComponent},
{path:'documents',component:DocumentComponent},
]}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
