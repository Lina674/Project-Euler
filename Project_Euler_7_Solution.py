import math

n = 100000

def sieve_of_erasthosthenes(n):
  a = [True for p in range(n)]
  a[0] = a[1] = False
  sqrt_n = int(math.sqrt(n))
  for i in range(2, sqrt_n + 1):
    if a[i]:
      j = i**2
      while j < n:
        a[j] = False
        j += i

  return [p for p, x in enumerate(a) if x]

order = 10001
list_prime = sieve_of_erasthosthenes(n)

while len(list_prime) < order:
  n += 1000
  list_prime = sieve_of_erasthosthenes(n)

print(list_prime[order - 1])
