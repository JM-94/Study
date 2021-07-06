import json 
	
options = json.load(open('info.json', 'rb'), encoding='CP949')
theaters = options['서울']['theaters']
print(theaters.keys())
