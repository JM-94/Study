from flask import Flask, render_template, request   # 웹 라이브러리
from perch import makeperch

app = Flask(__name__)


@app.route("/")
def home():
 length = request.args.get("length")
 if length is None:
  length = 50
 perch,weight = makeperch(int(length))
 return render_template('3.3.html', perch=perch, weight=weight)


app.run(host="127.0.0.1", port=5000, debug=True)














