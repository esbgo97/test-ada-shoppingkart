import React, { useState } from "react"
import { Container, Card, Table, CardBody, Row, Col, Button, UncontrolledTooltip } from "reactstrap"
import { Trash, Cash, PlusLg } from "react-bootstrap-icons"
var items = [
    { id: 1, name: "BMW Serie 1", price: 120000.5, description: "Vehiculo de la serie de entrada de BMW", stock: 5 },
    { id: 2, name: "BMW Serie 3", price: 350000.5, description: "Vehiculo de la categoria de Sedanes Medianos de BMW", stock: 2 },
    { id: 3, name: "Sandero RS 2.0", price: 350000.5, description: "Vehiculo de la categoria de Sedanes Medianos de BMW", stock: 2 }
]


export const ProductItem = (props) => {
    const { id, name, price, description, stock, onAddItem } = props
    return <tr>
        <td>
            <strong>{name}</strong>
        </td>
        <td>
            <i>${price}</i>
        </td>
        <td>
            <span>{stock}</span>
        </td>
        <td>
            <span>{description}</span>
        </td>
        <td>
            <UncontrolledTooltip
                placement="right"
                target="addShoppingItemBtn"
            >
                Agregar Al Carro
            </UncontrolledTooltip>
            <Button color="primary" id="addShoppingItemBtn"
                onClick={() => onAddItem(id)}
            ><PlusLg color="white" /></Button>
        </td>

    </tr>
}

export const ProductList = () => {
    const [shoppingItems, setShoppingItems] = useState([]);
    const onAddItem = (itemId) => {
        console.log("onAddItem", itemId)
        var productItem = items.filter(i => i.id === itemId)[0];
        var shopping = shoppingItems.filter(i => i.id === itemId)[0];

        if (productItem != null && shopping == null) {

            var currentShoppingItems = [...shoppingItems, productItem];
            setShoppingItems(currentShoppingItems)
        }

    }

    const onRemoveItem = (itemId) => {
            var currentShoppingItems = shoppingItems.filter(i => i.id !== itemId);
            setShoppingItems(currentShoppingItems)
        //var shoppingItem = shoppingItems.filter(i => i.id === itemId)[0];
        //if (shoppingItem != null) {

        //}
    }
    return <Container>
        <Row>
            <Col>
                <Card>
                    <CardBody>
                        <h4>
                            Listado de productos:
                        </h4>
                        <Table>
                            <thead>
                                <tr>
                                    <th>Nombre</th>
                                    <th>Precio</th>
                                    <th>Stock</th>
                                    <th>Descripción</th>
                                    <th>Agregar</th>
                                </tr>
                            </thead>
                            <tbody>
                                {items.map((i, index) => <ProductItem key={index} {...i} onAddItem={onAddItem} />)}
                            </tbody>
                        </Table>
                        <ul className="list-group">
                        </ul>
                    </CardBody>
                </Card>
            </Col>
            <Col>
                <KartItems shoppingItems={shoppingItems} onRemoveItem={onRemoveItem} />
            </Col>
        </Row>

    </Container>
}

export const KartItem = (props) => {
    const { id, name, price, description, stock, onRemoveItem } = props
    const [cantidad, setCantidad] = useState(1);

    return <li className="list-group-item d-flex justify-content-between align-items-start">
        <span>
            <strong>{name}: </strong>
        </span>
        <span><input type="number"
            className="form-control"
            style={{ width: 50 }}
            value={cantidad}
            max={stock}
            onChange={(e) => setCantidad(e.target.value)} /></span>
        <span>Valor: $ {cantidad * price}</span>
        <div>
            <UncontrolledTooltip
                placement="right"
                target="removeBtn"
            >
                Quitar Producto
            </UncontrolledTooltip>
            <Button color="danger" id="removeBtn" onClick={() => onRemoveItem(id)}><Trash /></Button>


        </div>
    </li>
}

export const KartItems = (props) => {
    const { shoppingItems, onRemoveItem } = props
    console.log({ shoppingItems })

    return <Card>
        <CardBody>
            <h4>Productos en el Carro</h4>

            <ul>
                {shoppingItems.map((i, index) => <KartItem key={index} {...i} onRemoveItem={onRemoveItem} />)}
            </ul>
            <div className="d-flex justify-content-between ">
                <strong>Total: </strong> $ {shoppingItems.reduce((a, b) => a + b.price, 0)}
            </div>
            <Button color="success" block>Comprar <Cash /></Button>
            <br />
            <Button color="danger" >Cancelar <Trash /> </Button>

        </CardBody>
    </Card>
}