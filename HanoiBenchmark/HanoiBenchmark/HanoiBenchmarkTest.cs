using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hanoi;

namespace HanoiBenchmark {
    [MemoryDiagnoser]
    [RankColumn]
    public class HanoiBenchmarkTest {
        [Params(5,10,15,20)]
        public byte N;
        private readonly HanoiTower _HanoiTower = new HanoiTower();

        [Benchmark]
        public void HanoiBenchmarkTestWithoutError() {
            _HanoiTower.HanoiTowers(N, 1, 2, 3);
        }
    }
}
