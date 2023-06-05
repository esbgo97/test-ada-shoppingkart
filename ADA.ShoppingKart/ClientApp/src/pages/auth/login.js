import React from "react"
import { Collapse, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';

export const Login = () => {

    return <div className="content">
        <h4>Ingresar</h4>
        <div className="card">
            <div className="card-body">

                <div class="mb-3">
                    <label for="exampleInputEmail1" class="form-label">Email</label>
                    <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" />
                    <div id="emailHelp" class="form-text">Este será tu usuario de Ingreso.</div>
                </div>
                <div class="mb-3">
                    <label for="exampleInputPassword1" class="form-label">Clave</label>
                    <input type="password" class="form-control" id="exampleInputPassword1" />
                </div>
                <div class="mb-3 form-check">
                    <input type="checkbox" class="form-check-input" id="exampleCheck1" />
                    <label class="form-check-label" for="exampleCheck1">Recordarme</label>
                </div>
                <button type="button" class="btn btn-primary">Entrar</button> &nbsp;
                <Link to="/register">
                    Registrarme
                </Link>


            </div>
        </div>
    </div>
}