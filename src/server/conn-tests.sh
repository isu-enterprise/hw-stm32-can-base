#/bin/bash

server=192.168.22.4

set -x

# curl http://$server:5000/todos/todo1 -d "data=Remember the milk" -X PUT
# curl http://$server:5000/todos/todo1
# curl http://$server:5000/todos/todo2 -d "data=Change my brakepads" -X PUT
# curl http://$server:5000/todos/todo2

# curl http://$server:5000/h3/spi -d '{"type":"string", "message":"HELLO, WORLD!"}' -X POST

curl http://$server:5000/h3/forth -d '{"command":": space 32 emit ;"}' -X POST
curl http://$server:5000/h3/forth -d '{"command":": space 32 emit1q ;"}' -X POST
curl http://$server:5000/h3/forth -d '{"command":"4 5 + ."}' -X POST
curl http://$server:5000/h3/forth -d '{"command":"t-i"}' -X POST
curl http://$server:5000/h3/forth -d '{"command":"tft-clear"}' -X POST

# It is in make
# curl -X POST http://$server:5000/h3/forth/loader \
#  -F "filename=_.fs" \
#  -F "content=@../_.fs"
