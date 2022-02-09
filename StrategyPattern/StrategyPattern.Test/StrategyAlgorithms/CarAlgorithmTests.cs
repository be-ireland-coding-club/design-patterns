using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategyPattern.StrategyAlgorithms;
using System;

namespace StrategyPattern.Test.StrategyAlgorithms
{
    [TestClass]
    public class CarAlgorithmTests
    {
        [TestMethod]
        public void WhenDrivingOnValidMapPoints_IshouldGetAValidRoute()
        {
            //Arrange
            CarAlgorithm algorithm = new CarAlgorithm();
            string from = "Dublin";
            string to = "Donegal";
            string path = "Dublin,Cavan,Donegal";

            //Act
            var route = algorithm.execute(from,to);

            //Assert
            Assert.IsNotNull(route);
            Assert.AreEqual(path, route.RoutePath);
        }

        [TestMethod]
        public void WhenDrivingStreightandBack_IshouldGetOnlyStreightRoute()
        {
            //Arrange
            CarAlgorithm algorithm = new CarAlgorithm();
            string from = "Abc";
            string to = "Ddd";
            string path = "Abc,Bb,Cc,Ddd";
            string exMessage = $"There is no Known route between the given points: {to} .. to .. {from}";

            //Act
            var route = algorithm.execute(from,to);
            var routeBackMessageEx = string.Empty;
            try{
                var routeBack = algorithm.execute(to,from);
            }
            catch(EntryPointNotFoundException ex)
            {
                routeBackMessageEx = ex.Message;
            }

            //Assert
            Assert.IsNotNull(route);
            Assert.AreEqual(path, route.RoutePath);
            
            Assert.AreEqual(exMessage, routeBackMessageEx);
        }           
    }
}