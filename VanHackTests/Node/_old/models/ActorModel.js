const Sequelize = require('sequelize');
const sequelize = require('../services/sqlite');
const moment = require('moment');

const ActorModel = sequelize.define('actors', {
  id: {
    type: Sequelize.INTEGER,
    primaryKey: true,
  },
  login: Sequelize.STRING,
  avatar_url: Sequelize.STRING
});

module.exports = ActorModel;
