// See https://aka.ms/new-console-template for more information

Console.WriteLine("Assigenment 3 output 1 and 2 in comments");
Console.WriteLine("Welsome to the best Registration Portal Ever!");
 int myvar = 1;
Console.WriteLine($"-Step{myvar}");
Console.Write("Please Enter your username :");
string name =  Console.ReadLine();
Console.WriteLine($"Welcome {name} ! ");
Console.WriteLine($"-Step{++myvar}");
Console.Write("Please create a password :");
string password = Console.ReadLine();
Console.WriteLine($"-Step{++myvar}");
Console.Write("Please create a password :");
string confirm = Console.ReadLine(); //for getting user output string save

bool b = password == confirm;
Console.WriteLine($"password match : {b}");
Console.WriteLine($"-Step{++myvar}");
Console.Write("Please enter your age :");
int age =  Convert.ToInt32(Console.ReadLine());//age INT output and set min age for getting True and False 
int minAge = 18;
bool isAdult = age >= minAge;
Console.WriteLine($"Eligibility status : {isAdult}");
age += 10;
Console.WriteLine($"After 10 year you will be {age} years old");// ask question regarding this 
Console.WriteLine("Thnak you for using this registration portal. Have a nice day");