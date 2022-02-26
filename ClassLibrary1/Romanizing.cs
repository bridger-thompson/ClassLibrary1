namespace ClassLibrary1
{
    public class Romanizing
    {
        public string ToRoman(int number)
        {
            if ((number < 0) || (number > 3999))
                throw new ArgumentOutOfRangeException("Exception");
            if (number < 1)
                return string.Empty;
            if (number >= 1000)
                return "m" + ToRoman(number - 1000);
            if (number >= 900)
                return "cm" + ToRoman(number - 900);
            if (number >= 500)
                return "d" + ToRoman(number - 500);
            if (number >= 400)
                return "cd" + ToRoman(number - 400);
            if (number >= 100)
                return "c" + ToRoman(number - 100);
            if (number >= 90)
                return "xc" + ToRoman(number - 90);
            if (number >= 50)
                return "l" + ToRoman(number - 50);
            if (number >= 40)
                return "xl" + ToRoman(number - 40);
            if (number >= 10)
                return "x" + ToRoman(number - 10);
            if (number >= 9)
                return "ix" + ToRoman(number - 9);
            if (number >= 5)
                return "v" + ToRoman(number - 5);
            if (number >= 4)
                return "iv" + ToRoman(number - 4);
            if (number >= 1)
                return "i" + ToRoman(number - 1);

            return string.Empty;
        }
    }
}