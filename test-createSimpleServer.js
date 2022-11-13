const http = require('http');

http.createServer((req,res)=> {
  res.writeHead(200, {'Context-Type': 'application/json'})
  res.end('Helle world');
}).listen(3456, ()=> {
  console.log('Connect to 3456');
})