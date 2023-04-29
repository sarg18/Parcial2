using Lists.Logic;

Console.WriteLine("*** Linked Lists ***");

var Bugatti = new Car { Brand = "Bugatti", Price = 200, Model = "Veyron", Year = 2020, Color ="Blue"};
var Bugatti2 = new Car { Brand = "Bugatti", Price = 240, Model = "Chiron", Year = 2020, Color = "Black" };
var ferrari = new Car { Brand = "Ferrari", Price = 180, Model = "Venom", Year = 2023, Color = "Red" };
var ferrari2 = new Car { Brand = "Ferrari", Price = 120, Model = "Phantom", Year = 2023, Color = "Red" };
var ferrari3 = new Car { Brand = "Ferrari", Price = 110, Model = "Orus", Year = 2023, Color = "White" };
var Porshe = new Car { Brand = "Porshe", Price = 95, Model = "Panamera", Year = 2009, Color = "Blue" };
var Porshe2 = new Car { Brand = "Porshe", Price = 110, Model = "Taycan", Year = 2000, Color = "Black" };
var Porshe3 = new Car { Brand = "Porshe", Price = 100, Model = "911", Year = 1996, Color = "Red" };
var Mazda = new Car { Brand = "Mazda", Price = 60, Model = "mazda 2", Year = 2021, Color = "Red" };
var Mazda2 = new Car { Brand = "Mazda", Price = 20, Model = "mazda 3", Year = 2009, Color = "Black" };
var Mazda3 = new Car { Brand = "Mazda", Price = 15, Model = "Allegro", Year = 2000, Color = "White" };
var Mazda4 = new Car { Brand = "Mazda", Price = 12 , Model = "mazda 323", Year = 1996, Color = "Blue" };

var Cars = new YourLinkedList<Car>();
Cars.Add(Bugatti);
Cars.Add(Bugatti2);
Cars.Add(ferrari);
Cars.Add(ferrari2);
Cars.Add(ferrari3);
Cars.Add(Porshe);
Cars.Add(Porshe2);
Cars.Add(Porshe3);
Cars.Add(Mazda);
Cars.Add(Mazda2);
Cars.Add(Mazda3);
Cars.Add(Mazda4);


Console.WriteLine(Cars.GetBrand("Mazda"));


Console.WriteLine("*** Year Cars ***");

Console.WriteLine(Cars.GetModel("Veyron"));

Console.WriteLine("*** Year Cars ***");

Console.WriteLine(Cars.GetYear(1996, 2021));

Console.WriteLine("*** Price Cars ***");

Console.WriteLine(Cars.GetPrice(60, 120));






