import { Component } from '@angular/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  public isNavbarCollapsed =true;
  constructor()
  {

  }
  goTo(link:string)
  {
    
    window.location.href=link;
    console.log(link);
  this.isNavbarCollapsed=!this.isNavbarCollapsed;
  }
  title = 'ABM TECHNO SOLUTION';
  copyRightsYear=new Date().getFullYear();
  logosrc='../assets/Images/logo-home.PNG';
}
