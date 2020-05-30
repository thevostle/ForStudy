def f (x, y):
    if (y == 0):
        return x
    else:
        return 2 * x * f(x, y-1) + y - 1

def main():
    x = int(input("Введите X: "))
    y = int(input("Введите Y: "))
    print(f(x, y))
    input()

if __name__ == '__main__':
    main()
