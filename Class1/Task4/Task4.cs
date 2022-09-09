namespace Task4
{
    public class Task4
    {
/*
 * В решениях следующих заданий предполагается использование циклов.
 */

/*
 * Задание 4.1. Пользуясь циклом for, посимвольно напечатайте рамку размера width x height,
 * состоящую из символов frameChar. Можно считать, что width>=2, height>=2.
 * Например, вызов printFrame(5,3,'+') должен напечатать следующее:

+++++
+   +
+++++
 */
        internal static void PrintFrame(int width, int height, char frameChar = '*')
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x <= width; x++)
                    if (x == width)
                        Console.Write('\n');
                    else if (x == width && y == height) ;
                    else if (x == 0 || y == 0 || x == width - 1 || y == height - 1)
                        Console.Write(frameChar);
                    else
                        Console.Write(' ');
            }
        }

/*
 * Задание 4.2. Выполните предыдущее задание, пользуясь циклом while.
 */
        internal static void PrintFrame2(int width, int height, char frameChar = '*')
        {
            int y = -1;
            while (++y < height)
            {
                int x = -1;
                while (++x <= width)
                    if (x == width)
                        Console.Write('\n');
                    else if (x == width && y == height) ;
                    else if (x == 0 || y == 0 || x == width - 1 || y == height - 1)
                        Console.Write(frameChar);
                    else
                        Console.Write(' ');
            }
        }


/*
 * Задание 4.3. Даны целые положительные числа A и B. Найти их наибольший общий делитель (НОД),
 * используя алгоритм Евклида:
 * НОД(A, B) = НОД(B, A mod B),    если B ≠ 0;        НОД(A, 0) = A,
 * где «mod» обозначает операцию взятия остатка от деления.
 */
        internal static long Gcd(long a, long b)
        {
            while (b != 0)
            {
                (a, b) = (b, a % b);
            }

            return a;
        }

/*
 * Задание 4.4. Дано вещественное число X и целое число N (> 0). Найти значение выражения
 * 1 + X + X^2/(2!) + … + X^N/(N!), где N! = 1·2·…·N.
 * Полученное число является приближенным значением функции exp в точке X.
 */
        internal static double ExpTaylor(double x, int n)
        {
            long nfac = 1;
            double xpow = 1;
            double sum = 1;
            for (int i = 1; i <= n; i++)
            {
                if (nfac > Int64.MaxValue / i)
                    nfac = Int64.MaxValue;
                else
                    nfac *= i;
                xpow *= x;
                sum += xpow / nfac;
            }

            return sum;
        }

        public static void Main(string[] args)
        {
            PrintFrame(5, 3, '+');
            PrintFrame2(5, 3, '+');
            Console.WriteLine(Gcd(5, 3));
            Console.WriteLine(ExpTaylor(0.1, 1000));
        }
    }
}
