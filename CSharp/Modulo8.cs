// namespace Cadastro;  forma nova poderia ser apenas assim...

namespace Cadastro
{
  public static class Calculos
  {
    public static int SomarNumeros(int a, int b)
    {
      return a + b;
    }
  }

  public class Produto
  {
    private int Id;
    public string Descricao { get; set; }
    public readonly int Estoque;// ou assim, public int Estoque { get; }  -- teremos acesso no construtor da classe..

    public Produto()
    {
      Estoque = 10;
    }


    public void ImpimirDesc()
    {
      System.Console.WriteLine(GetId() + " - " + Descricao);
    }

    public void SetId(int id)
    {
      Id = id;
    }

    public int GetId()
    {
      return Id;
    }

  }

  public class Pessoa
  {
    public int Id { get; set; }
    public string Endereco { get; set; }
    public string Cidade { get; set; }
    public string CEP { get; set; }

    public void ImprimirDados()
    {
      System.Console.WriteLine("Codigo: " + Id);
      System.Console.WriteLine("Endereco: " + Endereco);
      System.Console.WriteLine("Cidade: " + Cidade);
      System.Console.WriteLine("Cep: " + CEP);
    }
  }

  public class PessoaFisica : Pessoa
  {
    public string CPF { get; set; }

    public void ImprimirCPF()
    {
      System.Console.WriteLine("CPF: " + CPF);
    }
  }

  public class Funcionario : PessoaFisica
  {
    public string Matricula { get; set; }

  }
  public sealed class Configuracao //sealed nao pode ser herdada, deve ser instanciada para usar..
  {
    public string Host { get; set; }
  }

  public abstract class Animal//abstrata nao pode ser instanciada!! servirão como superclasses.. referencia para as demais
  {
    public string Nome { get; set; }

    public abstract string GetInfo();
    public void ImprimiDados()
    {
      System.Console.WriteLine("Nome Animal: " + Nome);
      System.Console.WriteLine("Info: " + GetInfo());
    }
  }

  public class Cachorro : Animal
  {
    public override string GetInfo()
    {
      return "Cachorro é bom amigo";
    }
  }

  public record Curso(int Id, string Descri);

  public class CursoTeste
  {
     public int Id { get; set; }
     public string Descricao { get; set; }
  }

  // public record Curso
  // {
  //   public int Id { get; set; }
  //   public string Descri { get; set; }

  //   // public override bool Equals(object? obj)
  //   // {
  //   //   if (obj == null) return false;
      
  //   //   if (obj is Curso curso)
  //   //   {
  //   //     return Id == curso.Id && Descri == curso.Descri;
  //   //   }
  //   //   return base.Equals(obj);
  //   // }

  //   // public static bool operator == (Curso a, Curso b)
  //   // {
  //   //   return a.Equals(b);
  //   // }

  //   // public static bool operator != (Curso a, Curso b)
  //   // {
  //   //   return !(a == b);
  //   // }

  // }

  public interface INotificacao  //contrato..
  {
    string Descricao {get; set;}

    void Notificar();
  }

  public class NotificacaoCliente : INotificacao
  {
    public string Descricao { get; set; }

    public void Notificar()
    {
      System.Console.WriteLine("Notificando cliente..");
    }
  }

  public class NotificacaoFuncionario : INotificacao
  {
    public string Descricao { get; set; }

    public void Notificar()
    {
      System.Console.WriteLine("Notificando funcionario");
    }
  }

  
}