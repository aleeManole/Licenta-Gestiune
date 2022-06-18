import React, { Component } from "react";
import { ButtonToolbar } from "react-bootstrap";
import { Button } from "react-bootstrap";
import { ModalSubinventar } from "../components/ModalSubinventar";
import { Table } from "react-bootstrap";
import { EditSubinvModal } from "../components/EditSubinvModal";
import axios from '../axiosInstance'

export class Subinventar extends Component {
    constructor(props) {
        super(props)
        this.state = { subinventare: [], addModalShow: false, editModalShow: false }
    }

    getListaSubinv() {
        fetch('https://localhost:44360/api/Subinventar/List', {
            method: "GET",
            headers : { 
                'Content-Type': 'application/json',
                'Accept': 'application/json'
               }
        })
            .then(response => response.json())
            .then(data => {
                console.log(this.setState({ subinventare: data }));
            }).catch(err => {
                console.log("Error reading data" + err);
            });
    }

    componentDidMount() {
        this.getListaSubinv();
    }



    deleteSubinv(subinvId) {
        if (window.confirm("Sunteti sigur?")) {
            axios.delete(`Subinventar/Delete?${subinvId}`)
        }
    }

    render() {
        const { subinventare, subinvId, studId, depId, dataPrim, dataPred, objId, cant } = this.state;
        let addModalClose = () => this.setState({ addModalShow: false });
        let editModalClose = () => this.setState({ editModalShow: false });

        return (
            <div>
                <Table className="mt-4" striped bordered hover responsive>
                    <thead>
                        <tr>
                            <th>Id subinventar</th>
                            <th>Nume/id student</th>
                            <th>Id depozit</th>
                            <th>Nume/id obiect</th>
                            <th>Data primire</th>
                            <th>Data predare</th>
                            <th>Cantitate</th>
                            <th>Optiuni</th>
                        </tr>
                    </thead>
                    <tbody>
                        {subinventare.map(subinv =>
                            <tr key={subinv.idSubinventar}>
                                <td>{subinv.idSubinventar}</td>
                                <td>{subinv.idStudent}</td>
                                <td>{subinv.idDepozit}</td>
                                <td>{subinv.idObiect}</td>
                                <td>{subinv.dataPrimire}</td>
                                <td>{subinv.dataPredare}</td>
                                <td>{subinv.cantitate}</td>
                                <td>
                                    <ButtonToolbar>
                                        <Button className="mr-2" variant="info"
                                            onClick={() => this.setState({
                                                editModalShow: true,
                                                subinvId: subinv.idSubinventar,
                                                studId: subinv.idStudent,
                                                depId: subinv.idDepozit,
                                                dataPrim: subinv.dataPrimire,
                                                dataPred: subinv.dataPredare,
                                                objId: subinv.idObiect,
                                                cant: subinv.cantitate,
                                            })}>
                                            Edit
                                        </Button>
                                        <Button className="mr-2" variant="danger"
                                            onClick={() => this.deleteSubinv(subinv.idSubinv)}>
                                            Stergere
                                        </Button>
                                        <EditSubinvModal show={this.state.editModalShow}
                                            idSubinventar={subinvId} idStudent={studId}
                                            idDepozit={depId} idObiect={objId}
                                            dataPrimire={dataPrim} dataPredare={dataPred}
                                            cantitate={cant} onHide={editModalClose} />
                                    </ButtonToolbar>
                                </td>
                            </tr>)}
                    </tbody>
                </Table>
                <ButtonToolbar>
                    <Button variant='primary' onClick={() => this.setState({ addModalShow: true })}>
                        Subinventar nou
                    </Button>
                    <ModalSubinventar show={this.state.addModalShow} onHide={addModalClose} />
                </ButtonToolbar>
            </div>
        )
    }
}
