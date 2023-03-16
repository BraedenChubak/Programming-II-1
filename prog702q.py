from Cl702q import *

def main():
  try:
    vehicles = []
    with open("data/prog702q.txt", 'r') as f:
      num = f.readline()
      while num != "":
        num = int(num)
        name = f.readline()
        tires = f.readline()
        if num == 1:
          worth = int(f.readline())
          p = Car(name, tires, worth)
          vehicles.append(p)
        elif num == 2:
          miles = int(f.readline())
          p = Truck(name, tires, miles)
          vehicles.append(p)
        elif num == 3:
          town = f.readline().strip()
          p = Bus(name, tires, town)
          vehicles.append(p)
        num = f.readline()

      carworth = 0
      totworth = 0
      long = ""
      truckval = 999999999999999999
      lowtruck = ""
      cartires = 0
      trucktires = 0
      bustires = 0
      count = 0

      for vehicle in vehicles:
        if isinstance(vehicle, Car):
          carworth += int(vehicle.worth)
          totworth += int(vehicle.worth)
          cartires += int(vehicle.tires)
          count += 1
        elif isinstance(vehicle, Truck):
          totworth += 50000 - (vehicle.miles * 0.25)
          if 50000 - (vehicle.miles * 0.25) < truckval:
            lowtruck = vehicle.name
          trucktires += int(vehicle.tires)
          count += 1
        elif isinstance(vehicle, Bus):
          totworth += 50000
          if len(vehicle.town) > len(long):
            long = vehicle.town
          bustires += int(vehicle.tires)
          count += 1

    
    print("The total number of vehicles is:", str(count))
    print("The total value of cars is: $" + str(carworth))
    print("The total value of all vehicles is: $" + str(totworth))
    print("The truck with the lowest value is:", str(lowtruck))
    print("The longest bus hometown name is:", str(long))
    print("The # of car tires is:", str(cartires))
    print("The # of truck tires is:", str(trucktires))
    print("The # of bus tires is:", str(bustires))
      
  except Exception as e:
    print("Error:", e)


if __name__ == "__main__":
  main()