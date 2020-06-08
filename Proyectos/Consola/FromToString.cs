#region Header
using System; using static System.Console; namespace CursoCSharp { class Global { 
#endregion    

static void Main() => Run();

static void Run()
{
    // Ingreso de números
    WriteLine("Sumando dos números (x + y)");
    WriteLine("---------------------------");
    WriteLine();
    Write("x: "); var sx = ReadLine();
    Write("y: "); var sy = ReadLine();

    // Conversión de string a decimales
    var x = decimal.Parse(sx);
    var y = decimal.Parse(sy);

    // Suma x + y
    var z = x + y;

    // Desplegar resultado
    WriteLine("x + y = " + z.ToString());
    WriteLine($"{x} + {y} = {z}");
    WriteLine();
}


#region Footer
    }
}
#endregion