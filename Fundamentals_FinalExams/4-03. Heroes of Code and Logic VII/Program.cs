using System;
using System.Collections.Generic;

namespace _4_03._Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());

            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();

            for (int i = 1; i <= numberOfHeroes; i++)
            {
                string[] hero = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = hero[0];
                double hp = double.Parse(hero[1]);
                double mp = double.Parse(hero[2]);

                heroes.Add(name, new Hero(hp, mp));
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "End")
                {
                    break;
                }

                switch (command[0])
                {
                    case "CastSpell":
                        CastCommand(heroes, command);
                        break;
                    case "TakeDamage":
                        TakeCommand(heroes, command);
                        break;
                    case "Recharge":
                        RechargeCommand(heroes, command);
                        break;
                    case "Heal":
                        HealCommand(heroes, command);
                        break;
                }
            }

            foreach (var hero in heroes)
            {
                Console.WriteLine($"{hero.Key}");
                Console.WriteLine($"  HP: {hero.Value.HP}");
                Console.WriteLine($"  MP: {hero.Value.MP}");
            }
        }

        private static void HealCommand(Dictionary<string, Hero> heroes, string[] command)
        {
            string name = command[1];
            double hp = double.Parse(command[2]);
            if (heroes[name].HP + hp > 100)
            {
                double usedHp = 100 - heroes[name].HP;
                heroes[name].HP = 100;
                Console.WriteLine($"{name} healed for {usedHp} HP!");
            }
            else
            {
                heroes[name].HP += hp;
                Console.WriteLine($"{name} healed for {hp} HP!");
            }
        }

        private static void RechargeCommand(Dictionary<string, Hero> heroes, string[] command)
        {
           string name = command[1];
           double mp = double.Parse(command[2]);
           if (heroes[name].MP + mp > 200)
           {
               double usedMp = 200 - heroes[name].MP;
               heroes[name].MP = 200;
               Console.WriteLine($"{name} recharged for {usedMp} MP!");
           }
           else
           {
               heroes[name].MP += mp;
               Console.WriteLine($"{name} recharged for {mp} MP!");
           }
        }

        private static void TakeCommand(Dictionary<string, Hero> heroes, string[] command)
        {
            string name = command[1];
            double damage = double.Parse(command[2]);
            string attacker = command[3];
            if (heroes[name].HP <= damage)
            {
                Console.WriteLine($"{name} has been killed by {attacker}!");
                heroes.Remove(name);
            }
            else
            {
                heroes[name].HP -= damage;
                Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {heroes[name].HP} HP left!");
            }
        }

        private static void CastCommand(Dictionary<string, Hero> heroes, string[] command)
        {
           string name = command[1];
           double mp = double.Parse(command[2]);
           string spell = command[3];

           if (heroes[name].MP >= mp)
           {
               heroes[name].MP -= mp;
               Console.WriteLine($"{name} has successfully cast {spell} and now has {heroes[name].MP} MP!");
           }
           else
           {
               Console.WriteLine($"{name} does not have enough MP to cast {spell}!");
           }
        }
    }

    class Hero
    {
        public Hero(double hp, double mp)
        {
            HP = hp;
            MP = mp;
        }
        public double HP { get; set; }
        public double MP { get; set; }
    }
}
