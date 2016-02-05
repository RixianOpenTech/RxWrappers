using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __ExtensionDataSetter
    {
        
        public static IObservable<System.Reactive.Unit> Invoke(this IObservable<Newtonsoft.Json.Serialization.ExtensionDataSetter> ExtensionDataSetterValue, IObservable<System.Object> o, IObservable<System.String> key, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(ExtensionDataSetterValue, o, key, value, (ExtensionDataSetterValueLambda, oLambda, keyLambda, valueLambda) => ExtensionDataSetterValueLambda.Invoke(oLambda, keyLambda, valueLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke(this IObservable<Newtonsoft.Json.Serialization.ExtensionDataSetter> ExtensionDataSetterValue, IObservable<System.Object> o, IObservable<System.String> key, IObservable<System.Object> value, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(ExtensionDataSetterValue, o, key, value, callback, @object, (ExtensionDataSetterValueLambda, oLambda, keyLambda, valueLambda, callbackLambda, @objectLambda) => ExtensionDataSetterValueLambda.BeginInvoke(oLambda, keyLambda, valueLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<System.Reactive.Unit> EndInvoke(this IObservable<Newtonsoft.Json.Serialization.ExtensionDataSetter> ExtensionDataSetterValue, IObservable<System.IAsyncResult> result)
        {
            return ObservableExt.ZipExecute(ExtensionDataSetterValue, result, (ExtensionDataSetterValueLambda, resultLambda) => ExtensionDataSetterValueLambda.EndInvoke(resultLambda));
        }

    }
}