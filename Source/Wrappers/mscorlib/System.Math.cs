using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Math
    {
        public static IObservable<System.Double> Acos(IObservable<System.Double> d)
        {
            return Observable.Select(d, (dLambda) => System.Math.Acos(dLambda));
        }


        public static IObservable<System.Double> Asin(IObservable<System.Double> d)
        {
            return Observable.Select(d, (dLambda) => System.Math.Asin(dLambda));
        }


        public static IObservable<System.Double> Atan(IObservable<System.Double> d)
        {
            return Observable.Select(d, (dLambda) => System.Math.Atan(dLambda));
        }


        public static IObservable<System.Double> Atan2(IObservable<System.Double> y, IObservable<System.Double> x)
        {
            return Observable.Zip(y, x, (yLambda, xLambda) => System.Math.Atan2(yLambda, xLambda));
        }


        public static IObservable<System.Decimal> Ceiling(IObservable<System.Decimal> d)
        {
            return Observable.Select(d, (dLambda) => System.Math.Ceiling(dLambda));
        }


        public static IObservable<System.Double> Ceiling(IObservable<System.Double> a)
        {
            return Observable.Select(a, (aLambda) => System.Math.Ceiling(aLambda));
        }


        public static IObservable<System.Double> Cos(IObservable<System.Double> d)
        {
            return Observable.Select(d, (dLambda) => System.Math.Cos(dLambda));
        }


        public static IObservable<System.Double> Cosh(IObservable<System.Double> value)
        {
            return Observable.Select(value, (valueLambda) => System.Math.Cosh(valueLambda));
        }


        public static IObservable<System.Decimal> Floor(IObservable<System.Decimal> d)
        {
            return Observable.Select(d, (dLambda) => System.Math.Floor(dLambda));
        }


        public static IObservable<System.Double> Floor(IObservable<System.Double> d)
        {
            return Observable.Select(d, (dLambda) => System.Math.Floor(dLambda));
        }


        public static IObservable<System.Double> Sin(IObservable<System.Double> a)
        {
            return Observable.Select(a, (aLambda) => System.Math.Sin(aLambda));
        }


        public static IObservable<System.Double> Tan(IObservable<System.Double> a)
        {
            return Observable.Select(a, (aLambda) => System.Math.Tan(aLambda));
        }


        public static IObservable<System.Double> Sinh(IObservable<System.Double> value)
        {
            return Observable.Select(value, (valueLambda) => System.Math.Sinh(valueLambda));
        }


        public static IObservable<System.Double> Tanh(IObservable<System.Double> value)
        {
            return Observable.Select(value, (valueLambda) => System.Math.Tanh(valueLambda));
        }


        public static IObservable<System.Double> Round(IObservable<System.Double> a)
        {
            return Observable.Select(a, (aLambda) => System.Math.Round(aLambda));
        }


        public static IObservable<System.Double> Round(IObservable<System.Double> value,
            IObservable<System.Int32> digits)
        {
            return Observable.Zip(value, digits,
                (valueLambda, digitsLambda) => System.Math.Round(valueLambda, digitsLambda));
        }


        public static IObservable<System.Double> Round(IObservable<System.Double> value,
            IObservable<System.MidpointRounding> mode)
        {
            return Observable.Zip(value, mode, (valueLambda, modeLambda) => System.Math.Round(valueLambda, modeLambda));
        }


        public static IObservable<System.Double> Round(IObservable<System.Double> value,
            IObservable<System.Int32> digits, IObservable<System.MidpointRounding> mode)
        {
            return Observable.Zip(value, digits, mode,
                (valueLambda, digitsLambda, modeLambda) => System.Math.Round(valueLambda, digitsLambda, modeLambda));
        }


        public static IObservable<System.Decimal> Round(IObservable<System.Decimal> d)
        {
            return Observable.Select(d, (dLambda) => System.Math.Round(dLambda));
        }


        public static IObservable<System.Decimal> Round(IObservable<System.Decimal> d,
            IObservable<System.Int32> decimals)
        {
            return Observable.Zip(d, decimals, (dLambda, decimalsLambda) => System.Math.Round(dLambda, decimalsLambda));
        }


        public static IObservable<System.Decimal> Round(IObservable<System.Decimal> d,
            IObservable<System.MidpointRounding> mode)
        {
            return Observable.Zip(d, mode, (dLambda, modeLambda) => System.Math.Round(dLambda, modeLambda));
        }


        public static IObservable<System.Decimal> Round(IObservable<System.Decimal> d,
            IObservable<System.Int32> decimals, IObservable<System.MidpointRounding> mode)
        {
            return Observable.Zip(d, decimals, mode,
                (dLambda, decimalsLambda, modeLambda) => System.Math.Round(dLambda, decimalsLambda, modeLambda));
        }


        public static IObservable<System.Decimal> Truncate(IObservable<System.Decimal> d)
        {
            return Observable.Select(d, (dLambda) => System.Math.Truncate(dLambda));
        }


        public static IObservable<System.Double> Truncate(IObservable<System.Double> d)
        {
            return Observable.Select(d, (dLambda) => System.Math.Truncate(dLambda));
        }


        public static IObservable<System.Double> Sqrt(IObservable<System.Double> d)
        {
            return Observable.Select(d, (dLambda) => System.Math.Sqrt(dLambda));
        }


        public static IObservable<System.Double> Log(IObservable<System.Double> d)
        {
            return Observable.Select(d, (dLambda) => System.Math.Log(dLambda));
        }


        public static IObservable<System.Double> Log10(IObservable<System.Double> d)
        {
            return Observable.Select(d, (dLambda) => System.Math.Log10(dLambda));
        }


        public static IObservable<System.Double> Exp(IObservable<System.Double> d)
        {
            return Observable.Select(d, (dLambda) => System.Math.Exp(dLambda));
        }


        public static IObservable<System.Double> Pow(IObservable<System.Double> x, IObservable<System.Double> y)
        {
            return Observable.Zip(x, y, (xLambda, yLambda) => System.Math.Pow(xLambda, yLambda));
        }


        public static IObservable<System.Double> IEEERemainder(IObservable<System.Double> x,
            IObservable<System.Double> y)
        {
            return Observable.Zip(x, y, (xLambda, yLambda) => System.Math.IEEERemainder(xLambda, yLambda));
        }


        public static IObservable<System.SByte> Abs(IObservable<System.SByte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Math.Abs(valueLambda));
        }


        public static IObservable<System.Int16> Abs(IObservable<System.Int16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Math.Abs(valueLambda));
        }


        public static IObservable<System.Int32> Abs(IObservable<System.Int32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Math.Abs(valueLambda));
        }


        public static IObservable<System.Int64> Abs(IObservable<System.Int64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Math.Abs(valueLambda));
        }


        public static IObservable<System.Single> Abs(IObservable<System.Single> value)
        {
            return Observable.Select(value, (valueLambda) => System.Math.Abs(valueLambda));
        }


        public static IObservable<System.Double> Abs(IObservable<System.Double> value)
        {
            return Observable.Select(value, (valueLambda) => System.Math.Abs(valueLambda));
        }


        public static IObservable<System.Decimal> Abs(IObservable<System.Decimal> value)
        {
            return Observable.Select(value, (valueLambda) => System.Math.Abs(valueLambda));
        }


        public static IObservable<System.SByte> Max(IObservable<System.SByte> val1, IObservable<System.SByte> val2)
        {
            return Observable.Zip(val1, val2, (val1Lambda, val2Lambda) => System.Math.Max(val1Lambda, val2Lambda));
        }


        public static IObservable<System.Byte> Max(IObservable<System.Byte> val1, IObservable<System.Byte> val2)
        {
            return Observable.Zip(val1, val2, (val1Lambda, val2Lambda) => System.Math.Max(val1Lambda, val2Lambda));
        }


        public static IObservable<System.Int16> Max(IObservable<System.Int16> val1, IObservable<System.Int16> val2)
        {
            return Observable.Zip(val1, val2, (val1Lambda, val2Lambda) => System.Math.Max(val1Lambda, val2Lambda));
        }


        public static IObservable<System.UInt16> Max(IObservable<System.UInt16> val1, IObservable<System.UInt16> val2)
        {
            return Observable.Zip(val1, val2, (val1Lambda, val2Lambda) => System.Math.Max(val1Lambda, val2Lambda));
        }


        public static IObservable<System.Int32> Max(IObservable<System.Int32> val1, IObservable<System.Int32> val2)
        {
            return Observable.Zip(val1, val2, (val1Lambda, val2Lambda) => System.Math.Max(val1Lambda, val2Lambda));
        }


        public static IObservable<System.UInt32> Max(IObservable<System.UInt32> val1, IObservable<System.UInt32> val2)
        {
            return Observable.Zip(val1, val2, (val1Lambda, val2Lambda) => System.Math.Max(val1Lambda, val2Lambda));
        }


        public static IObservable<System.Int64> Max(IObservable<System.Int64> val1, IObservable<System.Int64> val2)
        {
            return Observable.Zip(val1, val2, (val1Lambda, val2Lambda) => System.Math.Max(val1Lambda, val2Lambda));
        }


        public static IObservable<System.UInt64> Max(IObservable<System.UInt64> val1, IObservable<System.UInt64> val2)
        {
            return Observable.Zip(val1, val2, (val1Lambda, val2Lambda) => System.Math.Max(val1Lambda, val2Lambda));
        }


        public static IObservable<System.Single> Max(IObservable<System.Single> val1, IObservable<System.Single> val2)
        {
            return Observable.Zip(val1, val2, (val1Lambda, val2Lambda) => System.Math.Max(val1Lambda, val2Lambda));
        }


        public static IObservable<System.Double> Max(IObservable<System.Double> val1, IObservable<System.Double> val2)
        {
            return Observable.Zip(val1, val2, (val1Lambda, val2Lambda) => System.Math.Max(val1Lambda, val2Lambda));
        }


        public static IObservable<System.Decimal> Max(IObservable<System.Decimal> val1, IObservable<System.Decimal> val2)
        {
            return Observable.Zip(val1, val2, (val1Lambda, val2Lambda) => System.Math.Max(val1Lambda, val2Lambda));
        }


        public static IObservable<System.SByte> Min(IObservable<System.SByte> val1, IObservable<System.SByte> val2)
        {
            return Observable.Zip(val1, val2, (val1Lambda, val2Lambda) => System.Math.Min(val1Lambda, val2Lambda));
        }


        public static IObservable<System.Byte> Min(IObservable<System.Byte> val1, IObservable<System.Byte> val2)
        {
            return Observable.Zip(val1, val2, (val1Lambda, val2Lambda) => System.Math.Min(val1Lambda, val2Lambda));
        }


        public static IObservable<System.Int16> Min(IObservable<System.Int16> val1, IObservable<System.Int16> val2)
        {
            return Observable.Zip(val1, val2, (val1Lambda, val2Lambda) => System.Math.Min(val1Lambda, val2Lambda));
        }


        public static IObservable<System.UInt16> Min(IObservable<System.UInt16> val1, IObservable<System.UInt16> val2)
        {
            return Observable.Zip(val1, val2, (val1Lambda, val2Lambda) => System.Math.Min(val1Lambda, val2Lambda));
        }


        public static IObservable<System.Int32> Min(IObservable<System.Int32> val1, IObservable<System.Int32> val2)
        {
            return Observable.Zip(val1, val2, (val1Lambda, val2Lambda) => System.Math.Min(val1Lambda, val2Lambda));
        }


        public static IObservable<System.UInt32> Min(IObservable<System.UInt32> val1, IObservable<System.UInt32> val2)
        {
            return Observable.Zip(val1, val2, (val1Lambda, val2Lambda) => System.Math.Min(val1Lambda, val2Lambda));
        }


        public static IObservable<System.Int64> Min(IObservable<System.Int64> val1, IObservable<System.Int64> val2)
        {
            return Observable.Zip(val1, val2, (val1Lambda, val2Lambda) => System.Math.Min(val1Lambda, val2Lambda));
        }


        public static IObservable<System.UInt64> Min(IObservable<System.UInt64> val1, IObservable<System.UInt64> val2)
        {
            return Observable.Zip(val1, val2, (val1Lambda, val2Lambda) => System.Math.Min(val1Lambda, val2Lambda));
        }


        public static IObservable<System.Single> Min(IObservable<System.Single> val1, IObservable<System.Single> val2)
        {
            return Observable.Zip(val1, val2, (val1Lambda, val2Lambda) => System.Math.Min(val1Lambda, val2Lambda));
        }


        public static IObservable<System.Double> Min(IObservable<System.Double> val1, IObservable<System.Double> val2)
        {
            return Observable.Zip(val1, val2, (val1Lambda, val2Lambda) => System.Math.Min(val1Lambda, val2Lambda));
        }


        public static IObservable<System.Decimal> Min(IObservable<System.Decimal> val1, IObservable<System.Decimal> val2)
        {
            return Observable.Zip(val1, val2, (val1Lambda, val2Lambda) => System.Math.Min(val1Lambda, val2Lambda));
        }


        public static IObservable<System.Double> Log(IObservable<System.Double> a, IObservable<System.Double> newBase)
        {
            return Observable.Zip(a, newBase, (aLambda, newBaseLambda) => System.Math.Log(aLambda, newBaseLambda));
        }


        public static IObservable<System.Int32> Sign(IObservable<System.SByte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Math.Sign(valueLambda));
        }


        public static IObservable<System.Int32> Sign(IObservable<System.Int16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Math.Sign(valueLambda));
        }


        public static IObservable<System.Int32> Sign(IObservable<System.Int32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Math.Sign(valueLambda));
        }


        public static IObservable<System.Int32> Sign(IObservable<System.Int64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Math.Sign(valueLambda));
        }


        public static IObservable<System.Int32> Sign(IObservable<System.Single> value)
        {
            return Observable.Select(value, (valueLambda) => System.Math.Sign(valueLambda));
        }


        public static IObservable<System.Int32> Sign(IObservable<System.Double> value)
        {
            return Observable.Select(value, (valueLambda) => System.Math.Sign(valueLambda));
        }


        public static IObservable<System.Int32> Sign(IObservable<System.Decimal> value)
        {
            return Observable.Select(value, (valueLambda) => System.Math.Sign(valueLambda));
        }


        public static IObservable<System.Int64> BigMul(IObservable<System.Int32> a, IObservable<System.Int32> b)
        {
            return Observable.Zip(a, b, (aLambda, bLambda) => System.Math.BigMul(aLambda, bLambda));
        }


        public static IObservable<Tuple<System.Int32, System.Int32>> DivRem(IObservable<System.Int32> a,
            IObservable<System.Int32> b)
        {
            return Observable.Zip(a, b, (aLambda, bLambda) =>
            {
                System.Int32 resultOutput = default(System.Int32);
                var result = System.Math.DivRem(aLambda, bLambda, out resultOutput);
                return Tuple.Create(result, resultOutput);
            });
        }


        public static IObservable<Tuple<System.Int64, System.Int64>> DivRem(IObservable<System.Int64> a,
            IObservable<System.Int64> b)
        {
            return Observable.Zip(a, b, (aLambda, bLambda) =>
            {
                System.Int64 resultOutput = default(System.Int64);
                var result = System.Math.DivRem(aLambda, bLambda, out resultOutput);
                return Tuple.Create(result, resultOutput);
            });
        }
    }
}