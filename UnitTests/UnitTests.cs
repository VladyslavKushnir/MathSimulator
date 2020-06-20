using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathSimulator;

namespace UnitTests
{
    
    [TestClass]
    public class UnitTest
    {
        MainMethods mm = new MainMethods();
        /// <summary>
        /// 10+40=50
        /// </summary>
        [TestMethod]
        public void TestMethodAdd1()
        {
            int a=10, b=40, exp=50;
            int res =  mm.Addition(a, b);
            Assert.AreEqual(exp, res);
        }
        /// <summary>
        /// -40+40=0
        /// </summary>
        [TestMethod]
        public void TestMethodAdd2()
        {
            int a = -40, b = 40, exp = 0;
            int res = mm.Addition(a, b);
            Assert.AreEqual(exp, res);
        }
        /// <summary>
        /// 10-40=-30
        /// </summary>
        [TestMethod]
        public void TestMethodDiff1()
        {
            int a = 10, b = 40, exp = -30;
            int res = mm.Difference(a, b);
            Assert.AreEqual(exp, res);
        }
        /// <summary>
        /// 40-10=30
        /// </summary>
        [TestMethod]
        public void TestMethodDiff2()
        {
            int a = 40, b = 10, exp = 30;
            int res = mm.Difference(a, b);
            Assert.AreEqual(exp, res);
        }
        /// <summary>
        /// 40*10=400
        /// </summary>
        [TestMethod]
        public void TestMethodMul1()
        {
            int a = 40, b = 10, exp = 400;
            int res = mm.Multiplication(a, b);
            Assert.AreEqual(exp, res);
        }
        /// <summary>
        /// -40*10=-400
        /// </summary>
        [TestMethod]
        public void TestMethodMul2()
        {
            int a = -40, b = 10, exp = -400;
            int res = mm.Multiplication(a, b);
            Assert.AreEqual(exp, res);
        }
        /// <summary>
        /// 40/10=4
        /// </summary>
        [TestMethod]
        public void TestMethodDiv1()
        {
            int a = 40, b = 10, exp = 4;
            int res = mm.Division(a, b);
            Assert.AreEqual(exp, res);
        }
        /// <summary>
        /// -40/10=-4
        /// </summary>
        [TestMethod]
        public void TestMethodDiv2()
        {
            int a = -40, b = 10, exp = -4;
            int res = mm.Division(a, b);
            Assert.AreEqual(exp, res);
        }
        /// <summary>
        /// 80>40
        /// </summary>
        [TestMethod]
        public void TestMethodComp1()
        {
            int a = 80, b = 40, exp = 0;
            int res = mm.Comparsion(a, b);
            Assert.AreEqual(exp, res);
        }
        /// <summary>
        /// 40<80
        /// </summary>
        [TestMethod]
        public void TestMethodComp2()
        {
            int a = 40, b = 80, exp = 1;
            int res = mm.Comparsion(a, b);
            Assert.AreEqual(exp, res);
        }
        /// <summary>
        /// 80=80
        /// </summary>
        [TestMethod]
        public void TestMethodComp3()
        {
            int a = 80, b = 80, exp = 2;
            int res = mm.Comparsion(a, b);
            Assert.AreEqual(exp, res);
        }

    }
}
