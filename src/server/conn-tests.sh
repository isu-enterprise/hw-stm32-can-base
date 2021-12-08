#/bin/bash

server=192.168.22.4

set -x

curl http://$server:5000/todos/todo1 -d "data=Remember the milk" -X PUT
curl http://$server:5000/todos/todo1
curl http://$server:5000/todos/todo2 -d "data=Change my brakepads" -X PUT
curl http://$server:5000/todos/todo2
