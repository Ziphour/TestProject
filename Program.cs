﻿string permission = "Admin";
int level = 55;

if ((permission.Contains("Admin")) && (level > 55))
{
    Console.WriteLine("Welcome, Super Admin user.");

}

 else if ((permission.Contains("Admin")) && (level <= 55))
{
    Console.WriteLine("Welcome,Admin user.");

}


 else if ((permission.Contains("Manager")) && (level >= 20))
{
    Console.WriteLine("Contact an Admin for access.");

}


 else if (permission.Contains("Manager") && level < 20 || !permission.Contains("Admin") && !permission.Contains("Manager"))
{
    Console.WriteLine("You do not have sufficient privileges.");

}

