using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj3
{
    internal class Wolfman : Wolf, IPerson
    {

        public Wolfman(string name, int age, int weight, int teeth) : base(name, age, weight, teeth)
        {
        }
        public string Talk()
        {
            return "I am a wolfman!";
        }

        public override void DoSound()
        {
            Console.WriteLine("Wolfman sound");
        }

        // 13. I Bird klassen
        // 14. I Animal klassen
    }
}
