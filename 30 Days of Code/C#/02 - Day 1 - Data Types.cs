// Day 1: Data Types
// Declare second integer, double, and String variables.

int int_2 = Convert.ToInt32(Console.ReadLine().Trim());
double double_2 = Convert.ToDouble(Console.ReadLine().Trim());
string string_2 = Console.ReadLine().Trim();

// Read and save an integer, double, and String to your variables.
int sum_int = i + int_2;
double sum_double =  d + double_2;
string sum_string = s + string_2;

//Print the sum of both integer variables on a new line.
Console.WriteLine(sum_int);

//Print the sum of the double variables on a new line.
Console.WriteLine(sum_double.ToString("0.0"));

// Concatenate and print the String variables on a new line
Console.WriteLine(sum_string);
