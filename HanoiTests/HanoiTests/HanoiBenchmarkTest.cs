using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Hanoi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiTests {
    [MemoryDiagnoser]
    [RankColumn]
    public class HanoiBenchmarkTest {
        private readonly HanoiTower _HanoiTower = new HanoiTower();

        [Benchmark]
        public void HanoiBenchmarkTestWithoutError() {
            _HanoiTower.HanoiTowers(4, 1, 2, 3);
        }

        [Benchmark]
        public void HanoiBenchmarkTestWithError() {
            _HanoiTower.HanoiTowers(4, 1, 6, 3);
        }
    }
}
