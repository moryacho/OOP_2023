﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass;

internal class Magazine : Item, IPubs
{
    private String volume; // том
    private int number; // номер
    private String title; // название
    private int year; // год выпуска
    public bool IfSubs { get; set; }

    public Magazine(String volume, int number, String title, int year, long invNumber, bool taken)
        : base(invNumber, taken)
    {
        this.volume = volume;
        this.number = number;
        this.title = title;
        this.year = year;
    }
    public Magazine()
    { }

    public void Subs()
    {
        Console.WriteLine($"Подписка на журнал \"{title}\": {IfSubs}.");
}

    new public void Show()
    {
        Console.WriteLine($"\nЖурнал:\n" +
            $"Том: {volume}\n" +
            $"Номер: {number}\n" +
            $"Название: {title}\n" +
            $"Год выпуска: {year}");
        base.Show();
    }

    public override void Return() // операция "вернуть"
    {
        taken = true;
    }
}
