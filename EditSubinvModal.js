import React, {Component} from 'react';
import {Modal, Button, Row, Col, Form} from 'react-bootstrap';

export class EditSubinvModal extends Component{
    constructor(props){
        super(props);
        this.state={obiecte:[],studenti:[]};
        this.handleSubmit=this.handleSubmit.bind(this);
    }

    componentDidMount(){
        fetch(process.env.React_APP_API_OBJ+'List')
        .then(response=>response.json())
        .then(data=>{
            this.setState({obiecte:data});
        });
    }

    listaStudenti(){
        fetch(process.env.React_APP_API_STUD+'List')
        .then(response=>response.json())
        .then(data=>{
            this.setState({studenti:data});
        });
    }

    handleSubmit(event){
        event.preventdefault();
        fetch(process.env.React_APP_AP_SUBINVI+'List',{
            method:'PUT',
            headers:{
                'Accept':'application/json',
                'Content-Type':'appliction/json'
            },
            body:JSON.stringify({
                idSubinv:null,
                idStudent:event.target.idStudent.value,
                idDepozit:event.target.idDepozit.value,
                idObiect:event.target.idObiect.value,
                dataPrimire:event.target.dataPrimire.value,
                dataPredare:event.target.dataPredare.value,
                cantitate:event.target.cantitate.value,

            })
        })
        .then(res=>res.json())
        .then((result)=>{
            alert(result);
        },
        (error)=>{
            alert('Esuat');
        })
    }

    render(){
        return (
            <div className="container">
                <Modal {...this.props} 
                size="lg"
                aria-labelledby="contained-modal-title-vcenter"
                centered>
                   <Modal.Header clooseButton>
                       <Modal.Title id="contained-modal-title-vcenter">
                           Editare subinventar
                       </Modal.Title>
                   </Modal.Header>
                   <Modal.Body>
                       <Row>
                           <Col sm={6}>
                               <Form onSubmit={this.handleSubmit}>
                                   <Form.Group>
                                       <Form.Label>Sudent</Form.Label>
                                       <Form.Control type="text" name="numeStud" required defaultValue={this.props.idStudent} placeholder='nume student'/>
                                   </Form.Group>
                                   <Form.Group controlId="idSubinv">
                                       <Form.Label>Obiect</Form.Label>
                                       <Form.Control type="text" name="numeObiect" required defaultValue={this.props.idObiect} placeholder='nume obiect'/>
                                       <Form.Label>Depozit</Form.Label>
                                       <Form.Select name="depozit"  required defaultValue={this.props.idDepozit}>
                                           <option>Depozite</option>
                                           <option value="1">central</option>
                                           <option value="2">mobila</option>
                                           <option value="3">electronice</option>
                                       </Form.Select>
                                       <Form.Label>Cantitate</Form.Label>
                                       <Form.Control type="text" name="cantitate" required defaultValue={this.props.cantitate} placeholder='cantitate'/>
                                   </Form.Group>
                                   <Form.Group controlId="dataPrimire">
                                       <Form.Label>Data primire</Form.Label>
                                       <Form.Control type="date" name="dataPrimire" required defaultValue={this.props.dataPrimire} placeholder="data primire"/>
                                    </Form.Group>
                                   <Form.Group>
                                       <Button variant="primary" type="submit">
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