using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Sourcetest;

namespace ConsoleApp2
{
       [TestFixture]
    class Tests
    {   
        [Test]
        public void Title_init()
        { var x = new Book("bla",0,Currency.USD,"1","");
            String title = x.Title;
            Assert.IsTrue(String.Compare(title, "bla")==0);
        }
        [Test]
        public void Currency_init()
        {
            var x = new Book("bla", 0, Currency.USD,"1","");
            var y = new Book("bla", 0, Currency.EUR,"1","");

            Assert.IsTrue(x.GetCurrency() == Currency.USD);
            Assert.IsTrue(y.GetCurrency() == Currency.EUR);
        }
        [Test]
        public void Price_init()
        {
            var x = new Book("bla", 12.23, Currency.USD,"1","");
            

            Assert.IsTrue(x.Price == 12.23);  
        }
        [Test]
        public void Price_positive()
        {
            Assert.Catch(() =>
            {
                var x = new Book("bla", -12.23, Currency.USD,"1","");
            });  
        }
        [Test]
        public void ISBN_init()
        {
            var x = new Book("bla", 0,Currency.EUR, "1234567","");
            String isb = x.GetISBN();
            Assert.IsTrue(String.Compare(isb,"1234567")==0);
        }
        [Test]
        public void ISBN_empty()
        {
            Assert.Catch(() =>
            {
                var x = new Book("bla", 12.23, Currency.USD, "","");
            });
        }
        [Test]
        public void Title_empty()
        {
            Assert.Catch(() =>
            {
                var x = new Book("", 12.23, Currency.USD, "","");
            });
        }
        [Test]
        public void Author_init()
        {
            var x = new Book("bla", 0, Currency.EUR, "1234567","olaf");
            String aut = x.GetAuthor();
            Assert.IsTrue(String.Compare(aut, "olaf") == 0);
        }
    }
}
