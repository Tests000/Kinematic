using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Курсач_Кинематика
{
    class Task1 : Task
    {
        public double res { get; private set; }
        public double l { get; set; }
        public double v1 { get; set; }
        public double v2 { get; set; }
        public string task { get; private set; }

        public Task1()
        {
            task = "Колонна войск во время похода движется со скоростью v1 км/ч, растянувшись по дороге на расстояние l км. Командир,\nнаходящийся в хвосте колонны, посылает велосипедиста с поручением головному отряду. Велосипедист отправляется и\nедет со скоростью v2 км/ч и, на ходу выполнив поручение, сразу же возвращается обратно с той же скоростью.\nЧерез сколько времени t после получения поручения он вернулся обратно?";
        }

        public void solution()
        {
            if (l > 0 && v1 > 0 && v2 > 0)
                res = (l / (v1 + v2) + l / (v2 - v1)) * 3600;
            else
                res = -1;
        }
    }
}
