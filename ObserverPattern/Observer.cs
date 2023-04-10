using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    // Observer classını Gözlemci olarak kullandık.Burada kullanıcı classı olarak düşünebiliriz.
    public class Observer : IObserver
    {
        public string UserName { get; set; }

        public Observer(string userName)
        {
            UserName = userName;
        }

        public void Notify(Product product)
        {
            Console.WriteLine($"{UserName},{product.Code} is on sale!");
        }
    }
}
