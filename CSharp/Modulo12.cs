namespace Modulo12
{
  public class TrabalhandoComExceptions
  {

    public void AulaGerandoException()
    {
      while (true)
      {
        System.Console.WriteLine("Informe um Numero");
        var numero = Console.ReadLine();
        var resultado = 500 / int.Parse(numero);

        System.Console.WriteLine("Resultado: " + resultado);
      }


    }

    public void AulaTratandoException()
    {
      while (true)
      {
        try
        {
          System.Console.WriteLine("Informe um Numero");
          var numero = Console.ReadLine();
          var resultado = 500 / int.Parse(numero);

          System.Console.WriteLine("Resultado: " + resultado);
        }
        catch (DivideByZeroException exception)
        {
          System.Console.WriteLine("Erro de divisão: " + exception.Message);
          System.Console.WriteLine("Stack: " + exception.StackTrace);
        }
        catch (Exception exception)
        {
          System.Console.WriteLine("Deu pau... foi mal! " + exception.Message);
          System.Console.WriteLine("Stack: " + exception.StackTrace);
        }

      }


    }

  }
}