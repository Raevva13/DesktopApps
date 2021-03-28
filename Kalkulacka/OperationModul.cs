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
        /// Plus method with Input "a","b" and output Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Result, ResultString</returns>
        public ResultHolder Plus(double a, double b)
        {
            ResultHolder holder = new ResultHolder { Result = a + b }; //result
            holder.ResultString = $"{a} + {b} = {holder.Result}"; //result string with calculation

            return holder;
        }

        /// <summary>resu
        /// Minus method with input "a","b" and output Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Result, ResultString</returns>
        public ResultHolder Minus(double a, double b)
        {
            ResultHolder holder = new ResultHolder { Result = a - b }; //result
            holder.ResultString = $"{a} - {b} = {holder.Result}"; //result string with calculation

            return holder;
        }


        /// <summary>
        /// Multiply method with input "a","b" and output Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Result, ResultString</returns>
        public ResultHolder Times(double a, double b)
        {
            ResultHolder holder = new ResultHolder { Result = a * b }; //result
            holder.ResultString = $"{a} * {b} = {holder.Result}"; //result string with calculation

            return holder;
        }

        /// <summary>
        /// Divided method with input "a", "b" and output Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Result, ResultString</returns>
        public ResultHolder Divided(double a, double b)
        {
            ResultHolder holder = new ResultHolder { Result = a / b }; //result
            holder.ResultString = $"{a} ÷ {b} = {holder.Result}"; //result string with calculation

            return holder;
        }

        /// <summary>
        /// Modulo method with input "a","b", and output Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Result, ResultString</returns>
        public ResultHolder Modulo(double a, double b)
        {
            ResultHolder holder = new ResultHolder { Result = a % b }; //result
            holder.ResultString = $"{a} % {b} = {holder.Result}"; //result string with calculation

            return holder;
        }

        /// <summary>
        /// Sinus method (on degrees) with input "a" (degrees) and output Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Result, ResultString</returns>
        public ResultHolder Sin(double a)
        {
            ResultHolder holder = new ResultHolder { Result = Math.Sin((Math.PI * a) / 180)}; //result
            holder.ResultString = $"sin{a}° = {holder.Result}"; //result string with calculation

            return holder;
        }

        /// <summary>
        /// Cosinus method (on degrees) with input "a" (degrees) and output Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <returns>Result, ResultString</returns>
        public ResultHolder Cos(double a)
        {
            ResultHolder holder = new ResultHolder {Result = Math.Cos((Math.PI * a) / 180)}; //result
            holder.ResultString = $"cos{a}° = {holder.Result}"; //result string with calculation

            return holder;
        }

        /// <summary>
        /// Tangens method (on degree) with input "a" (degrees) and output Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <returns>Result, ResultString</returns>
        public ResultHolder Tan(double a)
        {
            ResultHolder holder = new ResultHolder { Result = Math.Tan((Math.PI * a) / 180) }; //result
            holder.ResultString = $"tan{a}° = {holder.Result}"; //result string with calculation

            return holder;
        }

        /// <summary>
        /// Cotangens method (on degree) with input "a" (degrees and output Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <returns>Result, ResultString</returns>
        public ResultHolder Cotan(double a)
        {
            ResultHolder holder = new ResultHolder { Result = 1 / (Math.Tan((Math.PI * a) / 180)) }; //result
            holder.ResultString = $"cotan{a}° = {holder.Result}"; //result string with calculation

            return holder;
        }

        /// <summary>
        /// SquereRoot method with input "a" and output Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <returns>Result, ResultString</returns>
        public ResultHolder SquereRoot(double a)
        {
            ResultHolder holder = new ResultHolder { Result = Math.Pow(a, 2) }; //result
            holder.ResultString = $"{a}^2 = {holder.Result}"; //result string with calculation

            return holder;
        }

        /// <summary>
        /// Cubes method with input "a" and output Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <returns>Result, ResultString</returns>
        public ResultHolder Cube(double a)
        {
            ResultHolder holder = new ResultHolder { Result = Math.Pow(a, 3) }; //result
            holder.ResultString = $"{a}^3 = {holder.Result}"; //result string with calculation

            return holder;
        }

        /// <summary>
        /// Power method with input "a","b" and output Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Result, ResultString</returns>
        public ResultHolder Power(double a, double b)
        {
            ResultHolder holder = new ResultHolder { Result = Math.Pow(a, b) }; //result
            holder.ResultString = $"{a}^{b} = {holder.Result}"; //result string with calculation

            return holder;
        }
    }
}
