import math

number = 100

for i in range(1, number+1):
    isPrime = True
    str_prime = "Prime"
    result = ""
    if i % 3 == 0:
        result += "Fizz"
    if i % 5 == 0:
        result += "Buzz"
    newNum = int(math.floor(math.sqrt(i)))
    for j in range(2, newNum+1):
        if i % j == 0:
            isPrime = False
            break
    if i == 1:
        isPrime = False
    if isPrime:
        result = result.ljust(10) + str_prime
    print("%s %s" % (str(i).ljust(4), result))

