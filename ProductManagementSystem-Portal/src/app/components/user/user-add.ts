
import { Component, OnInit, OnDestroy } from "@angular/core"
import { FormBuilder,FormGroup, Validators } from '@angular/forms'
import { Router } from "@angular/router"
import { Subscription, from } from 'rxjs';
import { HttpClient } from '@angular/common/http';
// import {  ToastrService } from 'ngx-toastr';


@Component({
    selector: "app-user",
    templateUrl: './user-add.html'
})
export class UserAddComponent implements OnInit {
    registerUser:FormGroup;
    result:any;

    constructor(private formBuilder:FormBuilder,private router:Router,private http:HttpClient) {
        
    }

    ngOnInit(): void {
        this.registerUser=this.formBuilder.group({
            userName:["",Validators.required],
            
            userMobile:["",Validators.required],
            userAddress:["",Validators.required]
        })
    }

    onAddUser(){
        this.http.post('http://localhost:4200/', this.registerUser.value).subscribe(t=>{
            this.result=t;
        })
    }

    onGoBack(){
        this.router.navigateByUrl('');
    }

    

}
