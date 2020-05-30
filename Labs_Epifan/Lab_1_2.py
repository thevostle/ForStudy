import math

def func (x):
    return x - 2 * (math.e ** x)
def proizv (x):
    return 1 - 2 * (math.e ** x)

def main():
    i = -5
    while i <= 5:
        print('\n' + str(i))
        print(func(i))
        print(proizv(i))
        i += 0.5
    input()

if __name__ == '__main__':
    main()
