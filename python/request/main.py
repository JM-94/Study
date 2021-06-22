import requests

headers = {'User-Agent' : 'Mozilla/5.0 (Macintosh; Intel Mac OS X 11_0_1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/89.0.4389.82 Safari/537.36'}

def getPageString(url):
    data = requests.get(url, headers = headers)
    print(data.content)
    return data.content
from libs.coupang.stringgetter import getPageString

url = "https://www.coupang.com/np/categories/465075"

print(getPageString(url))

from libs.coupang.stringgetter import getPageString

from bs4 import BeautifulSoup

def getProducts(string):
    bsObj = BeautifulSoup(string, "html.parser")
    ul = bsObj.find("ul", {"id":"productList"})  #아이템 리스트부분 추출
    lis = ul.findAll("li", {"class":"baby-product renew-badge"}) #각 아이템 추출

    for item in lis:
        #url
        a = item.find("a", {"class": "baby-product-link"})
        url = a.get('href')
        print("url:", url)

        #name
        div_name = item.find("div", {"class":"name"})
        name = div_name.getText()
        print("name:", name)

        #image
        dt_image = item.find("dt", {"class":"image"})
        image = dt_image.find("img").get('src')
        print("image:", image)

        #price
        price = item.find("strong", {"class":"price-value"}).getText()
        print("price:", price)

    print(len(lis))
    return []

url = "https://www.coupang.com/np/categories/465075"

pageString = getPageString(url)
print(getProducts(pageString))