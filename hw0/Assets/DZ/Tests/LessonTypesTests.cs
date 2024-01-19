using System;
using NUnit.Framework;
using static Sample.LessonTypes;

namespace Tests
{
    [TestFixture]
    public sealed class LessonTypesTests
    {
        [Test]
        public void SqrTest()
        {
            Assert.AreEqual(0, Sqr(0));
            Assert.AreEqual(4, Sqr(2));
            Assert.AreEqual(9, Sqr(-3));
        }

        [Test]
        public void DiscriminantTest()
        {
            Assert.AreEqual(0.0, Discriminant(0.0, 0.0, 0.0), 1e-13);
            Assert.AreEqual(0.0, Discriminant(1.0, -2.0, 1.0), 1e-13);
            Assert.AreEqual(1.0, Discriminant(1.0, 3.0, 2.0), 1e-13);
        }

        [Test]
        public void QuadraticEquationRootTest()
        {
            Assert.AreEqual(2.0, QuadraticEquationRoot(1.0, -3.0, 2.0), 1e-13);
            Assert.AreEqual(1.0, QuadraticEquationRoot(1.0, -2.0, 1.0), 1e-13);
            Assert.AreEqual(-3.0, QuadraticEquationRoot(1.0, 6.0, 9.0), 1e-13);
        }

        [Test]
        public void QuadraticRootProductTest()
        {
            Assert.AreEqual(1.0, QuadraticRootProduct(1.0, -2.0, 1.0), 1e-13);
            Assert.AreEqual(9.0, QuadraticRootProduct(1.0, 6.0, 9.0), 1e-13);
            Assert.AreEqual(2.0, QuadraticRootProduct(1.0, 3.0, 2.0), 1e-13);
        }

        [Test]
        public void TotalSecondsTest()
        {
            Assert.AreEqual(30035, TotalSeconds(8, 20, 35));
            Assert.AreEqual(86400, TotalSeconds(24, 0, 0));
            Assert.AreEqual(13, TotalSeconds(0, 0, 13));
        }

        [Test]
        public void LengthInMetersTest()
        {
            Assert.AreEqual(18.98, LengthInMeters(8, 2, 11), 1e-2);
            Assert.AreEqual(2.13, LengthInMeters(1, 0, 0), 1e-2);
        }

        [Test]
        public void AngleToRadianTest()
        {
            Assert.AreEqual(0.63256, AngleToRadian(36, 14, 35), 1e-5);
            Assert.AreEqual(Math.PI / 2.0, AngleToRadian(90, 0, 0), 1e-5);
        }

        [Test]
        public void SegmentLengthTest()
        {
            Assert.AreEqual(5.0, SegmentLength(3.0, 0.0, 0.0, 4.0), 1e-5);
            Assert.AreEqual(1.0, SegmentLength(0.0, 1.0, -1.0, 1.0), 1e-5);
            Assert.AreEqual(1.41, SegmentLength(1.0, 1.0, 2.0, 2.0), 1e-2);
        }

        [Test]
        public void GetThirdDigitTest()
        {
            Assert.AreEqual(8, GetThirdDigit(3801));
            Assert.AreEqual(1, GetThirdDigit(100));
            Assert.AreEqual(0, GetThirdDigit(1000));
        }

        [Test]
        public void TravelMinutesTest()
        {
            Assert.AreEqual(216, TravelMinutes(9, 25, 13, 1));
            Assert.AreEqual(1, TravelMinutes(21, 59, 22, 0));
        }

        [Test]
        public void CalcMoneyTest()
        {
            Assert.AreEqual(110.0, CalcMoney(100, 10, 1), 1e-2);
            Assert.AreEqual(1.0, CalcMoney(1, 0, 5), 1e-2);
            Assert.AreEqual(104.0, CalcMoney(13, 100, 3), 1e-2);
        }

        [Test]
        public void RevertNumberTest()
        {
            Assert.AreEqual(874, RevertNumber(478));
            Assert.AreEqual(201, RevertNumber(102));
        }
    }
}