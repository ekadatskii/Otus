using System;
namespace Sample
{
    public static class LessonTypes
    {

        // Максимальное количество баллов = 10

        /// Пример: Вычисление квадрата вещественного числа
        public static double Sqr(double x) => x * x;

        /// Пример: Вычисление дискриминанта квадратного уравнения
        public static double Discriminant(double a, double b, double c) => Sqr(b) - 4 * a * c;

        /// Пример: Поиск одного из корней квадратного уравнения
        public static double QuadraticEquationRoot(double a, double b, double c)
        {
            double discriminant = Discriminant(a, b, c);
            double x = (-b + Math.Sqrt(discriminant)) / (2 * a);
            return x;
        }

        /// Пример: Поиск произведения корней квадратного уравнения
        public static double QuadraticRootProduct(double a, double b, double c)
        {
            double sd = Math.Sqrt(Discriminant(a, b, c));
            double x1 = (-b + sd) / (2 * a);
            double x2 = (-b - sd) / (2 * a);
            return x1 * x2; // Результат
        }

        /// Пример главной функции в программе
        public static void Main(string[] args)
        {
            var x1x2 = QuadraticRootProduct(1.0, 13.0, 42.0);
            Console.WriteLine($"Root product: {x1x2}");
        }

        /**
         * Тривиальная (1 балл).
         *
         * Пользователь задает время в часах, минутах и секундах, например, 8:20:35.
         * Рассчитать время в секундах, прошедшее с начала суток (30035 в данном случае).
         */
        public static int TotalSeconds(int hours, int minutes, int seconds) => (hours * 60 * 60 + minutes * 60 + seconds);

        /**
         * Тривиальная (1 балл)
         *
         * Пользователь задает длину отрезка в саженях, аршинах и вершках (например, 8 саженей 2 аршина 11 вершков).
         * Определить длину того же отрезка в метрах (в данном случае 18.98).
         * 1 сажень = 3 аршина = 48 вершков, 1 вершок = 4.445 см.
         */
        public static double LengthInMeters(int sagenes, int arshins, int vershoks)
        {
            double _vershok_in_m = 4.445 / 100;
            double _arshin_in_vershok = 48 / 3;
            double _sagen_in_vershok = _arshin_in_vershok * 3;
            return (sagenes * _sagen_in_vershok + arshins * _arshin_in_vershok + vershoks) * _vershok_in_m;
        }

        /**
         * Тривиальная (1 балл)
         *
         * Пользователь задает угол в градусах, минутах и секундах (например, 36 градусов 14 минут 35 секунд).
         * Вывести значение того же угла в радианах (например, 0.63256).
         */
        public static double AngleToRadian(int deg, int min, int sec) => (deg * 60 * 60 + min * 60 + sec) * Math.PI / (180 * 3600);
        

        /**
         * Тривиальная (1 балл)
         *
         * Найти длину отрезка, соединяющего точки на плоскости с координатами (x1, y1) и (x2, y2).
         * Например, расстояние между (3, 0) и (0, 4) равно 5
         */
        public static double SegmentLength(double x1, double y1, double x2, double y2) => Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        

        /**
         * Простая (1 балл)
         *
         * Пользователь задает целое число, больше или равно 100 (например, 3801).
         * Определить третью цифру справа в этом числе (в данном случае 8).
         */
        public static int GetThirdDigit(int number) => (number / 100) % 10;
        

        /**
         * Простая (1 балл)
         *
         * Поезд вышел со станции отправления в h1 часов m1 минут (например в 9:25) и
         * прибыл на станцию назначения в h2 часов m2 минут того же дня (например в 13:01).
         * Определите время поезда в пути в минутах (в данном случае 216).
         */
        public static int TravelMinutes(int hoursDepart, int minutesDepart, int hoursArrive, int minutesArrive)
        {
            return (hoursArrive * 60 + minutesArrive) - (hoursDepart * 60 + minutesDepart);
        }

        /**
         * Простая (2 балла)
         *
         * Человек положил в банк сумму в s рублей под p% годовых (проценты начисляются в конце года).
         * Сколько денег будет на счету через n лет (с учётом сложных процентов)?
         * Например, 100 рублей под 10% годовых превратятся в 133.1 рубля
         */
        public static double CalcMoney(int initialMoney, int percent, int years) => initialMoney * Math.Pow(1 + (double)percent/100, years);

        /**
         * Простая (2 балла)
         *
         * Пользователь задает целое трехзначное число (например, 478).
         * Необходимо вывести число, полученное из заданного перестановкой цифр в обратном порядке (например, 874).
         */
        public static int RevertNumber(int number)
        {
            return number % 10 * 100 + number % 100 / 10 * 10 + number / 100;
        }
    }
}