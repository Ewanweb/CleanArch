using Microsoft.VisualBasic.CompilerServices;

namespace Clean_arch.Domain.Shared;

public class Mony : BaseValueObject
{
    /// <summary>
    /// Rial
    /// </summary>
    public int Value { get; }

    public Mony(int rialValue)
    {
        if (rialValue < 0)
            throw new InvalidDataException();

        Value = rialValue;
    }

    public static Mony FromRial(int value)
    {
        return new Mony(value);
    }
    public static Mony FromTooman(int value)
    {
        return new Mony(value * 10);
    }

    public static Mony operator +(Mony firstMony, Mony mony2)
    {
        return new Mony(firstMony.Value + mony2.Value);
    }

    public override string ToString()
    {
        return Value.ToString("#,0");
    }

    public static Mony operator -(Mony firstMony, Mony mony2)
    {
        return new Mony(firstMony.Value - mony2.Value);
    }
}