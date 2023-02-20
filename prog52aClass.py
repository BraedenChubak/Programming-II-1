class Shape:
  # Constructor: sets up class data
  def __init__(self, length, width):
    self.length = length
    self.width = width
    self.area = 0
    self.perim = 0

  # Mutator: modifies class data
  def calculate(self):
    self.area = self.length * self.width
    self.perim = 2 * self.length + 2 * self.width

  # Accessors/Getters: returns class data
  def getArea(self):
    return self.area

  def getPerim(self):
    return self.perim


def main():
  len = int(input("Enter Length: "))
  wid = int(input("Enter Width: "))
  shape = Shape(len, wid) # Call "Shape" instructor
  shape.calculate()
  print("Area:", shape.getArea())
  print("Perimeter:", shape.getPerim())

if __name__ == "__main__":
  main()