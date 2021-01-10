def getMinL(m):
    l = 0
    while 2**m > (2**l)/(l+1):
        l += 1
    return l

def isPow2(num): # true, если число - степень двойки
    return num & (num - 1) == 0

# строгая дизъюнкция
def disjunction(nums):
    result = 0
    if nums[0] != nums[1]:
        result = 1
    for i in range(2, len(nums)):
        if result == nums[i]:
            result = 0
        else:
            result = 1
    return result

def getPs(num):
    Ps_count = getMinL(len(num))-len(num)
    Ps = []
    for i in range(Ps_count):
        Bs = []
        for x in range(3,getMinL(len(num))+1):
            if len(bin(x))-2 > i:
                if bin(x)[len(bin(x))-1-i] == '1' and not isPow2(x):
                    Bs.append(x)
        dis = []
        for i in Bs:
            dis.append(num_with_p[i-1])
        Ps.append(disjunction(dis))
    return Ps
    
if __name__ == '__main__':
    num = input("Введите число: ")
    m = len(num)
    n = getMinL(m)
    k = n - m
    p = [None] * k
    numResult = [None] * n

    # помечаем координаты p в будующем ответе
    idx = 0 # сколько чисел из num добавили
    for i in range(1,n+1):
        if isPow2(i):
            numResult[i-1] = 'p'
        else:
            numResult[i-1] = int(num[idx])
            idx += 1
    global num_with_p
    num_with_p = numResult.copy()
    num_with_p_str = ''
    for i in num_with_p:
        num_with_p_str += str(i)

    # вывод решения
    print("\nРешение:")
    print('M = '+ str(m))
    print('N = '+ str(n))
    print('K = '+ str(k) + '\n')
    for i in range(n):
        print('b' + str(i+1), end='')
    print(' = ' + num_with_p_str)

    print('P: ', end='')
    print(getPs(num))

    idx = 0
    print('Result: ', end='')
    for i in numResult:
        if i != 'p':
            print(i, end='')
        else:
            print(getPs(num)[idx],end='')
            idx += 1

    input()
