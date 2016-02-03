using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __UCOMIEnumString
    {
        public static IObservable<Tuple<int, int>> Next(
            this IObservable<System.Runtime.InteropServices.UCOMIEnumString> UCOMIEnumStringValue,
            IObservable<System.Int32> celt, IObservable<System.String[]> rgelt)
        {
            return Observable.Zip(UCOMIEnumStringValue, celt, rgelt,
                (UCOMIEnumStringValueLambda, celtLambda, rgeltLambda) =>
                {
                    System.Int32 pceltFetchedOutput = default(System.Int32);
                    var result = UCOMIEnumStringValueLambda.Next(celtLambda, rgeltLambda, out pceltFetchedOutput);
                    return Tuple.Create(result, pceltFetchedOutput);
                });
        }


        public static IObservable<System.Int32> Skip(
            this IObservable<System.Runtime.InteropServices.UCOMIEnumString> UCOMIEnumStringValue,
            IObservable<System.Int32> celt)
        {
            return Observable.Zip(UCOMIEnumStringValue, celt,
                (UCOMIEnumStringValueLambda, celtLambda) => UCOMIEnumStringValueLambda.Skip(celtLambda));
        }


        public static IObservable<System.Int32> Reset(
            this IObservable<System.Runtime.InteropServices.UCOMIEnumString> UCOMIEnumStringValue)
        {
            return Observable.Select(UCOMIEnumStringValue,
                (UCOMIEnumStringValueLambda) => UCOMIEnumStringValueLambda.Reset());
        }


        public static IObservable<System.Runtime.InteropServices.UCOMIEnumString> Clone(
            this IObservable<System.Runtime.InteropServices.UCOMIEnumString> UCOMIEnumStringValue)
        {
            return Observable.Select(UCOMIEnumStringValue, (UCOMIEnumStringValueLambda) =>
            {
                System.Runtime.InteropServices.UCOMIEnumString ppenumOutput =
                    default(System.Runtime.InteropServices.UCOMIEnumString);
                UCOMIEnumStringValueLambda.Clone(out ppenumOutput);
                return ppenumOutput;
            });
        }
    }
}