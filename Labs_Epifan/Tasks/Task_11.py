a = 0 # int переменная
b = 0 # int переменная
d = 0 # int переменная

print("Введите A: ")
a = int(input())
print("Введите B: ")
b = int(input())
print("Введите диаметр: ")
d = int(input())

if (a + 2 <= d  and b + 2 <= d):
    print("Вася в порядке")
else:
    print("Какой то неправильный Винни Пух")
