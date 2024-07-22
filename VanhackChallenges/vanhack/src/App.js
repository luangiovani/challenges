import React, { Fragment } from 'react';
import logo from './images/logo.svg';
import './App.css';
import Highlights from './Events/Highlights';
import ComingSoon from './Events/ComingSoon';
import ScheduleEvents from './Events/ScheduleEvents';
import CssBaseline from '@material-ui/core/CssBaseline';
import Container from '@material-ui/core/Container';
import { Grid } from '@material-ui/core';

class App extends React.Component {
    constructor() {
      super();
      this.state = {
        events: [],
        highs: []
      };
    }
  
    componentDidMount() {
      fetch("http://localhost:2745/api/events/list")
        .then(response => response.json())
        .then(allEvents =>
          this.setState({
            events: allEvents.events,
            highs: allEvents.highs,
            isFetching: false
          })
        );
    }

    render() {
        return (
            <Fragment>
                  <CssBaseline />
                  <Container maxWidth="xl">
                      <Grid container>
                          <Grid item xs={12}>
                              <header className="App-header">
                                  <img src={ logo } alt="logotipo" />
                                  <span>Vanhackathon Challenges - Calendar Page</span>
                              </header>
                          </Grid>
                          <Highlights highs={ this.state.highs } />
                          <ComingSoon events={ this.state.events } />
                          <ScheduleEvents events={ this.state.events } />
                      </Grid>
                  </Container>
            </Fragment>
        );
    }
  }
  
export default App;