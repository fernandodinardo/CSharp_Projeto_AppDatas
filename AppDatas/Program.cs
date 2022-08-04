using System;
using System.Globalization;

namespace AppDatas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("My name is Fernando Di Nardo L.");
            System.Console.WriteLine("-------------------------------");
            System.Console.WriteLine(" ");

            /*
            DataTime()
            É uma Struct da Data e começa como 01/01/0001 12:00:00 AM

            var data = new DateTime();
            System.Console.WriteLine(data);
            */

            // Data Atual
            // Não precisa usar o NEW ... apenas o DateTime.NOW

            var dataAtual = DateTime.Now;
            System.Console.WriteLine(dataAtual);
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine(" ");


            // Dividindo os campos de DataTime

            System.Console.WriteLine(" ");
            var datas = new DateTime(2022, 08, 03, 14, 51, 33);
            System.Console.WriteLine(datas);
            System.Console.WriteLine("");
            System.Console.Write("ANO: ");
            System.Console.WriteLine(datas.Year);
            System.Console.Write("MÊS: ");
            System.Console.WriteLine(datas.Month);
            System.Console.Write("DIA: ");
            System.Console.WriteLine(datas.Day);
            System.Console.Write("HORA: ");
            System.Console.WriteLine(datas.Hour);
            System.Console.Write("MINUTOS: ");
            System.Console.WriteLine(datas.Minute);
            System.Console.Write("SEGUNDOS: ");
            System.Console.WriteLine(datas.Second);
            System.Console.Write("Dia da Semana: ");
            System.Console.WriteLine(datas.DayOfWeek);
            System.Console.Write("Dia do Ano: ");
            System.Console.WriteLine(datas.DayOfYear);
            System.Console.WriteLine("---------------------------");


            // Formatando Data

            System.Console.WriteLine("Datas Formatadas: ");
            var format1 = String.Format("{0}", dataAtual);
            System.Console.WriteLine(format1);

            var format2 = String.Format("{0:yyyy-MM-dd hh:mm:ss}", dataAtual);
            System.Console.WriteLine(format2);

            var format3 = String.Format("{0:dd/MM/yyyy hh:mm:ss}", dataAtual);
            System.Console.WriteLine(format3);
            System.Console.WriteLine(" ");

            System.Console.WriteLine("Data Dia/Mês/Ano");
            System.Console.WriteLine("Hora:Minuto:Segundos - FraçãoDeSegundos - TimeZone");
            var format4 = String.Format("{0:dd/MM/yyyy hh:mm:ss ff z}", dataAtual);
            System.Console.WriteLine(format4);
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine(" ");


            // CultureInfo
            // Datas em PT - Português Portugal
            // Datas em BR - Português Brasil
            // Datas em EN - Inglês US - Americano
            // Datas em UK - Inglês UK - Britânico
            // Datas em DE - Dinamarca

            var pt_Portugal = new CultureInfo("pt-PT");
            var pt_Brasil = new CultureInfo("pt-BR");
            var en_Usa = new CultureInfo("en-US");
            var en_Uk = new CultureInfo("en-UK");
            var de_Dinamarca = new CultureInfo("de-DE");
            var culturaAtual = CultureInfo.CurrentCulture;

            System.Console.WriteLine(DateTime.Now.ToString("D", pt_Brasil));
            System.Console.WriteLine(DateTime.Now.ToString("D", pt_Portugal));
            System.Console.WriteLine(DateTime.Now.ToString("D", en_Usa));
            System.Console.WriteLine(DateTime.Now.ToString("D", en_Uk));
            System.Console.WriteLine(DateTime.Now.ToString("D", de_Dinamarca));

            System.Console.WriteLine(" ");
            System.Console.Write("Data e Hora da máquina:");
            System.Console.WriteLine(culturaAtual);
            System.Console.WriteLine(DateTime.Now.ToString("D", culturaAtual));

            System.Console.WriteLine("--------------------------------");
            System.Console.WriteLine(" ");

            var dateTimeUtc = DateTime.UtcNow;
            System.Console.WriteLine(DateTime.Now);
            System.Console.WriteLine(dateTimeUtc);
            System.Console.WriteLine(dateTimeUtc.ToLocalTime());
            System.Console.WriteLine(" ");

            //var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            //System.Console.WriteLine(timezoneAustralia);
            //System.Console.WriteLine(" ");

            //var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(dateTimeUtc, timezoneAustralia);
            //System.Console.WriteLine(horaAustralia);
            //System.Console.WriteLine(" ");

            var timezones = TimeZoneInfo.GetSystemTimeZones();

            foreach (var timezone in timezones)
            {
                System.Console.WriteLine(timezone.Id);
                System.Console.WriteLine(timezone);
                System.Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTimeUtc, timezone));
                System.Console.WriteLine("----------");
            }

        }
    }
}
