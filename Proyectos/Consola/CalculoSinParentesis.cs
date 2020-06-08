#region Header
using System; using static System.Console; namespace CursoCSharp { class __Global { 
#endregion    

// Programa Consola para calcular una operación aritmética (sin paréntesis, ni precedencia)
// static void Main(string[] args) => Calcular(args);
static void Calcular(string[] args) 
{
      if(args.Length == 0)
            return;

      // Obtener línea con operación
      var operacion = GetOperacion(args);
      // Validar operación
      if(!ValidaOperacion(operacion))
      {
            WriteLine("Operación inválida!");
            return;
      }
      // Calcular
      var resultado = CalculaOperacion(operacion);
      // Escribir resultado
      WriteLine($"Resultado = {resultado}");
}

static decimal CalculaOperacion(string operacion)
{
      string[] strNumeros = operacion.Split(' ', '+','-','x','/');
      if(strNumeros.Length == 0)
            return 0M;
      string[] arrayOps = operacion.Split('0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ' ');
      var strOps = string.Concat(arrayOps);
      int num = 0;
      decimal resultado = decimal.Parse(strNumeros[num]);
      if(arrayOps.Length == 0)
            return resultado;
      int op  = 0;
      while(op < strOps.Length)
      {
            num++;
            if(strOps[op] == '+')
            {
                  resultado += decimal.Parse(strNumeros[num]);
            }
            else if(strOps[op] == '-')
            {
                  resultado -= decimal.Parse(strNumeros[num]);
            }
            else if(strOps[op] == 'x')
            {
                  resultado *= decimal.Parse(strNumeros[num]);
            }
            else if(strOps[op] == '/')
            {
                  resultado /= decimal.Parse(strNumeros[num]);
            }
            op++;
      }

      return resultado;
}

static string GetOperacion(string[] args) => string.Concat(args);
static bool ValidaOperacion(string operacion)
{
      var charOps = "+-x/";
      var charPermitidos = "0123456789 +-x/";
      int i = 0;
      while(i < operacion.Length)
      {
            if(!charPermitidos.Contains(operacion[i]))
                  return false;
            i++;
      }
      if(charOps.Contains(operacion[0]) || charOps.Contains(operacion[operacion.Length-1]))
            return false;
      
      return true;
}


#region Footer
    }
}
#endregion