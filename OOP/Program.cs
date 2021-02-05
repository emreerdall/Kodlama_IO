using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.Name = "Engin";
            customer1.Surname = "Demiroğ";
            customer1.CitizenshipNo = "123456";
            customer1.CustomerNo = "123";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "321";
            customer2.CompanyName = "KodlamaIO";
            customer2.TaxId = "9876541";

            // Gerçek Müşteri - Tüzel Müşteri
            //SOLİD yazılım geliştirme sistemi - 'L'


            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);




        }
    }
}
