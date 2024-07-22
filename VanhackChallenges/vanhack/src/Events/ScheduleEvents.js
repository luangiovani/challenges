import React from 'react'
import FullCalendar from '@fullcalendar/react'
import dayGridPlugin from '@fullcalendar/daygrid'
import timeGridPlugin from '@fullcalendar/timegrid'
import { Grid, Typography } from '@material-ui/core';

class ScheduleEvents extends React.Component {
    constructor(props) {
        super(props);
    }

    render(){
        return(
            <Grid container>
                <Grid item xs={12} sm={12} md={12} lg={12} container alignItems="center" justify="flex-start" className="grid-header-typography">
                    <Typography variant={ 'h5' }>
                        All Events
                    </Typography>
                </Grid>
                <Grid item xs={12} sm={12} md={12} lg={12} container className="mb grid-customized-box" alignItems="center">
                    <div className="grid-calendar">
                        <FullCalendar defaultView="timeGridWeek" 
                            plugins={[ dayGridPlugin, timeGridPlugin ]} 
                            header={{
                                left: 'prev,next today',
                                center: 'title',
                                right: 'dayGridMonth,timeGridWeek,timeGridDay,listWeek'
                            }}
                            minTime={ "07:00:00" } 
                            maxTime={ "23:00:00" } 
                            events={[
                                { title: 'Relocation Summit 2019', date: '2019-11-27' },
                                { title: 'VanHackathon', date: '2019-11-15', allDay : true },
                                { title: 'VanHackathon', date: '2019-11-16', allDay : true },
                                { title: 'VanHackathon', date: '2019-11-17' },
                                { title: 'VanHackathon', date: '2019-11-18' },
                                { title: 'VanHackathon', date: '2019-11-19' },
                                { title: 'VanHackathon', date: '2019-11-20', allDay : true },
                                { title: 'Leap Vancouver - Job Fair', date: '2019-12-02' },
                                { title: 'Leap Ontario', date: '2020-02-03' },
                                { title: 'Leap Calgary', date: '2020-02-24' },
                                { title: 'Colombia Recruiting Mission', date: '2020-03-08' },
                                { title: 'Leap MTL', date: '2020-03-12' },
                                { title: 'Leap Vancouver', date: '2020-03-30' },
                                { title: 'Past Event 1', date: '2019-10-30' },
                                { title: 'Past Event 2', date: '2019-10-25' },
                                { title: 'Past Event 3', date: '2019-09-30' },
                                { title: 'Past Event 4', date: '2019-08-15' },
                            ]}
                        />
                    </div>
                </Grid>
            </Grid>
        );
    }
}

export default ScheduleEvents;