using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategyPattern.StrategyAlgorithms;

namespace StrategyPattern.Test;

[TestClass]
public class WalkAlgorithmTests
{
    [TestMethod]
    public void WhenWalkingFromAtoD_IshouldGetAValidRoute()
    {
        //Arrange
        WalkAlgorithm algorithm = new WalkAlgorithm();
        string from = "A";
        string to = "D";
        string path = "A,B,C,D";

        //Act
        var route = algorithm.execute(from,to);

        //Assert
        Assert.IsNotNull(route);
        Assert.AreEqual(path, route.RoutePath);
    }

    [TestMethod]
    public void WhenWalkingStreightandBack_IshouldGetAValidRoute()
    {
        //Arrange
        WalkAlgorithm algorithm = new WalkAlgorithm();
        string from = "Abcd";
        string to = "Dcba";
        string path = "Abcd,Bbc,Cda,Dcba";
        string pathBack = "Dcba,Cda,Bbc,Abcd";

        //Act
        var route = algorithm.execute(from,to);
        var routeBack = algorithm.execute(to,from);

        //Assert
        Assert.IsNotNull(route);
        Assert.AreEqual(path, route.RoutePath);
        
        Assert.IsNotNull(routeBack);
        Assert.AreEqual(pathBack, routeBack.RoutePath);
    }
}    