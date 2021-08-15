// Day 2: Operators

public static void solve(double meal_cost, int tip_percent, int tax_percent)
{
   double total_cost;
   total_cost = Math.Round(meal_cost + meal_cost * tip_percent / 100 +   meal_cost * tax_percent / 100);
   Console.WriteLine(total_cost);
 }
