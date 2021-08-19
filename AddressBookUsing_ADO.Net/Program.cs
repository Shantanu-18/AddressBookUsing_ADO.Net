using System;

namespace AddressBookUsing_ADO.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to Address Book!");

            AddressBook addressBook = new AddressBook();
            AddressBookModel model = new AddressBookModel();
            addressBook.DisplayByCityOrState(model);
        }
    }
}
