﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FirstTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
            //test from vs 
            //test from aws
            Assert.AreEqual(2, 2);
        }
    }
}
