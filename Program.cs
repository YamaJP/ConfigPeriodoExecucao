using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigHorario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var horarioInicio = "23:00";
            var horarioFim = "07:00";

            DateTime periodoInicio = DateTime.Now;
            DateTime periodoFim = DateTime.Now;
            
            periodoInicio = DateTime.Today.Add(TimeSpan.Parse(horarioInicio));
            //Quero executar das 23h às 07h do dia seguinte
            periodoFim = DateTime.Today
                                        .AddDays(DateTime.Today.Add(TimeSpan.Parse(horarioInicio)) > DateTime.Today.Add(TimeSpan.Parse(horarioFim)) ? 1 : 0)
                                        .Add(TimeSpan.Parse(horarioFim));


            Console.WriteLine($"periodoInicio={periodoInicio} periodoFim={periodoFim}");


            if (DateTime.Now >= periodoInicio && DateTime.Now <= periodoFim)
                Console.WriteLine($"horaAtual={DateTime.Now} EXECUTAR");
            else
                Console.WriteLine($"horaAtual={DateTime.Now} SLEEP");

            Console.ReadKey();

        }
    }
}
