const Sequelize = require('sequelize');

const sequelize = new Sequelize({
  dialect: 'sqlite',
  storage: ':memory:'
});

sequelize
  .authenticate()
  .then(() => {
    console.info('Database connection established');
  })
  .catch((err) => {
    console.error('Unable to connect to database', err);
  });

sequelize.sync()
  .then(() => {
    console.info('Tables created successfully.');
  })
  .catch((err) => {
    console.info('Error', err);
  });
module.exports = sequelize;
