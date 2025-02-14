import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HttpService } from '../../services/http.service';

@Component({
  selector: 'app-confirm-email',
  standalone: true,
  imports: [],
  templateUrl: './confirm-email.component.html',
  styleUrl: './confirm-email.component.css'
})
export class ConfirmEmailComponent {

  email: string = ""
  response: string = "Mail adresiniz onaylanıyor..."


  constructor(private activated: ActivatedRoute, private http: HttpService){
      this.activated.params.subscribe(res=>{
        this.email=res["email"];
        this.confirm();
      })
  }

  confirm(){
    this.http.post<string>("Auth/ConfirmEmail",{email: this.email},(res)=>{
      this.response = res;
    })
  }
}
