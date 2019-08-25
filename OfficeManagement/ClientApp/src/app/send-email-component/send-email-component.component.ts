import { Component, OnInit } from '@angular/core';
import { FormsModule }   from '@angular/forms';
import { Email } from '../email';
import {HttpClientServiceService} from '../http-client-service.service';
@Component({
  selector: 'app-send-email-component',
  templateUrl: './send-email-component.component.html',
  styleUrls: ['./send-email-component.component.scss']
})

export class SendEmailComponentComponent  {

 public model:Email;
  constructor(private httpClientService : HttpClientServiceService) { 
   this.model= new Email('','','');
  }

 
  onSubmit()
  {

    alert("Email"+this.model.emailId+" Subject"+this.model.subject+" Body"+this.model.emailBody);
    
  }
}
