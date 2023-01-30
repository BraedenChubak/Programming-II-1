eggs = int(input("Enter the number of eggs: "))
invalid = 0
ppd = 0.0
if eggs > 0 and eggs < 48:
  ppd = 0.5
elif eggs >= 48 and eggs < 72:
  ppd = 0.45
elif eggs >= 72 and eggs < 132:
  ppd = 0.4
elif eggs > 132:
  ppd = 0.35
else:
  print("Invalid Input, Only positive integers allowed.")
  invalid = 1
totalcost = eggs * ppd / 12
ppe = ppd / 12
if invalid == 0:
  print("The cost of your eggs is: $" + str(totalcost))