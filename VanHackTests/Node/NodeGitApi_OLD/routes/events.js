var express = require('express');
var router = express.Router();
const EventsController = require('../controllers/events');
  
router.get('/', EventsController.getAllEvents);
router.post('/', EventsController.addEvent);
router.get('/actors/:id', EventsController.getByActor);

module.exports = router;