using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач_Кинематика
{
    public class Task3 : Task
    {
        public double res { get; private set; }
        public double t3 { get; private set; }
        public double t1 { get; set; }
        public double t2 { get; set; }
        public double S { get; set; }
        public double Vav { get; set; }
        public string task { get; private set; }

        public Task3()
        {
            task = "Расстояние между двумя станциями s м поезд метро проходит со средней скоростью vср м/c. При этом на разгон он\nзатрачивает время t1 с, затем идет равномерно некоторое время t3 и на замедление до полной остановки тратит\nвремя t2 с. Построить график скорости движения поезда и определить наибольшую скорость поезда vмакс.";
        }

        public void solution()
        {
            if (t1 > 0 && t2 > 0 && S > 0 && Vav > 0)
            {
                t3 = S / Vav - t1 - t2;
                res = 2 * S / (t1 + t2 + 2 * t3);
            }
            else
                res = -1;
        }
    }
}
