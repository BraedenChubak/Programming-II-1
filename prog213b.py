from Cl213b import *

def main():
  try:
    with open("data/prog213b.txt", 'r') as f:
      for line in f:
        ldata = line

        order = Packages(ldata)
        order.calc()
        print(str(order))

  except Exception as e:
    print("Error:", e)


if __name__ == "__main__":
  main()