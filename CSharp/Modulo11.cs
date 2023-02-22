namespace Modulo11
{
    public class TrabalhandoComDatas
    {
        public void AulaDateTime()
        {
            var date1 = new DateTime(2022, 04, 13, 10, 10, 00);
            var date2 = DateTime.Parse("2022/12/22 19:35:23");
            var date3 = DateTime.Now;
            var date4 = DateTime.Now.AddDays(30);
            
            System.Console.WriteLine(date1);
            System.Console.WriteLine(date2);
            System.Console.WriteLine(date3);
            System.Console.WriteLine(date4);

            System.Console.WriteLine(date3.ToString("dd*MM*yyyy"));
            System.Console.WriteLine(date3.ToString("dd-MM-yyyy HH:mm:ss"));

            var dateOffSet1 = new DateTimeOffset(DateTime.Now, new TimeSpan( -3, 0, 0));
            System.Console.WriteLine(dateOffSet1.LocalDateTime);
            System.Console.WriteLine(dateOffSet1.UtcDateTime);

            System.Console.WriteLine(DateTimeOffset.Now);
            System.Console.WriteLine(DateTimeOffset.UtcNow);


        }


        public void AulaSubDatas()
        {
            var date1 = DateTime.Now;
            var date2 = DateTime.Parse("1986-04-13");

            var diff = date1 - date2;   //ou: date1.Subtract(date2);
            System.Console.WriteLine(diff.TotalDays);
            System.Console.WriteLine(diff.TotalHours);

        }

        public void AulaAddDiaMesAno()
        {
            var date1 = DateTime.Now;

            System.Console.WriteLine(date1.AddDays(90));
            System.Console.WriteLine(date1.AddMonths(4));
            System.Console.WriteLine(date1.AddYears(15));

        }

        public void AulaAddHours()
        {
            var date1 = DateTime.Now;

            System.Console.WriteLine(date1.AddHours(4));
            System.Console.WriteLine(date1.AddMinutes(40));
            System.Console.WriteLine(date1.AddSeconds(500));

        }

        public void AulaADiaDaSemana()
        {
            var date1 = DateTime.Now;
            System.Console.WriteLine(date1.DayOfWeek);
        }

        public void AulaADateOnly()
        {
            // var somenteData = new DateOnly(2023,04,13); ///diponivel a partir do .net 6
            var somenteData = DateOnly.Parse("2023-04-13"); ///diponivel a partir do .net 6
            
            System.Console.WriteLine(somenteData);
            System.Console.WriteLine(somenteData.ToString("dd/MM/yy"));  //so trabalha com data.... nao pega  hora!!!!!!

        }
        public void AulaATimeOnly()
        {
            var outraHora = new TimeOnly(12,50,35,58);  
            var somenteHora = TimeOnly.Parse("23:01:25"); ///diponivel a partir do .net 6
            
            System.Console.WriteLine(somenteHora);
            System.Console.WriteLine(somenteHora.ToString("HH:mm:ss"));  //so trabalha com HORA....

        }



    }


}