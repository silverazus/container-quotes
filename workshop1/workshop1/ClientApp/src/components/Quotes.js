import React, { useCallback, useContext, useEffect, useState } from 'react';
import apple from '../image/greenapple.jpeg';
import { Container, Row, Col } from 'reactstrap';
export default function Quotes() {
    const [quotes, setQuotes] = useState({quote:''});

    useEffect(() => {
      
        loadData();

    }, [])
    const loadData = async () => {
        try {
            const response = await fetch('quote');
            const data = await response.json();
           
            setQuotes(data)
        }
        catch (error) {
            console.log(error)

        }
    }
    return (
        <>
            <Container style={{ textAlign: 'center' }}>
                <Row >
                <Col>< img style={{ width: "5%" }} src={apple} />
                        {quotes.quote}
                        </Col>
                </Row><Row> <Col>
                    <a href={'https://github.com/silverazus/container-quotes'}>https://github.com/silverazus/container-quotes</a>

                </Col></Row>
            </Container>
        </>
        );
}