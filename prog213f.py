from Cl213f import *
def main():
  try:
    elecbills = []
    with open("data/prog213f.dat", 'r') as f:
      for line in f:
        kwh = float(line)
        if kwh != -999:
          bill = Electric(kwh)
          elecbills.append(bill)
    for bill in elecbills:
      bill.calc()
      print(bill)

  except Exception as e:
    print("Error:", e)


if __name__ == "__main__":
  main()