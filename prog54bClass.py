class Circle:
  def __init__(self, num1, num2, num3, num4):
    self.num1 = num1
    self.num2 = num2
    self.num3 = num3
    self.num4 = num4
    self.sum = 0
    self.avg = 0

  def calculate(self):
    self.sum = self.num1 + self.num2 + self.num3 + self.num4
    self.avg = (self.num1 + self.num2 + self.num3 + self.num4) / 4

  def getSum(self):
    return self.sum

  def getAvg(self):
    return self.avg

def main():
  num1 = int(input("Enter Number 1: "))
  num2 = int(input("Enter Number 2: "))
  num3 = int(input("Enter Number 3: "))
  num4 = int(input("Enter Number 4: "))
  circle = Circle(num1, num2, num3, num4)
  circle.calculate()
  print("The sum is:", circle.getSum())
  print("The average is:", circle.getAvg())

if __name__ == "__main__":
  main()