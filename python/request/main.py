# import requests
# import pandas as pd
# from bs4 import BeautifulSoup
# from urllib import parse
# from datetime import datetime
# import time
# from urllib.request import urlopen
# from urllib.parse import quote_plus
#
# base_url = 'https://www.coupang.com/np/search?q={}&page={}'
# keyword = input("검색할 키워드 : ")
# headers = {
#     'User-Agent' : 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.114 Safari/537.36'
# }
# result_list = []
# url = base_url.format(keyword,1)
# print(url)
# res = requests.get(url, headers=headers)
# if res.status_code == 200:
#     soup = BeautifulSoup(res.text, "lxml")
#     print(soup)
#     last_page = soup.select_one('a.btn-last').text.strip()
#     print(last_page)
# error_cnt = 0
# cp_url = 'https://www.coupang.com/'
# for page in range(1, int(last_page)+1):
#     url = base_url.format(keyword, page)
#     res = requests.get(url, headers=headers)
#     if res.status_code == 200:
#         soup = BeautifulSoup(res.text, "lxml")
#         item_list = soup.select('ul#productList li')
#         for item in item_list:
#             try:
#                 item_name = item.select_one('div.name').text.strip()
#                 link = item.select_one('a').get('href')
#                 link = parse.urljoin(cp_url, link)
#                 price = item.select_one('strong.price-value').text.strip()
#                 price = ''.join(price.split(','))
#                 result_list.append([item_name, link, price])
#             except:
#                 error_cnt += 1
#
# curr = datetime.now().strftime('%Y-%m-%d')
# filename = '쿠팡조회결과_{}_{}.csv'.format(keyword,curr)
# df = pd.DataFrame(result_list, columns=['title','link','price'])
# df.to_csv(filename, index=False, encoding='UTF-8')
# print('fail to save :', error_cnt)
#
#
# # baseUrl = 'https://www.coupang.com/np/search?q={}&page={}'
# # plusUrl = input('검색어 입력: ')
# #
# # headers = {
# #     'User-Agent' : 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.114 Safari/537.36'
# # }
# # result_list = []
# # url = baseUrl.format(plusUrl, 1)
# # print(url)
# # res = requests.get(url, headers=headers)
# # # url = baseUrl + quote_plus(plusUrl)  # 한글 검색 자동 변환
# # # html = urlopen(url)
# # soup = BeautifulSoup(url, "html.parser")
# # img = soup.find_all(class_='search-product-wrap-img')
# #
# # n = 1
# # for i in img:
# #     print(n)
# #     imgUrl = i['data-source']
# #     with urlopen(imgUrl) as f:
# #         with open('./images/img' + str(n) + '.jpg', 'wb') as h:  # w - write b - binary
# #             img = f.read()
# #             h.write(img)
# #     n += 1
# #     if n > 200:
# #         break
# #
# # print('Image Crawling is done.')


import requests
import re
from bs4 import BeautifulSoup
from tkinter import *

# gui 구성
win = Tk()
win.geometry("300x300")
win.title("coupang")

ent = Entry(win)
ent.pack()

def keyword():
    a = ent.get()
    print(a)

btn = Button(win)
btn.config(width=10, height=5)
btn.config(text="검색")
btn.config(command=keyword)
btn.pack()
win.mainloop()


for i in range(1, 6):
    # print("페이지 :", i)
    # url = "https://www.coupang.com/np/search?q=%EB%85%B8%ED%8A%B8%EB%B6%81&channel=user&component=&eventCategory=SRP&trcid=&traid=&sorter=scoreDesc&minPrice=&maxPrice=&priceRange=&filterType=&listSize=36&filter=&isPriceRange=false&brand=&offerCondition=&rating=0&page={}&rocketAll=false&searchIndexingToken=1=4&backgroundColor=".format(
    #     i)
    base_url = 'https://www.coupang.com/np/search?q={}&page={}'

    keyword = input("검색한 키워드 : ")

    url = base_url.format(keyword, 1)
    headers = {
        "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.89 Safari/537.36"}
    res = requests.get(url, headers=headers)
    res.raise_for_status()
    soup = BeautifulSoup(res.text, "lxml")

    items = soup.find_all("li", attrs={"class": re.compile("^search-product")})

    for item in items:
        # 광고 제품은 제외
        ad_badge = item.find("span", attrs={"class": "ad-badge-text"})
        if ad_badge:
            # print("  <광고 상품 제외합니다>")
            continue

        name = item.find("div", attrs={"class": "name"}).get_text()  # 제품명
        # 애플 제품 제외
        if "Apple" in name:
            # print("  <Apple 상품 제외합니다>")
            continue

        price = item.find("strong", attrs={"class": "price-value"}).get_text()  # 가격

        # 리뷰 100개 이상, 평점 4.5 이상 되는 것만 조회
        rate = item.find("em", attrs={"class": "rating"})  # 평점
        if rate:
            rate = rate.get_text()
        else:
            # print("  <평점 없는 상품 제외합니다>")
            continue

        rate_cnt = item.find("span", attrs={"class": "rating-total-count"})  # 평점 수
        if rate_cnt:
            rate_cnt = rate_cnt.get_text()[1:-1]  # 예 : (26)
        else:
            # print("  <평점 수 없는 상품 제외합니다>")
            continue

        link = item.find("a", attrs={"class": "search-product-link"})["href"]

        if float(rate) >= 4.5 and int(rate_cnt) >= 100:
            # print(name, price, rate, rate_cnt)
            print(f"제품명 : {name}")
            print(f"가격 : {price}원")
            print(f"평점 : {rate}점 ({rate_cnt}개)")
            print("바로가기 : {}".format("https://www.coupang.com" + link))
            print("-" * 100)  # 줄긋기


