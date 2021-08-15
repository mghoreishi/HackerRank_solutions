//Day 9: Recursion 3

public static int factorial(int n)
{
  if(n>1)
    return n * factorial(n-1);
  else
    return n;
}
