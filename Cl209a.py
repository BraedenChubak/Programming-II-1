class Counting:
  def __init__(self, num):
    self.num = num
    self.totalcounter = 0
    self.bigcounter = 0
    self.smallcounter = 0

  def calc(self):
    for line in self.num:
      self.totalcounter += 1
      if int(line) < 500:
        self.smallcounter += 1
      else:
        self.bigcounter += 1

  def __str__(self):
    return f"The number of numbers less than 500 is {self.smallcounter}\nThe number of numbers greater than or equal to 500 is {self.bigcounter}\nThe total number of numbers is {self.totalcounter}"