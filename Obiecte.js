import React, { Component, useState } from "react";
import { ButtonToolbar } from "react-bootstrap";
import { Button } from "react-bootstrap";
import Table from 'react-bootstrap/Table'
import { AdaugareObjModal } from "./AdaugareObjModal";
import { EditObjModal } from "./EditObjModal";
import axios from '../axiosInstance'

export class Obiecte extends Component {
    constructor(props) {
        super(props)
        this.state = { obiecte: [], addModalShow: false, editModalShow: false }
    
    }


    getListaObiecte() {
        fetch("https://localhost:44360/api/Obiect/List", {
            method: "GET"
        })
            .then(response => response.json())
            .then(data => {
                (this.setState({ obiecte: data }));
            }).catch(err => {
                console.log("Error reading data" + err);
            });

    }

    componentDidMount() {
        this.getListaObiecte();
    }

    /*deleteObiect(idObiect) {
        console.log(idObiect);
        if (window.confirm("Sunteti sigur?")) {
            axios.delete(`Obiect/Delete?idObiect=${idObiect}`)
            .then(() => this.setState({status: 'Delete successful'}));
            getListaObiecte()
        }
    }*/

    deleteObiect(objId){
        alert(objId);
    }

    render() {
        const { obiecte, objId, objName, objCateg } = this.state;
        
        let addModalClose = () => this.setState({ addModalShow: false });
        let editModalClose = () => this.setState({ editModalShow: false });

        return (
            <div>
                <Table className="mt-4 size=lg" striped bordered hover responsive>
                    <thead>
                        <tr>
                            <th>Nr.</th>
                            <th>Nume</th>
                            <th>Categorie</th>
                            <th>Optiuni</th>
                        </tr>
                    </thead>
                    <tbody>
                        {obiecte.map(obj =>
                            <tr key={obj.idObiect}>
                                <td>{obj.idObiect}</td>
                                <td>{obj.nume}</td>
                                <td>{obj.categorie}</td>
                                <td>
                                    <ButtonToolbar>
                                        <Button className="mr-2" variant="info"
                                            onClick={() => this.setState({
                                                editModalShow: true,
                                                objId: obj.idObiect,
                                                objName: obj.nume,
                                                objCateg: obj.categorie
                                            })}>
                                            Edit
                                        </Button>
                                        <Button className="mr-2" variant="danger"
                                            onClick={() => this.deleteObiect(console.log(obj.idObiect))}>
                                            Stergere
                                        </Button>
                                        <EditObjModal show={this.state.editModalShow} objId={objId} objName={objName} objCateg={objCateg} onHide={editModalClose} />
                                    </ButtonToolbar>
                                </td>
                            </tr>)}

                    </tbody>
                </Table>

                <ButtonToolbar>
                    <Button variant='primary' onClick={() => this.setState({ addModalShow: true })}>
                        Adauga obiect nou
                    </Button>
                    <AdaugareObjModal show={this.state.addModalShow} onHide={addModalClose} />
                </ButtonToolbar>
            </div>
        )
    }

}