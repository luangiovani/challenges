const Sequelize = require('sequelize');
const sequelize = require('../services/sqlite');

const RepoModel = sequelize.define('repo', {
  id: {
    type: Sequelize.INTEGER,
    primaryKey: true,
  },
  name: Sequelize.STRING,
  url: Sequelize.STRING,
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

module.exports = RepoModel;
