const Sequelize = require('sequelize');
const moment = require('moment');
const sequelize = require('../services/sqlite');
const ActorModel = require('./ActorModel');
const RepoModel = require('./RepoModel');

const EventModel = sequelize.define('event', {
  id: {
    type: Sequelize.INTEGER,
    primaryKey: true,
  },
  type: Sequelize.STRING,
  created_at: {
    type: Sequelize.DATE,
    get() {
      const date = this.getDataValue('created_at');
      return moment(date).format('YYYY-MM-DD HH:mm:ss');
    },
  },
  updated_at: {
    type: Sequelize.DATE,
    get() {
      const date = this.getDataValue('created_at');
      return moment(date).format('YYYY-MM-DD HH:mm:ss');
    },
  },
});

EventModel.belongsTo(ActorModel);
EventModel.belongsTo(RepoModel);
// For the Actor, avoid circular dependency
ActorModel.hasMany(EventModel);

module.exports = EventModel;
