from flask import Flask, render_template
import sqlite3
from werkzeug.exceptions import abort

app = Flask(__name__)


def getDbConnection():
    conn = sqlite3.connect('templates/database.db')
    conn.row_factory = sqlite3.Row
    return conn


@app.route('/')
def index():
    conn = getDbConnection()
    posts = conn.execute('SELECT * FROM posts').fetchall()
    conn.close()
    return render_template('index.html', posts=posts)


if __name__ == '__main__':
    app.run()
