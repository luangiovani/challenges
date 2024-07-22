import React from 'react';
import { Grid, Typography } from '@material-ui/core';
import canada from '../images/canada.svg';
import colombia from '../images/colombia.svg';
import Moment from 'react-moment';

class CommingSoon extends React.Component {
      constructor(props) {
          super(props);
      }
      render() {

        return (
            <Grid container>
                <Grid item xs={12} sm={12} md={12} lg={12} container alignItems="center" justify="flex-start" className="grid-header-typography">
                    <Typography variant={ 'h5' }>
                        Next Events
                    </Typography>
                </Grid>
                <Grid item xs={12} sm={12} md={12} lg={12} container alignItems="center" justify="flex-start" className="mb grid-customized-box">
                <div className="accordion">
                    <ul>
                        { this.props.events.map((event) => { 
                            return(
                            <li className={ event.className }>
                                <div> 
                                    {event.country === 'Canada' ? 
                                        <img src={ canada } alt="canada_flag" className="img-flags" />
                                    : 
                                        <img src={ colombia } alt="colombia_flag" className="img-flags" />
                                    }
                                    <a href="#">
                                        <Typography variant={'h4'}>
                                            { event.name }
                                        </Typography>
                                        <Typography variant={'h6'}>
                                            { event.subtitle }
                                        </Typography>
                                        <Typography variant='subtitle2' style={{ color: '#fff' }} className="MuiTypography-colorTextSecondary">
                                            { event.city + ' - ' + event.country }
                                        </Typography>
                                        <Typography variant='subtitle2' style={{ color: '#fff' }} className="MuiTypography-colorTextSecondary">
                                            Deadline: <Moment format="DD/MM/YYYY">{ event.endApplicationDate }</Moment>
                                        </Typography>
                                    </a>
                                </div>
                            </li>
                            )})
                        }
                    </ul>
                </div>
                </Grid>
            </Grid>       
        );
      }
}

export default CommingSoon;