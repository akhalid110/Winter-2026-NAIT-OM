// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// static CTOR fired and initialized the random object and Current Rand value
using Lecture4Demo3;

Console.WriteLine($"Static property rand = {StaticSample.CurrentRand}");

// Now make some instances, they all use the same static Random object
StaticSample a = new StaticSample();
Console.WriteLine($"Instance a has rand = {a.InstanceRand}");
StaticSample b = new StaticSample();
Console.WriteLine($"Instance b has rand = {b.InstanceRand}");
// Access through class name, static value unchanged
Console.WriteLine($"Static property rand = {StaticSample.CurrentRand}");
