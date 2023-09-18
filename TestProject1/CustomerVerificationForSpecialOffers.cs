using Á‡‰‡ÌËÂ_1;
using Á‡‰‡ÌËÂ3;
using Á‡‰‡˜‡_2;
using System;

namespace TestProject1.Test
{
  public class Tests
    {
        [TestCase(3, 1000001, 61, true)]
        [TestCase(5, 500000, 50, false)]
        [TestCase(5, 500000, 61, true)]
        public static void AreOffersAvailable(int bankProductsAmount, int totalMoney, int age, bool expected)
        {
            bool actual = Library.AreOffersAvailable(bankProductsAmount, totalMoney, age);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(1 ,1000, 10, 1100)]
        [TestCase(6, 5000, 6, 7091)]
        [TestCase(10, 1000, 10, 2591)]
        [TestCase(8, 10000, 9, 19923)]
        public static void AmountOfSavings(int durationYears, int sum, int percent, int expected)
        {
            int actual = Calculate≈TheSizeOfBankDeposit.AmountOfSavings(durationYears, sum, percent);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(2800, 6)]
        [TestCase(47000, 47)]
        [TestCase(100, 1)]
        [TestCase(2350, 5)]
        public static void OptimalNumberBanknotes(int money,int expected)
        {
            int actual = —ountingBanknotesByAutomat.OptimalNumberBanknotes(money);

            Assert.AreEqual(expected,actual); 
        }
        [Test]
        public void AreOffersAvailableTest_WhenBankProdAmountAndAgeAreNegative_ShouldArgumentException()
        {
            int bankProductsAmount = -1;
            int totalMoney = 700000;
            int age = 61;

            Assert.Throws<ArgumentException>(() => Library.AreOffersAvailable(bankProductsAmount, totalMoney, age));
        }

        [Test]
        public void AmountOfSavingsTest_WhenTheParametersAreNegative_ShouldArgumentException()
        {
            int durationYears = -3;
            int sum = -6;
            int percent = -1;

            Assert.Throws<ArgumentException>(() => Calculate≈TheSizeOfBankDeposit.AmountOfSavings(durationYears, sum, percent));
        }
        [Test]
        public void OptimalNumberBanknotesTest_WhenMoneyIsNegative_ShouldArgumentException()
        {
            int money = -2;
            Assert.Throws<ArgumentException>(() => —ountingBanknotesByAutomat.OptimalNumberBanknotes(money));
        }


    }
    
}