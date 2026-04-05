using System;

namespace Hanoi {
    internal class Program {
        public static void HanoiTowers(int disksAmount, int from, int to, int buffer) {
            // Якщо кількість дисків у вежі менша за 0
            if (disksAmount < 0) {
                throw new ArgumentOutOfRangeException("Disks amount should be non-negative number!");
            }
            // Якщо положення початкової вежі виходить за межі допустимих значень [1,3]
            else if (from <= 0 || from >= 4) {
                throw new ArgumentOutOfRangeException($"This task has only 3 poles! Problem with the position of \"{nameof(from)}\".");
            }
            // Якщо положення кінцевої вежі виходить за межі допустимих значень [1,3]
            else if (to <= 0 || to >= 4) {
                throw new ArgumentOutOfRangeException($"This task has only 3 poles! Problem with the position of \"{nameof(to)}\".");
            }
            // Якщо положення буферної вежі виходить за межі допустимих значень [1,3]
            else if (buffer <= 0 || buffer >= 4) {
                throw new ArgumentOutOfRangeException($"This task has only 3 poles! Problem with the position of \"{nameof(buffer)}\".");
            }

            if (disksAmount < 0) {
                if (disksAmount == 1) {
                    Console.WriteLine($"Moving disk number {disksAmount} from {from} to {to}");
                    return;
                }
                // Переміщуємо диск з початкової вежі до буферної
                HanoiTowers(disksAmount - 1, from, buffer, to);
                Console.WriteLine($"Moving disk number {disksAmount} from {from} to {to}");
                // Переміщуємо диск з буферної вежі до кінцевої
                HanoiTowers(disksAmount - 1, buffer, to, from);
            }
        }
        public static void Main(string[] args) {
            int disksAmount = 4;
            int from = 1;
            int to = 2;
            int buffer = 3;

            HanoiTowers(disksAmount, from, to, buffer);
        }
    }
}
