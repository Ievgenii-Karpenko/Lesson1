using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    public class Sniper : Player
    {
        public int ZoomLevel = 1;

        public Sniper()
        {
            IsSniper = true;
        }

        public Sniper(string name, int hp)// : base(name, hp)
        {
            Console.WriteLine("--- Sniper c-tor  ------");
        }

        public void ShowIsSniper()
        {
            Console.WriteLine("Is sniper: " + IsSniper);
        }

        public override void ShowInfo()
        {
            string result = "";
            result += GetInfo();
            result += "Zoom Level: " + ZoomLevel;

            Console.WriteLine(result);
        }

        public new void VirtulaMethod()
        {
            Console.WriteLine("Inside class Sniper");
        }
    }
}
