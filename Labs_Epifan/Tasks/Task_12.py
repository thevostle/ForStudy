# код специально написан в стиле других языков


arrayLen = 0
arraySum = 0


print("Введите длину массива: ")
arrayLen = int(input())
array = []      # array = [arrayLen]

# наполнение массива числами
for i in range(0, arrayLen):    # в Си это выглядит как for(int i = 0; i < arrayLen; i++) {...}
    num = 0

    print("Введите новый элемент массива: ")
    num = int(input())


    # В паскале это выглядит как array[i] = num, но тут так просто не получится
    array.append(num)

for i in range(0, arrayLen):
    if (array[i] <= 100):
        arraySum = arraySum + array[i]

for i in range(0, arrayLen):
    if (i % 2 == 0): # каждый нечетный элемент
        array[i] = arraySum


print("Сумма элементов меньше 100: ")
print(arraySum)

print("Результат: ")
for i in range(0, arrayLen):
    print(array[i])
