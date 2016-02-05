using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __ErrorContext
    {
        
        public static IObservable<System.Exception> get_Error(this IObservable<Newtonsoft.Json.Serialization.ErrorContext> ErrorContextValue)
        {
            return Observable.Select(ErrorContextValue, (ErrorContextValueLambda) => ErrorContextValueLambda.Error);
        }


        public static IObservable<System.Object> get_OriginalObject(this IObservable<Newtonsoft.Json.Serialization.ErrorContext> ErrorContextValue)
        {
            return Observable.Select(ErrorContextValue, (ErrorContextValueLambda) => ErrorContextValueLambda.OriginalObject);
        }


        public static IObservable<System.Object> get_Member(this IObservable<Newtonsoft.Json.Serialization.ErrorContext> ErrorContextValue)
        {
            return Observable.Select(ErrorContextValue, (ErrorContextValueLambda) => ErrorContextValueLambda.Member);
        }


        public static IObservable<System.String> get_Path(this IObservable<Newtonsoft.Json.Serialization.ErrorContext> ErrorContextValue)
        {
            return Observable.Select(ErrorContextValue, (ErrorContextValueLambda) => ErrorContextValueLambda.Path);
        }


        public static IObservable<System.Boolean> get_Handled(this IObservable<Newtonsoft.Json.Serialization.ErrorContext> ErrorContextValue)
        {
            return Observable.Select(ErrorContextValue, (ErrorContextValueLambda) => ErrorContextValueLambda.Handled);
        }


        public static IObservable<System.Reactive.Unit> set_Handled(this IObservable<Newtonsoft.Json.Serialization.ErrorContext> ErrorContextValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(ErrorContextValue, value, (ErrorContextValueLambda, valueLambda) => ErrorContextValueLambda.Handled = valueLambda);
        }

    }
}