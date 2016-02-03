using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Guid
    {
        public static IObservable<System.Guid> Parse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => System.Guid.Parse(inputLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Guid>> TryParse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) =>
            {
                System.Guid resultOutput = default(System.Guid);
                var result = System.Guid.TryParse(inputLambda, out resultOutput);
                return Tuple.Create(result, resultOutput);
            });
        }


        public static IObservable<System.Guid> ParseExact(IObservable<System.String> input,
            IObservable<System.String> format)
        {
            return Observable.Zip(input, format,
                (inputLambda, formatLambda) => System.Guid.ParseExact(inputLambda, formatLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Guid>> TryParseExact(IObservable<System.String> input,
            IObservable<System.String> format)
        {
            return Observable.Zip(input, format, (inputLambda, formatLambda) =>
            {
                System.Guid resultOutput = default(System.Guid);
                var result = System.Guid.TryParseExact(inputLambda, formatLambda, out resultOutput);
                return Tuple.Create(result, resultOutput);
            });
        }


        public static IObservable<System.Byte[]> ToByteArray(this IObservable<System.Guid> GuidValue)
        {
            return Observable.Select(GuidValue, (GuidValueLambda) => GuidValueLambda.ToByteArray());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Guid> GuidValue)
        {
            return Observable.Select(GuidValue, (GuidValueLambda) => GuidValueLambda.ToString());
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Guid> GuidValue)
        {
            return Observable.Select(GuidValue, (GuidValueLambda) => GuidValueLambda.GetHashCode());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Guid> GuidValue,
            IObservable<System.Object> o)
        {
            return Observable.Zip(GuidValue, o, (GuidValueLambda, oLambda) => GuidValueLambda.Equals(oLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Guid> GuidValue,
            IObservable<System.Guid> g)
        {
            return Observable.Zip(GuidValue, g, (GuidValueLambda, gLambda) => GuidValueLambda.Equals(gLambda));
        }


        public static IObservable<System.Int32> CompareTo(this IObservable<System.Guid> GuidValue,
            IObservable<System.Object> value)
        {
            return Observable.Zip(GuidValue, value,
                (GuidValueLambda, valueLambda) => GuidValueLambda.CompareTo(valueLambda));
        }


        public static IObservable<System.Int32> CompareTo(this IObservable<System.Guid> GuidValue,
            IObservable<System.Guid> value)
        {
            return Observable.Zip(GuidValue, value,
                (GuidValueLambda, valueLambda) => GuidValueLambda.CompareTo(valueLambda));
        }


        public static IObservable<System.Guid> NewGuid()
        {
            return ObservableExt.Factory(() => System.Guid.NewGuid());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Guid> GuidValue,
            IObservable<System.String> format)
        {
            return Observable.Zip(GuidValue, format,
                (GuidValueLambda, formatLambda) => GuidValueLambda.ToString(formatLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.Guid> GuidValue,
            IObservable<System.String> format, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(GuidValue, format, provider,
                (GuidValueLambda, formatLambda, providerLambda) =>
                    GuidValueLambda.ToString(formatLambda, providerLambda));
        }
    }
}