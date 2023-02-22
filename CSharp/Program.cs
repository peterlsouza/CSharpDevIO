
// Console.WriteLine("Hello, World!");

using System;

namespace Application
{
  public class programa
  {
    static void Main(string[] args)
    {
      // AulaClasses();
      // AulaPropSomenteLeitura();
      // AulaHerança();
      // AulaClasseSelada();
      // AulaClasseAbstrata(); 
      // AulaRecord();
      // AulaInterface();
      // TrabalhandoComDatas();
      // TrabalhandoComExceptions();
      // TrabalhandoComArquvivos();
      TrabalhandoComLink();
    }

    private static void AulaClasses()
    {
      var resultado = Cadastro.Calculos.SomarNumeros(15, 54);  //temos acesso a calculos pois é uma função public e classe static, quando a classe nao é static temos q criar uma instancia da mesma
      System.Console.WriteLine(resultado);

      // var produto = new Cadastro.Produto();  //instanciando.. se torna um objeto
      // produto.SetId(1); 
      // produto.Descricao = "Notebook";

      // produto.ImpimirDesc();

      // System.Console.WriteLine(produto.GetId());
    }
    private static void AulaPropSomenteLeitura()
    {
      var produto = new Cadastro.Produto();
      produto.Descricao = "Mouse";
      // produto.Estoque = 1;
      System.Console.WriteLine(produto.Estoque);
    }

    private static void AulaHerança()
    {
      // var pessoaFisica = new Cadastro.PessoaFisica();
      // pessoaFisica.Id = 10;
      // pessoaFisica.Endereco = "Rua tres";
      // pessoaFisica.Cidade = "SBO";
      // pessoaFisica.CEP = "13456649";
      // pessoaFisica.CPF = "29632785860";

      // pessoaFisica.ImprimirDados();
      // pessoaFisica.ImprimirCPF();

      var funcionario = new Cadastro.Funcionario();
      funcionario.Id = 12;
      funcionario.Endereco = "Rua sete";
      funcionario.Cidade = "SBO";
      funcionario.CEP = "13456649";
      funcionario.CPF = "29632785860";

      funcionario.ImprimirDados();
      funcionario.ImprimirCPF();
    }

    private static void AulaClasseSelada()
    {
      // var config = new Cadastro.Configuracao()
      // config.Host = "Localhost"
      // ouu 
      var config = new Cadastro.Configuracao()
      {
        Host = "localhost"
      };
      System.Console.WriteLine(config.Host);
    }

    private static void AulaClasseAbstrata()
    {
      var cachorro = new Cadastro.Cachorro();
      cachorro.Nome = "Doguinho";
      cachorro.ImprimiDados();

    }

    private static void AulaRecord()
    {
      // var curso1 = new Cadastro.Curso {Id = 1, Descri = "Curso"};
      // var curso2 = new Cadastro.Curso {Id = 1, Descri = "Curso"};

      var curso1 = new Cadastro.Curso(1, "Curso");
      var curso2 = curso1 with { Descri = "Teste Novo" };

      // var curso1 = new Cadastro.CursoTeste {Id = 1, Descricao = "Curso"};
      // // var curso2 = curso1;
      // // curso2.Descricao = "Teste Teste";
      // var curso2 = new Cadastro.CursoTeste();
      // curso2.Id = curso1.Id;
      // curso2.Descricao = "Nova Descricao";

      // System.Console.WriteLine(curso1 == curso2);
      // System.Console.WriteLine(curso1.Equals(curso2));
      System.Console.WriteLine(curso1.Descri);
      System.Console.WriteLine(curso2.Descri);

    }

    private static void AulaInterface()
    {
      // var notifyCliente = new Cadastro.NotificacaoCliente();
      // notifyCliente.Notificar();

      // Cadastro.INotificacao notificacao = new Cadastro.NotificacaoFuncionario();
    }

    private static void TrabalhandoComDatas()
    {
      // var trabalhandoComDatas = new Modulo11.TrabalhandoComDatas();
      // trabalhandoComDatas.AulaDateTime();
      // trabalhandoComDatas.AulaSubDatas();
      // trabalhandoComDatas.AulaAddDiaMesAno();
      // trabalhandoComDatas.AulaAddHours();
      // trabalhandoComDatas.AulaADiaDaSemana();
      // trabalhandoComDatas.AulaADateOnly();
      // trabalhandoComDatas.AulaATimeOnly();
    }

    private static void TrabalhandoComExceptions()
    {
      var TrabalhandoComExceptions = new Modulo12.TrabalhandoComExceptions();
      //  TrabalhandoComExceptions.AulaGerandoException();
      TrabalhandoComExceptions.AulaTratandoException();
    }

    private static void TrabalhandoComArquvivos()
    {
      var TrabalhandoComArquivos = new Modulo13.TrabalhandoComArquivos();
      //  TrabalhandoComExceptions.AulaGerandoException();
      // TrabalhandoComArquivos.AulaLendoArquivo();
      TrabalhandoComArquivos.AulaExcluindoArquivo();
    }

    private static void TrabalhandoComLink()
    {
      var trabalhandoComLink = new Modulo14.TrabalhandoComLink();
      // trabalhandoComLink.AulaWhere();
      // trabalhandoComLink.AulaOrdenacao();
      // trabalhandoComLink.AulaTake();
      // trabalhandoComLink.AulaCount();
      trabalhandoComLink.AulaFirstOrFirstOrDefault();

    }
  }
}
