using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json
{
    public static class __IJsonLineInfo
    {
        
        public static IObservable<System.Boolean> HasLineInfo(this IObservable<Newtonsoft.Json.IJsonLineInfo> IJsonLineInfoValue)
        {
            return Observable.Select(IJsonLineInfoValue, (IJsonLineInfoValueLambda) => IJsonLineInfoValueLambda.HasLineInfo());
        }


        public static IObservable<System.Int32> get_LineNumber(this IObservable<Newtonsoft.Json.IJsonLineInfo> IJsonLineInfoValue)
        {
            return Observable.Select(IJsonLineInfoValue, (IJsonLineInfoValueLambda) => IJsonLineInfoValueLambda.LineNumber);
        }


        public static IObservable<System.Int32> get_LinePosition(this IObservable<Newtonsoft.Json.IJsonLineInfo> IJsonLineInfoValue)
        {
            return Observable.Select(IJsonLineInfoValue, (IJsonLineInfoValueLambda) => IJsonLineInfoValueLambda.LinePosition);
        }

    }
}