// See https://aka.ms/new-console-template for more information
using ObserverPattern;

Console.WriteLine("Hello, World!");


var mateBook = new Product { Id = 1, Code = "mtb500", Price = 699 };
var macBook = new Product { Id = 2, Code = "mcb250", Price = 1399 };

var observer = new Observer("alperkaragoz");
var observerOtherUser = new Observer("karagozalper");

ShoppingCenter shoppingCenter = new();
shoppingCenter.Register(observer, macBook);
shoppingCenter.Register(observerOtherUser, mateBook);
//shoppingCenter.NotifyByProductCode(macBook.Code); 
shoppingCenter.NotifyAll();

Console.ReadLine();