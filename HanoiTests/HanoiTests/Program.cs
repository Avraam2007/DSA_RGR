using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiTests {
    internal class Program {
        static void Main(string[] args) {
            BenchmarkRunner.Run<HanoiBenchmarkTest>();
        }
    }
}
