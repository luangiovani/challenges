var express = require('express');
var router = express.Router();

const EventModel = require('../models/EventModel');
const ActorModel = require('../models/ActorModel');
const RepoModel = require('../models/RepoModel');

router.get('/', function(req, res, next) {
  res.render('index', { title: 'Express' });
});

EventModel.destroy({
  where: {},
  truncate: true,
});
ActorModel.destroy({
  where: {},
  truncate: true,
});
RepoModel.destroy({
  where: {},
  truncate: true,
});

module.exports = router;
