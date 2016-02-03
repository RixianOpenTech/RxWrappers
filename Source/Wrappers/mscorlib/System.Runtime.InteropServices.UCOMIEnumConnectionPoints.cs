using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __UCOMIEnumConnectionPoints
    {
        public static IObservable<Tuple<int, int>> Next(
            this IObservable<System.Runtime.InteropServices.UCOMIEnumConnectionPoints> UCOMIEnumConnectionPointsValue,
            IObservable<System.Int32> celt, IObservable<System.Runtime.InteropServices.UCOMIConnectionPoint[]> rgelt)
        {
            return Observable.Zip(UCOMIEnumConnectionPointsValue, celt, rgelt,
                (UCOMIEnumConnectionPointsValueLambda, celtLambda, rgeltLambda) =>
                {
                    System.Int32 pceltFetchedOutput = default(System.Int32);
                    var result = UCOMIEnumConnectionPointsValueLambda.Next(celtLambda, rgeltLambda,
                        out pceltFetchedOutput);
                    return Tuple.Create(result, pceltFetchedOutput);
                });
        }


        public static IObservable<System.Int32> Skip(
            this IObservable<System.Runtime.InteropServices.UCOMIEnumConnectionPoints> UCOMIEnumConnectionPointsValue,
            IObservable<System.Int32> celt)
        {
            return Observable.Zip(UCOMIEnumConnectionPointsValue, celt,
                (UCOMIEnumConnectionPointsValueLambda, celtLambda) =>
                    UCOMIEnumConnectionPointsValueLambda.Skip(celtLambda));
        }


        public static IObservable<System.Int32> Reset(
            this IObservable<System.Runtime.InteropServices.UCOMIEnumConnectionPoints> UCOMIEnumConnectionPointsValue)
        {
            return Observable.Select(UCOMIEnumConnectionPointsValue,
                (UCOMIEnumConnectionPointsValueLambda) => UCOMIEnumConnectionPointsValueLambda.Reset());
        }


        public static IObservable<System.Runtime.InteropServices.UCOMIEnumConnectionPoints> Clone(
            this IObservable<System.Runtime.InteropServices.UCOMIEnumConnectionPoints> UCOMIEnumConnectionPointsValue)
        {
            return Observable.Select(UCOMIEnumConnectionPointsValue, (UCOMIEnumConnectionPointsValueLambda) =>
            {
                System.Runtime.InteropServices.UCOMIEnumConnectionPoints ppenumOutput =
                    default(System.Runtime.InteropServices.UCOMIEnumConnectionPoints);
                UCOMIEnumConnectionPointsValueLambda.Clone(out ppenumOutput);
                return ppenumOutput;
            });
        }
    }
}