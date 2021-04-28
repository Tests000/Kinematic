using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач_Кинематика
{
    class Task5:Task
    {
        public double res { get; private set; }
        public double v { get; private set; }
        public double v0 { get; set; }
        public double S { get; set; }
        public double t { get; set; }
        public string task { get; private set; }

        public Task5()
        {
            task = "Реактивный самолет летит со скоростью v0 м/c. С некоторого момента самолет движется с ускорением в течение t с и в\nпоследнюю секунду проходит путь s м. Определить ускорение a и конечную скорость v самолета";
        }

        public void solution()
        {
            if (t > 0 && v0 > 0 && S > 0)
            {
                res = (S-v0)/(t-0.5);
                v = v0 + res * t;
            }
            else
                res = -1;
        }
    }
}
