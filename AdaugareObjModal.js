import React, { Component, } from 'react';
import { Modal, Button, Row, Col, Form } from 'react-bootstrap';
import axios from '../axiosInstance'

export class AdaugareObjModal extends Component {
    state = {
        nume: null,
        categorie: null
    };


    handleChangeCategorie = (event) => {
         this.setState({categorie: event.target.value}) 
    }

    handleChangeNume = (event)=>{
        this.setState({nume: event.target.value})
    }

    handleSubmit = (event) => {
        console.log("Intra submit");
        axios
            .post(`Obiect/Add?idObiect=${12}&nume=${this.state.nume}&categorie=${this.state.categorie}`)
            .then((res) => {console.log(res)})
    }

    render() {
        return (
            <div className="container">
                <Modal {...this.props}
                    size="lg"
                    aria-labelledby="contained-modal-title-vcenter"
                    centered>
                    <Modal.Header >
                        <Modal.Title id="contained-modal-title-vcenter">
                            Adauga obiect in inventar
                        </Modal.Title>
                    </Modal.Header>
                    <Modal.Body>
                        <Row>
                            <Col sm={6}>
                                <Form onSubmit={this.handleSubmit}>
                                    <Form.Group controlId="numeObiect">
                                        <Form.Label>Nume obiect</Form.Label>
                                        <Form.Control 
                                            type="text" 
                                            name="numeObiect"
                                            required
                                            placeholder='nume obiect'
                                            onChange={this.handleChangeNume} 
                                        />
                                        <Form.Label>Categorie</Form.Label>
                                        <Form.Select 
                                            name="categorieObiect" 
                                            required
                                            onChange={this.handleChangeCategorie}>
                                            <option>Categorii</option>
                                            <option value="electronice">electronice</option>
                                            <option value="mobila">mobila</option>
                                            <option value="instrumente">instrumente</option>
                                        </Form.Select>
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