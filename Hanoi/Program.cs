using System;

namespace Hanoi {
    internal class Program {
        static void Main(string[] args) {
            byte disksAmount = 4;
            byte from = 1;
            byte to = 2;
            byte buffer = 3;
            HanoiTower tower = new HanoiTower();

            tower.HanoiTowers(disksAmount, from, to, buffer);


        }
    }
}
