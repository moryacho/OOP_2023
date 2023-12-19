using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressionProject;

internal class GeometricProgression : IProgression
{
    private int start; // Первый член прогрессии
    private int ratio; // Знаменатель

    public GeometricProgression(int start, int ratio)
    {
        this.start = start;
        this.ratio = ratio;
    }

    public int GetElement(int k)
    {
        return start * (int)Math.Pow(ratio, k - 1);
    }
}
