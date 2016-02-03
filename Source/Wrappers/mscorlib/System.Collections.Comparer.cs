using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections
{
    public static class __Comparer
    {
        public static IObservable<System.Int32> Compare(this IObservable<System.Collections.Comparer> ComparerValue,
            IObservable<System.Object> a, IObservable<System.Object> b)
        {
            return Observable.Zip(ComparerValue, a, b,
                (ComparerValueLambda, aLambda, bLambda) => ComparerValueLambda.Compare(aLambda, bLambda));
        }


        public static IObservable<System.Reactive.Unit> GetObjectData(
            this IObservable<System.Collections.Comparer> ComparerValue,
            IObservable<System.Runtime.Serialization.SerializationInfo> info,
            IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(ComparerValue, info, context,
                (ComparerValueLambda, infoLambda, contextLambda) =>
                    ComparerValueLambda.GetObjectData(infoLambda, contextLambda));
        }
    }
}