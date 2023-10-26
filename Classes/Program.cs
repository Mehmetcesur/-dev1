namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.add();
            customerManager.Uptade();  

            ProductManager productManager = new ProductManager();
            productManager.add();
            productManager.Uptade();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;    
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";

            Customer customer2 = new Customer
            {

                Id = 1,City = "İstanbul", FirstName ="Derin", LastName = "Demiroğ" 

            };
            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }

}