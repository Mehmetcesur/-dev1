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

            Console.ReadLine();
        }
    }

}