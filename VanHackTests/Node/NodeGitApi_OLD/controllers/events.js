const EventModel = require('../models/EventModel');
const ActorModel = require('../models/ActorModel');
const RepoModel = require('../models/RepoModel');

const getAllEvents = async (req, res) => {
	const events = await EventModel.findAll({
	  attributes: {
		exclude: ['createdAt', 'updatedAt', 'actorId', 'repoId'],
	  },
	  include: [
		{
		  model: ActorModel,
		  attributes: ['id', 'login', 'avatar_url'],
		},
		{
		  model: RepoModel,
		  attributes: ['id', 'name', 'url'],
		},
	  ],
	  order: [['id']],
	});
	return res.status(200).send(events);
  };

  const addEvent = async (req, res, next) => {
	// basic same id check, if present return 400
	// else insert
	const {
	  id, type, actor, repo, created_at,
	} = req.body;
	const [actorInDB, eventInDB, repoInDB] = await Promise.all([
	  ActorModel.findByPk(actor.id),
	  EventModel.findByPk(id),
	  RepoModel.findByPk(repo.id),
	]);
	if (eventInDB) {
	  return res.status(400).send({});
	}
	if (!actorInDB) {
		await ActorModel.create({
			id: actor.id,
			login: actor.login,
			avatar_url: actor.avatar_url,
			created_at: actor.created_at
		});
	}	

	if (!repoInDB) {
		await RepoModel.create({
			id: repo.id,
			name: repo.name,
			url: repo.url,
			created_at: repo.created_at
		});
	}

	await EventModel.create({
		id,
		type,
		created_at,
		actorId: actor.id,
		repoId: repo.id,
	  });

	return res.status(201).send({});
  };


  const getByActor = async (req, res) => {
	// 404 if actor does not exist
	// return all the events
	const { id } = req.params;
	const events = await EventModel.findAll({
	  where: {
		actorId: id,
	  },
	  attributes: {
		exclude: ['createdAt', 'updatedAt', 'actorId', 'repoId'],
	  },
	  include: [
		{
		  model: ActorModel,
		  attributes: ['id', 'login', 'avatar_url'],
		},
		{
		  model: RepoModel,
		  attributes: ['id', 'name', 'url'],
		},
	  ],
	  order: [['id']],
	});
	return res.status(200).send(events);
  };

const eraseEvents = async (req, res) => {
	await Promise.all([
	  EventModel.destroy({
		where: {},
		truncate: true,
	  }),
	  ActorModel.destroy({
		where: {},
		truncate: true,
	  }),
	  RepoModel.destroy({
		where: {},
		truncate: true,
	  }),
	]);
  
	return res.status(200).send({});
  };

module.exports = {
	getAllEvents: getAllEvents,
	addEvent: addEvent,
	getByActor: getByActor,
	eraseEvents: eraseEvents
};