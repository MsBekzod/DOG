


// string name = "Ismingizni kiriting:";
// System.Console.Write(name);
// string ismi = Console.ReadLine();
// string greeting = $"Assalom alekum  {ismi} aka";
// System.Console.WriteLine(greeting);

// System.Console.Write("Yoshingizni kiriting:");
// string age = Console.ReadLine();
// int yosh = Convert.ToInt32(age);
// int ageDifference = 2024 - yosh;
// System.Console.WriteLine($"Sizning tug'ulgan yilingiz {ageDifference}-yil!");

System.Console.Write("Yoshingizni kiriting:");
string firstNumber = Console.ReadLine();
int a = Convert.ToInt32(firstNumber);
System.Console.Write("Do'stingizni yoshini kiriting kiriting:");
string secondNumber = Console.ReadLine();
int b = Convert.ToInt32(secondNumber);
int farq = a - b;

System.Console.WriteLine($"Sizning yoshingiz do'stingiznikidan {farq} ga katta!:  {a > b}");

