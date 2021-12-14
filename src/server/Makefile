.PHONY: run-spi py run-server ctest load stop

SERVER=192.168.22.4

run: run-server

run-server:
	./run.sh

run-spi:
	sudo /home/eugeneai/cardio/src/server/cardio/bin/python3 spi.py

py:
	sudo /home/eugeneai/cardio/src/server/cardio/bin/python3

ctest:
	./conn-tests.sh

load:
	curl -X POST http://$(SERVER):5000/h3/forth/loader \
		-F "filename=_.fs" \
		-F "content=@../_.fs"

stop:
	curl -X POST http://$(SERVER):5000/h3/control -d '{"command":"stop"}'
