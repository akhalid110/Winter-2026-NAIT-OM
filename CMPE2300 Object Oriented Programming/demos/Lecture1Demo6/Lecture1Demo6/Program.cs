// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
 * Lecture1 - Demo6 - Making basic types nullable 
 */

//int
int? iX = null;
if(iX == null)
{
    iX = 0;
    Console.WriteLine("iX was null - It's been assigned value 0.");
}
else
{
    Console.WriteLine("It is not null.");
}


Console.WriteLine();


//bool
bool? bState = null;
//by making the variable bState nullable, it can now have 3 possible states: true, false and null
switch (bState)
{
    case true:  //processing for true
        break;
    case false: //processing for false
        break;
    case null:
        Console.WriteLine("bState was null - it's been assigned false");
        bState = false;
        break;
}