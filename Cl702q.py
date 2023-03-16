class Vehicle:
  def __init__(self, name, tires):
    self.name = name
    self.tires = tires

class Car(Vehicle):
  def __init__(self, name, tires, worth):
    super().__init__(name, tires)
    self.worth = worth

class Truck(Vehicle):
  def __init__(self, name, tires, miles):
    super().__init__(name, tires)
    self.miles = miles

class Bus(Vehicle):
  def __init__(self, name, tires, town):
    super().__init__(name, tires)
    self.town = town