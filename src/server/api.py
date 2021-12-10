from flask import Flask, request
from flask_restful import Resource, Api
import spi
import serial
import time

TTY='/dev/ttyS1'
SER=None
DELAY=40


app = Flask(__name__)
api = Api(app)

todos = {}


class ForthH3(Resource):
    def post(self):
        json_data=request.get_json(force=True)
        cmd=json_data['command']
        cmd=cmd.rstrip('\n\r')
        cmd=cmd.rstrip('\r\n')
        cmd=cmd.rstrip('\n')
        cmd=cmd.rstrip('\r')
        cmd=cmd.encode('utf8')
        SER.write(cmd+b'\r')
        time.sleep(DELAY/1000)
        l=SER.readline().decode('utf8')
        a=l.rstrip('\n')
        error='NO ERROR'
        if a.endswith(' ok.'):
            rc='OK'
            a=a.rstrip(' ok.')
        elif (a.endswith(' not found.')):
            a=a.rstrip(' not found.')
            error='NOT FOUND'
            rc='KO'
        elif (a.endswith(' unhandled interrupt')):
            # Reset and reload h3
            a=a.rstrip(' unhandled interrupt')
            error='UNHANDLED INTERRUPT'
            c='KO'
        else:
            rc='KO'
            error='UNKNOWN'
        return {'line':l, 'answer':a, 'rc':rc, 'error':error}

class Screen(Resource):
    pass

class H3Connection(Resource):
    def post(self):
        json_data=request.get_json(force=True)
        typ=json_data['type']
        msg=json_data['message']
        print('Received', typ, msg)
        # spi.tranfer_test()
        return {'rc':'OK', 'error':0, 'answer':'SOMETHING FROM SPIDEV'}

class TodoSimple(Resource):
    def get(self, todo_id):
        return {todo_id: todos[todo_id]}

    def put(self, todo_id):
        todos[todo_id] = request.form['data']
        return {todo_id: todos[todo_id]}

api.add_resource(TodoSimple, '/todos/<string:todo_id>')
api.add_resource(H3Connection,  '/h3/spi')
api.add_resource(ForthH3,  '/h3/forth')

if __name__ == '__main__':
    spi.connect()
    SER = serial.Serial(TTY, 115200, timeout=1)
    app.run(debug=True, host="192.168.22.4")
    spi.disconnect()
    SER.close()
