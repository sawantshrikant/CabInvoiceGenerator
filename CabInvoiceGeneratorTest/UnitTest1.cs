using CabInvoiceGeneratorDemo;

namespace CabInvoiceGeneratorTest
{
    public class Tests
    {
        private CabInvoiceGenerator cabInvoice;
        [SetUp]
        public void Setup()
        {
            this.cabInvoice = new CabInvoiceGenerator();
        }

        [Test]
        public void GivenDistanceAndTime_WhenProper_ShouldReturnFare()
        {
            double totalFare = this.cabInvoice.CalculateFare(3.0, 5.0);
            Assert.AreEqual(35.0, totalFare);
        }
    }
}