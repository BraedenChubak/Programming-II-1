def sum3(n):
  if n == 3:
    return n
  return n + sum3(n-3)

def main():
  n = int(input("Enter a multiple of 3: "))
  print("The sum of all multiples of 3, from 3 to " + str(n) + ", is", str(sum3(n)))

if __name__ == "__main__":
  main()