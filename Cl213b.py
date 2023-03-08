class Packages:
  def __init__(self, packages):
    self.packages = int(packages)
    self.ppi = 0
    self.total = 0

  def calc(self):
    if self.packages < 99:
      self.ppi = 5.95
    elif self.packages < 199:
      self.ppi = 5.75
    elif self.packages < 199:
      self.ppi = 5.40
    else:
      self.ppi = 5.15
    self.total = round(self.ppi * self.packages, 2)

  def __str__(self):
    return f"Quantity: {self.packages}\nPrice per Package: ${self.ppi}\nTotal Cost: ${self.total}\n---------------------------"