using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач_Кинематика
{
    public class Task4:Task
    {
        public double res { get; private set; }
        public double v0 { get; private set; }
        public double t1 { get; set; }
        public double t2 { get; set; }
        public double l { get; set; }
        public string task { get; private set; }

        public Task4()
        {
            task = "Первый вагон поезда прошел мимо наблюдателя, стоящего на платформе, за t1с, а второй — за t2 с. Длина вагона l м.\nНайти ускорение a поезда и его скорость v0 в начале наблюдения. Движение поезда считать равнопеременным.";
        }

        public void solution()
        {
            if (t1 > 0 && t2 > 0 && l > 0)
            {
                res = 2 * (l / t1 - 2*l / (t1 + t2)) / t2;
                v0 = (l + res * t1 * t1 / 2) / t1;
            }
            else
                res = -1;
        }
    }
}
