using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Less_6
{


    class ClassFunc
    {
        Menu exit = new Menu();
        
        /// <summary>
        /// /////////////////////// begin
        /// </summary>

        public void Lesson_1()
        {
            
            Console.WriteLine("   " +
                "Less_1" +
                "/////////////////////////");

            int a = Convert.ToInt32(Console.ReadLine());
            int P = 4 * a;
            Console.WriteLine(P);

            exit.Exit();

        }
        public void Lesson_2()
        {

            Console.WriteLine("   " +
                "Less_2" +
                "/////////////////////////");

            int a = Convert.ToInt32(Console.ReadLine());
            int point = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Pow(a, point));

            exit.Exit();

        }
        public void Lesson_3()
        {

            Console.WriteLine("   " +
                "Less_3" +
                "/////////////////////////");

            int a = 6, b = 9;
            int S = a * b;
            int P = 2 * (a + b);


            Console.Write("S ="); Console.WriteLine(S);
            Console.Write("P ="); Console.WriteLine(P);

            exit.Exit();

        }
        public void Lesson_4()
        {

            Console.WriteLine("   " +
                "Less_4" +
                "/////////////////////////");
            const double pi = 3.14;
            int d = 6;
            double L = pi * d;
            Console.Write("L = "); Console.WriteLine(L);

            exit.Exit();
        }
        public void Lesson_5()
        {

            Console.WriteLine("   " +
                "Less_5" +
                "/////////////////////////");
            double a = Convert.ToDouble(Console.ReadLine());
            Math.Pow(a, 2);
            double S = 6 * a;
            Console.Write("V ="); Console.WriteLine(Math.Pow(a, 3));
            Console.Write("S ="); Console.WriteLine(S);


            exit.Exit();
        }
        public void Lesson_6()
        {
            Console.WriteLine("   " +
              "Less_6" +
              "/////////////////////////");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int V = a * b * c;
            int S = 2 * (a * b + b + c + a * c);
            Console.Write("V ="); Console.WriteLine(V);
            Console.Write("S ="); Console.WriteLine(S);

            exit.Exit();
        }
        public void Lesson_7()
        {

            Console.WriteLine("   " +
                "Less_2" +
                "/////////////////////////");

            const double pi = 3.14;
            double R = 5;


            double L = 2 * pi * R;

            double S = pi * (Math.Pow(R, 2));

            Console.Write("L= "); Console.WriteLine(L);
            Console.Write("S= "); Console.WriteLine(S);

            exit.Exit();
        }
        public void Lesson_8()
        {

            Console.WriteLine("   " +
                "Less_8" +
                "/////////////////////////");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int Mid = (a + b) / 2;
            Console.Write("Среднее ="); Console.WriteLine(Mid);

            exit.Exit();
        }
        public void Lesson_9()
        {
            Console.WriteLine("   " +
                "Less_9" +
                "/////////////////////////");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            a = a * b;
            a = Convert.ToInt32(Math.Sqrt(a));
            Console.Write("Ответ ="); Console.WriteLine(a);

            exit.Exit();
        }
        public void Lesson_10()
        {

            Console.WriteLine("   " +
                "Less_10" +
                "/////////////////////////");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            a = Convert.ToInt32(Math.Pow(a, 2));
            b = Convert.ToInt32(Math.Pow(b, 2));
            Console.Write("Add: "); Console.WriteLine(a + b);
            Console.Write("Sub: "); Console.WriteLine(a - b);
            Console.Write("Div: "); Console.WriteLine(a / b);
            Console.Write("Mul: "); Console.WriteLine(a * b);

            exit.Exit();


        }
        public void Lesson_11()
        {

            Console.WriteLine("   " +
                "Less_10" +
                "/////////////////////////");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            a = Convert.ToInt32(Math.Abs(a));
            b = Convert.ToInt32(Math.Abs(b));
            Console.Write("Add: "); Console.WriteLine(a + b);
            Console.Write("Sub: "); Console.WriteLine(a - b);
            Console.Write("Div: "); Console.WriteLine(a / b);
            Console.Write("Mul: "); Console.WriteLine(a * b);

            exit.Exit();


        }
        public void Lesson_12()
        {

            Console.WriteLine("   " +
                "Less_12" +
                "/////////////////////////");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = 0, P = a + b + c;
            int с = Convert.ToInt32(Math.Sqrt(Math.Pow(a, 2) * Math.Pow(b, 2)));
            Console.Write("P ="); Console.WriteLine(P);
            Console.Write("c ="); Console.WriteLine(c);

            exit.Exit();

        }
        public void Lesson_13()
        {

            Console.WriteLine("   " +
                "Less_10" +
                "/////////////////////////");
            const double pi = 3.14;
            double R1, R2, S1, S2, S3;
            R1 = 10; R2 = 5;
            S1 = pi * Math.Pow(R1, 2);
            S2 = pi * Math.Pow(R2, 2);
            S3 = S1 - S2;

            Console.WriteLine(S1);
            Console.WriteLine(S2);
            Console.WriteLine(S3);

            exit.Exit();

        }
        public void Lesson_14()
        {

            Console.WriteLine("   " +
                "Less_14" +
                "/////////////////////////");
            const double pi = 3.14;
            int L = Convert.ToInt32(Console.ReadLine());

            double R = L / 2 * pi;
            double S = pi * Math.Pow(R, 2);
            Console.WriteLine("R = {0} | S = {1}", R, S);

            exit.Exit();





        }
        public void Lesson_15()
        {

            Console.WriteLine("   " +
                "Less_15" +
                "/////////////////////////");
            const double pi = 3.14;
            int S = Convert.ToInt32(Console.ReadLine());
            double R = Math.Sqrt(S / pi);
            double D = 2 * R;
            double L = pi * D;

            Console.WriteLine("Диаметр = {0} | Длина = {1}", D, L);

            exit.Exit();


        }
        public void Lesson_16()
        {

            Console.WriteLine("   " +
                "Less_16" +
                "/////////////////////////");

            int x1, x2;
            x1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Расстояние между x1 x2 = {0}", Math.Abs(x2 - x1));

            exit.Exit();


        }
        public void Lesson_17()
        {

            Console.WriteLine("   " +
                "Less_10" +
                "/////////////////////////");

            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());

            int AC = A + C;
            int BC = B + C;

            Console.WriteLine("Сумма {0}", AC + BC);

            exit.Exit();

        }
        public void Lesson_18()
        {

            Console.WriteLine("   " +
                "Less_10" +
                "/////////////////////////");


            Console.Write("Введите координату точки A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату точки B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                int tmp = b;
                b = a;
                a = tmp;
            }

            int c;
            do
            {
                Console.Write("Введите координату точки C: ");
                c = int.Parse(Console.ReadLine());
            } while (c < a || c > b);

            Console.WriteLine("AC * BC = {0}", Math.Abs((c - a) * (b - c)));

            exit.Exit();

        }
        public void Lesson_19()
        {

            Console.WriteLine("   " +
                "Less_10" +
                "/////////////////////////");

            int x1, y1, x2, y2, a, b, p, s;
            Console.WriteLine("Введите координаты противоположных вершин прямоугольника: (x1, y1) и (x2, y2) ->");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            a = Math.Abs(x1 - x2);
            b = Math.Abs(y1 - y2);
            p = 2 * (a + b);
            s = a * b;
            Console.WriteLine("Периметр прямоугольника = {0}" + "\n" + "Площадь прямоугольника = {1}", p, s);

            exit.Exit();
        }
        public void Lesson_20()
        {

            int x1, y1, x2, y2;
            double r;
            Console.WriteLine("Введите координаты 2х точек: (x1, y1) и (x2, y2) ->");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Расстояние = {0}", r);

            exit.Exit();


        }
        public void Lesson_21()
        {


            double a, b, c, x1, x2, x3, y1, y2, y3, p, per, s;


            Console.WriteLine("Введите x1,y1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите x2,y2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите x3,y3:");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());

            a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            c = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            per = a + b + c;

            p = per / 2;

            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine("Периметр треугольника = {0}" + "Площадь треугольника = {1}", per, s);

            exit.Exit();

        }
        public void Lesson_22()
        {

            int a, b, tmp;



            Console.WriteLine("Введите A и B: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine("A = {0} |  B = {1}", a, b);
            exit.Exit();

        }
        public void Lesson_23()
        {




            int a, b, c, tmp;


            Console.WriteLine("Введите a,b,и c: ");

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            tmp = c;

            c = b;
            b = a;
            a = tmp;
            Console.WriteLine("A={0} | B = {1} | C={2}", a, b, c);

            exit.Exit();
        }
        public void Lesson_24()
        {
            int a, b, c, tmp;

            Console.WriteLine("Введите a, b и c: ");

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            tmp = a;
            a = b;
            b = c;
            c = tmp;
            Console.WriteLine("A = {0} B = {1} C = {2}", a, b, c);
            exit.Exit();

        }
        public void Lesson_25()
        {



            Console.WriteLine("Введите значение x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            double y = 3 * Math.Pow(x, 6) - 6 * Math.Pow(x, 2) - 7;
            Console.WriteLine("Y = {0} ", y);

            exit.Exit();

        }
        public void Lesson_26()
        {



            Console.WriteLine("Введите значение x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            double y = 4 * Math.Pow(x - 3, 6) - 7 * Math.Pow(x - 3, 3) + 2;
            Console.WriteLine("Y = {0} ", y);

            exit.Exit();

        }
        public void Lesson_27()
        {
            int A, B;
            Console.WriteLine("Введите значение A: ");

            A = Convert.ToInt32(Console.ReadLine());
            B = A * A;

            Console.WriteLine("{0} во второй степени - {1} ", A, B);
            B = B * B;

            Console.WriteLine("{0} в четвертой степени - {1}", A, B);
            B = B * B;

            Console.WriteLine("{0} в восьмой степени - {1}", A, B);


            exit.Exit();
        }
        public void Lesson_28()
        {
            int B, C;
            Console.WriteLine("Введите значение A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            B = A * A;

            Console.WriteLine("{0} во второй степени - {1}", A, B);
            C = A * B;

            Console.WriteLine("{0} в третьей степени - {1}", A, C);
            B = C * B;

            Console.WriteLine("{0} в пятой степени - {1}", A, B);
            C = B * B;

            Console.WriteLine("{0} в десятой степени - {1}", A, C);
            B = B * C;

            Console.WriteLine("{0} в пятнадцатой степени - {1}", A, B);

            exit.Exit();

        }
        public void Lesson_29()
        {

            const double pi = 3.14;
            int a;

            Console.WriteLine("Введите значение угла в градусах (0..360) ->");
            a = Convert.ToInt32(Console.ReadLine());
            double r = a * pi / 180;
            Console.WriteLine("Значение угла в радианах = {0}", r);

            exit.Exit();
        }
        public void Lesson_30()
        {


            const double pi = 3.14;
            Console.WriteLine("Введите значение угла в радианах: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (0 <= a && a < 2 * pi)
            {

                double b = (180 / pi) * a;

                Console.WriteLine("Значение угла в градусах: {0}", b);


            }
            else
                Console.WriteLine("Число должно соответствовать условию - 0<a<2*Pi!");

            exit.Exit(); ;


        }
        public void Lesson_31()
        {

            Console.WriteLine("Введите значение температуры в градусах Фаренгейта:");
            int TF = Convert.ToInt32(Console.ReadLine());
            int TC = (TF - 32) * 5 / 9;
            Console.WriteLine("Эта температура в градусах Цельсия: {0} ", TC);

            exit.Exit();

        }
        public void Lesson_32()
        {

            Console.WriteLine("Введите значение температуры в градусах Цельсия: ");
            int TC = Convert.ToInt32(Console.ReadLine());
            int TF = TC * 9 / 5 + 32;
            Console.WriteLine("Эта температура в градусах Фаренгейта:{0} ", TF);

            exit.Exit();
        }
        public void Lesson_33()
        {
            int X_kilo, Price_x_kilo, Y_kilo, Price_y_kilo, Price_one_kilo;


            Console.WriteLine("Введите количество килограмм: ");
            X_kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость конфет: ");
            Price_x_kilo = Convert.ToInt32(Console.ReadLine());
            Price_one_kilo = Price_x_kilo / X_kilo;
            Console.WriteLine("Стоимость 1 кг. конфет -- {0}", Price_one_kilo);
            Console.WriteLine("Введите количество кг.:");
            Y_kilo = Convert.ToInt32(Console.ReadLine());
            Price_y_kilo = Y_kilo * Price_one_kilo;
            Console.WriteLine("Цена конфет за {0} кг. конфет равна {1} ", Y_kilo, Price_y_kilo);

            exit.Exit();
        }
        public void Lesson_34()
        {
            int sweet_kilo, Price_sweet_kilo, Price_one_sweet_kilo;
            int iris_kilo, Price_iris_kilo, Price_one_iris_kilo;
            int Ratio;


            Console.WriteLine("Введите количество килограмм шоколадных конфет: ");
            sweet_kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость конфет: ");
            Price_sweet_kilo = Convert.ToInt32(Console.ReadLine());
            Price_one_sweet_kilo = Price_sweet_kilo / sweet_kilo;
            Console.WriteLine("Стоимость 1 кг. конфет -- {0} ", Price_one_sweet_kilo);
            Console.WriteLine("Введите количество килограмм ирисок:");
            iris_kilo = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("Введите стоимость конфет: ");
            Price_iris_kilo = Convert.ToInt32(Console.ReadLine());
            Price_one_iris_kilo = Price_iris_kilo / iris_kilo;
            Console.WriteLine("Стоимость 1 кг. конфет -- ", Price_one_iris_kilo);
            Ratio = Price_one_sweet_kilo / Price_one_iris_kilo;
            Console.WriteLine("Один килограмм конфет дороже ирисок в " + Ratio + " раз.");

            exit.Exit();
        }
        public void Lesson_35()
        {
            int S, V, U, T1, T2;


            Console.WriteLine("Введите скорость лодки: ");
            V = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите скорость течения реки: ");
            U = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите время движения по озеру: ");
            T1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите время движения по реке: ");
            T2 = Convert.ToInt32(Console.ReadLine());
            S = T2 * (V - U) + T1 * V;
            Console.WriteLine("Путь, пройденный лодкой равен {0}", S);

            exit.Exit();
        }
        public void Lesson_36()
        {
            int V1, V2, S, T, S1;


            Console.WriteLine("Введите скорость первого автомобиля: ");
            V1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите скорость второго автомобиля: ");
            V2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите время: ");
            T = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите расстояние между автомобилями: ");
            S = Convert.ToInt32(Console.ReadLine());
            S1 = (V1 + V2) * T + S;
            Console.WriteLine("Через {0} ч. расстояние  {1} км.", T, S1);

            exit.Exit();
        }
        public void Lesson_37()
        {
            int S_obshyi, S_cherez_T, T, S, V1, V2;


            Console.WriteLine("Введите скорость первого автомобиля: ");
            V1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите скорость второго автомобиля: ");
            V2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первоначальное расстояние: ");
            S = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите T: ");
            T = Convert.ToInt32(Console.ReadLine());
            S_obshyi = T * (V1 + V2);
            S_cherez_T = Math.Abs(S - S_obshyi);
            Console.WriteLine("Расстояние между автомобилями через " + T + " ч = " + S_cherez_T);

            exit.Exit();
        }
        public void Lesson_38()
        {
            int x, A, B;


            Console.WriteLine("Программа для решения уравнения A * x + B = 0.  ");
            Console.WriteLine("Введите коэффициент А: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите коэффициент В: ");
            B = Convert.ToInt32(Console.ReadLine());
            x = -B / A;
            Console.WriteLine("х = " + x);

            exit.Exit();
        }
        public void Lesson_39()
        {
            double B, A, C;
            double x1, x2;

            Console.WriteLine("Программа для решения уравнения A * x^2 + B * x + C = 0. ");
            Console.WriteLine("Введите коэффициент А: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите коэффициент В: ");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите коэффициент C: ");
            C = Convert.ToInt32(Console.ReadLine());
            double D = Math.Pow(B, 2) - 4 * A * C;
            x1 = ((-B + Math.Sqrt(D)) / (2 * A));
            x2 = ((-B + Math.Sqrt(D)) / (2 * A));
            Console.WriteLine("D ={0}", D);
            Console.WriteLine("x1 ={0}", x1);
            Console.WriteLine("x2 ={0}", x2);

            exit.Exit();
        }
        public void Lesson_40()
        {
            int A1, B1, C1, A2, B2, C2, x, y, D;


            Console.WriteLine("Введите коэффициенты A1 и A2: ");
            A1 = Convert.ToInt32(Console.ReadLine());
            A2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите коэффициенты B1 и B2: ");
            B1 = Convert.ToInt32(Console.ReadLine());
            B2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите коэффициенты C1 и C2: ");
            C1 = Convert.ToInt32(Console.ReadLine());
            C2 = Convert.ToInt32(Console.ReadLine());
            D = A1 * B2 - A2 * B1;
            x = (C1 * B2 - C2 * B1) / D;
            y = (A1 * C2 - A2 * C1) / D;
            Console.WriteLine("x = {0}", x);
            Console.WriteLine("y = {0}", y);

            exit.Exit();
        }




        /// <summary>
        /// ///////////////////////////// integer
        /// </summary>
        public void Lesson_41()
        {
            int l, k;


            Console.WriteLine("Введите значение L:");
            l = Convert.ToInt32(Console.ReadLine());
            k = l / 100;
            Console.WriteLine("Количество полных метров: " + k);

            exit.Exit();
        }
        public void Lesson_42()
        {
            int M, k;


            Console.WriteLine("Введите значение M:");
            M = Convert.ToInt32(Console.ReadLine());
            k = M / 1000;
            Console.WriteLine("Количество полных тонн: " + k);

            exit.Exit();

        }
        public void Lesson_43()
        {
            int a, k;


            Console.WriteLine("Введите размер файла: ");
            a = Convert.ToInt32(Console.ReadLine());
            k = a / 1024;
            Console.WriteLine("Количество полных килобайтов: " + k);

            exit.Exit();
        }
        public void Lesson_44()
        {
            int a, b, k;


            Console.WriteLine("Введите a и b: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            k = a / b;
            Console.WriteLine("Количество отрезков B, размещенных на отрезке A: " + k);

            exit.Exit();
        }
        public void Lesson_45()
        {
            int a, b, k;


            Console.WriteLine("Введите a и b: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            k = a % b;
            Console.WriteLine("Длина незанятой части отрезка: " + k);

            exit.Exit();

        }
        public void Lesson_46()
        {
            int chislo, desyatki, edinizi;
            Console.WriteLine("Введите число: ");
            chislo = Convert.ToInt32(Console.ReadLine());
            desyatki = chislo / 10;
            Console.WriteLine(desyatki);
            edinizi = chislo % 10;
            Console.WriteLine(edinizi);

            exit.Exit();
        }
        public void Lesson_47()
        {
            int chislo, desyatki, edinizi, summa, proizv;
            Console.WriteLine("Введите число: ");
            chislo = Convert.ToInt32(Console.ReadLine());
            desyatki = chislo / 10;
            edinizi = chislo % 10;
            summa = desyatki + edinizi;
            proizv = desyatki * edinizi;
            Console.WriteLine("Сумма цифр числа: " + summa);
            Console.WriteLine("Произведение цифр числа:" + proizv);

            exit.Exit();
        }
        public void Lesson_48()
        {
            int chislo, desyatki, edinizi;


            Console.WriteLine("Введите число: ");
            chislo = Convert.ToInt32(Console.ReadLine());
            desyatki = chislo / 10;
            edinizi = chislo % 10;
            chislo = edinizi * 10 + desyatki;
            Console.WriteLine("Полученное число:" + chislo);

            exit.Exit();
        }
        public void Lesson_49()
        {

            int chislo, sotni;
            Console.WriteLine("Введите число: ");
            chislo = Convert.ToInt32(Console.ReadLine());
            sotni = chislo / 100;
            Console.WriteLine(sotni);

            exit.Exit();
        }
        public void Lesson_50()
        {
            int chislo, edinizi, desyatki;
            Console.WriteLine("Введите число: ");
            chislo = Convert.ToInt32(Console.ReadLine());
            edinizi = chislo % 10;
            Console.WriteLine(edinizi);
            desyatki = chislo % 100 / 10;
            Console.WriteLine(desyatki);

            exit.Exit();
        }





        public void Lesson_51()
        {
            int chislo, sotni, desyatki, edinizi, summa, proizv;


            Console.Write("Введите число: ");
            chislo = Convert.ToInt32(Console.ReadLine());
            sotni = chislo / 100;
            desyatki = chislo % 100 / 10;
            edinizi = chislo % 10;
            summa = sotni + desyatki + edinizi;
            proizv = sotni * desyatki * edinizi;
            Console.WriteLine("Сумма всех цифр числа: " + summa);
            Console.WriteLine("Произведение всех цифр числа: ", proizv);
            exit.Exit();
        }



        public void Lesson_52()
        {
            int chislo, sotni, desyatki, edinizi;


            Console.Write("Введите число: ");
            chislo = Convert.ToInt32(Console.ReadLine());
            sotni = chislo / 100;
            desyatki = chislo % 100 / 10;
            edinizi = chislo % 10;
            chislo = edinizi * 100 + desyatki * 10 + sotni;
            Console.WriteLine("Полученное число: ", chislo);
            exit.Exit();
        }


        public void Lesson_53()
        {
            int chislo, sotni, ost;
            Console.WriteLine("Введите число:");
            chislo = Convert.ToInt32(Console.ReadLine());
            sotni = chislo / 100;
            ost = chislo % 100;
            chislo = ost * 10 + sotni;
            Console.WriteLine("Полученное число:  " + chislo);

            exit.Exit();

        }



        public void Lesson_54()
        {
            int chislo, edinizi, ost;
            Console.Write("Введите число");
            chislo = Convert.ToInt32(Console.ReadLine());
            edinizi = chislo % 10;
            ost = chislo / 10;
            chislo = edinizi * 100 + ost;
            Console.WriteLine("Полкченное число :" + chislo);
            exit.Exit();

        }



        public void Lesson_55()
        {
            int chislo, sotni, desyatki, edinizi;
            Console.WriteLine("Введите число");
            chislo = Convert.ToInt32(Console.ReadLine());
            sotni = chislo / 100;
            desyatki = chislo % 100 / 10;
            edinizi = chislo % 10;
            chislo = desyatki * 100 + sotni * 10 + edinizi;
            Console.WriteLine("Введите число" + chislo);
            exit.Exit();
        }


        public void Lesson_56()
        {
            int chislo, sotni, desyatki, edinizi;
            Console.Write("Введите число");
            chislo = Convert.ToInt32(Console.ReadLine());
            sotni = chislo / 100;
            desyatki = chislo % 100 / 10;
            edinizi = chislo % 10;
            chislo = sotni * 100 + edinizi * 10 + desyatki;
            Console.WriteLine("Полученное число" + chislo);

            exit.Exit();
        }


        public void Lesson_57()
        {
            int chislo, sotni;
            Console.WriteLine("Введите число");
            chislo = Convert.ToInt32(Console.ReadLine());
            sotni = chislo / 100 % 10;
            Console.WriteLine("Найденная цифра" + sotni);

            exit.Exit();
        }
        public void Lesson_58()
        {
            int chislo, tis;
            Console.WriteLine("Введите число");
            chislo = Convert.ToInt32(Console.ReadLine());
            tis = chislo / 1000 % 10;
            Console.WriteLine("Найденная цифра" + tis);

            exit.Exit();
        }
        public void Lesson_59()
        {
            int N, min;
            Console.Write("Введите N");
            N = Convert.ToInt32(Console.ReadLine());
            min = N / 60;
            Console.WriteLine("Количество полных минут, прошедших с начала суток: " + min);
            exit.Exit();

        }
        public void Lesson_60()
        {
            int N, hours;
            Console.Write("Введите N: ");
            N = Convert.ToInt32(Console.ReadLine());
            hours = N / 3600;
            Console.WriteLine("Количество полных часов, прошедших с начала суток: " + hours);
            exit.Exit();

        }

        public void Lesson_61()
        {
            int n, sec;
            Console.Write("Введите количество секунд N:");
            n = Convert.ToInt32(Console.ReadLine());
            sec = n % 60;
            Console.WriteLine("Количество секунд, прошедших с начала последней минуты: " + sec);

            exit.Exit();
        }
        public void Lesson_62()
        {
            int n, sec;
            Console.Write("Введите количество секунд N: ");
            n = Convert.ToInt32(Console.ReadLine());
            sec = n % 3600;
            Console.WriteLine("Количество секунд,прошедших с начала последнего часа:" + sec);

            exit.Exit();
        }

        public void Lesson_63()
        {
            int n, min;
            Console.Write("Введите количество секунд N: ");
            n = Convert.ToInt32(Console.ReadLine());
            min = n % 3600 / 60;
            Console.WriteLine("Количество полных минут,прошедших с начала последнего часа:" + min);

            exit.Exit();
        }


        public void Lesson_64()
        {
            int k, number;
            Console.Write("Введите день года:");
            k = Convert.ToInt32(Console.ReadLine());
            number = k % 7;
            Console.Write("Номер дня недели: " + number);

            exit.Exit();
        }


        public void Lesson_65()
        {
            int k, number;


            Console.Write("Введите день года: ");
            k = Convert.ToInt32(Console.ReadLine());
            number = (k + 3) % 7;
            Console.WriteLine("Номер дня недели: " + number);

            exit.Exit();

        }


        public void Lesson_66()
        {
            int k, number;


            Console.Write("Введите день года: ");
            k = Convert.ToInt32(Console.ReadLine());
            number = (k + 3) % 7;
            Console.WriteLine("Номер дня недели: " + number);

            exit.Exit();

        }


        public void Lesson_67()
        {

            int k, number;


            Console.Write("Введите день года: ");
            k = Convert.ToInt32(Console.ReadLine());
            number = (k + 3) % 7;
            Console.WriteLine("Номер дня недели: " + number);

            exit.Exit();
        }


        public void Lesson_68()
        {
            int k, number;


            Console.Write("Введите день года: ");
            k = Convert.ToInt32(Console.ReadLine());
            number = (k + 3) % 7;
            Console.WriteLine("Номер дня недели: " + number);

            exit.Exit();

        }


        public void Lesson_69()
        {
            int a, b, c, k, s;

            Console.Write("vvedite A,B,C=>");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            k = (a / c) * (b / c);
            Console.WriteLine("koli4estvo kvadratov=" + k);
            s = a * (b % c) + b * (a % c) - (a % c) * (b % c);
            Console.WriteLine("nezanyatay S=" + s);

            exit.Exit();

        }


        public void Lesson_70()
        {

            int c, y;

            Console.WriteLine("Введите год");
            y = Convert.ToInt32(Console.ReadLine());
            c = y / 100;
            if (y % 100 < 0 || y % 100 > 0)
                c = c + 1;
            Console.WriteLine("Год {0} - столетие {1}", y, c);

            exit.Exit();



        }



        /// <summary>
        /// /////////////////////////// case
        /// </summary>

        public void Lesson_71()
        {
            int k;
            Console.WriteLine("Введите целое число в диапазоне 1-7:  ");
            k = Convert.ToInt32(Console.ReadLine());
            switch (k)
            {
                case 1: Console.WriteLine("Понедельник\n"); break;
                case 2: Console.WriteLine("Вторник\n"); break;
                case 3: Console.WriteLine("Среда\n"); break;
                case 4: Console.WriteLine("Четверг\n"); break;
                case 5: Console.WriteLine("Пятница\n"); break;
                case 6: Console.WriteLine("Суббота\n"); break;
                case 7: Console.WriteLine("Воскресенье\n"); break;
                default: Console.WriteLine("Дней недели нет.\n"); break;


            }

            exit.Exit();

        }
        public void Lesson_72()
        {

            int k = Convert.ToInt32(Console.ReadLine());
            switch (k)
            {
                case 1: Console.WriteLine("плохо"); break;
                case 2: Console.WriteLine("неудовлетворительно"); break;
                case 3: Console.WriteLine("удовлетворительно"); break;
                case 4: Console.WriteLine("хорошо"); break;
                case 5: Console.WriteLine("отлично"); break;
                default: Console.WriteLine("ошибка"); break;
            }
            exit.Exit();
        }
        public void Lesson_73()
        {

            int month;
            Console.WriteLine("Месяц:");
            month = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("зима\n");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("весна\n");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("лето\n");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("осень\n");
                    break;

            }
            exit.Exit();
        }
        public void Lesson_74()
        {
            int month;
            Console.WriteLine("Месяц:");

            month = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("В месяце 31 днень.\n");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("В месяце 30 дней.\n");
                    break;
                case 2:
                    Console.WriteLine("В месяце 28 дней.\n");
                    break;

            }

            exit.Exit();

        }
        public void Lesson_75()
        {

            int n;
            float a, b;
            Console.WriteLine("N:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B:");
            b = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine(a + b);
                    break;
                case 2:
                    Console.WriteLine(a - b);
                    break;
                case 3:
                    Console.WriteLine(a * b);
                    break;
                case 4:
                    Console.WriteLine(a / b);
                    break;
            }
            exit.Exit();

        }
        public void Lesson_76()
        {
            Console.WriteLine("n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("l");
            int l = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine(l / 10);
                    break;
                case 2:
                    Console.WriteLine(l * 1000);
                    break;
                case 3:
                    Console.WriteLine(l);
                    break;
                case 4:
                    Console.WriteLine(l / 1000);
                    break;
                case 5:
                    Console.WriteLine(l / 100);
                    break;
            }
        }
        public void Lesson_77()
        {

            int n;
            float m;
            Console.WriteLine("N:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("M:");
            m = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine(m);
                    break;
                case 2:
                    Console.WriteLine(m / 1000000);
                    break;
                case 3:
                    Console.WriteLine(m / 1000);
                    break;
                case 4:
                    Console.WriteLine(m * 1000);
                    break;
                case 5:
                    Console.WriteLine(m * 100);
                    break;
            }
        }
        public void Lesson_78()
        {


            int D, M;
            Console.WriteLine("Введите день:");
            D = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер месяца:");
            M = Convert.ToInt32(Console.ReadLine());
            D = D - 1;
            if (D == 0)
            {
                M = M - 1;
                if (M == 0)
                {
                    M = 12;
                }
                switch (M)
                {
                    case 1: D = 31; break;
                    case 3: D = 31; break;
                    case 5: D = 31; break;
                    case 7: D = 31; break;
                    case 8: D = 31; break;
                    case 10: D = 31; break;
                    case 12: D = 31; break;
                    case 4: D = 30; break;
                    case 6: D = 30; break;
                    case 9: D = 30; break;
                    case 11: D = 30; break;
                    case 2: D = 28; break;

                }

            }
            exit.Exit();
        }
        public void Lesson_79()
        {

            int D, M;
            Console.WriteLine("Введите целое число D (день): ");
            D = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число М (месяц): ");
            M = Convert.ToInt32(Console.ReadLine());
            switch (++D)
            {
                case 29: if (M == 2) { D = 1; ++M; } break;
                case 31: if (M == 4 || M == 6 || M == 9 || M == 11) { D = 1; ++M; } break;
                case 32:
                    if (++M > 12) M = 1;
                    D = 1; break;
            }
            Console.WriteLine("Следующая дата: ");
            Console.WriteLine(D + "" + M);
            exit.Exit();

        }
        public void Lesson_80()
        {
            char S;
            int N;
            Console.WriteLine("Введите символ направления («С» — север, «З» — запад, «Ю» — юг, «В» — восток): ");
            S = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите цифровую команду для робота (0 — продолжать движение, 1 — поворот налево, -1 — поворот направо): ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Направление - ");
            switch (N)
            {
                case 1:
                    switch (S)
                    {
                        case 'С': Console.Write(" З "); break;
                        case 'Ю': Console.Write(" В "); break;
                        case 'З': Console.Write(" Ю "); break;
                        case 'В': Console.Write(" С "); break;
                    }
                    break;
                case -1:
                    switch (S)
                    {
                        case 'С': Console.Write(" В "); break;
                        case 'Ю': Console.Write(" З "); break;
                        case 'З': Console.Write(" С "); break;
                        case 'В': Console.Write(" Ю "); break;
                    }
                    break;
                case 0:
                    switch (S)
                    {
                        case 'С': Console.Write(" С "); break;
                        case 'Ю': Console.Write(" Ю "); break;
                        case 'З': Console.Write(" З "); break;
                        case 'В': Console.Write(" В "); break;
                    }
                    break;
            }
            exit.Exit();
        }
        public void Lesson_81()
        {
            int n1, n2;
            char c;
            Console.WriteLine("Направление:");
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите цифровую команду N1 для локатора( 1 — поворот налево, -1 — поворот направо, 2 - поворот на  180): ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите цифровую команду N2 для локатора( 1 — поворот налево, -1 — поворот направоб, 2 - поворот на 180):");
            n2 = Convert.ToInt32(Console.ReadLine());



            switch (c)
            {
                case 'С':
                    switch (n1 + n2)
                    {
                        case -1:
                        case 3:
                            c = 'В';
                            break;
                        case 1:
                            c = 'З';
                            break;
                        case -2:
                        case 2:
                            c = 'Ю';
                            break;
                    }
                    break;
                case 'В':
                    switch (n1 + n2)
                    {
                        case -1:
                        case 3:
                            c = 'Ю';
                            break;
                        case 1:
                            c = 'С';
                            break;
                        case -2:
                        case 2:
                            c = 'З';
                            break;
                    }
                    break;
                case 'Ю':
                    switch (n1 + n2)
                    {
                        case -1:
                        case 3:
                            c = 'З';
                            break;
                        case 1:
                            c = 'В';
                            break;
                        case -2:
                        case 2:
                            c = 'С';
                            break;
                    }
                    break;
                case 'З':
                    switch (n1 + n2)
                    {
                        case -1:
                        case 3:
                            c = 'С';
                            break;
                        case 1:
                            c = 'Ю';
                            break;
                        case -2:
                        case 2:
                            c = 'В';
                            break;
                    }
                    break;
            }

            Console.WriteLine("Ориентация локатора " + c);
            exit.Exit();

        }
        public void Lesson_82()
        {

            int n;
            double x, r, d, l, s;
            Console.WriteLine("Номер элемента:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Длинна:");
            x = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    r = x;
                    d = 2 * r;
                    l = 2 * 3.14 * r;
                    s = 3.14 * r * r;
                    Console.WriteLine("D = {0}, L = {1}, S = {2}", d, l, s);
                    break;
                case 2:
                    r = x / 2;
                    d = x;
                    l = 2 * 3.14 * r;
                    s = 3.14 * r * r;
                    Console.WriteLine("R = {0}, L = {1}, S = {2}", r, l, s);
                    break;
                case 3:
                    r = x / 2 * 3.14;
                    d = 2 * r;
                    l = x;
                    s = 3.14 * r * r;
                    Console.WriteLine("R = {0}, D = {1}, S = {2}", r, d, s);
                    break;
                case 4:
                    r = Math.Sqrt(x / 3.14);
                    d = 2 * r;
                    l = 2 * 3.14 * r;
                    s = x;
                    Console.WriteLine("R = {0}, D = {1}, L = {2}", r, d, l);
                    break;
            }
            exit.Exit();
        }
        public void Lesson_83()
        {
            int n;
            double x, a, c, h, s;
            Console.WriteLine("Номер элемента:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Длинна:");
            x = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    a = x;
                    c = a * Math.Sqrt(2);
                    h = c / 2;
                    s = c * h / 2;
                    Console.WriteLine("C = {0} ,H = {1}, S = {2}", c, h, s);
                    break;
                case 2:
                    c = x;
                    a = c / Math.Sqrt(2);
                    h = c / 2;
                    s = c * h / 2;
                    Console.WriteLine("A = {0} ,H = {1} ,S = {2}", a, h, s);
                    break;
                case 3:
                    h = x;
                    c = 2 * h;
                    a = c / Math.Sqrt(2);
                    s = c * h / 2;
                    Console.WriteLine("A = {0} ,C = {1} ,S = {2}", a, c, s);
                    break;
                case 4:
                    s = x;
                    h = Math.Sqrt(s);
                    c = 2 * h;
                    a = c / Math.Sqrt(2);
                    Console.WriteLine("A= {0} ,C = {1} , H = {2}", a, c, h);
                    break;
            }
            exit.Exit();
        }
        public void Lesson_84()
        {
            int n;
            double x, a, r1, r2, s;
            Console.WriteLine("Номер элемента:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Длинна:");
            x = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    a = x;
                    r1 = a * Math.Sqrt(3) / 6;
                    r2 = 2 * r1;
                    s = a * a * Math.Sqrt(3) / 4;
                    Console.WriteLine("r1 = {0},r2 = {1},s = {2}", r1, r2, s);
                    break;
                case 2:
                    r1 = x;
                    a = r1 * 6 / Math.Sqrt(3);
                    r2 = 2 * r1;
                    s = a * a * Math.Sqrt(3) / 4;
                    Console.WriteLine(" a = {0} ,r2 = {1} ,s = {2}", a, r2, s);
                    break;
                case 3:
                    r2 = x;
                    r1 = r2 / 2;
                    a = r1 * 6 / Math.Sqrt(3);
                    s = a * a * Math.Sqrt(3) / 4;
                    Console.WriteLine("a = {0}, r1 ={1}, s = {2}", a, r1, s);
                    break;
                case 4:
                    s = x;
                    a = Math.Sqrt(s * 4 / Math.Sqrt(3));
                    r1 = a * Math.Sqrt(3) / 6;
                    r2 = 2 * r1;
                    Console.WriteLine("a = {0} r1 = {1} r2 = {2}", a, r1, r2);
                    break;
            }
            exit.Exit();
        }
        public void Lesson_85()
        {
            int n, m;
            Console.WriteLine("Достоинство:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Масть:");
            m = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 6:
                    Console.WriteLine("шестёрка ");
                    break;
                case 7:
                    Console.WriteLine("семёрка ");
                    break;
                case 8:
                    Console.WriteLine("восьмёрка ");
                    break;
                case 9:
                    Console.WriteLine("девятка ");
                    break;
                case 10:
                    Console.WriteLine("десятка ");
                    break;
                case 11:
                    Console.WriteLine("валет ");
                    break;
                case 12:
                    Console.WriteLine("дама ");
                    break;
                case 13:
                    Console.WriteLine("король ");
                    break;
                case 14:
                    Console.WriteLine("туз ");
                    break;
            }

            switch (m)
            {
                case 1:
                    Console.WriteLine("пик");
                    break;
                case 2:
                    Console.WriteLine("треф");
                    break;
                case 3:
                    Console.WriteLine("бубен");
                    break;
                case 4:
                    Console.WriteLine("червей");
                    break;
            }
            exit.Exit();
        }
        public void Lesson_86()
        {
            int y;
            Console.WriteLine("Возраст:");
            y = Convert.ToInt32(Console.ReadLine());

            switch (y / 10)
            {
                case 2:
                    Console.WriteLine("двадцать ");
                    break;
                case 3:
                    Console.WriteLine("тридцать ");
                    break;
                case 4:
                    Console.WriteLine("сорок ");
                    break;
                case 5:
                    Console.WriteLine("пятдесят ");
                    break;
                case 6:
                    Console.WriteLine("шестьдесят ");
                    break;
            }

            switch (y % 10)
            {
                case 1:
                    Console.WriteLine("один ");
                    break;
                case 2:
                    Console.WriteLine("два ");
                    break;
                case 3:
                    Console.WriteLine("три ");
                    break;
                case 4:
                    Console.WriteLine("четыре ");
                    break;
                case 5:
                    Console.WriteLine("пять ");
                    break;
                case 6:
                    Console.WriteLine("шесть ");
                    break;
                case 7:
                    Console.WriteLine("семь ");
                    break;
                case 8:
                    Console.WriteLine("восемь ");
                    break;
                case 9:
                    Console.WriteLine("девять ");
                    break;
            }

            switch (y % 10)
            {
                case 0:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("лет. ");
                    break;
                case 1:
                    Console.WriteLine("год.");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("года.");
                    break;
            }
            exit.Exit();
        }
        public void Lesson_87()
        {
            int n;
            Console.WriteLine("кол-во:");
            n = Convert.ToInt32(Console.ReadLine());

            if (n / 10 == 1)
                switch (n)
                {
                    case 10:
                        Console.WriteLine("десять учебных заданий.");
                        break;
                    case 11:
                        Console.WriteLine("одинадцать учебных заданий.");
                        break;
                    case 12:
                        Console.WriteLine("двенадцать учебных заданий.");
                        break;
                    case 13:
                        Console.WriteLine("тринадцать учебных заданий.");
                        break;
                    case 14:
                        Console.WriteLine("четырнадцать учебных заданий.");
                        break;
                    case 15:
                        Console.WriteLine("пятнадцать учебных заданий.");
                        break;
                    case 16:
                        Console.WriteLine("шестнадцать учебных заданий.");
                        break;
                    case 17:
                        Console.WriteLine("семнадцать учебных заданий.");
                        break;
                    case 18:
                        Console.WriteLine("восемнадцать учебных заданий");
                        break;
                    case 19:
                        Console.WriteLine("девятнадцать учебных заданий.");
                        break;
                }
            else
            {
                switch (n / 10)
                {
                    case 2:
                        Console.WriteLine("двадцать ");
                        break;
                    case 3:
                        Console.WriteLine("тридцать ");
                        break;
                    case 4:
                        Console.WriteLine("сорок ");
                        break;
                }

                switch (n % 10)
                {
                    case 1:
                        Console.WriteLine("одно ");
                        break;
                    case 2:
                        Console.WriteLine("два ");
                        break;
                    case 3:
                        Console.WriteLine("три ");
                        break;
                    case 4:
                        Console.WriteLine("четыре ");
                        break;
                    case 5:
                        Console.WriteLine("пять ");
                        break;
                    case 6:
                        Console.WriteLine("шесть ");
                        break;
                    case 7:
                        Console.WriteLine("семь ");
                        break;
                    case 8:
                        Console.WriteLine("восемь ");
                        break;
                    case 9:
                        Console.WriteLine("девять ");
                        break;
                }

                switch (n % 10)
                {
                    case 0:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        Console.WriteLine("учебных заданий");
                        break;
                    case 1:
                        Console.WriteLine("учебное задание");
                        break;
                    case 2:
                    case 3:
                    case 4:
                        Console.WriteLine("учебных задания");
                        break;
                }
                
            }
            exit.Exit();
        }
        public void Lesson_88()
        {

            int K;
            Console.WriteLine("Введите целое число в диапазоне 100–999:  ");
            K = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(K);
            switch (K / 100)
            {
                case 1: Console.WriteLine("Сто "); break;
                case 2: Console.WriteLine("Двести "); break;
                case 3: Console.WriteLine("Триста "); break;
                case 4: Console.WriteLine("Четыреста "); break;
                case 5: Console.WriteLine("Пятьсот "); break;
                case 6: Console.WriteLine("Шестьсот "); break;
                case 7: Console.WriteLine("Семьсот "); break;
                case 8: Console.WriteLine("Восемьсот "); break;
                case 9: Console.WriteLine("Девятьсот "); break;
            }
            switch ((K % 100) / 10)
            {
                case 0: break;
                case 2: Console.WriteLine("двадцать "); break;
                case 3: Console.WriteLine("тридцать "); break;
                case 4: Console.WriteLine("сорок "); break;
                case 5: Console.WriteLine("пятьдесят "); break;
                case 6: Console.WriteLine("шестьдесят "); break;
                case 7: Console.WriteLine("семьдесят "); break;
                case 8: Console.WriteLine("восемьдесят "); break;
                case 9: Console.WriteLine("девяносто "); break;
                case 1:
                    switch (K % 100)
                    {
                        case 11: Console.WriteLine("одиннадцать "); break;
                        case 12: Console.WriteLine("двенадцать "); break;
                        case 13: Console.WriteLine("тринадцать "); break;
                        case 14: Console.WriteLine("четырнадцать "); break;
                        case 15: Console.WriteLine("пятнадцать "); break;
                        case 16: Console.WriteLine("шестнадцать "); break;
                        case 17: Console.WriteLine("семнадцать "); break;
                        case 18: Console.WriteLine("восемнадцать "); break;
                        case 19: Console.WriteLine("девятнадцать "); break;
                        case 10: Console.WriteLine("десять "); break;
                    }
                    break;
            }
            if ((K % 100 / 10) != 1)
            {
                switch (K % 10)
                {
                    case 0: break;
                    case 1: Console.WriteLine("один "); break;
                    case 2: Console.WriteLine("два "); break;
                    case 3: Console.WriteLine("три "); break;
                    case 4: Console.WriteLine("четыре "); break;
                    case 5: Console.WriteLine("пять "); break;
                    case 6: Console.WriteLine("шесть "); break;
                    case 7: Console.WriteLine("семь "); break;
                    case 8: Console.WriteLine("восемь "); break;
                    case 9: Console.WriteLine("девять "); break;
                }
            }
            exit.Exit();

        }
        public void Lesson_89()
        {

            int n;
            Console.WriteLine("Год:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("год ");

            switch ((n) % 10)
            {
                case 0:
                case 1:
                    Console.Write("бел");
                    break;
                case 2:
                case 3:
                    Console.Write("черн");
                    break;
                case 4:
                case 5:
                    Console.Write("зелён");
                    break;
                case 6:
                case 7:
                    Console.Write("красн");
                    break;
                case 8:
                case 9:
                    Console.Write("жёлт");
                    break;
            }

            switch ((n + 1) % 5)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 9:
                case 10:
                case 11:
                    Console.Write("ой ");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.Write("ого ");
                    break;
            }

            switch ((n + 8) % 12)
            {
                case 0:
                    Console.Write("крысы\n");
                    break;
                case 1:
                    Console.Write("коровы\n");
                    break;
                case 2:
                    Console.Write("тигра\n");
                    break;
                case 3:
                    Console.Write("зайца\n");
                    break;
                case 4:
                    Console.Write("дракона\n");
                    break;
                case 5:
                    Console.Write("змеи\n");
                    break;
                case 6:
                    Console.Write("лошади\n");
                    break;
                case 7:
                    Console.Write("овцы\n");
                    break;
                case 8:
                    Console.Write("обезьяны\n");
                    break;
                case 9:
                    Console.Write("курицы\n");
                    break;
                case 10:
                    Console.Write("собаки\n");
                    break;
                case 11:
                    Console.Write("свиньи\n");
                    break;
            }
            exit.Exit();
        }

        public void Lesson_90()
        {

            int d, m;
            Console.WriteLine("день:");
            d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("месяц:");
            m = Convert.ToInt32(Console.ReadLine());

            switch (m)
            {
                case 1:
                    if (d > 19) Console.WriteLine("Водолей");
                    else Console.WriteLine("Козерог");
                    break;
                case 2:
                    if (d > 18) Console.WriteLine("Рыбы");
                    else Console.WriteLine("Водолей");
                    break;
                case 3:
                    if (d > 20) Console.WriteLine("Овен");
                    else Console.WriteLine("Рыбы");
                    break;
                case 4:
                    if (d > 19) Console.WriteLine("Телец");
                    else Console.WriteLine("Овен");
                    break;
                case 5:
                    if (d > 20) Console.WriteLine("Близнецы");
                    else Console.WriteLine("Телец");
                    break;
                case 6:
                    if (d > 21) Console.WriteLine("Рак");
                    else Console.WriteLine("Близнецы");
                    break;
                case 7:
                    if (d > 22) Console.WriteLine("Лев");
                    else Console.WriteLine("Рак");
                    break;
                case 8:
                    if (d > 22) Console.WriteLine("Дева");
                    else Console.WriteLine("Лев");
                    break;
                case 9:
                    if (d > 22) Console.WriteLine("Весы");
                    else Console.WriteLine("Дева");
                    break;
                case 10:
                    if (d > 22) Console.WriteLine("Скорпион");
                    else Console.WriteLine("Весы");
                    break;
                case 11:
                    if (d > 22) Console.WriteLine("Стрелец");
                    else Console.WriteLine("Скорпион");
                    break;
                case 12:
                    if (d > 21) Console.WriteLine("Козерог");
                    else Console.WriteLine("Стрелец");
                    break;
            }
            exit.Exit();

        }






        /// <summary>
        /// /////////////////////////// for
        /// </summary>


        public void Lesson_91()
        {
            int k = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(k);
                    Thread.Sleep(100);
                }

            }
            Console.ReadKey();

            exit.Exit();

        }
        public void Lesson_92()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a < b)
            {

                for (int i = a; i < b; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(100);
                }

            }
            Console.ReadKey();

            exit.Exit();

        }
        public void Lesson_93()
        {

            


            Console.WriteLine("A:");
            int a = Convert.ToInt32(Console.ReadLine());
          


            Console.WriteLine("B:");
      
            int b = Convert.ToInt32(Console.ReadLine());

            int i;
            for (i = b - 1; i > a; --i)
                Console.WriteLine(i);

            Console.WriteLine( b - a - 1);

            exit.Exit();
        }
        public void Lesson_94()
        {

            float c;
            Console.WriteLine("c:");
            c  = Convert.ToInt32(Console.ReadLine());

            
            for (int i = 1; i <= 10; ++i) {

              Console.WriteLine("{0}, {1}",i, c * i);
            }
            Console.ReadKey();
          


        }
        public void Lesson_95()
        {

            float c;
            Console.WriteLine("Cost:");
            c = Convert.ToInt32(Console.ReadLine());

            double m;
            for (m = 0.1; m < 1.1; m += 0.1)
               Console.WriteLine("{0}, {1}", m, c * m);

            exit.Exit();
        }
        public void Lesson_96()
        {
            float c;
            Console.WriteLine("Cost:");
            c = Convert.ToInt32(Console.ReadLine());

            double m;
            for (m = 1.2; m < 2.1; m += 0.1)
                Console.WriteLine("{0}, {1}", m, c * m);
            exit.Exit();
        }
        public void Lesson_97()
        {
            int a, b;
            Console.WriteLine("A:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B:");
          b = Convert.ToInt32(Console.ReadLine());

            int i, sum = 0;
            for (i = a; i <= b; ++i)
                sum += i;

            Console.WriteLine(sum);
            exit.Exit();

        }
        public void Lesson_98()
        {

            int a, b;
            Console.WriteLine("A:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B:");
            b = Convert.ToInt32(Console.ReadLine());

            int i, rez = 1;
            for (i = a; i <= b; ++i)
                rez *= i;
            Console.WriteLine("rez = {0} \n ", rez);
            exit.Exit();

        }
        public void Lesson_99()
        {

            int a, b;
            Console.WriteLine("A:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B:");
            b = Convert.ToInt32(Console.ReadLine()); ;

            int i, rez = 0;
            for (i = a; i <= b; ++i)
                rez += i * i;
            Console.WriteLine("rez = {0} \n ", rez);
            exit.Exit();

        }
        public void Lesson_100()
        {

            int n;
            Console.WriteLine("N:");
            n = Convert.ToInt32(Console.ReadLine());

            int i;
            float rez = 0;
            for (i = 1; i <= n; ++i) {
                rez += 1 / (float)i;
            }
                

            Console.WriteLine("rez = {0}", rez);
            exit.Exit();
        }





        public void Lesson_101() {

            int n;
            Console.WriteLine("N:");
            n = Convert.ToInt32(Console.ReadLine());


            float rez = 1;
            int i;

            for (i = 1; i <= n; ++i)
                rez *= (float)i;

            Console.WriteLine("%f \n ", rez); exit.Exit();


        }

        public void Lesson_102()
        {
            float x;
            Console.WriteLine("X:");
            x = Convert.ToInt32(Console.ReadLine());

            int n;
            Console.WriteLine("N:");
            n = Convert.ToInt32(Console.ReadLine()); exit.Exit();


            float x1 = 1, n1 = 1, rez = 1.0f;
            int i;

            for (i = 1; i <= n; ++i)
            {
                n1 *= (float)i;
                x1 *= x;
                rez += x1 / n1;
            }
            Console.WriteLine("%f \n ", rez); exit.Exit();

        }
        public void Lesson_103()
        {
            float x;
            Console.WriteLine("X:");
           x = Convert.ToInt32(Console.ReadLine());

            int n;
            Console.WriteLine("N:");
            n = Convert.ToInt32(Console.ReadLine());


            float x1 = x, rez = x;
            int i;

            for (i = 1; i < n; ++i)
            {
                x1 *= -1 * x * x;
                rez += x1;
            }
            Console.WriteLine("%f \n ", rez); exit.Exit();

        }
        public void Lesson_104()
        {
            float x;
            Console.WriteLine("X:");
           x = Convert.ToInt32(Console.ReadLine());

            int n;
            Console.WriteLine("N:");
            n = Convert.ToInt32(Console.ReadLine());


            float x1 = 1, n1 = 1, rez = 1.0f;
            int i, k = 0;

            for (i = 2; i <= n; ++i)
            {
                ++k;
                n1 *= (float)k;
                ++k;
                n1 *= (float)k;
                x1 *= -1 * x * x;
                rez += x1 / n1;
            }
            Console.WriteLine("%f \n ", rez); exit.Exit();

        }
        public void Lesson_105()
        {
            float x;
            Console.WriteLine("X:");
            x = Convert.ToInt32(Console.ReadLine());

            int n;
            Console.WriteLine("N:");
           n = Convert.ToInt32(Console.ReadLine());


            float x1 = x, rez = x;
            int i;

            for (i = 2; i <= n; ++i)
            {
                x1 *= -1 * x;
                rez += x1 / i;
                Console.WriteLine("%f; %f \n ", rez, x1);
            }
            Console.WriteLine("%f \n ", rez); exit.Exit();

        }
        public void Lesson_106()
        {
            float x;
            Console.WriteLine("X:");
           x = Convert.ToInt32(Console.ReadLine());

            int n;
            Console.WriteLine("N:");
           n = Convert.ToInt32(Console.ReadLine());


            float x1 = x, rez = x;
            int i, k = 1;
            for (i = 2; i <= n; ++i)
            {
                k += 2;
                x1 *= -1 * x * x;
                rez += x1 / k;
            }
            Console.WriteLine("%f \n ", rez); exit.Exit();

        }
        public void Lesson_107()
        {
            float x;
            Console.WriteLine("X:");
            x = Convert.ToInt32(Console.ReadLine());

            int n;
            Console.WriteLine("N:");
            n = Convert.ToInt32(Console.ReadLine());

            float temp1 = 1, temp2 = 1, rez = x, pow = x;
            int i;
            for (i = 1; i < n; ++i)
            {
                temp1 *= 2 * i - 1;
                temp2 *= 2 * i;
                pow *= x * x;
                rez += temp1 * pow / (temp2 * (2 * i + 1));
            }
            Console.WriteLine("%f \n ", rez); exit.Exit();

        }
        public void Lesson_108()
        {
            int n;
            float x;
            Console.WriteLine("X:");
            x = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("N:");
            n = Convert.ToInt32(Console.ReadLine());


            float temp1 = 1, temp2 = 1, rez = 1, pow = 1;
            int i;
            for (i = 1; i < n; ++i)
            {
                temp1 *= 2 * i - 3;
                temp2 *= 2 * i;
                pow *= (-1) * x;
                rez += temp1 * pow / temp2;
            }
            Console.WriteLine("%f \n ", rez); exit.Exit();

        }
        public void Lesson_109()
        {
            int n;
            Console.WriteLine("N:");
            n = Convert.ToInt32(Console.ReadLine());

            float a;
            Console.WriteLine("A:");
           a = Convert.ToInt32(Console.ReadLine());

            float b;
            Console.WriteLine("B:");
            b = Convert.ToInt32(Console.ReadLine());

            float h = (b - a) / n;
            Console.WriteLine("H:%f \n ", h);

            int i;
            for (i = 0; i <= n; ++i)
            {
                Console.WriteLine("%f \n ", a + i * h); exit.Exit();
            }

        }
        public void Lesson_110()
        {
            int n;
            Console.WriteLine("N:");
            n = Convert.ToInt32(Console.ReadLine());

            float a;
            Console.WriteLine("A:");
            a = Convert.ToInt32(Console.ReadLine());

            float b;
            Console.WriteLine("B:");
            b = Convert.ToInt32(Console.ReadLine());

            float h = (b - a) / n;
            Console.WriteLine("H:%f \n ", h);

            int i;
            for (i = 0; i <= n; ++i)
            {
                Console.WriteLine("%f \n ", 1 - Math.Sin(a + i * h)); exit.Exit();
            }

        }
        public void Lesson_111()
        {
            int n;
            Console.WriteLine("N:");
            n = Convert.ToInt32(Console.ReadLine());


            float ai = 2;
            Console.WriteLine("A(0)=%f\n", ai);
            int i;
            for (i = 1; i <= n; ++i)
            {
                Console.WriteLine("A(%i)=%f \n", i, 2 + 1 / ai);
                ai = 2 + 1 / ai;
            }
            exit.Exit();

        }
        public void Lesson_112()
        {
            int n;
            Console.WriteLine("N:");
            n = Convert.ToInt32(Console.ReadLine());


            float ai = 1;
            Console.WriteLine("A(0)=%f\n", ai);
            int i;
            for (i = 1; i <= n; ++i)
            {
                Console.WriteLine("A(%i)=%f \n", i, (ai + 1) / i);
                ai = (ai + 1) / i;
            }
            exit.Exit();
        }
        public void Lesson_113()
        {
            int k;
            Console.WriteLine("K:");
            k = Convert.ToInt32(Console.ReadLine());
            int f1 = 1, f2 = 1;
            Console.WriteLine("F(1)=%i\n", f1);
            Console.WriteLine("F(2)=%i\n", f2);

            int i;
            for (i = 3; i <= k; ++i)
            {
                f1 = f1 + f2;
                f2 = f1 - f2;
                Console.WriteLine("F(%i)=%i \n", i, f1);
            }
            exit.Exit();
        }
        public void Lesson_114()
        {
            int n;
            Console.WriteLine("N:");
            n = Convert.ToInt32(Console.ReadLine());
            float a1 = 1, a2 = 2;
            Console.WriteLine("A(1)={0}\n", a1);
            Console.WriteLine("A(2)={0}\n", a2);

            int i;
            float ak;
            for (i = 3; i <= n; ++i)
            {
                ak = (a1 + 2 * a2) / 3;
                Console.WriteLine("A({0})={1} \n", i, ak);
                a1 = a2;
                a2 = ak;
            }
            exit.Exit();
        }
        public void Lesson_115()
        {
            int n;
            Console.WriteLine("N:");
            n = Convert.ToInt32(Console.ReadLine());
            float a1 = 1, a2 = 2, a3 = 3;
            Console.WriteLine("A(1)={0}\n", a1);
            Console.WriteLine("A(2)={0}\n", a2);
            Console.WriteLine("A(3)={0}\n", a3);

            int i;
            float ak;
            for (i = 4; i <= n; ++i)
            {
                ak = a3 + a2 - 2 * a1;
                Console.WriteLine("A({0})={1} \n", i, ak);
                a1 = a2;
                a2 = a3;
                a3 = ak;
            }
            exit.Exit();
        }
        public void Lesson_116()
        {
            int n, k;
            Console.WriteLine("N:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("K:");
            k = Convert.ToInt32(Console.ReadLine());

            int i, i2;
            float rez = 0, nk;
            for (i = 1; i <= n; ++i)
            {
                nk = i;
                for (i2 = 1; i2 <= k; ++i2) nk *= i;
                rez += nk;
            }
            Console.WriteLine( rez);
            exit.Exit();
        }
        public void Lesson_117()
        {
            int n;
            Console.WriteLine("N:");
           n = Convert.ToInt32(Console.ReadLine());

            int i, i2;
            float rez = 0, ni;
            for (i = 1; i <= n; ++i)
            {
                ni = i;
                for (i2 = 1; i2 <= i; ++i2) ni *= i;
                rez += ni;
            }
            exit.Exit();
        }
        public void Lesson_118()
        {

            int n;
            Console.WriteLine("N:");
            n = Convert.ToInt32(Console.ReadLine());

            int i, i2;
            float rez = 0, ni;
            for (i = 1; i <= n; ++i)
            {
                ni = i;
                for (i2 = 1; i2 <= n - i; ++i2) ni *= i;
                rez += ni;
            }
            Console.WriteLine( rez); exit.Exit();
        }
        public void Lesson_119()
        {

            int a, b;
            Console.WriteLine("A:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B:");
             b = Convert.ToInt32(Console.ReadLine());

            int i, i2;
            for (i = a; i <= b; ++i)
            {
                for (i2 = 1; i2 <= i; ++i2) Console.WriteLine(" i");
                Console.WriteLine("\n");
            }
            exit.Exit();
        }
        public void Lesson_120()
        {
            int a, b;
            Console.WriteLine("A:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B:");
            b = Convert.ToInt32(Console.ReadLine());

            int i, i2;
            for (i = 1; i <= b - a + 1; ++i)
            {
                for (i2 = 1; i2 <= i; ++i2) Console.WriteLine(a + i - 1);
                Console.WriteLine("\n");
            }
            
        }


        ///// bool



        public void Lesson_121()
        {
            int A;
            Console.WriteLine("A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}\n", A > 0);
            exit.Exit();

        }

        public void Lesson_122()
        {
            int A;
            Console.WriteLine("A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}\n", A % 2 != 0);
            exit.Exit();
        }

        public void Lesson_123()
        {
            int A;
            Console.WriteLine("A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}\n", A % 2 == 0);
            exit.Exit();
        }

        public void Lesson_124()
        {
            int A, B;
            Console.WriteLine("A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B:");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}\n", (A > 2) & (B <= 3));
            exit.Exit();
        }

        public void Lesson_125()
        {
            int A, B;
            Console.WriteLine("A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B:");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}\n", (A >= 0) & (B < -2));
            exit.Exit();
        }

        public void Lesson_126()
        {
            int A, B, C;
            Console.WriteLine("A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B:");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("C:");
            C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}\n", (A < B) & (B < C));
            exit.Exit();
        }

        public void Lesson_127()
        {
            int A, B, C;
            Console.WriteLine("A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B:");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("C:");
            C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}\n", ((A < B) & (B < C)) | ((A > B) & (B > C)));
            exit.Exit();
        }

        public void Lesson_128()
        {
            int A, B;
            Console.WriteLine("A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B:");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}\n", (A % 2 != 0) & (B % 2 != 0));
            exit.Exit();
        }

        public void Lesson_129()
        {
            int A, B;
            Console.WriteLine("A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B:");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}\n", (A % 2 != 0) | (B % 2 != 0));
            exit.Exit();
        }

        public void Lesson_130()
        {
            int A, B;
            Console.WriteLine("A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B:");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}\n", ((A % 2 != 0) & (B % 2 == 0)) | ((A % 2 == 0) & (B % 2 != 0)));
            exit.Exit();
        }

        public void Lesson_131()
        {
            int A, B;
            Console.WriteLine("A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B:");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}\n", ((A % 2 == 0) & (B % 2 == 0)) | ((A % 2 != 0) & (B % 2 != 0)));
            exit.Exit();
        }

        public void Lesson_132()
        {
            int A, B, C;
            Console.WriteLine("A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B:");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("C:");
            C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}\n", (A > 0) & (B > 0) & (C > 0));
            exit.Exit();
        }

        public void Lesson_133()
        {
            int A, B, C;
            Console.WriteLine("A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B:");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("C:");
            C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}\n", (A > 0) | (B > 0) | (C > 0));
            exit.Exit();
        }



        public void Lesson_134()
        {
            int A, B, C;
            Console.WriteLine("A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B:");

            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("C:");
            C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}\n", ((A > 0) & ((B > 0) | (C > 0))) | ((B > 0) & ((A > 0) | (C > 0))) | ((C > 0) & ((B > 0) | (A > 0))));
            exit.Exit();
        }

        public void Lesson_135()
        {
            int A, B, C;
            Console.WriteLine("A:");
           A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B:");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("C:");
            C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}\n", ((A <= 0) & (B > 0) & (C > 0)) | ((B <= 0) & (A > 0) & (C > 0)) | ((C <= 0) & (B > 0) & (A > 0)));
            exit.Exit();
        }

        public void Lesson_136()
        {
            int A;
            Console.WriteLine("A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}\n", (A > 9) & (A < 100) & (A % 2 == 0));
            exit.Exit();
        }


        public void Lesson_137()
        {
            int A;
            Console.WriteLine("A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}\n", (A > 99) & (A < 1000) & (A % 2 != 0));

            exit.Exit();
        }
        public void Lesson_138()
        {
            int A, B, C;
            Console.WriteLine("A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B:");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("C:");
            C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}\n", (A == B) | (A == C) | (B == C));
            exit.Exit();
        }
        public void Lesson_139()
        {

            int A, B, C;
              Console.WriteLine("A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B:");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("C:");
            C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}\n", (A == (-1) * B) | (A == (-1) * C) | (B == (-1) * C)); exit.Exit();

        }
        public void Lesson_140()
        {
            int A;
            Console.WriteLine("A:");
            A = Convert.ToInt32(Console.ReadLine());

            A = Math.Abs(A);
            Console.WriteLine("{0}\n", ((A / 100) != (A % 100 / 10)) & ((A / 100) != (A % 10)) & ((A % 100 / 10) != (A % 10))); exit.Exit();

        }
        public void Lesson_141()
        {
            int A;
            Console.WriteLine("A:");
            A = Convert.ToInt32(Console.ReadLine());

            A = Math.Abs(A);
            Console.WriteLine("{0}\n", ((A / 100) < (A % 100 / 10)) & ((A % 100 / 10) < (A % 10))); exit.Exit();

        }

        public void Lesson_142()
        {
            int A;
            Console.WriteLine("A:");
            A = Convert.ToInt32(Console.ReadLine());

            A = Math.Abs(A);
            Console.WriteLine("{0}\n", (((A / 100) > (A % 100 / 10)) & ((A % 100 / 10) > (A % 10))) | (((A / 100) < (A % 100 / 10)) & ((A % 100 / 10) < (A % 10)))); exit.Exit();

        }
        public void Lesson_143()
        {
            int A;
            Console.WriteLine("A:");
            A = Convert.ToInt32(Console.ReadLine());

            A = Math.Abs(A);
            Console.WriteLine("{0}\n", A % 10 == A / 1000 & A % 100 / 10 == A % 1000 / 100); exit.Exit();

        }
        public void Lesson_144()
        {
            

                float A, B, C;
                Console.WriteLine("A:");
                A = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("B:");
                B = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("C:");
                C = Convert.ToInt32(Console.ReadLine());

                float D;
                D = B * B - 4 * A * C;

                Console.WriteLine("{0}\n", D >= 0); exit.Exit();

            }
        public void Lesson_145()
        {
                float x, y;
                Console.WriteLine("x:");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("y:");
                y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0}\n", x < 0 & y > 0); exit.Exit();

            }
        public void Lesson_146()
        {
                float x, y;
                Console.WriteLine("x:");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("y:");
                y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0}\n", x > 0 & y < 0); exit.Exit();

            }
        public void Lesson_147()
        {
                float x, y;
                Console.WriteLine("x:");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("y:");
                y = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("{0}\n", x < 0 & y != 0); exit.Exit();

            }
        public void Lesson_148()
        {
                float x, y;
                Console.WriteLine("x:");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("y:");
                y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0}\n", x * y > 0); exit.Exit();

            }
        public void Lesson_149()
        {
                float x, y, x1, y1, x2, y2;
                Console.WriteLine("x:");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("y:");
                y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("x1:");
                x1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("y1:");
                y1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("x2:");
                x2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("y2:");
                y2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0}\n", x1 < x & x < x2 & y2 < y & y < y1); exit.Exit();

            }
        public void Lesson_150()
        {
                float a, b, c;
                Console.WriteLine("a:");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("b:");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("c:");
                c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0}\n", (a == b) & (a == c) & (b == c)); exit.Exit();

            }
        public void Lesson_151()
        {
                float a, b, c;
                Console.WriteLine("a:");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("b:");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("c:");
                c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0}\n", (a == b) | (a == c) | (b == c)); exit.Exit();

            }
        public void Lesson_152()
        {
                float a, b, c;
                Console.WriteLine("a:");
                a = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("b:");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("c:");
                c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0}\n", (a * a == b * b + c * c) | (b * b == a * a + c * c) | (c * c == a * a + b * b)); exit.Exit();

            }
        

        public void Lesson_153()
            {
                float a, b, c;
                Console.WriteLine("a:");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("b:");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("c:");
                c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0}\n", (a < b + c) & (b < a + c) & (c < a + b)); exit.Exit();

            }

        public void Lesson_154()
            {
                int x, y;
                Console.WriteLine("x:");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("y:");
                y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0}\n", (x + y) % 2 != 0); exit.Exit();

            }

        public void Lesson_155()
            {
                int x1, y1, x2, y2;
                Console.WriteLine("x1:");
                x1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("y1:");
                y1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("x2:");
                x2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("y2:");
                y2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0}\n", (x1 + y1) % 2 == (x2 + y2) % 2); exit.Exit();

            }



        public void Lesson_156()
            {
                int x1, y1, x2, y2;
                Console.WriteLine("x1:");
                x1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("y1:");
                y1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("x2:");
                x2= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("y2:");
                y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}\n", (x1 == x2) | (y1 == y2)); exit.Exit();

            }



        public void Lesson_157()
            {
                int x1, y1, x2, y2;
                Console.WriteLine("x1:");
                x1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("y1:");
                y1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("x2:");
                x2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("y2:");
                y2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0}\n", Math.Abs(x1 - x2) <= 1 & Math.Abs(y1 - y2) <= 1); exit.Exit();

            }



        public void Lesson_158()
            {
                int x1, y1, x2, y2;
                Console.WriteLine("x1:");
                x1
                    = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("y1:");
                y1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("x2:");
               x2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("y2:");
                y2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0}\n", Math.Abs(x1 - x2) == Math.Abs(y1 - y2)); exit.Exit();

            }


        public void Lesson_159()
            {


                int x1, y1, x2, y2;
                Console.WriteLine("x1:");
                x1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("y1:");
                y1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("x2:");
                x2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("y2:");
                y2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0}\n", Math.Abs(x1 - x2) == Math.Abs(y1 - y2) | (x1 == x2) | (y1 == y2)); exit.Exit();

            }

        
        public void Lesson_160()
        {
                int x1, y1, x2, y2;
                Console.WriteLine("x1:");
                x1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("y1:");
                y1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("x2:");
                x2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("y2:");
                y2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0}\n", (Math.Abs(x1 - x2) == 1 & Math.Abs(y1 - y2) == 2) | (Math.Abs(x1 - x2) == 2 & Math.Abs(y1 - y2) == 1)); exit.Exit();

            }




        /// <summary>
        /// ////////////////////////////// if else
        /// </summary>
        /// 

        public void Lesson_161()
        {
            int a;
            Console.WriteLine("a:");
            a = Convert.ToInt32(Console.ReadLine());

            if (a > 0)
            {
                a++;
            }

            Console.WriteLine("{0}\n", a);
         


            exit.Exit();

        }

        public void Lesson_162()
        {
            int a;
            Console.WriteLine("a:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
                a++;
            else
                a = a - 2;

            Console.WriteLine("{0}\n", a);
         
            exit.Exit();
        }

        public void Lesson_163()
        {
            int a;
            Console.WriteLine("a:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                a = a - 2;
            }
            else if (a == 0)
            {
                a = 10;
            }
            else if (a > 0)
            {
                a++;
            }
            Console.WriteLine("{0}\n", a);
            exit.Exit();
        }

        public void Lesson_164()
        {
            int a1, a2, a3;
            Console.WriteLine("a1:");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a2:");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a3:");
            a3 = Convert.ToInt32(Console.ReadLine());

            if (a1 > 0) a1 = 1;
            else a1 = 0;

            if (a2 > 0) a2 = 1;
            else a2 = 0;

            if (a3 > 0) a3 = 1;
            else a3 = 0;


            Console.WriteLine("{0}\n", a1 + a2 + a3);
            exit.Exit();
        }

        public void Lesson_165()
        {
            int a1, a2, a3, res1, res2;
            Console.WriteLine("a1:");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a2:");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a3:");
            a3 = Convert.ToInt32(Console.ReadLine());

            res1 = res2 = 0;
            if (a1 > 0) res1++;
            if (a1 < 0) res2++;

            if (a2 > 0) res1++;
            if (a2 < 0) res2++;

            if (a3 > 0) res1++;
            if (a3 < 0) res2++;


            Console.WriteLine(" '+': {0}\n '-': {1}\n", res1, res2);
            exit.Exit();
        }

        public void Lesson_166()
        {
            int a1, a2;
            Console.WriteLine("a1:");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a2:");
            a2 = Convert.ToInt32(Console.ReadLine());

            if (a1 > a2) Console.WriteLine(" {0}\n", a1);
            else Console.WriteLine(" {0}\n", a2);
            exit.Exit();
        }

        public void Lesson_167()
        {
            int a1, a2;
            Console.WriteLine("a1:");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a2:");
            a2 = Convert.ToInt32(Console.ReadLine());

            if (a1 < a2) Console.WriteLine("{0}\n",1);
            else Console.WriteLine("{0}\n", 2);

            exit.Exit();
        }

        public void Lesson_168()
        {
            int a1, a2;
            Console.WriteLine("a1:");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a2:");
            a2 = Convert.ToInt32(Console.ReadLine());

            if (a1 > a2) Console.WriteLine(" {0} {1}\n", a1, a2);
            else Console.WriteLine(" {0} {1}\n", a2, a1);
            exit.Exit();
        }

        public void Lesson_169()
        {
            float a, b;
            Console.WriteLine("A:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B:");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }

            Console.WriteLine("a: {0}\n b: {0}\n", a, b);
            exit.Exit();
        }

        public void Lesson_170()
        {
            float a, b;
            Console.WriteLine("A:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B:");
            b = Convert.ToInt32(Console.ReadLine());

            if (a != b) a = b = a + b;
            else a = b = 0;

            Console.WriteLine("a: {0}\n b: {0}\n", a, b);
            exit.Exit();
        }

        public void Lesson_171()
        {
            float a, b;
            Console.WriteLine("A:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B:");
            b = Convert.ToInt32(Console.ReadLine());

            if (a != b) a = b = (a > b) ? a : b;
            else a = b = 0;

            Console.WriteLine("a: {0}\n b: {0}\n", a, b);
            exit.Exit();
        }

        public void Lesson_172()
        {
            float a1, a2, a3;
            Console.WriteLine("1:");
            a1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2:");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3:");
            a3 = Convert.ToInt32(Console.ReadLine());

            if ((a1 <= a2) & (a1 <= a3)) Console.WriteLine("{0}\n", a1);
            else if ((a2 <= a1) & (a2 <= a3)) Console.WriteLine("{0}\n", a2);
            else Console.WriteLine("{0}\n", a3);
            exit.Exit();
        }

        public void Lesson_173()
        {
            float a1, a2, a3;
            Console.WriteLine("1:");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2:");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3:");
            a3 = Convert.ToInt32(Console.ReadLine());

            if (((a2 <= a1) & (a1 <= a3)) | ((a2 >= a1) & (a1 >= a3))) Console.WriteLine("{0}\n", a1);
            else if (((a1 <= a2) & (a2 <= a3)) | ((a1 >= a2) & (a2 >= a3))) Console.WriteLine("{0}\n", a2);
            else Console.WriteLine("{0}\n", a3);
            exit.Exit();
        }

        public void Lesson_174()
        {
            float a1, a2, a3;
            Console.WriteLine("1:");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2:");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3:");
            a3 = Convert.ToInt32(Console.ReadLine());

            if ((a1 <= a2) & (a1 <= a3)) Console.WriteLine("{0}\n", a1);
            else if ((a2 <= a2) & (a2 <= a3)) Console.WriteLine("{0}\n", a2);
            else Console.WriteLine("{0}\n", a3);

            if ((a1 >= a2) & (a1 >= a3)) Console.WriteLine("{0}\n", a1);
            else if ((a2 >= a2) & (a2 >= a3)) Console.WriteLine("{0}\n", a2);
            else Console.WriteLine("{0}\n", a3);
            exit.Exit();
        }

        public void Lesson_175()
        {
            float a1, a2, a3, sum;
            Console.WriteLine("1:");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2:");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3:");
            a3 = Convert.ToInt32(Console.ReadLine());

            if ((a1 >= a2) & (a1 >= a3))
            {
                if (a2 >= a3)
                {
                    Console.WriteLine("{0}\n", a1 + a2);
                }
                else Console.WriteLine("{0}\n", a1 + a3);
            }
            else if ((a2 >= a1) & (a2 >= a3))
                if (a1 >= a3)
                {
                    Console.WriteLine("{0}\n", a1 + a2);
                }
                else Console.WriteLine("{0}\n", a2 + a3);
            else
              if (a1 >= a2)
            {
                Console.WriteLine("{0}\n", a1 + a3);
            }
            else Console.WriteLine("{0}\n", a2 + a3);
            exit.Exit();
        }

        public void Lesson_176()
        {
            float a, b, c;
            Console.WriteLine("A:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("C:");
            c = Convert.ToInt32(Console.ReadLine());

            if ((a <= b) & (b <= c))
            {
                a = a * 2;
                b = b * 2;
                c = c * 2;
            }
            else
            {
                a = a * (-1);
                b = b * (-1);
                c = c * (-1);
            }
            Console.WriteLine("A: {0}\nB: {1}\nC: {2}\n", a, b, c);
            exit.Exit();
        }

        public void Lesson_177()
        {
            float a, b, c;
            Console.WriteLine("A:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("C:");
            c = Convert.ToInt32(Console.ReadLine());

            if (((a <= b) & (b <= c)) | ((a >= b) & (b >= c)))
            {
                a = a * 2;
                b = b * 2;
                c = c * 2;
            }
            else
            {
                a = a * (-1);
                b = b * (-1);
                c = c * (-1);
            }
            Console.WriteLine("A: {0}\nB: {1}\nC: {2}\n", a, b, c);
            exit.Exit();
        }

        public void Lesson_178()
        {
    int a1, a2, a3;
            Console.WriteLine("1:");
    a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2:");
    a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3:");
    a3 = Convert.ToInt32(Console.ReadLine());

            if (a2 == a3) Console.WriteLine("{0}\n", 1);
    else if (a1 == a3) Console.WriteLine("{0}\n", 2);
            else Console.WriteLine("{0}\n", 3);
    exit.Exit();
        }

        public void Lesson_179()
        {
            int a1, a2, a3, a4;
            Console.WriteLine("1:");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2:");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3:");
            a3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("4:");
            a4 = Convert.ToInt32(Console.ReadLine());

            if (a2 == a3 ) Console.WriteLine("{0}\n", 1);
            else if (a1 == a3 ) Console.WriteLine("{0}\n", 2);
            else if (a2 == a4) Console.WriteLine("{0}\n", 3);
            else Console.WriteLine("{0}\n", 4);
            exit.Exit();
        }

        public void Lesson_180()
        {

            float a, b, c;
            Console.WriteLine("A:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("C:");
            c = Convert.ToInt32(Console.ReadLine());

            if (Math.Abs(a - b) < Math.Abs(a - c)) Console.WriteLine("B\n");
            else Console.WriteLine("C\n");
            exit.Exit();
        }

        public void Lesson_181()
        {
            int x, y;
            Console.WriteLine("x:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y:");
            y = Convert.ToInt32(Console.ReadLine());

            if ((x == 0) & (y == 0)) Console.WriteLine("0");
            else if (x == 0) Console.WriteLine("1");
            else if (y == 0) Console.WriteLine("2");
            else Console.WriteLine("3");

            exit.Exit();
        }


        public void Lesson_182()
        {

            float x, y;
            Console.WriteLine("x:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y:");
            y = Convert.ToInt32(Console.ReadLine());

            if ((x > 0) & (y > 0)) Console.WriteLine("I\n");
            else if ((x < 0) & (y > 0)) Console.WriteLine("II\n");
            else if ((x < 0) & (y < 0)) Console.WriteLine("III\n");
            else Console.WriteLine("IV\n");
            exit.Exit();
        }


        public void Lesson_183()
        {
            int x1, y1, x2, y2, x3, y3;
            Console.WriteLine("x1:");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y1:");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("x2:");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y2:");
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("x3:");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y3:");
            y3 = Convert.ToInt32(Console.ReadLine());

            if (x2 == x3) Console.WriteLine("x4: {0} \n", x1);
            else if (x3 == x1) Console.WriteLine("x4: {0} \n", x2);
            else Console.WriteLine("x4: {0} \n", x3);

            if (y2 == y3) Console.WriteLine("y4: {0} \n", y1);
            else if (y3 == y1) Console.WriteLine("y4: {0} \n", y2);
            else Console.WriteLine("y4: {0} \n", y3);
            exit.Exit();
        }


        public void Lesson_184()
        {
            float x;
            Console.WriteLine("x: ");
            x = Convert.ToInt32(Console.ReadLine());

            if (x > 0) Console.WriteLine("fx={0}\n", 2 * Math.Sin(x));
            else Console.WriteLine("fx={0}\n", 6 - x);
            exit.Exit();
        }


        public void Lesson_185()
        {
            float x;
            Console.WriteLine("x: ");
            x = Convert.ToInt32(Console.ReadLine());

            if ((x < -2) | (x > 2)) Console.WriteLine("fx={0}\n", 2 * x);
            else Console.WriteLine("fx={0}\n", -3 * x);
            exit.Exit();
        }


        public void Lesson_186()
        {
            float x;
            Console.WriteLine("x: ");
            x = Convert.ToInt32(Console.ReadLine());

            if (x <= 0) Console.WriteLine("fx={0}\n", -x);
            else if ((0 < x) & (x < 2)) Console.WriteLine("fx={0}\n", x * x);
            else Console.WriteLine("fx={0}\n", 4.0);
            exit.Exit();
        }


        public void Lesson_187()
        {
            float x;
            Console.WriteLine("x: ");
            x = Convert.ToInt32(Console.ReadLine());

            if (x < 0) Console.WriteLine("fx={0}\n", 0);
            else if ((((int)x) % 2) == 0) Console.WriteLine("fx={0}\n", 1);
            else Console.WriteLine("fx={0}\n", -1);

            exit.Exit();
        }


        public void Lesson_188()
        {
            int y;
            Console.WriteLine("year: ");
            y = Convert.ToInt32(Console.ReadLine());
            if ((y % 100) == 0)
                if ((y % 400) == 0) Console.WriteLine("366\n");
                else Console.WriteLine("365\n");
            else if ((y % 4) == 0) Console.WriteLine("366\n");
            else Console.WriteLine("365\n");
            exit.Exit();
        }


        public void Lesson_189()
        {
            int num;
            Console.WriteLine("num:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 0) Console.WriteLine("Нулевое");
            else
            {
                if (num > 0) Console.WriteLine("Положительное ");
                else Console.WriteLine("Отрицательное ");
                if ((num % 2) == 0) Console.WriteLine("чётное ");
                else Console.WriteLine("нечётное ");
            }
            Console.WriteLine("число.");

            exit.Exit();
        }

        public void Lesson_190()
        {
            int num;
            Console.WriteLine("num:");
            num = Convert.ToInt32(Console.ReadLine());

            if ((num % 2) == 0) Console.WriteLine("Чётное ");
            else Console.WriteLine("Нечётное ");
            if (num > 99) Console.WriteLine("трёхзначное ");
            else if ((99 >= num) & (num > 9)) Console.WriteLine("двухзначное ");
            else if (num <= 9) Console.WriteLine("однозначное ");
            Console.WriteLine("число.");
            exit.Exit();
        }

        /// <summary>
        /// ///////////////////////////////////// 
        /// </summary>

        public void Lesson_191()
        {
            int a, b;
            Console.WriteLine("A:");
            a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B:");
            b = Convert.ToInt32(Console.ReadLine());

            int temp = a;
            while (temp >= 0)
            {
                temp -= b;
            }
            Console.WriteLine("{0}\n ", temp + b);
            exit.Exit();
        }

        public void Lesson_192()
        {

            int a, b;
            Console.WriteLine("A:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B:");
            b = Convert.ToInt32(Console.ReadLine());

            int temp = a;
            int num = 0;
            while (temp - b >= 0)
            {
                temp -= b;
                ++num;
            }
            Console.WriteLine("{0}\n ", num);
            exit.Exit();
        }

        public void Lesson_193()
        {
            int n, k;
            Console.WriteLine("N:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("K:");
            k = Convert.ToInt32(Console.ReadLine());

            int num = 0;
            while (n >= k)
            {
                n -= k;
                ++num;
            }
            Console.WriteLine("int\\int:{0}\n", num);

            Console.WriteLine("{0}\n", n);
            exit.Exit();
        }

        public void Lesson_194()
        {
            int a;
            Console.WriteLine("A:");
            a = Convert.ToInt32(Console.ReadLine());

            while (a > 0) a -= 3;

            Console.WriteLine("{0}\n", a == 0 ? "True" : "False");
            exit.Exit();
        }

        public void Lesson_195()
        {
            int n;
            Console.WriteLine("N:");
            n = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            while (n >= 2)
            {
                ++k;
                n /= 2;
            }
            Console.WriteLine("K: {0}\n", k);
            exit.Exit();
        }

        public void Lesson_196()
        {
            int n;
            Console.WriteLine("N:");
            n = Convert.ToInt32(Console.ReadLine());
            float rez = 1;
            while (n >= 2)
            {
                rez *= n;
                n -= 2;
            }

            Console.WriteLine("N!!: {0}\n", rez);
            exit.Exit();
        }

        public void Lesson_197()
        {
            int n;
            Console.WriteLine("N:");
            n = Convert.ToInt32(Console.ReadLine());
            int k = 1;
            while (k * k <= n) ++k;
            Console.WriteLine("K: {0}\n", k);
            exit.Exit();
        }

        public void Lesson_198()
        {
            int n;
            Console.WriteLine("N:");
            n = Convert.ToInt32(Console.ReadLine());
            int k = 1;
            while (k * k <= n) ++k;
            Console.WriteLine("K: {0}", k - 1);
            exit.Exit();
        }

        public void Lesson_199()
        {

            int n;
            Console.WriteLine("N:");
            n = Convert.ToInt32(Console.ReadLine());
            int k = 1, temp = 3;
            while (temp <= n)
            {
                temp *= 3;
                ++k;
            }
            Console.WriteLine("K: {0}\n", k);
            exit.Exit();
        }

        public void Lesson_200()
        {
            int n;
            Console.WriteLine("N:");
            n = Convert.ToInt32(Console.ReadLine());
            int k = 0, temp = 3;
            while (temp < n)
            {
                temp *= 3;
                ++k;
            }
            Console.WriteLine("K: {0}\n", k);
            exit.Exit();
        }


















































    }
}