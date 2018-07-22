using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiscountApplication_Thien;

namespace DiscountTestProject
{
    [TestClass]
    public class UnitTest1
    {
        #region Reg1

        [TestMethod]
        public void Req1_1_validInteger_InputPrice()
        {
            //step 1 - Arrange
            string inputPrice = "10";
            string discount = "10";
            string expetedResult = "9";
            string actualResult;

            //step 2 - Act
            actualResult = DiscountCalculator.calculate(inputPrice, discount);

            //step 3 - Assert
            Assert.AreEqual(expetedResult, actualResult);

        }

        [TestMethod]
        public void Req1_2_validInteger_InputDiscount()
        {
            //step 1 - Arrange
            string inputPrice = "50";
            string discount = "5";
            string expetedResult = "47.5";
            string actualResult;

            //step 2 - Act
            actualResult = DiscountCalculator.calculate(inputPrice, discount);

            //step 3 - Assert
            Assert.AreEqual(expetedResult, actualResult);

        }

        [TestMethod]
        public void Req1_3_validInteger_InputPrice()
        {
            //step 1 - Arrange
            string inputPrice = "125.50";
            string discount = "25";
            string expetedResult = "94.125"; //not now final $94.15
            string actualResult;

            //step 2 - Act
            actualResult = DiscountCalculator.calculate(inputPrice, discount);

            //step 3 - Assert
            Assert.AreEqual(expetedResult, actualResult);

        }

        [TestMethod]
        public void Req1_4_validInteger_InputDiscountZero()
        {
            //step 1 - Arrange
            string inputPrice = "50";
            string discount = "0";
            string expetedResult = "50";
            string actualResult;

            //step 2 - Act
            actualResult = DiscountCalculator.calculate(inputPrice, discount);

            //step 3 - Assert
            Assert.AreEqual(expetedResult, actualResult);

        }
        #endregion

        #region Reg2

        [TestMethod]
        public void Req2_1_InvalidString_InputPrice()
        {
            //step 1 - Arrange
            string inputPrice = "A";
            string discount = "20";
            string expetedResult = "Error - Enter Numbers Only";
            string actualResult;

            //step 2 - Act
            actualResult = DiscountCalculator.calculate(inputPrice, discount);

            //step 3 - Assert
            Assert.AreEqual(expetedResult, actualResult);

        }

        [TestMethod]
        public void Req2_2_InvalidString_InputDiscount()
        {
            //step 1 - Arrange
            string inputPrice = "50";
            string discount = "A";
            string expetedResult = "Error - Enter Numbers Only";
            string actualResult;

            //step 2 - Act
            actualResult = DiscountCalculator.calculate(inputPrice, discount);

            //step 3 - Assert
            Assert.AreEqual(expetedResult, actualResult);

        }
        #endregion
    }
}
