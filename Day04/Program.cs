using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class Program
    {
        static void Main(string[] args)
        {
            Player[] players = new Player[2];
            players[0] = new Player();
            players[0].id = "Otang";
            players[0].name = "오태진";
            players[0].hp = 100;
            players[0].attack = 10;
            players[0].moveSpeed = 1.0f;

            players[1] = new Player();
            players[1].id = "Park";
            players[1].name = "박재환";
            players[1].hp = 50;
            players[1].attack = 12;
            players[1].moveSpeed = 1.6f;


            Slime[] slimes = new Slime[3];
            slimes[0] = new Slime();
            slimes[0].name = "Slime00";
            slimes[0].hp = 10;
            slimes[0].attack = 5;
            slimes[0].moveSpeed = 0.8f;
            
            slimes[1] = new Slime();
            slimes[1].name = "Slime01";
            slimes[1].hp = 10;
            slimes[1].attack = 5;
            slimes[1].moveSpeed = 0.8f;
            
            slimes[2] = new Slime();
            slimes[2].name = "Slime02";
            slimes[2].hp = 10;
            slimes[2].attack = 5;
            slimes[2].moveSpeed = 0.8f;

            Goblin[] goblins = new Goblin[2];
            goblins[0] = new Goblin();
            goblins[0].name = "Slime00";
            goblins[0].hp = 10;
            goblins[0].attack = 5;
            goblins[0].moveSpeed = 0.8f;




            players[0].Move();

        }

    } 
}
