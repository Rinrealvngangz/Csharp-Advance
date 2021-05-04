using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLesson
{
    public class EventHandlerPriceChanged
    {
        public decimal OldPrice { get; set; }
        public decimal CurrentPrice { get; set; }

        public EventHandlerPriceChanged(decimal oldPrice , decimal currentPrice)
        {
            this.OldPrice = oldPrice;
            this.CurrentPrice = currentPrice;
        }
    }
    public delegate void PriceChangedDotNet(object sender, EventHandlerPriceChanged e);

    class ProductDotNet
    {
        private decimal Oldprice { get; set; }
        private decimal _currentPrice;

        public event PriceChangedDotNet PriceChangedEvent;
        public decimal CurrentPrice
        {
            get { return _currentPrice; }
            set
            {
                if(_currentPrice == value)
                {
                    return;
                }
                Oldprice = _currentPrice;
                _currentPrice = value;
                if(PriceChangedEvent != null)
                {
                    PriceChangedEvent(this, new EventHandlerPriceChanged(Oldprice, _currentPrice));
                }

            }
        }
        
    }

    public delegate void PriceChange(decimal priceChange, decimal oldPrice);
    
    class Product
    {
        public event PriceChange EventHandlerPriceChange;
       private decimal   OldPrice { get; set; } 
       public string Name { get; set; }
        private decimal _price ;
       public decimal Price
        {
            get { return _price; }
            set
            {
                if(_price == value)
                {
                    return;
                }
                OldPrice = _price;
                _price = value;

                if (EventHandlerPriceChange != null)
                {
                    EventHandlerPriceChange(_price,OldPrice);        
            
                }
             
            }
            
        }
    
    } 
    class Program
    {
        
        static void Main(string[] args)
        {
          
           /* Product product = new Product();
            product.Name = "Book";
            product.Price = 3000;
            Console.WriteLine("Gia hien tai la : {0}",product.Price);
            product.EventHandlerPriceChange += Product_EventHandlerPriceChange;
            Console.WriteLine("Choose price new:(Y/N)");
            string confirm = Console.ReadLine();
            if ("Y".Equals(confirm))
            {
               decimal priceNew = InputPriceNew();
                product.Price = priceNew;
            }*/
                /* 
                    Dotnet Event
                */
                ProductDotNet productDotnet = new ProductDotNet{ CurrentPrice = 4000 };
            productDotnet.PriceChangedEvent += ProductDotnet_PriceChangedEvent;
            Console.WriteLine("Choose price new:(Y/N)");
            string confirm = Console.ReadLine();
            if ("Y".Equals(confirm))
            {
                decimal priceNew = InputPriceNew();
                productDotnet.CurrentPrice = priceNew;
            }
            Console.ReadKey();

        }

        private static void ProductDotnet_PriceChangedEvent(object sender, EventHandlerPriceChanged e)
        {
            PrintPriceChange(e.CurrentPrice, e.OldPrice);
        }

        private static void Product_EventHandlerPriceChange(decimal priceChange, decimal oldPrice)
        {
            Action<decimal, decimal> printPrice = new Action<decimal, decimal>(PrintPriceChange);
            printPrice(priceChange, oldPrice);
            
        }

        public static  void PrintPriceChange(decimal priceChange, decimal oldPrice)
        {
            Console.WriteLine("Price old: {0}", oldPrice);
            Console.WriteLine("Price change: {0}", priceChange);
           
        }

        public static decimal InputPriceNew()
        {
            
                Console.WriteLine("Nhap gia moi:");
                decimal priceNew = decimal.Parse(Console.ReadLine());
                return priceNew;    
           
        }
    }
}
