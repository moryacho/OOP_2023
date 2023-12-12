using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass;

internal abstract class Item
{
    // инвентарный номер — целое число
    protected long invNumber;
    // хранит состояние объекта - взят ли на руки
    protected bool taken;
    // истина, если этот предмет имеется в библиотеке

    public abstract void Return(); // операция "вернуть"

    public Item(long invNumber, bool taken)
    {
        this.invNumber = invNumber;
        this.taken = taken;
    }

    public Item()
    {
        this.taken = true;
    }

    public bool IsAvailable()
    {
        if (taken == true)
            return true;
        else
            return false;
    }

    // инвентарный номер
    public long GetInvNumber()
    {
        return invNumber;
    }

    // операция "взять"
    public void Take()
    {
        taken = false;
    }

    public virtual void Show()
    {
        Console.WriteLine("Состояние единицы хранения:\n" +
            "Инвентарный номер: {0}\n" +
            "Наличие: {1}", invNumber, taken);
    }

    public void TakeItem()
    {
        if (this.IsAvailable())
            this.Take();
    }
}