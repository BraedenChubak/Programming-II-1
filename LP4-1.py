copies = int(input("Enter the number of copies: "))
ppc = 0
invalid = 0
if copies > 0 and copies <= 99:
  ppc = 0.3
elif copies > 99 and copies <= 499:
  ppc = 0.28
elif copies > 499 and copies <= 749:
  ppc = 0.27
elif copies > 749 and copies <= 1000:
  ppc = 0.26
elif copies > 1000:
  ppc = 0.25
else:
  print("Invalid Input, Only positive integers allowed.")
  invalid = 1
if invalid == 0:
  totalcost = ppc * copies
  print("The price per copy is: $" + str(ppc))
  print("The total cost is: $" + str(totalcost))