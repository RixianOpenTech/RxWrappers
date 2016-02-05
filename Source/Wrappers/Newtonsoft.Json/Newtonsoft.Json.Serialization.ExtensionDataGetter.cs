using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __ExtensionDataGetter
    {
        
        public static IObservable<IEnumerable<KeyValuePair<object, object>>> Invoke(this IObservable<Newtonsoft.Json.Serialization.ExtensionDataGetter> ExtensionDataGetterValue, IObservable<System.Object> o)
        {
            return Observable.Zip(ExtensionDataGetterValue, o, (ExtensionDataGetterValueLambda, oLambda) => ExtensionDataGetterValueLambda.Invoke(oLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke(this IObservable<Newtonsoft.Json.Serialization.ExtensionDataGetter> ExtensionDataGetterValue, IObservable<System.Object> o, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(ExtensionDataGetterValue, o, callback, @object, (ExtensionDataGetterValueLambda, oLambda, callbackLambda, @objectLambda) => ExtensionDataGetterValueLambda.BeginInvoke(oLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<IEnumerable<KeyValuePair<object, object>>> EndInvoke(this IObservable<Newtonsoft.Json.Serialization.ExtensionDataGetter> ExtensionDataGetterValue, IObservable<System.IAsyncResult> result)
        {
            return Observable.Zip(ExtensionDataGetterValue, result, (ExtensionDataGetterValueLambda, resultLambda) => ExtensionDataGetterValueLambda.EndInvoke(resultLambda));
        }

    }
}