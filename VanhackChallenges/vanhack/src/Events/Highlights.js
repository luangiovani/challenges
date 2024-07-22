import React from 'react';
import "react-responsive-carousel/lib/styles/carousel.min.css";
import { Carousel } from 'react-responsive-carousel';
import { Grid, Typography, Button } from '@material-ui/core';
import canada from '../images/canada.svg';
import colombia from '../images/colombia.svg';
import Moment from 'react-moment';

class Highlights extends React.Component {
    
    constructor(props) {
        super(props);
    }

    render() {
        return (this.props.highs != undefined && 
            <Grid item xs={12} className="mb grid-customized-box">
                <Carousel autoPlay
                    interval={ 10000 }
                    showIndicators= { false } 
                    showStatus= { false } 
                    showThumbs={ false } 
                    infiniteLoop={ true } >
                    {
                        this.props.highs.map((event) => { return(
                            <div id={ 'evento_banner_' + event.id }>
                                <Grid container key={ 'k_evento_banner_' + event.id }>
                                    <Grid item container>
                                        <img alt={event.slug} src={ require("../images/"+event.cover) } className="banner"/>
                                    </Grid>
                                    <Grid item container alignItems="center" justify="center" className="footer-caroussel">
                                        <Grid item xs={2} sm={1} md={1} lg={1} container alignItems="center" justify="flex-start">
                                            {event.country === 'Canada' ? 
                                                <img src={ canada } alt="canada_flag" className="img-flags" />
                                            : 
                                                <img src={ colombia } alt="colombia_flag" className="img-flags" />
                                            }
                                            
                                        </Grid>
                                        <Grid item xs={10} sm={11} md={11} lg={11} container alignItems="center" justify="flex-start">
                                            <Grid item xs={12} sm={12} md={12} lg={3}>
                                                <Typography variant={ 'h6' }>
                                                    { event.name }
                                                </Typography>
                                            </Grid>
                                            <Grid item xs={12} sm={12} md={9} lg={7} container justify="space-between">
                                                <Typography variant='subtitle2' className="MuiTypography-colorTextSecondary">
                                                    { event.city + ' - ' + event.country }
                                                </Typography>
                                                <Typography variant='subtitle2' className="MuiTypography-colorTextPrimary">
                                                    { event.subtitle }
                                                </Typography>
                                                <Typography variant='subtitle2' className="MuiTypography-colorTextSecondary">
                                                    Deadline:
                                                </Typography>
                                                <Typography variant='body2' className="MuiTypography-colorTextPrimary">
                                                    <Moment format="DD/MM/YYYY">{ event.endApplicationDate }</Moment>
                                                </Typography>
                                            </Grid>    
                                            <Grid item xs={12} sm={12} md={3} lg={2} container justify="flex-end">
                                                <Button variant="contained" color="primary">
                                                    See details
                                                </Button>    
                                            </Grid>                        
                                        </Grid>
                                    </Grid>
                                </Grid>
                            </div>
                        )})
                
                    }
                </Carousel>
            </Grid>
        );
    }
}

export default Highlights;