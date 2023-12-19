using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressionProject;

internal class ArithmeticProgression : IProgression
{
    private int start; // Начальный член прогрессии
    private int diff; // Разность

    public ArithmeticProgression(int start, int diff)
    {
        this.start = start;
        this.diff = diff;
    }

    public int GetElement(int k)
    {
        return start + (k - 1) * diff;
    }
}
