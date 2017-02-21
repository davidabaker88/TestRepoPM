using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGAME
{
    class JungleArea
    {
         public string type;
        public List<string> monsterType;
        public Random rand;

        public JungleArea()
        {
            type = "Jungle";
            rand = new Random();
            monsterType = new List<string>{"yay","yay@"};

        }
        public Enemy EnemyEncounter()
        {
            int monsterIndex = rand.Next(3);
            int health;
            int strength;
            int defence;
            if (monsterType[monsterIndex] == "Giant Scorpion")
            {
                health = 20;
                strength = 50;
                defence = 4;
            }
            else if (monsterType[monsterIndex] == "Mr. Baker")
            {
                health = 100;
                strength = 1;
                defence = 1000;
            }
            else 
            {
                health = 30;
                strength = 40;
                defence = 30;
            }
            Enemy newEnemy = new Enemy(health,strength,defence,monsterType[monsterIndex]);
            return newEnemy;
        } 
    }
}
