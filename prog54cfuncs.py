pi = 3.14159
def calcCircum(radius):
  return radius * 2 * pi

def calcArea(radius):
  return pi * radius**2

def circumArea(radius):
  circum = round(calcCircum(radius), 3)
  area = round(calcArea(radius), 3)
  return circum, area

def main():
  radius = int(input("Enter radius: "))
  c, a = circumArea(radius)
  print(f"Area: {a}\nCircumference: {c}")

if __name__ == "__main__":
  main()