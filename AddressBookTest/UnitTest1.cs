using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddressBookUsing_ADO.Net;

namespace AddressBookTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AddressBook addressBook = new AddressBook();
            AddressBookModel model = new AddressBookModel();

            model.FirstName = "Shantanu";
            model.LastName = "Borkar";
            model.Address = "007 - Walls street";
            model.City = "Austin";
            model.State = "Texas";
            model.ZipCode = "73301";
            model.PhoneNumber = "1122334455";
            model.EmailId = "Shantanu@xyz.com";

            var result = addressBook.AddContacts(model);
            Assert.IsTrue(result);
        }
    }
}
