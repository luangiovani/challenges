const Sequelize = require('sequelize');
const sequelize = require('../services/sqlite');

const ActorModel = sequelize.define('actor', {
  id: {
    type: Sequelize.INTEGER,
    primaryKey: true,
  },
  login: Sequelize.STRING,
  avatar_url: Sequelize.STRING,
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
  }
});

module.exports = ActorModel;
