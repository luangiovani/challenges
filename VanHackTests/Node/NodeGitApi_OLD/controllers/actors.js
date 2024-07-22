const Sequelize = require('sequelize');
const ActorModel = require('../models/ActorModel');
const EventModel = require('../models/EventModel');
const moment = require('moment');
const _ = require('lodash');

const getAllActors = async (req, res) => {
	const actors = await ActorModel.findAll({
	  attributes: {
		include: [
		  'id',
		  'login',
		  'avatar_url',
		  [Sequelize.fn('COUNT', Sequelize.col('events.actorId')), 'eventCount'],
		  [Sequelize.fn('max', Sequelize.col('events.created_at')), 'latestEvent'],
		],
		exclude: ['createdAt', 'updatedAt'],
	  },
	  include: [{
		model: EventModel, attributes: [],
	  }],
	  group: ['events.actorId'],
	  order: [
		[Sequelize.literal('eventCount'), 'DESC'],
		[Sequelize.literal('latestEvent'), 'DESC'],
		['login'],
	  ],
	});
	const modifiedActors = actors.map(actor => ({
	  id: actor.id,
	  login: actor.login,
	  avatar_url: actor.avatar_url,
	}));
	return res.status(200).send(modifiedActors);
  };

  const updateActor = async (req, res) => {
	const { avatar_url, id, login } = req.body;
	const actorInDB = await ActorModel.findByPk(id);
	if (!actorInDB) {
	  return res.status(404).send({});
	}
	if (login !== actorInDB.login) {
	  return res.status(400).send({});
	}
	await ActorModel.update({
	  avatar_url,
	}, {
	  where: {
		id,
	  },
	});
	return res.status(200).send({});
  };

const getStreakInfo = (allEvents) => {
	const streakInfo = {};
	allEvents.forEach((event) => {
	  const { actorId, created_at } = event;
	  if (streakInfo[actorId]) {
		//
		const actorStreak = streakInfo[actorId];
		const lastEvent = moment(actorStreak.lastEvent, 'YYYY-MM-DD');
		const currentEvent = moment(created_at, 'YYYY-MM-DD');
		const daysDifference = lastEvent.diff(currentEvent, 'days');
		if (daysDifference === 1) {
		  // increment streak
		  actorStreak.currentStreak += 1;
		  if (actorStreak.currentStreak > actorStreak.highestStreak) {
			actorStreak.highestStreak = actorStreak.currentStreak;
			// actorStreak.hightestStreak += 1; // thoughts?
		  } else {
			// do nothing
		  }
		} else if (daysDifference > 1) {
		  // reset streak
		  actorStreak.currentStreak = 0;
		} else {
		  // do nothing
		}
		actorStreak.lastEvent = created_at;
	  } else {
		streakInfo[actorId] = {
		  currentStreak: 0,
		  highestStreak: 0,
		  lastEvent: created_at,
		  latestEvent: moment(created_at).valueOf(),
		  login: event.actor.login,
		};
	  }
	});
	return streakInfo;
  };
  
  const getStreakInfoArray = streakInfo => Object.keys(streakInfo).map(actorId => ({
	actorId,
	highestStreak: streakInfo[actorId].highestStreak,
	latestEvent: streakInfo[actorId].latestEvent,
	login: streakInfo[actorId].login,
  }));
  
  const getActorsIdByStreak = sortedStreakInfo => sortedStreakInfo.map(info => Number(info.actorId));
  
  const getStreak = async (req, res) => {
	const allEvents = await EventModel.findAll({
	  include: [ActorModel],
	  order: [
		['actorId'],
		['created_at', 'DESC'],
	  ],
	});
	const streakInfo = getStreakInfo(allEvents);
	const streakInfoArray = getStreakInfoArray(streakInfo);
	const sortedStreakInfo = _.orderBy(
	  streakInfoArray,
	  ['highestStreak', 'latestEvent', 'login'],
	  ['desc', 'desc', 'asc'],
	);
	const actorsIdByStreak = getActorsIdByStreak(sortedStreakInfo);
	const actorsInOrder = await Promise.all(actorsIdByStreak.map(actorId => ActorModel.findOne({
	  where: {
		id: actorId,
	  },
	  attributes: {
		include: ['id', 'login', 'avatar_url'],
		exclude: ['createdAt', 'updatedAt'],
	  },
	})));
	return res.status(200).send(actorsInOrder);
  };


module.exports = {
	updateActor: updateActor,
	getAllActors: getAllActors,
	getStreak: getStreak
};