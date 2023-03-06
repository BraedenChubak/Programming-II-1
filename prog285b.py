from cl285b import *

def main():
  try:
    with open("data/prog285b.dat", 'r') as f:
      for line in f:
        ldata = line.split(" ")
        id = int(ldata[0])
        code = int(ldata[1])
        sales = float(ldata[2])

        seller = Salesperson(id, code, sales)
        seller.setComm()
        print(str(seller))  # print(seller)

  except Exception as e:
    print("Error:", e)


if __name__ == "__main__":
  main()