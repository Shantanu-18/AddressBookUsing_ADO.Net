using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddressBookUsing_ADO.Net;

namespace AddressBookTest
{
    [TestClass]
    public class UnitTest1
    {
        AddressBook addressBook = new AddressBook();
        AddressBookModel model = new AddressBookModel();

        [TestMethod]
        public void AddingContactShouldReturnTrue()
        {
            model.FirstName = "Tom";
            model.LastName = "Cruse";
            model.Address = "007 - Breakers street";
            model.City = "Vegas";
            model.State = "Texas";
            model.ZipCode = "73301";
            model.PhoneNumber = "1122334455";
            model.EmailId = "007@xyz.com";

            var result = addressBook.AddContacts(model);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UpdatingContactShouldReturnTrue()
        {
            model.FirstName = "Tom";
            model.LastName = "Holland";
            model.Address = "Cental park";
            model.City = "New york";
            model.State = "New york";
            model.ZipCode = "668899";
            model.PhoneNumber = "8888888888";
            model.EmailId = "spider@xyz.com";

            var result = addressBook.EditContact(model);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DelectingContactShouldReturnTrue()
        {
            model.FirstName = "Tony";
            model.LastName = "Cruse";
            model.Address = "007 - Breakers street";
            model.City = "Vegas";
            model.State = "Mexico";
            model.ZipCode = "771122";
            model.PhoneNumber = "6699332211";
            model.EmailId = "007@xyz.com";

            var result = addressBook.DeleteContact(model);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GivenCityOrStateShouldReturnDataIfFound()
        {
            var result = addressBook.DisplayByCityOrState(model);
            Assert.IsNotNull(result);
        }
    }
}
