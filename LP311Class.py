class ClLP311:
  def __init__(self, ds, cg, db, ts):
    self.design = ds
    self.coding = cg
    self.debug = db
    self.test = ts
    self.time = 0
    self.percents = [0]*4

  def _percent(self, number):
    return round((number / self.time) * 100, 2)

  def calculate(self):
    self.time = self.design + self.coding + self.debug + self.test
    self.percents[0] = self._percent(self.design)
    self.percents[1] = self._percent(self.coding)
    self.percents[2] = self._percent(self.debug)
    self.percents[3] = self._percent(self.test)

  def display(self):
    print("Task\t\t\t% Time")
    print()
    print(f"Designing\t\t{self.percents[0]}%")
    print(f"Coding\t\t\t{self.percents[1]}%")
    print(f"Debugging\t\t{self.percents[2]}%")
    print(f"Testing\t\t\t{self.percents[3]}%")


def main():
  print("Enter the time spent on the following things: \n")
  design = float(input("Designing: "))
  coding = float(input("Coding: "))
  debug = float(input("Debugging: "))
  test = float(input("Testing: "))
  print()
  
  budget = ClLP311(design, coding, debug, test)
  budget.calculate()
  budget.display()

if __name__ == "__main__":
  main()