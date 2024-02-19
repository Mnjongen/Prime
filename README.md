# Prime

## Description

Prime is a simple .NET library that implements different prime number algorithms.

Note: This is a work in progress package. Things might change and not all features are implemented yet.

## Features

- Easy to use
- Contains different prime number algorithms
  - Simple algorithm
  - Sieve of Eratosthenes (WIP)
  - Sieve of Atkin (WIP)
- Supports large prime numbers
- Well documented
- Optimized for performance

## Installation

### .NET CLI

> dotnet add package Mnjongen.Prime

### NuGet Package Manager

> Install-Package Mnjongen.Prime

## Usage

Here are some examples of how to use the library.

### SimplePrimeAlgorithm

Get the first 25 prime numbers using `Prime.Algorithms.Simple.SimplePrimeAlgorithm`

```csharp
IPrimeAlgorithm primeAlgorithm = new SimplePrimeAlgorithm();

var primes = new List<int>();
for (int i = 0; i < 25; i++)
{
    primes.Add(primeAlgorithm.GetNextPrime());
}
```

## Planned Features

- More prime number algorithms
    - Sieve of Eratosthenes
    - Sieve of Atkin

- Primality tests
    - Miller–Rabin
    - Solovay–Strassen
    - Baillie–PSW
