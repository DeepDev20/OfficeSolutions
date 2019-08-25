import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { NgbModule, NgbCarousel,NgbDropdown } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule }   from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DefaultViewComponentComponent } from './default-view-component/default-view-component.component';
import { SendEmailComponentComponent } from './send-email-component/send-email-component.component';
import { SliderComponent } from './slider/slider.component';
import { CompanyComponent } from './company/company.component';
import { ProductAndserviceComponent } from './product-andservice/product-andservice.component';
import { HttpClient } from '@angular/common/http';
import { LoginComponent } from './login/login.component';
import { DashboardComponent } from './Core/dashboard/dashboard.component';
import { DashElementsComponent } from './Core/dash-elements/dash-elements.component';
import { InvoiceComponent } from './Core/invoice/invoice.component';
import { CompaniesComponent } from './Core/companies/companies.component';
import { EmployeesComponent } from './Core/employees/employees.component';
import { SalaryComponent } from './Core/salary/salary.component';
import { ExpensesComponent } from './Core/expenses/expenses.component';
import { DocumentComponent } from './Core/document/document.component';



@NgModule({
  declarations: [
    AppComponent,
    DefaultViewComponentComponent,
    SendEmailComponentComponent,
    SliderComponent,
    CompanyComponent,
    ProductAndserviceComponent,  
    LoginComponent, DashboardComponent, DashElementsComponent, InvoiceComponent, CompaniesComponent, EmployeesComponent, SalaryComponent, ExpensesComponent, DocumentComponent
  ],
  imports: [
    BrowserModule,
    NgbModule, 
    AppRoutingModule,
    FormsModule,
    // HttpClient,
  ],
  providers: [HttpClient],
  bootstrap: [AppComponent]
})
export class AppModule { }
