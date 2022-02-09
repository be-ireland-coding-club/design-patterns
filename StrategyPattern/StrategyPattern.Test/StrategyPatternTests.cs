using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StrategyPattern.Utils;

namespace StrategyPattern.Test;

[TestClass]
public class StrategyPatternTests
{
    [TestMethod]
    public void WhenGivenAValidWalkRouteTheClientShouldGetAResponse()
    {
        //Arrange
        Client c = new Client();
        Points p = new Points("Dundrum", "Clondalkin");
        string routePath = "something,something else";
        decimal budget = 5;
        decimal time = 30;

        //Act
            bool result = c.ResolveStrategy(TransportTypesEnum.Walk);
            Route resultRoute = c.ContextStrategy.ResolveRoute(p);

        //Assert
        Assert.IsTrue(result,"The strategy should be resolved");
        Assert.IsTrue(resultRoute!=null,"The route is null!");
        Assert.AreEqual(routePath,resultRoute.RoutePath);
        Assert.AreEqual(budget,resultRoute.Budget);
        Assert.AreEqual(time,resultRoute.TimeInMinutes);
    }

        [TestMethod]
    public void WhenGivenAnInvalidWalkRouteTheClientShouldGetAResponse()
    {
        //Arrange
        Client c = new Client();
        Points p = new Points("D", "C");

        //Act
        bool result = c.ResolveStrategy(TransportTypesEnum.Walk);
        Route resultRoute = c.ContextStrategy.ResolveRoute(p);

        //Assert
        Assert.IsTrue(result,"The strategy should be resolved");
        Assert.IsTrue(resultRoute==null,"The route is null!");
    }
    
    [TestMethod]
    public void WhenGivenABusRouteTheRouteIsNotImplemented()
    {
        //Arrange
        Client c = new Client();
        Points p = new Points("D", "C");

        //Act
        bool result = c.ResolveStrategy(TransportTypesEnum.Bus);
        Route resultRoute = c.ContextStrategy.ResolveRoute(p);

        //Assert
        Assert.IsTrue(result,"The strategy should be resolved");
        Assert.IsTrue(resultRoute==null,"The route is not implemented!");
    }

    [TestMethod]
    public void WhenGivenAnUnknownRouteTheStrategyIsNotImplemented()
    {
        //Arrange
        Client c = new Client();
        Points p = new Points("D", "C");

        //Act
        bool result = c.ResolveStrategy(TransportTypesEnum.Unknown);
        Route resultRoute = c.ContextStrategy.ResolveRoute(p);

        //Assert
        Assert.IsFalse(result,"The strategy can't be resolved, as the type is not resolved");
        Assert.IsTrue(c.ContextStrategy==null,"The client strategy is null!");
    }
}