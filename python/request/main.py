import requests
import pandas as pd
from bs4 import BeautifulSoup
from urllib import parse
from datetime import datetime
import time
from urllib.request import urlopen
from urllib.parse import quote_plus

base_url = 'https://www.coupang.com/np/search?q={}&page={}'
keyword = input("검색할 키워드 : ")
headers = {
    'User-Agent' : 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.106 Safari/537.36'
}
result_list = []
url = base_url.format(keyword,1)
print(url)
res = requests.get(url, headers=headers)
if res.status_code == 200:
    soup = BeautifulSoup(res.text, "lxml")
    print(soup)
    last_page = soup.select_one('a.btn-last').text.strip()
    print(last_page)
error_cnt = 0
cp_url = 'https://www.coupang.com/'
for page in range(1, int(last_page)+1):
    url = base_url.format(keyword, page)
    res = requests.get(url, headers=headers)
    if res.status_code == 200:
        soup = BeautifulSoup(res.text, "lxml")
        item_list = soup.select('ul#productList li')
        for item in item_list:
            try:
                item_name = item.select_one('div.name').text.strip()
                link = item.select_one('a').get('href')
                link = parse.urljoin(cp_url, link)
                price = item.select_one('strong.price-value').text.strip()
                price = ''.join(price.split(','))
                result_list.append([item_name, link, price])
            except:
                error_cnt += 1

curr = datetime.now().strftime('%Y-%m-%d')
filename = '쿠팡조회결과_{}_{}.csv'.format(keyword,curr)
df = pd.DataFrame(result_list, columns=['title','link','price'])
df.to_csv(filename, index=False, encoding='UTF8')
print('fail to save :', error_cnt)

# baseUrl = 'https://www.coupang.com/np/search?q={}&page={}'
# plusUrl = input('검색어 입력: ')
# crawl_num = int(input('크롤링할 갯수 입력(최대 50개): '))
#
# url = baseUrl + quote_plus(plusUrl)  # 한글 검색 자동 변환
# html = urlopen(url)
# soup = bs(html, "html.parser")
# img = soup.find_all(class_='_img')
#
# n = 1
# for i in img:
#     print(n)
#     imgUrl = i['data-source']
#     with urlopen(imgUrl) as f:
#         with open('./images/img' + str(n) + '.jpg', 'wb') as h:  # w - write b - binary
#             img = f.read()
#             h.write(img)
#     n += 1
#     if n > crawl_num:
#         break

# print('Image Crawling is done.')
