from flask import Flask,render_template,request
import cv2
import numpy as np

app = Flask(__name__)

@app.route("/")
def home():
    return render_template("index.html")

@app.route("/upload",methods=["POST","GET"])
def upload():
    file = request.files['file']
    filename = f"static/{file.filename}"
    file.save(filename)
    return render_template("print.html",oimg = filename)

@app.route("/addimg",methods=["POST","GET"])
def addimg():
    file1 = request.files['file1']
    file2 = request.files['file2']
    np1file = f"static/{file1.filename}"
    np2file = f"static/{file2.filename}"
    file1.save(np1file)
    file2.save(np2file)

    cvfile1 = cv2.imread(np1file)
    cvfile2 = cv2.imread(np2file)

    cvfile3 = cv2.add(cvfile1,cvfile2)
    cvfile3name = f"static/cvadd.jpg"
    cv2.imwrite(cvfile3name,cvfile3)

    npfile = np.add(cvfile1, cvfile2)
    npfile3name = f"static/npadd.jpg"
    cv2.imwrite(npfile3name, npfile)
    return render_template("print1.html",cvfile3name=cvfile3name,npfile3name=npfile3name)

app.run(host="127.0.0.1",port="5001")