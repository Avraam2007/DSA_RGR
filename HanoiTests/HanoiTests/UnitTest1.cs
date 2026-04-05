using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Hanoi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Policy;

namespace HanoiTests {
    [TestClass]

    public class HanoiTests {
        private HanoiTower _HanoiTower;

        [TestInitialize]
        public void Setup() { 
            _HanoiTower = new HanoiTower();
        }

        [TestCleanup]
        public void Cleanup() { 
            _HanoiTower = null;
        }
        
        [TestMethod]
        public void HanoiTower_WithInvalidDisksNumber() {
            string expectedMessage = "Disks amount should be non-negative number!";
            var actual = Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
                _HanoiTower.HanoiTowers(-2, 3, 2, 1)
            );

            StringAssert.Contains(actual.Message, expectedMessage);
        }

        [TestMethod]
        public void HanoiTower_WithInvalidFromPole() {
            string expectedMessage = "This task has only 3 poles! Problem with the position of \"from\".";
            var actual = Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
                _HanoiTower.HanoiTowers(4, 9, 2, 1)
            );

            StringAssert.Contains(actual.Message, expectedMessage);
        }

        [TestMethod]
        public void HanoiTower_WithInvalidToPole() {
            string expectedMessage = "This task has only 3 poles! Problem with the position of \"to\".";
            var actual = Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
                _HanoiTower.HanoiTowers(4, 1, -8, 1)
            );

            StringAssert.Contains(actual.Message, expectedMessage);
        }

        [TestMethod]
        public void HanoiTower_WithInvalidBufferPole() {
            string expectedMessage = "This task has only 3 poles! Problem with the position of \"buffer\".";
            var actual = Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
                _HanoiTower.HanoiTowers(4, 1, 2, 8)
            );

            StringAssert.Contains(actual.Message, expectedMessage);
        }

        [TestMethod]
        public void HanoiTower_WithValidNumbers() {
            _HanoiTower.HanoiTowers(4, 1, 2, 3);
        }
    }
}