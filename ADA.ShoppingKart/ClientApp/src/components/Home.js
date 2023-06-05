import React, { Component } from 'react';

export class Home extends Component {
    static displayName = Home.name;

    render() {
        return (
            <div>
                <h1>Shopping Kart!</h1>
                <p>El siguiente proyecto hace parte de una prueba de ingreso como Desarrollador Full Stack.
                    <br />
                    Desarrollado por <a href="https://esbgo97.github.io/cv/" target="_blank">Edward Bustos</a>
                </p>
                <p>Tenga en cuenta los siguientes puntos:</p>
                <ul>
                    <li>El Código esta publicado en <a href="https://github.com/esbgo97/test-ada-shoppingkart">GitHub</a></li>
                    <li>El Backend está construido en <a href='https://get.asp.net/'>ASP.NET Core</a> v6.0 LTS & <a href='https://msdn.microsoft.com/en-us/library/67ef8sbd.aspx'>C#</a> </li>
                    <li>El Frontend está construido en <a href='https://facebook.github.io/react/'>React</a>, con <a href='http://getbootstrap.com/'>Bootstrap</a> para los estilos</li>
                    <li>La DB debe ejecutarse en un motor <a href='https://www.microsoft.com/en-us/sql-server/sql-server-downloads'> SQL Server</a> </li>
                </ul>
                <p>Se utilizaron las Siguientes Librerias:</p>
                <ul>
                    <li><strong>Swagger: </strong>. Para documentación del API. (<a href="https://localhost:7146/swagger/index.html" target="_blank">Backend</a>)</li>
                    <li><strong>Entity Framework</strong>. Para el manejo de conexiones a la DB.</li>
                    <li><strong>Json Web Token</strong>. Para el Aseguramiento de Datos entre cliente-servidor.</li>
                </ul>

            </div>
        );
    }
}
