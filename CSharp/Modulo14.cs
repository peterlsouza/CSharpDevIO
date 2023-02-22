namespace Modulo14
{
    public class TrabalhandoComLink
    {
        public void AulaWhere()
        {
            string nomeCompleto = "Peterson Luiz de Souza";

            Func<char, bool> filtro = c => c == 'P';

            // var resultado = nomeCompleto.Where(a => a == 'e');
            // var resultado = nomeCompleto.Where(filtro);
            var resultado = from c in nomeCompleto where c == 'e' select c;

            foreach (var letra in resultado)
            {
                System.Console.WriteLine(letra);
            }


            // !
            // *
            // TODO
            // ? 

            var numeros = new int[] {10, 6, 5, 50, 15};
            var resultado2 = numeros.Where(p => p >= 10);

            foreach (var numero in resultado2)
            {
                System.Console.WriteLine(numero);                
            }
        }


        public void AulaOrdenacao()
        {
            var numeros = new int [] { 10, 6, 26, 17, 8};
            var resultado = numeros.OrderByDescending(p => p);
            
            var nomes = new string [] {"Peter", "Sara", "Esther", "Ana Julia"};
            var resultado2 = nomes.OrderBy(p => p);


            foreach (var numero in resultado)
             {
                System.Console.WriteLine(numero);
             }

            foreach (var nome in resultado2)
             {
                System.Console.WriteLine(nome);
             }
        }

        public void AulaTake()
        {
            var numeros = new int [] { 10, 6, 26, 17, 8, 19};
            
            var resultado = numeros.Where(p => p > 10).Take(4).OrderBy(p => p);

            foreach (var numero in resultado)
            {
               System.Console.WriteLine(numero);
            }
        }

        public void AulaCount()
        {
            var numeros = new int [] { 10, 6, 26, 17, 8, 19};
            var resultado = numeros.Count(p => p > 10);
            
            System.Console.WriteLine(resultado);
            
        }

        public void AulaFirstOrFirstOrDefault()
        {
            var numeros = new int [] { 10, 6, 26, 17, 8, 19};
            // var resultado = numeros.First( p => p > 500);
            // var resultado = numeros.FirstOrDefault( p => p > 500, -99);
            
            // var resultado = numeros.Average();
            // var resultado = numeros.Min();
            var resultado = numeros.Max();

            System.Console.WriteLine(resultado);
            
        }


    }
}