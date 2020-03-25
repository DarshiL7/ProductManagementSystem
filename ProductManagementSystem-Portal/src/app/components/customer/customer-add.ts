
import { Component, OnInit, OnDestroy } from "@angular/core"
import { FormBuilder,FormGroup, Validators } from '@angular/forms'
import { Router } from "@angular/router"
import { Subscription, from } from 'rxjs';
// import {  ToastrService } from 'ngx-toastr';


@Component({
    selector: "app-customer",
    templateUrl: './customer-add.html'
})
export class CustomerAddComponent implements OnInit {
    registerCustomer:FormGroup;

    constructor(private formBuilder:FormBuilder,private router:Router) {
        
    }

    ngOnInit(): void {
        this.registerCustomer=this.formBuilder.group({
            customerName:["",Validators.required],
            
            customerMobile:["",Validators.required,Validators.maxLength(10)],
            customerAddress:["",Validators.required]
        })
    }

    onAddCustomer(){

    }

    onGoBack(){
        this.router.navigateByUrl('');
    }

    

}
