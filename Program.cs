// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Text.RegularExpressions;

Random dice = new();
int rollOne = dice.Next(1,3);
int rollTwo = dice.Next(1,3);
int rollThree = dice.Next(1,3);
int totalRoll = rollOne + rollTwo + rollThree;

Console.WriteLine(@$"Your total roll was {totalRoll}");

if (totalRoll <= 4){

Console.WriteLine($"Love ya!\n");


} if ( totalRoll >= 5){

    Console.WriteLine($"You win !\n");

} if ((rollOne == rollTwo) && (rollThree == rollOne) ){

    Console.WriteLine("Wow congrats! Secret line unlocked!!!\nTriples!!!");
    totalRoll +=3;

} else if ((rollOne == rollTwo) || (rollThree == rollOne) || (rollTwo == rollThree)){

    Console.WriteLine("Wow congrats! Secret line unlocked!!!\nDoubles!!");
    totalRoll += 2;

}



// Console.WriteLine(dice.Next((int)n1,(int)n2));
// Console.WriteLine(dice.Next(9));

// int n3 = dice.Next(1, 0);    
