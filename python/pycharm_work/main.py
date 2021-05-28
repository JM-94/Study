# from csvrw import doRead, doWrite
# from mysqlrw import selectMember, insertMember
# from daegudb import read_csv_write_mysql
from flask import Flask ,render_template

app = Flask(__name__)

@app.route("/")
def index():
    return "잘되나.."

@app.route("/aa")
def aa():
    test = "<h1>ㅠㅠ</h1>"
    return render_template("index.html",te=test)


if __name__ == '__main__':
    app.run(host="127.0.0.1",debug=True)
    # read_csv_write_mysql()
    # doWrite()
    # doRead()
    # insertMember()
    # selectMember()

# ctrl+ alt + shift + l 자동정렬