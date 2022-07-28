// See https://aka.ms/new-console-template for more information
//How to generate random numbers
//These are not true random numbers, but rather pseudo random numbers
//"of a number, a sequence of numbers, or any digital data-satisfying
//one or more statistical tests for randomness but produced by a definite
//mathematical procedure
//To create random numbers you have to instantiate a random object
//You could have named it anything but we chose random
Random random = new Random();
//We can now use the random object to generate random numbers
//There are a few ways to do this and we will focus on the next and
//next double method
int num = random.Next(1,7); //This will generate a random whole integer
//If you do not specify a range it will pick parameters
//and generate a random number between 0 and 2 billion
//So we set parameters for this to pick a random number between 1 and 6
Console.WriteLine(num);
//You can always make adjustments such as 
int number = random.Next(1, 7) + 100; // This will display a random number between
//101 and 106
Console.WriteLine(number);
//----------------------------------------
//The next double method will generate a random decimal number
double num2 = random.NextDouble(); //The random number will be between 0 and 1
Console.WriteLine(num2);
//-----------------------------------------------------
//If you want to display multiple random numbers say from a dice rolled 3 times
int n1 = random.Next(1, 7);
int n2 = random.Next(1, 7);
int n3 = random.Next(1, 7);
Console.WriteLine(n1);
Console.WriteLine(n2);  
Console.WriteLine(n3);  
//-----------------------------------------------------------------------

Console.ReadKey();
