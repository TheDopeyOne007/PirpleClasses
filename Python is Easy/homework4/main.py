myUniqueList = []
leftOvers = []

def addToMyUniqueList(value):
    if value not in myUniqueList:
        myUniqueList.append(value)
        return True
    leftOvers.append(value)
    return False


print(addToMyUniqueList(45))
print(addToMyUniqueList(45))
print(addToMyUniqueList(33))
print(addToMyUniqueList(45))
print(addToMyUniqueList(99))
print(addToMyUniqueList(99))
print(addToMyUniqueList(99))
print(addToMyUniqueList(99))

print(myUniqueList)
print(leftOvers)

