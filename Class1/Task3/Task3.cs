namespace Task3
{
    public class Task3
    {
/*
 * Прежде чем приступать к выполнению заданий, допишите к ним тесты.
 */

/*
 * Задание 3.1. Для данного вещественного x найти значение следующей функции f, принимающей значения целого типа:
 * 	        0,	если x < 0,
 * f(x) = 	1,	если x принадлежит [0, 1), [2, 3), …,
           −1,	если x принадлежит [1, 2), [3, 4), … .
 */
        internal static double F(double x)
        {
            if (x < 0) return 0;
            if (0 <= x % 2 && x % 2 < 1) return 1;
            return -1;
        }

/*
 * Задание 3.2. Дан номер года (положительное целое число). Определить количество дней в этом году,
 * учитывая, что обычный год насчитывает 365 дней, а високосный — 366 дней. Високосным считается год,
 * делящийся на 4, за исключением тех годов, которые делятся на 100 и не делятся на 400
 * (например, годы 300, 1300 и 1900 не являются високосными, а 1200 и 2000 — являются).
 */
        internal static int NumberOfDays(int year)
        {
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                return 366;
            return 365;
        }

/*
 * Задание 3.3. Локатор ориентирован на одну из сторон света («С» — север, «З» — запад,
 * «Ю» — юг, «В» — восток) и может принимать три цифровые команды поворота:
 * 1 — поворот налево, −1 — поворот направо, 2 — поворот на 180°.
 * Дан символ C — исходная ориентация локатора и целые числа N1 и N2 — две посланные команды.
 * Вернуть ориентацию локатора после выполнения этих команд.
 */
        internal static char Rotate2(char orientation, int cmd1, int cmd2)
        {
            char[] orientations = { 'С', 'З', 'Ю', 'В', };

            char rotate1(char orientation, int cmd)
            {
                int index = Array.IndexOf(orientations, orientation);
                int newIndex = (index + orientations.Length + cmd) % orientations.Length;
                return orientations[newIndex];
            };

            char result1 = rotate1(orientation, cmd1);
            char result2 = rotate1(result1, cmd2);
            return result2;
        }

/*
 * Задание 3.4. Дано целое число в диапазоне 20–69, определяющее возраст (в годах).
 * Вернуть строку-описание указанного возраста, обеспечив правильное согласование
 * числа со словом «год», например: 20 — «двадцать лет», 32 — «тридцать два года»,
 * 41 — «сорок один год».
 *
 * Пожалуйста, научитесь делать такие вещи очень аккуратно. Программное обеспечение
 * переполнено некорректными с точки зрения русского языка решениями.
 */
        internal static String AgeDescription(int age)
        {
            string[] tens =
            {
                "[0]",
                "[1]",
                "двадцать",
                "тридцать",
                "сорок",
                "пятьдесят",
                "шестьдесят",
            };
            string[] ones =
            {
                "лет",
                "один год",
                "два года",
                "три года",
                "четыре года",
                "пять лет",
                "шесть лет",
                "семь лет",
                "восемь лет",
                "девять лет",
            };

            return $"{tens[age / 10]} {ones[age % 10]}";
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(F(0));
            Console.WriteLine(NumberOfDays(2014));
            Console.WriteLine(Rotate2('С', 1, 1));
            Console.WriteLine(AgeDescription(69));
        }
    }
}