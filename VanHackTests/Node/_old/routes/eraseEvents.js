var express = require('express');
var router = express.Router();
const EventsController = require('../controllers/events');

// Route related to delete events

router.delete('/erase', EventsController.eraseEvents);

module.exports = router;