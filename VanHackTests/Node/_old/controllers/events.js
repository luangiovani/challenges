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

  const createEvent = async (event) => {
	const {
	  id, type, actor, repo, created_at,
	} = event;
	await EventModel.create({
	  id,
	  type,
	  created_at,
	  actorId: actor.id,
	  repoId: repo.id,
	});
  };
  
  const createActor = async (actor) => {
	const { id, login, avatar_url } = actor;
	await ActorModel.create({
	  id,
	  login,
	  avatar_url,
	});
  };
  
  const createRepo = async (repo) => {
	const { id, name, url } = repo;
	await RepoModel.create({
	  id,
	  name,
	  url,
	});
  };

  const addEvent = async (req, res, next) => {
	// basic same id check, if present return 400
	// else insert
	const {
	  id, actor, repo
	} = req.body;

	const [actorInDB, eventInDB, repoInDB] = await Promise.all([
	  ActorModel.findByPk(actor.id),
	  EventModel.findByPk(id),
	  RepoModel.findByPk(repo.id),
	]);
	if (eventInDB) {
	  return res.status(400).send({});
	}
	// check this event
	if (!actorInDB) {
		await createActor(actor);
	}
	if (!repoInDB) {
		await createRepo(repo);
	}
	await createEvent(req.body);

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
		})
	  ]);
	
	  return res.status(200).send({});
  };

module.exports = {
	getAllEvents: getAllEvents,
	addEvent: addEvent,
	getByActor: getByActor,
	eraseEvents: eraseEvents
};