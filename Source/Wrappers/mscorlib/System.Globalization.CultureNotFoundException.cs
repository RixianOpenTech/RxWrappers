using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
    public static class __CultureNotFoundException
    {
        public static IObservable<System.Reactive.Unit> GetObjectData(
            this IObservable<System.Globalization.CultureNotFoundException> CultureNotFoundExceptionValue,
            IObservable<System.Runtime.Serialization.SerializationInfo> info,
            IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(CultureNotFoundExceptionValue, info, context,
                (CultureNotFoundExceptionValueLambda, infoLambda, contextLambda) =>
                    CultureNotFoundExceptionValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.Nullable<System.Int32>> get_InvalidCultureId(
            this IObservable<System.Globalization.CultureNotFoundException> CultureNotFoundExceptionValue)
        {
            return Observable.Select(CultureNotFoundExceptionValue,
                (CultureNotFoundExceptionValueLambda) => CultureNotFoundExceptionValueLambda.InvalidCultureId);
        }


        public static IObservable<System.String> get_InvalidCultureName(
            this IObservable<System.Globalization.CultureNotFoundException> CultureNotFoundExceptionValue)
        {
            return Observable.Select(CultureNotFoundExceptionValue,
                (CultureNotFoundExceptionValueLambda) => CultureNotFoundExceptionValueLambda.InvalidCultureName);
        }


        public static IObservable<System.String> get_Message(
            this IObservable<System.Globalization.CultureNotFoundException> CultureNotFoundExceptionValue)
        {
            return Observable.Select(CultureNotFoundExceptionValue,
                (CultureNotFoundExceptionValueLambda) => CultureNotFoundExceptionValueLambda.Message);
        }
    }
}