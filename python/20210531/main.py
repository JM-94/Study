from flask import Flask, render_template, request
import cv2
# opencv-python
# numpy
# flask

app = Flask(__name__)

@app.route("/")
def home():
    return render_template("index.html")

'''
    templates 폴더에다가 html파일들을넣고
    static 폴더에다가 image파일이나 js,css등을 넣으면되요
'''
@app.route("/upload", methods=['POST'])
def upload():
    image = request.files['file']
    image.save(f"static/{image.filename}")
    print(image.filename)

    npimage = cv2.imread(f"static/{image.filename}")
    # npimage[0:100,0:100] = [0,0,0]
    roi = npimage[30:210,180:360]
    npimage[0:180,0:180] = roi
    npimage[:,:,2] = 0

    npimagename = f"static/np{image.filename}"
    cv2.imwrite(npimagename,npimage) #numpy 배열에 이미지화저장

    return render_template("print.html"\
       ,image=image.filename,npimage=npimagename)

app.run(host="127.0.0.1", port=5000);
