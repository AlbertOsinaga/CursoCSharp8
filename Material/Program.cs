#region Header
using System;
using static System.Console; using static System.Math; namespace CursoCSharp { 
class Global { 
#endregion    

static void Main() => Iniciar();
static void Iniciar() 
{
      int[] enteros;      	           // declaración array de enteros
      enteros = new int[10];             // inicialización array para 10 enteros
      enteros[0] = 12;                   // inicialización de primer elemento
      string[] palabras;	           // declaración array de strings
      palabras = new string[20];         // inicialización para 20 strings
      palabras[19] = "FIN";              // Inicialización ultimo elemento
      var c = new char[3];	           // declaración e inicializción implícita
      c[0] = 'a'; c[1] = 'b'; c[2] = 'c'; 
      var m = new decimal[]  {12.8M, 45.9M, 34M};
      var estaciones = new[] {"Invierno", "Primavera", "Verano", "Otoño"}; 
      WriteLine($"enteros[0] = {enteros[0]}");
      WriteLine ($"c[0..3] = {c[0]} {c[1]} {c[2]}"); WriteLine(palabras[19]); 
      WriteLine ($"estaciones[1] = {estaciones[1]}");
}


#region Footer
}}
#endregion