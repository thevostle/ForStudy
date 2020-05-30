def f (x, y):
    result = x
    for i in range(1, y+1):
        result = result * x * 2 + i - 1
    
    return result

def main():
    x = int(input("Введите X: "))
    y = int(input("Введите Y: "))
    print(f(x, y))
    input()

if __name__ == '__main__':
    main()
