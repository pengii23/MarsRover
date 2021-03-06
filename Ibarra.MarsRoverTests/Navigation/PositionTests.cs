﻿using System;
using Ibarra.MarsRover.Navigation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ibarra.MarsRoverTests.Navigation {
    [TestClass]
    public class PositionTests {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PositionTest_InvalidX() {
            var position = new Position(-1, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PositionTest_InvalidY() {
            var position = new Position(5, -2);
        }
    }
}