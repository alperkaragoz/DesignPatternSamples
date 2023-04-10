using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    // ShoppingCenter sınıfı Observer Pattern'de SUBJECT olarak kullanılıyor.
    public class ShoppingCenter
    {
        private Dictionary<IObserver, Product> observers = new();
        public void Register(IObserver observer, Product product)
        {
            observers.TryAdd(observer, product);
        }
        public void Unregister(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void NotifyAll()
        {
            observers.ToList().ForEach(observer =>
            {
                observer.Key.Notify(observer.Value);
            });
        }
        public void NotifyByProductCode(string productCode)
        {
            foreach (var observer in observers)
            {
                if (observer.Value.Code.Equals(productCode))
                    observer.Key.Notify(observer.Value);
            }
        }
    }
}
