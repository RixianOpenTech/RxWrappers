using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __ErrorEventArgs
    {
        
        public static IObservable<System.Object> get_CurrentObject(this IObservable<Newtonsoft.Json.Serialization.ErrorEventArgs> ErrorEventArgsValue)
        {
            return Observable.Select(ErrorEventArgsValue, (ErrorEventArgsValueLambda) => ErrorEventArgsValueLambda.CurrentObject);
        }


        public static IObservable<Newtonsoft.Json.Serialization.ErrorContext> get_ErrorContext(this IObservable<Newtonsoft.Json.Serialization.ErrorEventArgs> ErrorEventArgsValue)
        {
            return Observable.Select(ErrorEventArgsValue, (ErrorEventArgsValueLambda) => ErrorEventArgsValueLambda.ErrorContext);
        }

    }
}