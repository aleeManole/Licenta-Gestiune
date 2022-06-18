import { computeHeadingLevel } from '@testing-library/dom';
import React, { Component } from 'react';
import { Modal, Button, Row, Col, Form } from 'react-bootstrap';
import axios from '../axiosInstance'

export class ModalSubinventar extends Component {
    constructor(props) {
        super(props);
        this.state = { obiecte: [], studenti: [] ,
        };
    }

    state ={
        idStudent: null,
        idAngajat: null,
        idDepozit: null,
        idObiect: null,
        dataPrimire: null,
        dataPredare: null,
        cantitate: null
    };


    subinventarAttributes = {
        idSubinventar: null,
        idStudent: null,
        idAngajat: null,
        idDepozit: null,
        idObiect: null,
        dataPrimire: null,
        dataPredare: null,
        cantitate: null
    };

    updatedStateValue = {
        idSubinventar: null,
        idStudent: null,
        idAngajat: null,
        idDepozit: null,
        idObiect: null,
        dataPrimire: null,
        dataPredare: null,
        cantitate: null
    }

    handleChange = (event) => {
        console.log("Intra");
        this.setState({
            subinventarAttributes: this.updatedStateValue = {
                [event.target.idStudent]: event.target.value,
                [event.target.idAngajat]: event.target.value,
                [event.target.idDepozit]: event.target.value,
                [event.target.idObiect]: event.target.value,
                [event.target.dataPrimire]: event.target.value,
                 [event.target.dataPredare]: event.target.value,
                [event.target.cantitate]: event.target.value
            }
        });

    }

    handleSubmit = (event) => {
        console.log("Intra submit");
        axios
            .post(`Subinventar/Add`, console.log(this.subinventarAttributes))
            .then((res) => {
                console.log(res)
            })
            .catch(error => {
                console.log(error)
            })

    }

    render() {
        const {idSubinventar,
            idStudent,
            idDepozit,
            idObiect,
            dataPrimire,
            dataPredare,
            cantitate} = this.state
        return (
            <div className="container">
                <Modal {...this.props}
                    size="lg"
                    aria-labelledby="contained-modal-title-vcenter"
                    centered>
                    <Modal.Header>
                        <Modal.Title id="contained-modal-title-vcenter">
                            Adauga subinventar
                        </Modal.Title>
                    </Modal.Header>
                    <Modal.Body>
                        <Row>
                            <Col sm={6}>
                                <Form onSubmit={this.handleSubmit}>
                                    <Form.Group>
                                        <Form.Label>Alege un student</Form.Label>
                                        <Form.Control
                                            type="text"
                                            name="idStudent"
                                            value={idStudent}
                                            required
                                            placeholder='nume student'
                                            onChange={this.handleChange} />
                                    </Form.Group>
                                    <Form.Group >
                                        <Form.Label>Obiect</Form.Label>
                                        <Form.Control
                                            type="text"
                                            name="idObiect"
                                            required
                                            value={idObiect}
                                            placeholder='obiect'
                                            onChange={this.handleChange} />
                                        <Form.Label>Depozit</Form.Label>
                                        <Form.Select
                                            name="idDepozit"
                                            required
                                            value={idDepozit}
                                            onChange={this.handleChange}>
                                            <option>Depozite</option>
                                            <option value="central">central</option>
                                            <option value="mobila">mobila</option>
                                            <option value="electronice">electronice</option>
                                        </Form.Select>
                                        <Form.Label>Cantitate</Form.Label>
                                        <Form.Control
                                            type="text"
                                            name="cantitate"
                                            required
                                            value={cantitate}
                                            placeholder='cantitate'
                                            onChange={this.handleChange} />
                                    </Form.Group>
                                    <Form.Group controlId="dataPrimire">
                                        <Form.Label>Data primire</Form.Label>
                                        <Form.Control
                                            type="date"
                                            name="dataPrimire"
                                            required
                                            value={dataPrimire}
                                            placeholder="data primire"
                                            onChange={this.handleChange} />
                                    </Form.Group>
                                    <Form.Group controlId="dataPredare">
                                        <Form.Label>Data predare</Form.Label>
                                        <Form.Control
                                            type="date"
                                            name="dataPredare"
                                            required
                                            value={dataPredare}
                                            placeholder="data predare"
                                            onChange={this.handleChange} />
                                    </Form.Group>
                                    <Form.Group>
                                        <Button
                                            variant="primary"
                                            type="button"
                                            onClick={this.handleSubmit}>
                                            Salveaza
                                        </Button>
                                    </Form.Group>
                                </Form>
                            </Col>
                        </Row>
                    </Modal.Body>
                    <Modal.Footer>
                        <Button variant="danger" onClick={this.props.onHide}>
                            Inchide
                        </Button>
                    </Modal.Footer>
                </Modal>
            </div>
        )
    }
}