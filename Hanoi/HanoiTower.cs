using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi {
    public class HanoiTower {
        public void HanoiTowers(byte disksAmount, byte from, byte to, byte buffer) {
            if (disksAmount < 0) {
                throw new ArgumentOutOfRangeException("Disks amount should be non-negative number!");
            }
            else if (from <= 0 || from >= 4) {
                throw new ArgumentOutOfRangeException($"This task has only 3 poles! Problem with the position of \"{nameof(from)}\".");
            }
            else if (to <= 0 || to >= 4) {
                throw new ArgumentOutOfRangeException($"This task has only 3 poles! Problem with the position of \"{nameof(to)}\".");
            }
            else if (buffer <= 0 || buffer >= 4) {
                throw new ArgumentOutOfRangeException($"This task has only 3 poles! Problem with the position of \"{nameof(buffer)}\".");
            }
            
            if (disksAmount != 0) {
                HanoiTowers(Convert.ToByte(disksAmount - 1), from, buffer, to);
                Console.WriteLine($"Moving disk number {disksAmount} from {from} to {to}");
                HanoiTowers(Convert.ToByte(disksAmount - 1), buffer, to, from);
            }
        }
    }
}
