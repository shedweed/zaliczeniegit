using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TestJednostkowy
{
    [TestFixture]
    public class Class1
    {
        //[Test]
        public int poleKwadratu(int a)
        {
            return a * a;
        }

        public double poleOkregu(double r)
        {
            return 2 * 3.14 * r;
        }

        public int poleProstokatu(int a, int b)
        {
            return a * b;
        }

        public int poleTrojkat(int a, int h)
        {
            if (a < 0 || h < 0)
            {
                return -1;
            }
            else
            {
                return (a * h) / 2;
            }
        }

        [Test]
        public void sprawadzanieTR()
        {
            //poleTrojkat(5, -5);
            Assert.AreEqual(12, poleTrojkat(5, 5));
        }

        [Test]
        public void sprawadzanieOK()
        {
            poleOkregu(5);
        }

        [Test]
        public void sprawadzaniePR()
        {
            poleProstokatu(5, 5);
        }

        [Test]
        public void sprawadzanieKW()
        {
            poleKwadratu(5);
        }

    }
}
