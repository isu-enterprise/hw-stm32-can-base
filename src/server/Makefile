.PHONY: run-spi py run-server ctest load stop loadh3 forgetram
.PHONY: load-all run-lis

# SERVER=192.168.22.4
SERVER=192.168.0.114
F=curl http://$(SERVER):5000/h3/forth

run: run-server

run-server:
	./run.sh

run-spi:
	sudo /home/eugeneai/cardio/src/server/cardio/bin/python3 spi.py

run-lis:
	sudo /home/eugeneai/cardio/src/server/cardio/bin/python3 lis.py

py:
	sudo /home/eugeneai/cardio/src/server/cardio/bin/python3

ctest:
	./conn-tests.sh

init-all: forgetram load loadh3 tft-init h3-init

load:
	curl -X POST http://$(SERVER):5000/h3/forth/loader \
		-F "filename=_.fs" \
		-F "content=@../_.fs"

loadh3:
	curl -X POST http://$(SERVER):5000/h3/forth/loader \
		-F "filename=30-h3.fs" \
		-F "content=@../30-h3.fs"

stop:
	curl -X POST http://$(SERVER):5000/h3/control -d '{"command":"stop"}'


tft-init:
	$(F) -d '{"command":"tft-init "}' -X POST

h3-init:
	$(F) -d '{"command":"init-h3 "}' -X POST

tft-clear: tft-init
	$(F) -d '{"command":"tft-clear "}' -X POST

forgetram:
	$(F) -d '{"command":"forgetram "}' -X POST

reset:
	$(F) -d '{"command":"reset "}' -X POST
