using System;
namespace Application
{
    class Problem104
    {
        public static void solution()
        {
            Product obj3=new Product(1010, "daal", 160, "one kilo");
            Product[] products=new Product[]{obj3};

            Order obj1 = new Order(12, "2007/07/14", 500,products );
            Order[] orders=new Order[] {obj1};

            Customer obj= new Customer(1,"Pillow",977,orders);
            obj.DisplayCustomerDetails();

         
            

        }
          class Product
        {
            public int ProductId;
            public string ProductName;
            public int Price;
            public string QuantityAvailable;
            public Product( int productId, string productName, int price, string quantityAvailable) 
            {
                ProductId=productId;
                ProductName=productName;
                Price=price;
                QuantityAvailable=quantityAvailable;

            }

            public void DisplayProductDetails()
            {
                Console.WriteLine($"ProductId:{ProductId},ProductName:{ProductName},Price:{Price},QuantityAvailable:{QuantityAvailable}"); 
                Console.WriteLine($"QuantityAvailable:{QuantityAvailable}");
            }
            }
            class Order
        {
            public int OrderId;
            public string OrderDate;
            public int TotalAmount;
            public Product[] Products;
            public Order( int orderId,string orderDate,int totalAmount,Product[] products)
            {
               OrderId=  orderId;
               OrderDate= orderDate;
               TotalAmount= totalAmount;
               Products= products;

            }
            public void Displayorder()
            {
                Console.WriteLine($"OrderId:{OrderId},OrderDate:{OrderDate},TotalAmount:{TotalAmount}");
                Console.WriteLine("Product:");
                foreach(var Product in Products)
                {
                    Product.DisplayProductDetails();

                }
            }

        } 

        class Customer
        {
            public int Customerid;
            public string CustomerName;
            public int Customercontact;
            public Order[] Orderss;
            public Customer(int customerid, string customername, int customercontact,Order[] orderss)
            {
                Customerid=customerid;
                CustomerName=customername;
                Customercontact=customercontact;
                Orderss=orderss;

            }
            public void DisplayCustomerDetails()
            {
                Console.WriteLine("Customer:");
                Console.WriteLine($"CustomerId:{Customerid},CustomerName:{CustomerName},Customercontact:{Customercontact}");

               Console.WriteLine("Order:");
               foreach(var Order in Orderss)
            {
                Order.Displayorder();
            }

            }

        }
        
        }
    
}