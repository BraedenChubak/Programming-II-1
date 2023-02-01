num1 = int(input("Enter a number: "))
num2 = int(input("Enter a second number: "))
while num2 > 0:
  temp = num1 % num2
  num1 = num2
  num2 = temp
print("The GCD of your numbers is: " + str(num1))