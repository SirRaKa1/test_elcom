using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_elcom
{
    internal class Tamagotchi
    {
        public Tamagotchi(string name)
        {
            Name = name;
            Health = 10;
            Happiness = 5;
            Hunger = 0;
            Tiredness = 0;
        }


        public string Name;

        public int Health;

        public int Happiness;

        public int Hunger;

        public int Tiredness;

        public string  ToString(String state)
        {
            StringBuilder s = new(Name);
            s.AppendLine("\n\n" + state)
                .AppendLine("\n\nHealth")
                .AppendLine(StatBar(Health))
                .AppendLine("Happiness")
                .AppendLine(StatBar(Happiness))
                .AppendLine("Hunger")
                .AppendLine(StatBar(Hunger))
                .AppendLine("Tiredness")
                .AppendLine(StatBar(Tiredness));
            return s.ToString();
        }

        private string StatBar(int x)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < x; i++) { sb.Append("#"); }
            for (int i = x; i<10; i++) { sb.Append('_'); }
            return sb.ToString();
        }

        public void Sleep()
        {
            Health++;
            if (Health > 10) { Health = 10; }
            Tiredness = 0;
            Hunger++;
            Hunger = UpCheck(Hunger);
            Happiness -= 3;
            Happiness = DownCheck(Happiness);
        }

        public void Feed()
        {
            Tiredness++;
            Tiredness = UpCheck(Tiredness);
            Hunger -= 5;
            Hunger = DownCheck(Hunger);
            Happiness -= 2;
            Happiness = DownCheck(Happiness);
        }

        public void Play()
        {
            Tiredness += 3;
            Tiredness = UpCheck(Tiredness);
            Hunger += 3;
            Hunger = UpCheck(Hunger);
            Happiness += 5;
            if(Happiness > 10) {  Happiness = 10; }
        }

        public void Heal()
        {
            Health = 10;
            Hunger += 5;
            Tiredness += 5;
            Happiness -= 5;
            if ((Tiredness > 10) && (Hunger > 10) && (Happiness < 10)) { Health = 0; }
            if (Hunger > 10) { Hunger = 10; }
            if (Tiredness > 10) { Tiredness = 10; }
            if(Happiness < 0) { Happiness = 0; }
        }

        private int DownCheck(int x)
        {
            if (x < 0)
            {
                Health -= 3;
                x = 0;
            }
            return x;

        }

        private int UpCheck(int x)
        {
            if (x > 10)
            {
                Health -= 3;
                x= 10;
            }
            return x;
                
        }
    }
}
