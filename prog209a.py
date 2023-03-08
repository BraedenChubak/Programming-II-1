from Cl209a import *

def main():
  try:
    with open("data/prog215a.dat", 'r') as f:
      ldata = f
      number = Counting(ldata)
      number.calc()
      print(str(number))

  except Exception as e:
    print("Error:", e)


if __name__ == "__main__":
  main()