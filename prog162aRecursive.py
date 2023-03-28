import sys
sys.setrecursionlimit(5000)

def fact(n):
  if n == 1:
    return n           # Base/Ending Case
  return n * fact(n-1) # Recursive Case

def main():
  num = int(input("Enter a Number: "))
  while num != 0:
    factn = fact(num)
    print(f"{num}! = {factn}")
    num = int(input("Enter a Number: "))

if __name__ == "__main__":
  main()