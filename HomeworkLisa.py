password = str(input("Введите пароль: "))
difficulty = 0
symbols = ['@', '#', '%', '&']
char_now = ''

# проверка
sym_up = 0
sym_low = 0
have_num = 0
have_sym = 0

for i in range(len(password)):
    char_now = str(password[i])
    if (char_now.isupper()):
        sym_up = 1
    if (char_now.islower()):
        sym_low = 1
    if (char_now.isnumeric()):
        have_num = 1
    for sym in symbols:
        if (char_now in symbols):
            have_sym = 1
            
print("\n*** Проверка ***")
if (len(password) >= 5):
    print("Длина: :)")
    difficulty += 1
else:
    print("Длина: :(")
    
if (sym_up and sym_low):
    print("Регистры: :)")
    difficulty += 1
else:
    print("Регистры: :(")

if (have_num):
    print("Числа: :)")
    difficulty += 1
else:
    print("Числа: :(")

if (have_sym):
    print("Символы: :)")
    difficulty += 1
else:
    print("Символы: :(")


print("\nРезультат: сложность пароля составляет " + str(difficulty*25) + "%")
input()
