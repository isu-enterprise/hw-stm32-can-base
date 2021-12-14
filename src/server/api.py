from flask import Flask, request
from flask_restful import Resource, Api
from werkzeug.datastructures import ImmutableMultiDict
import spi
import serial
import time
import os, signal

TTY='/dev/ttyS1'
SER=None
DELAY=40
SER_TIMEOUT=20 # Seconds

app = Flask(__name__)
api = Api(app)

todos = {}


class ForthResource(Resource):
    def send(self, cmd):
        if type(cmd)==str:
            cmd=cmd.encode('utf8')
        cmd=cmd.rstrip(b'\n\r')
        cmd=cmd.rstrip(b'\r\n')
        cmd=cmd.rstrip(b'\n')
        cmd=cmd.rstrip(b'\r')
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
        

class ForthH3(ForthResource):
    def post(self):
        json_data=request.get_json(force=True)
        cmd=json_data['command']
        return self.send(cmd)
        

class H3Connection(Resource):
    def post(self):
        json_data=request.get_json(force=True)
        typ=json_data['type']
        msg=json_data['message']
        print('Received', typ, msg)
        # spi.tranfer_test()
        return {'rc':'OK', 'error':0, 'answer':'SOMETHING FROM SPIDEV'}

class ForthResource(Resource):
    def send(self, cmd):
        if type(cmd)==str:
            cmd=cmd.encode('utf8')
        cmd=cmd.rstrip(b'\n\r')
        cmd=cmd.rstrip(b'\r\n')
        cmd=cmd.rstrip(b'\n')
        cmd=cmd.rstrip(b'\r')
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
        

class ForthH3(ForthResource):
    def post(self):
        json_data=request.get_json(force=True)
        cmd=json_data['command']
        return self.send(cmd)

class ForthFileLoader(ForthResource):
    def post(self):
        content=request.files['content']
        name=request.form['filename']
        print('loading', name)
        print('here')
        list=[]
        rc='OK'
        ln=1
        fln=''
        qqq
        for l in content:
            l=l.rstrip(b'\n')
            print(ln,':', l.decode('utf-8'))
            rcl=self.send(l)
            list.append(rcl)
            if rcl['rc']=='KO':
                rc='KO'
                fln=ln
                break
            # time.sleep(40/1000)
            ln+=1
        error='NO ERROR'
        return {'rc':rc, 'list':list, 'error':error, 'l':fln}
    
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


class H3Control(Resource):
    def post(self):
        json_data=request.get_json(force=True)
        cmd = json_data['command']
        if cmd=='stop':
            os.kill(os.getpid(), signal.SIGINT)
        return {'rc:':'OK', 'command':cmd, 'message':'Server is shutting down!'}

    
class TodoSimple(Resource):
    def get(self, todo_id):
        return {todo_id: todos[todo_id]}

    def put(self, todo_id):
        todos[todo_id] = request.form['data']
        return {todo_id: todos[todo_id]}

api.add_resource(TodoSimple, '/todos/<string:todo_id>')
api.add_resource(H3Control,  '/h3/control')
api.add_resource(H3Connection,  '/h3/spi')
api.add_resource(ForthFileLoader,  '/h3/forth/loader')
api.add_resource(ForthH3,  '/h3/forth')

if __name__ == '__main__':
    spi.connect()
    SER = serial.Serial(TTY, 115200, timeout=SER_TIMEOUT)
    app.run(debug=True, host="192.168.22.4")
    spi.disconnect()
    SER.close()
