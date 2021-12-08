from flask import Flask, request
from flask_restful import Resource, Api
import spi

app = Flask(__name__)
api = Api(app)

todos = {}

# class Screen



class TodoSimple(Resource):
    def get(self, todo_id):
        return {todo_id: todos[todo_id]}

    def put(self, todo_id):
        todos[todo_id] = request.form['data']
        return {todo_id: todos[todo_id]}

api.add_resource(TodoSimple, '/todos/<string:todo_id>')

if __name__ == '__main__':
    spi.connect()
    app.run(debug=True)
    spi.disconnect()

