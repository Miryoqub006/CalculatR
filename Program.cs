string userInput = Console.ReadLine();

int plusIndex = userInput.IndexOf("+");
int minusIndex = userInput.IndexOf("-");
int kopIndex = userInput.IndexOf("*+");
int bolIndex = userInput.IndexOf("/");
int darajaIndex = userInput.IndexOf("^");

int firstNum = Convert.ToInt32(userInput.Substring(0, 1));

int secNum = Convert.ToInt32(userInput.Substring(2, 1));

if (plusIndex >= 0)
{
    Console.WriteLine($" {firstNum + secNum}  ");
}
else if (minusIndex >= 0)
{
    Console.WriteLine($" {firstNum - secNum}  ");
}
else if (bolIndex >= 0)
{
    Console.WriteLine($" {firstNum / secNum}  ");
}
else if (kopIndex >= 0)
{
    Console.WriteLine($" {firstNum * secNum}  ");
}
else if (darajaIndex >= 0)
{
    Console.WriteLine($" {Math.Pow(firstNum, secNum)}  ");
}