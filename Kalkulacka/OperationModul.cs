using Kalkulacka.DataHolders;
using System;


namespace Kalkulacka
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class OperationModul
    {

        private static readonly object lockObject = new object();
        private static OperationModul _instance;

        private OperationModul() 
        { }

        /// <summary>
        /// Singleton Instance
        /// </summary>
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
        /// Plus method with Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public ResultHolder Plus(double a, double b)
        {
            ResultHolder holder = new ResultHolder { Result = a + b };
            holder.ResultString = $"{a} + {b} = {holder.Result}";

            return holder;
        }

        /// <summary>resu
        /// Minus method with Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public ResultHolder Minus(double a, double b)
        {
            ResultHolder holder = new ResultHolder { Result = a - b };
            holder.ResultString = $"{a} - {b} = {holder.Result}";

            return holder;
        }


        /// <summary>
        /// Multiply method with Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public ResultHolder Times(double a, double b)
        {
            ResultHolder holder = new ResultHolder { Result = a * b };
            holder.ResultString = $"{a} * {b} = {holder.Result}";

            return holder;
        }

        /// <summary>
        /// Divided method with Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public ResultHolder Divided(double a, double b)
        {
            ResultHolder holder = new ResultHolder { Result = a / b };
            holder.ResultString = $"{a} ÷ {b} = {holder.Result}";

            return holder;
        }

        /// <summary>
        /// Modulo method with Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public ResultHolder Modulo(double a, double b)
        {
            ResultHolder holder = new ResultHolder { Result = a % b };
            holder.ResultString = $"{a} % {b} = {holder.Result}";

            return holder;
        }

        /// <summary>
        /// Sinus method (on degrees) with Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public ResultHolder Sin(double a)
        {
            ResultHolder holder = new ResultHolder { Result = Math.Sin((Math.PI * a) / 180)};
            holder.ResultString = $"sin{a}° = {holder.Result}";

            return holder;
        }

        /// <summary>
        /// Cosinus method (on degrees) with Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public ResultHolder Cos(double a)
        {
            ResultHolder holder = new ResultHolder {Result = Math.Cos((Math.PI * a) / 180)};
            holder.ResultString = $"cos{a}° = {holder.Result}";

            return holder;
        }

        /// <summary>
        /// Tangens method (on degree) with Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>

        public ResultHolder Tan(double a)
        {
            ResultHolder holder = new ResultHolder { Result = Math.Tan((Math.PI * a) / 180) };
            holder.ResultString = $"tan{a}° = {holder.Result}";

            return holder;
        }

        /// <summary>
        /// Cotangens method (on degree) with Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public ResultHolder Cotan(double a)
        {
            ResultHolder holder = new ResultHolder { Result = 1 / (Math.Tan((Math.PI * a) / 180)) };
            holder.ResultString = $"cotan{a}° = {holder.Result}";

            return holder;
        }

        /// <summary>
        /// SquereRoot method with Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public ResultHolder SquereRoot(double a)
        {
            ResultHolder holder = new ResultHolder { Result = Math.Pow(a, 2) };
            holder.ResultString = $"{a}^2 = {holder.Result}";

            return holder;
        }

        /// <summary>
        /// Cubes method with Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>

        public ResultHolder Cube(double a)
        {
            ResultHolder holder = new ResultHolder { Result = Math.Pow(a, 3) };
            holder.ResultString = $"{a}^3 = {holder.Result}";

            return holder;
        }

        /// <summary>
        /// Power method with Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public ResultHolder Power(double a, double b)
        {
            ResultHolder holder = new ResultHolder { Result = Math.Pow(a, b) };
            holder.ResultString = $"{a}^{b} = {holder.Result}";

            return holder;
        }
    }
}
