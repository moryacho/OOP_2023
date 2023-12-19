namespace MyClass;

internal class Program
{
    static void Main(string[] args)
    {
        Book b1 = new Book();
        b1.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс", 123, 2012);
        Book.SetPrice(12);
        //b1.Show();
        //Console.WriteLine("\nИтоговая стоимость аренды: {0}p.", b1.PriceBook(3));
        //Console.WriteLine();

        Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь", 1234, 2013, 101, true);
        b2.TakeItem();
        //b2.Show();
        Console.WriteLine();

        Book b3 = new Book("Лермонтов М.Ю.", "Мцыри");
        //b3.Show();
        //Console.WriteLine();

        //Item item1 = new Item();
        //item1.Show();
        //Console.WriteLine();

        Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
        mag1.Show();
        mag1.IfSubs = true;
        //mag1.Subs();
        Console.WriteLine();

        //Console.WriteLine("\nТестирование полиморфизма");
        //Item it;
        //it = b2;
        //it.TakeItem();
        //it.Return();
        //it.Show();

        //it = mag1;
        //it.TakeItem();
        //it.Return();
        //it.Show();

        Item[] itmas = new Item[4];
        itmas[0] = b1;
        itmas[1] = b2;
        itmas[2] = b3;
        itmas[3] = mag1;

        Array.Sort(itmas);
        Console.WriteLine("\nСортировка по инвентарному номеру");
        foreach (Item x in itmas)
        {
            x.Show();
        }

        Console.ReadLine();
    }
}