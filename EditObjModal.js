import React, { Component } from 'react';
import { Modal, Button, Row, Col, Form } from 'react-bootstrap';
import axios from '../axiosInstance'

export class EditObjModal extends Component {
    // constructor(props){
    //  super(props);
    // }

    state = {
        nume: null,
        categorie: null
    };

    handleUpdateCategorie = (event) => {
        this.setState({categorie: event.target.value}) 
   }

   handleUpdateNume = (event)=>{
       this.setState({nume: event.target.value})
   }


    handleSubmitUpdates = (event) => {
        event.preventDefault();
        const obiect = {
            nume: this.state.nume,
            categorie: this.state.categorie
        }
        axios.put(`Obiect/Update?idObiect=${0}&nume=${this.state.nume}&categorie=${this.state.categorie}`)
            .then(res => console.log(res.data));
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
                            Editeaza datele despre obiect
                        </Modal.Title>
                    </Modal.Header>
                    <Modal.Body>
                        <Row>
                            <Col sm={6}>
                                <Form onSubmit={this.handleSubmitUpdates}>
                                    <Form.Group controlId="idObiect">
                                        <Form.Label>Id obiect</Form.Label>
                                        <Form.Control
                                            type="text"
                                            name="idObiect"
                                            required
                                            disabled
                                            defaultValue={this.props.idObiect}
                                            placeholder="id obiect" />
                                    </Form.Group>
                                    <Form.Group controlId="numeObiect">
                                        <Form.Label>Nume obiect</Form.Label>
                                        <Form.Control 
                                            type="text" 
                                            name="numeObiect" 
                                            required 
                                            defaultValue={this.props.nume} 
                                            placeholder='nume obiect'
                                            onChange={this.handleUpdateNume} />
                                        <Form.Label>Categorie</Form.Label>
                                        <Form.Select 
                                            name="categorieObiect" 
                                            required
                                            defaultValue={this.props.categorie}
                                            onChange={this.handleUpdateCategorie}> 
                                            <option>Alege</option>
                                            <option value="electronice">electronice</option>
                                            <option value="mobila">mobila</option>
                                            <option value="instrumente">instrumente</option>
                                        </Form.Select>
                                    </Form.Group>
                                    <Form.Group>
                                        <Button
                                            variant="primary"
                                            type="button"
                                            onClick={this.handleSubmitUpdates}>
                                            Salveaza schimbarile
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