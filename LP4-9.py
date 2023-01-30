import random
invalid = 0
comnum = random.randrange(1, 21)
playernum = int(input("Please Enter an Integer between 1 and 20: "))
if playernum < 0 or playernum > 20:
  print("Invalid Input! Please Enter a positive integer between 1 and 20!")
  invalid = 1
if invalid == 0:
  print("The Computer's Number is " + str(comnum))
  print("Your Number is " + str(playernum))
  if comnum == playernum:
    print("You Win!")
  else:
    print("You Lost! Better luck next time!")