

using System.Xml;

Console.Write("What is your first name: ");
string firstName=Console.ReadLine();

Console.Write("What is your last name: ");
string lastName = Console.ReadLine();

if (firstName.ToLower()=="héctor" && lastName.ToLower() == "sandoval")
{
    Console.WriteLine("Hello Mr. Sandoval.");
} 
else if (firstName.ToLower()== "héctor")
{
    Console.WriteLine("Hello. You have a cool first name.");
} else if (lastName.ToLower()=="sandoval")
{
    Console.WriteLine("Hello. You have a great last name.");
} else
{
    Console.WriteLine("Sorry. You don't have a cool name.");
}

if (firstName.ToLower() == "héctor" && lastName.ToLower() == "sandoval")
{
    Console.WriteLine("Hello Mr. Sandoval.");
}
if (firstName.ToLower() == "héctor")
{
    Console.WriteLine("Hello. You have a cool first name.");
}else
{
    Console.WriteLine("Sorry. You don't have a cool first name.");
}

if (lastName.ToLower() == "sandoval")
{
    Console.WriteLine("Hello. You have a great last name.");
}
else
{
    Console.WriteLine("Sorry. You don't have a cool last name.");
}


int age = 0;

if (age>100)
{
    Console.WriteLine("You are up there in years");
}

if (firstName.ToLower() == "héctor" && lastName.ToLower() == "sandoval")
{
    Console.WriteLine("Hello Professor Sandoval.");
}
else if (firstName.ToLower() == "héctor" || lastName.ToLower() == "sandoval")
{
    Console.WriteLine("Hello. You have a cool name.");
}else
{
    Console.WriteLine("Hello Student.");
}