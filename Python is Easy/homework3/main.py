from os import truncate


def checkEquality(a, b, c):
    a = int(a)
    b = int(b)
    c = int(c)
    equals = 0
    if a == b or b == c or c == a:
        return True
    return False


print(checkEquality("1", 1, 8))