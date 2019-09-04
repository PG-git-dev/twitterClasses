using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using twitterClasses;//чтобы подключить этот проект нужно сначала добавить на него ссылку из текущего UnitTestProject1

namespace UnitTestProject1
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void RightCutTest()//обрезание строки, где оно нужно
        {
            var res = StringHelper.Cut("В связи с нестабильностью национальной валюты Украины просим провести денежную реформу, заменив национальную валюту Украины гривну на более стабильную — доллар США с пересчетом цен, тарифов, окладов заработной платы, стипендий, пенсий, средств на счетах предприятий, учреждений и организаций, а также вкладов граждан", 140);
            Assert.AreEqual("В связи с нестабильностью национальной валюты Украины просим провести денежную реформу, заменив национальную валюту Украины гривну на более ", res);
        }
        [TestMethod]
        public void RightNotCutTest()//обрезание строки, где оно не нужно
        {
            var res = StringHelper.Cut("В связи с нестабильностью", 140);
            Assert.AreEqual("В связи с нестабильностью", res);
        }
        [TestMethod]
        public void RightCutEmpyStringTest()//обрезание пустой строки
        {
            var res = StringHelper.Cut(String.Empty, 140);
            Assert.AreEqual(String.Empty, res);
        }
        [TestMethod]
        public void RightCutNullStringTest()//обрезание не понятно чего
        {
            var res = StringHelper.Cut(null, 140);
            Assert.IsNull(res);
        }
        [TestMethod]
        public void RightCutLimNullTest()//при обрезании до 0 символов
        {
            var res = StringHelper.Cut("В связи с нестабильностью", 0);
            Assert.AreEqual(String.Empty, res);
        }
    }
}
