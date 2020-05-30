import math

def print_data(x):
    print('\n' + str(x))
    print(x - 2 * (math.e ** x))
    print(1 - 2 * (math.e ** x))

def main ():
    i = -5
    while i <= 5:
        print_data(i)
        i += 0.5
    input()

if __name__ == '__main__':
    main()
