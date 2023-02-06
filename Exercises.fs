//Exercise 1.1
let sqr x = x*x

//Exercise 1.2
let pow x n = System.Math.Pow(x,n)

//Exercise 1.3
let rec sum n = if n <> 0 then n+(sum(n-1)) else 0

//Exercise 1.4
let rec fib n =
    match n with
    | 0 -> 0
    | 1 -> 1
    | n -> fib(n-1) + fib(n-2)

//Exercise 1.5
let dup (s: string) = s+s

//Exercise 1.6
let rec dupn s n = if n <> 0 then s+dupn (s) (n-1) else ""

//Exercise 1.7
let rec bin (n,k) = if n=k || k=0 then 1 else bin(n-1,k-1) + bin(n-1,k)