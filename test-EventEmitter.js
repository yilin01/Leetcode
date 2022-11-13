const EventEmitter = require('events')

const myEmitter = new EventEmitter();

myEmitter.on('event',()=> {console.log('hey')});

myEmitter.emit('event');