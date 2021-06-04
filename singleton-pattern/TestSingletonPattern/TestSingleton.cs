using NUnit.Framework;
using SingletonPattern;
using System.Threading.Tasks;

namespace TestSingletonPattern
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NaiveSingletonPatternTest()
        {
            //Arrange
            PrinterNaive firstPrinterObject = null;
            PrinterNaive secondPrinterObject = null;
            PrinterNaive thirdPrinterObject = null;

            //Act
            Task task1 = Task.Factory.StartNew(() => {
                firstPrinterObject = InitializePrinterNaiveObjectAndAddDocument("First", "First-Document");
            });
            Task task2 = Task.Factory.StartNew(() => {
                secondPrinterObject = InitializePrinterNaiveObjectAndAddDocument("Second", "Second-Document");
            });
            Task task3 = Task.Factory.StartNew(() => {
                thirdPrinterObject = InitializePrinterNaiveObjectAndAddDocument("Third", "Third-Document");
            });
            Task.WaitAll(task1, task2, task3);

            //Assert
            Assert.IsTrue(firstPrinterObject.Equals(secondPrinterObject));
            Assert.IsTrue(firstPrinterObject.Equals(thirdPrinterObject));
            Assert.IsTrue(thirdPrinterObject.Equals(secondPrinterObject));
        }

        [Test]
        public void ThreadSafeSingletonPatternTest()
        {
            //Arrange
            PrinterThreadSafe firstPrinterObject = null;
            PrinterThreadSafe secondPrinterObject = null;
            PrinterThreadSafe thirdPrinterObject = null;

            //Act
            Task task1 = Task.Factory.StartNew(() => {
                firstPrinterObject = InitializePrinterThreadSafeObjectAndAddDocument("First", "First-Document");
            });
            Task task2 = Task.Factory.StartNew(() => {
                secondPrinterObject = InitializePrinterThreadSafeObjectAndAddDocument("Second", "Second-Document");
            });
            Task task3 = Task.Factory.StartNew(() => {
                thirdPrinterObject = InitializePrinterThreadSafeObjectAndAddDocument("Third", "Third-Document");
            });
            Task.WaitAll(task1, task2, task3);

            //Assert
            Assert.IsTrue(firstPrinterObject.Equals(secondPrinterObject));
            Assert.IsTrue(firstPrinterObject.Equals(thirdPrinterObject));
            Assert.IsTrue(thirdPrinterObject.Equals(secondPrinterObject));
        }

        public PrinterNaive InitializePrinterNaiveObjectAndAddDocument(string instanceName, string documentName)
        {
            var printerObject = PrinterNaive.GetPrinterInstance(instanceName);
            printerObject.AddDocument(documentName);
            printerObject.PrintDocument();
            return printerObject;
        }

        public PrinterThreadSafe InitializePrinterThreadSafeObjectAndAddDocument(string instanceName, string documentName)
        {
            var printerObject = PrinterThreadSafe.GetPrinterInstance(instanceName);
            printerObject.AddDocument(documentName);
            printerObject.PrintDocument();
            return printerObject;
        }
    }
}