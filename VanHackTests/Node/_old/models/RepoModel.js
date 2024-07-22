const Sequelize = require('sequelize');
const sequelize = require('../services/sqlite');
const moment = require('moment');

const RepoModel = sequelize.define('repos', {
  id: {
    type: Sequelize.INTEGER,
    primaryKey: true,
  },
  name: Sequelize.STRING,
  url: Sequelize.STRING
});

module.exports = RepoModel;
