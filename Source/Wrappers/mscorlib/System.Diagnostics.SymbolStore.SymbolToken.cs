using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.SymbolStore
{
    public static class __SymbolToken
    {
        public static IObservable<System.Int32> GetToken(
            this IObservable<System.Diagnostics.SymbolStore.SymbolToken> SymbolTokenValue)
        {
            return Observable.Select(SymbolTokenValue, (SymbolTokenValueLambda) => SymbolTokenValueLambda.GetToken());
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Diagnostics.SymbolStore.SymbolToken> SymbolTokenValue)
        {
            return Observable.Select(SymbolTokenValue, (SymbolTokenValueLambda) => SymbolTokenValueLambda.GetHashCode());
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Diagnostics.SymbolStore.SymbolToken> SymbolTokenValue,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(SymbolTokenValue, obj,
                (SymbolTokenValueLambda, objLambda) => SymbolTokenValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Diagnostics.SymbolStore.SymbolToken> SymbolTokenValue,
            IObservable<System.Diagnostics.SymbolStore.SymbolToken> obj)
        {
            return Observable.Zip(SymbolTokenValue, obj,
                (SymbolTokenValueLambda, objLambda) => SymbolTokenValueLambda.Equals(objLambda));
        }
    }
}