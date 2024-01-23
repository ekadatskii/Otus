using System;
// ReSharper disable InvalidXmlDocComment

namespace Sample
{
    public static class LessonConstructions
    {
        // Максимальное количество баллов = 10

        ///Пример: Найти число корней квадратного уравнения ax^2 + bx + c = 0
        public static int QuadraticRootNumber(double a, double b, double c)
        {
            double discriminant = Discriminant(a, b, c);

            if (discriminant > 0)
            {
                return 2;
            }

            if (discriminant == 0)
            {
                return 1;
            }

            return 0;
        }
        
        public static double Discriminant(double a, double b, double c) => Sqr(b) - 4 * a * c;
        public static double Sqr(double x) => x * x;

        ///Пример: Получить строковую нотацию для оценки по пятибалльной системе
        public static string GradeNotation(int grade)
        {
            return grade switch
            {
                5 => "отлично",
                4 => "хорошо",
                3 => "удовлетворительно",
                2 => "неудовлетворительно",
                _ => "несуществующая оценка $grade",
            };
        }

        ///Пример: Вычисление факториала 
        public static double Factorial(int n)
        {
            double result = 1.0;
            
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
        
        /**
         * Тривиальная (1 балл)
         *
         * Мой возраст. Для заданного 0 < n < 200, рассматриваемого как возраст человека,
         * вернуть строку вида: «21 год», «32 года», «12 лет».
         */
        public static string AgeDescription(int age)
        {
            int age_var = (age >= 100) ? age % 100 : age;
            switch (age_var) {
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                    return $"{age} лет";
            }
            switch (age_var % 10) {
                case 1:
                    return $"{age} год";
                case 2:
                case 3:
                case 4:
                    return $"{age} года";
                default:
                    return $"{age} лет";
            }
        }

        /**
         * Простая (2 балла)
         *
         * Нa шахматной доске стоят черный король и две белые ладьи (ладья бьет по горизонтали и вертикали).
         * Определить, не находится ли король под боем, а если есть угроза, то от кого именно.
         * Вернуть 0, если угрозы нет, 1, если угроза только от первой ладьи, 2, если только от второй ладьи,
         * и 3, если угроза от обеих ладей.
         * Считать, что ладьи не могут загораживать друг друга
         */
        public static int WhichRookThreatens(
            int kingX, int kingY,
            int rookX1, int rookY1,
            int rookX2, int rookY2
        )
        {
            return  (kingX == rookX1 && kingX == rookX2) ? 3 : 
                    (kingY == rookY1 && kingY == rookY2) ? 3 : 
                    (kingX == rookX1 && kingY == rookY2) ? 3 :
                    (kingX == rookX2 && kingY == rookY1) ? 3 :
                    (kingX == rookX2 || kingY == rookY2) ? 2 :
                    (kingX == rookX1 || kingY == rookY1) ? 1 : 
                    0;
        }

        /**
         * Средняя (2 балла)
         *
         * Треугольник задан длинами своих сторон a, b, c.
         * Проверить, является ли данный треугольник остроугольным (вернуть 0),
         * прямоугольным (вернуть 1) или тупоугольным (вернуть 2).
         * Если такой треугольник не существует, вернуть -1.
         */
        public static int TriangleKind(double a, double b, double c)
        {
            return  ((a + b) <= c) ? -1 :
                    ((a + c) <= b) ? -1 :
                    ((b + c) <= a) ? -1 :
                    ((Math.Pow(a, 2) + Math.Pow(b, 2)) == Math.Pow(c, 2)) ? 1 :
                    ((Math.Pow(a, 2) + Math.Pow(c, 2)) == Math.Pow(b, 2)) ? 1 :
                    ((Math.Pow(b, 2) + Math.Pow(c, 2)) == Math.Pow(a, 2)) ? 1 :
                    ((Math.Pow(a, 2) + Math.Pow(b, 2)) < Math.Pow(c, 2)) ? 2 :
                    ((Math.Pow(a, 2) + Math.Pow(c, 2)) < Math.Pow(b, 2)) ? 2 :
                    ((Math.Pow(b, 2) + Math.Pow(c, 2)) < Math.Pow(a, 2)) ? 2 :
                    0;
        }

        /**
         * Тривиальная (1 балла)
         *
         * Найти число Фибоначчи из ряда 1, 1, 2, 3, 5, 8, 13, 21, ... с номером n.
         * Ряд Фибоначчи определён следующим образом: fib(1) = 1, fib(2) = 1, fib(n+2) = fib(n) + fib(n+1)
         */
        public static int Fibonacci(int n)
        {
            int fib_n = 1;
            int fib_n_plus_1 = 1;
            int fib_var;
            for (int i = 0; i < n-2; i++) {
                fib_var = fib_n_plus_1;
                fib_n_plus_1 += fib_n;
                fib_n = fib_var;
            }
            return fib_n_plus_1;
        }

        /**
         * Простая (2 балла)
         *
         * Для заданного числа n > 1 найти минимальный делитель, превышающий 1
         */
        public static int MinDivisor(int n)
        {
            int _minDivisor = n;
            for (int i = 2; i < n; i++) {
                if (n % i == 0) { 
                    _minDivisor = i;
                    break;
                }
            }
            return _minDivisor;
        }

        /**
         * Средняя (2 балла)
         *
         * Поменять порядок цифр заданного числа n на обратный: 13478 -> 87431.
         *
         * Использовать операции со строками в этой задаче запрещается!
         */
        public static int Revert(int n)
        {
            int var = n;
            int _reverse = 0;
            while (var > 0) {
                _reverse = _reverse * 10 + var % 10;
                var /= 10;
            }
            return _reverse;
        }
    }
}