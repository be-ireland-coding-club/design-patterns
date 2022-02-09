using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategyPattern.StrategyAlgorithms;
using System;

namespace StrategyPattern.Test.StrategyAlgorithms
{
    [TestClass]
    public class BicycleAlgorithmTests
    {
        [TestMethod]
        public void WhenCallingBicycleStrategy_ShouldHaveNotImplementedException()
        {
            //Arrange
            BicycleAlgorithm algorithm = new BicycleAlgorithm();
            string from = "A";
            string to = "D";
            string exMessage ="The BicycleAlgorithm strategy is not implemented yet!";

            try{
                //Act
                var route = algorithm.execute(from,to);
            }
            catch(NotImplementedException ex){
                //Assert
                Assert.IsNotNull(ex);
                Assert.AreEqual(exMessage, ex.Message);
            }
        }        
    }
}