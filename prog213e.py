from Cl213e import *
def main():
  try:
    famlist = []
    with open("data/prog213e.dat", 'r') as f:
      for line in f:
        famlist.append(line)
      family = Ages(famlist[0], famlist[1:])
      family.calc()
      print(family)

  except Exception as e:
    print("Error:", e)


if __name__ == "__main__":
  main()