using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp;

internal class CostCalculator
{
    public decimal Calculate(decimal power, int duration)
    {
        if (power < 0)
        {
            throw new ArgumentException("Zużycie energii nie może być mniejsze od 0");
        }

        if (duration < 0 || duration > 60)
        {
            throw new ArgumentOutOfRangeException("Czas musi zawierać się pomiędzy 1..60 minut");
        }

        return power * duration;
    }
}
