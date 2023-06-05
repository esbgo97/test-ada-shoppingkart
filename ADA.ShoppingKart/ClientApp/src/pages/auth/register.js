import React from "react"

export const Register = () => {

    return <>
        <h4>Register</h4>
        <div className="card">
            <div className="card-body">
                <form>
                    <div class="mb-3">
                        <label for="exampleInputEmail1" class="form-label">Email</label>
                        <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" />
                        <div id="emailHelp" class="form-text">Este será tu usuario de Ingreso.</div>
                    </div>
                    <div class="mb-3">
                        <label for="exampleInputPassword1" class="form-label">Clave</label>
                        <input type="password" class="form-control" id="exampleInputPassword1" />
                    </div>

                    <div class="mb-3">
                        <label for="exampleInputPassword1" class="form-label">Role</label>

                        <select class="form-select" aria-label="Default select example">
                            <option selected>Seleccione un Rol</option>
                            <option value="0">Admin</option>
                            <option value="1">Buyer</option>
                        </select>
                    </div>

                    <button type="submit" class="btn btn-primary">Entrar</button>
                </form>
            </div>
        </div>
    </>
}