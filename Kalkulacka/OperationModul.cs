using Kalkulacka.DataHolders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kalkulacka
{
    public class OperationModul
    {
        private static readonly object lockObject = new object();
        private static OperationModul _instance;

        private OperationModul() 
        { }

        public static OperationModul Instance
        {
            get
            {
                lock(lockObject)
                {
                    return _instance ?? (_instance = new OperationModul());
                }
            }
        }

        /// <summary>
        /// TBD
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public ResultHolder Plus(double a, double b)
        {
            ResultHolder holder = new ResultHolder();
            holder.Result = a + b;
            holder.ResultString = $"{a} + {b} = {holder.Result}";

            return holder;
        }

        public ResultHolder Minus(double a, double b)
        {
            ResultHolder holder = new ResultHolder();
            holder.Result = a - b;
            holder.ResultString = $"{a} - {b} = {holder.Result}";

            return holder;
        }

        public ResultHolder Times(double a, double b)
        {
            ResultHolder holder = new ResultHolder();
            holder.Result = a * b;
            holder.ResultString = $"{a} * {b} = {holder.Result}";

            return holder;
        }

        public ResultHolder Divided(double a, double b)
        {
            ResultHolder holder = new ResultHolder();
            holder.Result = a / b;
            holder.ResultString = $"{a} ÷ {b} = {holder.Result}";

            return holder;
        }

        public ResultHolder Modulo(double a, double b)
        {
            ResultHolder holder = new ResultHolder();
            holder.Result = a % b;
            holder.ResultString = $"{a} % {b} = {holder.Result}";

            return holder;
        }

        public ResultHolder Sin(double a)
        {
            ResultHolder holder = new ResultHolder();
            holder.Result = Math.Sin((Math.PI * a) / 180);
            holder.ResultString = $"sin{a}° = {holder.Result}";

            return holder;
        }

        public ResultHolder Cos(double a)
        {
            ResultHolder holder = new ResultHolder();
            holder.Result = Math.Cos((Math.PI * a) / 180);
            holder.ResultString = $"cos{a}° = {holder.Result}";

            return holder;
        }

        public ResultHolder Tan(double a)
        {
            ResultHolder holder = new ResultHolder();
            holder.Result = Math.Tan((Math.PI * a) / 180);
            holder.ResultString = $"tan{a}° = {holder.Result}";

            return holder;
        }

        public ResultHolder Cotan(double a)
        {
            ResultHolder holder = new ResultHolder();
            holder.Result = 1 / (Math.Tan((Math.PI * a) / 180));
            holder.ResultString = $"cotan{a}° = {holder.Result}";

            return holder;
        }

        public ResultHolder SquereRoot(double a)
        {
            ResultHolder holder = new ResultHolder();
            holder.Result = Math.Pow(a, 2);
            holder.ResultString = $"{a}^2 = {holder.Result}";

            return holder;
        }

        public ResultHolder Cube(double a)
        {
            ResultHolder holder = new ResultHolder();
            holder.Result = Math.Pow(a, 3);
            holder.ResultString = $"{a}^3 = {holder.Result}";
            return holder;
        }

        public ResultHolder Power(double a, double b)
        {
            ResultHolder holder = new ResultHolder();
            holder.Result = Math.Pow(a, b);
            holder.ResultString = $"{a}^{b} = {holder.Result}";

            return holder;
        }
    }
}
