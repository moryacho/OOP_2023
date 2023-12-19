using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass;

internal class Book : Item
{
    private string author; // автор
    private string title; // название
    private string publisher; // издательство
    private int pages; // кол-во страниц
    private int year; // год издания
    private static double price = 9; // аренда
    private bool returnSrok;

    public Book(String author, String title)
    {
        this.author = author;
        this.title = title;
    }

    static Book() //статический конструктор
    {
        price = 10;
    }

    public Book(String author, String title, String publisher, int pages, int year, long invNumber, bool taken)
        : base(invNumber, taken)
    {
        this.author = author;
        this.title = title;
        this.publisher = publisher;
        this.pages = pages;
        this.year = year;
    }

    public Book(String author, String title, String publisher, int pages, int year)
    {
        this.author = author;
        this.title = title;
        this.publisher = publisher;
        this.pages = pages;
        this.year = year;
    }
    public Book()
    { }

    public void SetBook(string author, string title, string publisher, int pages, int year)
    {
        this.author = author;
        this.title = title;
        this.publisher = publisher;
        this.pages = pages;
        this.year = year;
    }

    public static void SetPrice(double price)
    {
        Book.price = price;
    }

    new public void Show()
    {
        Console.WriteLine("\nКнига:\n" +
            "Автор: {0}\n" +
            "Название:{1}\n" +
            "Год издания: {2}\n" +
            "{3} стр.\n" +
            "Стоимость аренды: {4}", author, title, year, pages, Book.price);
        base.Show();
    }

    public double PriceBook(int s)
    {
        double cost = s * price;
        return cost;
    }

    public void ReturnSrok()
    {
        returnSrok = true;
    }

    public override void Return() // операция "вернуть"
    {
        if (returnSrok == true)
            taken = true;
        else
            taken = false;
    }
}