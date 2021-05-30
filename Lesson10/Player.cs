using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    public class Player
    {
        // public
        // private
        // protected
        // internal
        private string _name = "asdasd";
        private int _hp;
        public List<string> Weapon = new List<string>();

        protected bool IsSniper = false;

        //public string GetName()
        //{
        //    return _name;
        //}

        //public void SetName(string name)
        //{
        //    _name = name;
        //}

        public bool IsAlive { get; set; } = true;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int HP
        {
            get => _hp;
            set
            {
                if (value < 0)
                {
                    _hp = 0;
                    IsAlive = false;
                }
                else if (value > 100)
                {
                    _hp = 100;
                }
                else
                {
                    _hp = value;
                }
            }
        }

        public Player()
        {
            Console.WriteLine("--- Player c-tor  ------");
            _name = "Unknown";
            _hp = 0;
        }

        public Player(string Name, int HP)
        {
            Console.WriteLine("--- Player c-tor  ------");
            this.Name = Name;
            this.HP = HP;
            Weapon = new List<string>();
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine(GetInfo());
        }

        public virtual void VirtulaMethod()
        {
            Console.WriteLine("Inside class Player");
        }

        protected string GetInfo()
        {
            string result = "";
            result += $"Name: {_name}, Hp: {_hp}" + "\n";
            result += "List of weapons:\n";
            //result += "Zoom Level" + ZoomLevel;
            foreach (var item in Weapon)
            {
                result += item + "\n";
            }

            return result;
        }

        public void SaveToPC()
        {
            File.WriteAllText(@"C:\test\Player.txt", GetInfo());
        }

    }
}
