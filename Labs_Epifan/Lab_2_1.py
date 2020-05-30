def f (x, y):
    if (y == 0):
        return x
    else:
        return 2 * x * f(x, y-1) + y - 1

def main():
    print(f(1, 5))
    input()

if __name__ == '__main__':
    main()
