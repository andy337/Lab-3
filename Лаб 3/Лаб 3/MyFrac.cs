using System;
using System.Collections.Generic;
using System.Text;

namespace Лаб_3
{
    class MyFrac
    {
        private long nom;
        private long denom;

        public MyFrac(long nom_, long denom_)
        {
            long a = nom_;
            long b = denom_;
            while (b != 0)
                b = a % (a = b);

            if (denom_ < 0)
            {
                denom_ = Math.Abs(denom_);
                nom_ = -1 * nom_;
                if (nom_ < 0)
                {
                    nom_ = Math.Abs(nom_);
                }
            }

            nom = nom_ / Math.Abs(a);
            denom = denom_ / Math.Abs(a);
        }

        public override string ToString()
        {
            return nom + "/" + denom;
        }

        public static MyFrac Plus(MyFrac f1, MyFrac f2)
        {
            return new MyFrac(f1.nom * f2.denom + f1.denom * f2.nom, f1.denom * f2.denom);
        }

        public static MyFrac Minus(MyFrac f1, MyFrac f2)
        {
            return new MyFrac(f1.nom * f2.denom - f2.nom * f1.denom, f1.denom * f2.denom);
        }

        public static MyFrac Multiply(MyFrac f1, MyFrac f2)
        {
            return new MyFrac(f1.nom * f2.nom, f1.denom * f2.denom);
        }

        public static MyFrac Divide(MyFrac f1, MyFrac f2)
        {
            return new MyFrac(f1.nom * f2.denom, f1.denom * f2.nom);
        }

        public static MyFrac GetRGR115LeftSum(int n)
        {
            MyFrac res = new MyFrac(1, 1);
            for (int i = 2; i <= n; i++)
            {
                res = Multiply(res, Minus(new MyFrac(1, 1), new MyFrac(1, i * i)));
            }
            return res;
        }

        public static MyFrac GetRGR113LeftSum(int n)
        {
            MyFrac res = new MyFrac(0, 1);
            for (int i = 1; i <= n; i++)
            {
                res = Plus(res, Multiply(new MyFrac(1, (2 * i) - 1), new MyFrac(1, (2 * i) + 1)));
            }
            return res;
        }
    }
}
