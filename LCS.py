# наибольшая общая подпоследовательность

def LCS(x, y):
    if len(x) == 0 or len(y) == 0:
        return []
    if x[-1] == y[-1]:
        return LCS(x[:-1], y[:-1]) + [x[-1]]
    else:
        left = LCS(x[:-1], y)
        right = LCS(x, y[:-1])
        return left if len(left) > len(right) else right

X = "AGGTHHHGGJPG"
Y = "FGGJJJ"

for i in LCS(X, Y):
    print(i, end="")
