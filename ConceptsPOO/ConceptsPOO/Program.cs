﻿// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

Console.WriteLine("POO CONCEPTS");
Console.WriteLine("=========");
try
{
    Console.WriteLine(new Date(2024, 02, 29));
    Console.WriteLine(new Date(1974, 9, 23));
    Console.WriteLine(new Date(1985, 11, 30));
}
catch (Exception error)
{

    Console.WriteLine(error.Message);
}