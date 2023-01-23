# Take in the radius, then print the radius, area, and circumference of a circle
pi = 3.14159

radius = float(input("Enter the Radius: "))

circum = 2 * pi * radius
area = pi * radius ** 2

print("The Radius is: " + str(radius))
print("The Area is: " + str(area))
print("The Circumferece is: " + str(circum))