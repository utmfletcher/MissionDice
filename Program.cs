
using MissionDice;
using System.Threading.Tasks;

DiceTools dt = new DiceTools();

int numRolls;

// UI/UX / instructions 
Console.WriteLine("Welcome to the dice throwing simulator! ");
Console.WriteLine("");
Console.WriteLine("How many dice rolls would you like to simulate?");

// take user input 
numRolls = int.Parse(Console.ReadLine());

// UI/UX
Console.WriteLine("");
Console.WriteLine("DICE ROLLING SIMULATION RESULTS ");
Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
Console.WriteLine("Total number of rolls = "+ numRolls + ". ");
Console.WriteLine("");

// calculate the number of rolls for each number
// print histogram output  
dt.RollDice(numRolls);


Console.WriteLine("");
Console.WriteLine("Thank you for using the dice throwing simulator.  Goodbye! ");
