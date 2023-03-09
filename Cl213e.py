class Ages:
  def __init__(self, num, agelist):
    self.num = int(num)
    self.agelist = agelist
    self.group1 = 0
    self.group2 = 0
    self.group3 = 0
    self.group4 = 0
    self.group5 = 0
    self.total = 0
    self.percent1 = 0
    self.percent2 = 0
    self.percent3 = 0
    self.percent4 = 0
    self.percent5 = 0
    self.counter = 0

  def calc(self):
    for line in self.agelist:
      if self.counter < self.num:
        if int(line) < 20:
          self.group1 += 1
        elif int(line) < 40:
          self.group2 += 1
        elif int(line) < 60:
          self.group3 += 1
        elif int(line) < 80:
          self.group4 += 1
        else:
          self.group5 += 1
      self.counter += 1
    self.total = self.group1 + self.group2 + self.group3 + self.group4 + self.group5
    self.percent1 = round((self.group1 / self.total) * 100, 2)
    self.percent2 = round((self.group2 / self.total) * 100, 2)
    self.percent3 = round((self.group3 / self.total) * 100, 2)
    self.percent4 = round((self.group4 / self.total) * 100, 2)
    self.percent5 = round((self.group5 / self.total) * 100, 2)

  def __str__(self):
    return f"Age Group\tDistribution\tPercentage\n<20\t\t\t{self.group1}\t\t\t\t{self.percent1}\n20-39\t\t{self.group2}\t\t\t\t{self.percent2}\n40-59\t\t{self.group3}\t\t\t\t{self.percent3}\n60-79\t\t{self.group4}\t\t\t\t{self.percent4}\n>80\t\t\t{self.group5}\t\t\t\t{self.percent5}"