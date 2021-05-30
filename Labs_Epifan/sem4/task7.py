import os
from tabulate import tabulate

def matrix(Travel):
    table=[(i+1, Travel[i].name, Travel[i].place, Travel[i].price, Travel[i].time) for i in range(len(Travel))]
    headers = ['№', 'ФИО', 'Место', 'Стоимость', 'Продолжительность отдыха']
    print(tabulate(table, headers, tablefmt = 'pipe'))
    print('\n')
    return (tabulate(table, headers, tablefmt = 'pipe'))

def matrixNew(Travel):
    table=[(i+1, Travel[i].name, Travel[i].place, Travel[i].price, Travel[i].time) for i in range(len(Travel))]
    headers = ['№', 'ФИО', 'Место', 'Стоимость', 'Продолжительность отдыха']
    print(tabulate(table, headers, tablefmt = 'pipe'))
    return (tabulate(table, headers, tablefmt = 'pipe'))

def insertionSort(data):
	for i in range(len(data)):
		j = i - 1 
		key = data[i]
		while data[j].price > key.price and j >= 0:
			data[j + 1] = data[j]
			j -= 1
		data[j + 1] = key
	return data

class Travel():
    def __init__(self, name, place, price, time):
        self.name = name
        self.place = place
        self.price = float(price)
        self.time = time

travels = []
placelist = []

n = 1
while input('Добавить путевку? \n (д/н) ') == 'д':
    print('\tПутевка №', n, ':')
    name = input('Ф.И.О.: ')
    place = input('Место: ')
    price = input('Стоимость: ')
    time = input('Продолжительность отдыха: ')
    travels.append(Travel(name, place, price, time))
    n += 1

g = open('travels.txt', 'w')
g.write("Список путевок\n")
g.write(str(matrix(travels)))
n = input('Введите место: ')
for i, el in enumerate(travels):
    if travels[i].place == n:
        placelist.append(travels[i])

insertionSort(placelist)
g.write("\n\nСписок путевок отсортированных по стоимости\n")
g.write(str(matrixNew(placelist)))
g.close()
