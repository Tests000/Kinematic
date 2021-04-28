using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач_Кинематика
{
    class Task2 : Task
    {
        public double res { get; private set; }
        public double d { get; set; }
        public double v { get; set; }
        public double l { get; set; }
        public string task { get; private set; }

        public Task2()
        {
            task = "Вагон шириной d м, движущийся со скоростью v м/с, был пробит пулей, летевшей перпендикулярно движению вагона.\nСмещение отверстий в стенках вагона относительно друг друга равно l м. Какова скорость движения пули?";
        }

        public void solution()
        {
            if (d > 0 && v > 0 && l > 0)
                res = d*v/l;
            else
                res = -1;
        }
    }
}
