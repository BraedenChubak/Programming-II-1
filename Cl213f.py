class Electric:
  def __init__(self, kwh):
    self.kwh = kwh
    self.cost = 0.0

  def calc(self):
    if self.kwh < 2000:
      self.cost = round(self.kwh * 0.07, 2)
    elif self.kwh < 10000:
      self.cost = round(2000 * 0.07 + (self.kwh - 2000) * 0.05, 2)
    else:
      self.cost = round(2000 * 0.07 + 8000 * 0.05 + (self.kwh - 10000) * 0.04, 2)

  def __str__(self):
    return f"The cost of {self.kwh} KWH is: ${self.cost}"