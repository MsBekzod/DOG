

string name = "Ismingizni kiriting:";
System.Console.Write(name);
string ismi = Console.ReadLine();
string greeting = $"Assalom alekum  {ismi} aka";
System.Console.WriteLine(greeting);

System.Console.Write("Yoshingizni kiriting:");
string age = Console.ReadLine();
int yosh = Convert.ToInt32(age);
int ageDifference = 2024 - yosh;
System.Console.WriteLine($"Sizning tug'ulgan yilingiz {ageDifference}-yil!");


