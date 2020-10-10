# In my function makeBoard, it makes a board with each box being of size 1 character
# with no outer boarders as to follow the example
# So it prints exactly the number cols and rows that the user passes into the function
# since in the example so rows and columns are lost so it wont have the exact number of rows and cols
# the users asked. I decided to add asterisk to show the possible boxes in the board to place data
# to show the columns and rows in a better way.

def makeBoard(row, col):
    # We check the columns if it can fit the max which I will set to 84, since after that
    # the columns start to wrap, the rows can be as much as the user wants in theory
    maxNum = 85
    if col >= maxNum:
        return False
    # We print out infos to show that what is the size of the board that
    # will be printed
    print("Printing %sx%s board" % (row, col))
    print("Row = %s and Col = %s\n" % (row, col))
    # So we loop two times the row minus 1 to account for the rows that will
    # just be horizontal lines
    for r in range(2*row-1):
        if r % 2 == 0:
            # Here, we loop each column on each row and print asterisk with the glyph symbol
            for column in range(1, col+1):
                if column != col:
                    print("*|", end="")
                else:
                    print("*", end="\n")
        else:
            print("-" * (col * 2-1))
    # This ends the printing and then we return true for this function
    print("\nDone printing...Exiting")
    return True

if __name__ == "__main__":
    print(makeBoard(4, 4))



