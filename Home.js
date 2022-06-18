import Button from "@restart/ui/esm/Button";
import React, {Component} from "react";
//import Button from "react-bootstrap/Button";
import {Obiecte} from "../components/Obiecte";

export class Home extends Component{
    

    render(){
       
        return (
            <div className="mt-5 d-flex justify-content-left">
                <Obiecte />
            </div>
            
        )
    }
}
