using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization.Formatters
{
    public static class __InternalST
    {
        
        public static IObservable<System.Reactive.Unit> InfoSoap(IObservable<System.Object[]> messages)
        {
            return Observable.Do(messages, (messagesLambda) => System.Runtime.Serialization.Formatters.InternalST.InfoSoap(messagesLambda)).ToUnit();
        }


        public static IObservable<System.Boolean> SoapCheckEnabled()
        {
            return ObservableExt.Factory(() => System.Runtime.Serialization.Formatters.InternalST.SoapCheckEnabled());
        }


        public static IObservable<System.Reactive.Unit> Soap(IObservable<System.Object[]> messages)
        {
            return Observable.Do(messages, (messagesLambda) => System.Runtime.Serialization.Formatters.InternalST.Soap(messagesLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> SoapAssert(IObservable<System.Boolean> condition, IObservable<System.String> message)
        {
            return ObservableExt.ZipExecute(condition, message, (conditionLambda, messageLambda) => System.Runtime.Serialization.Formatters.InternalST.SoapAssert(conditionLambda, messageLambda));
        }


        public static IObservable<System.Reactive.Unit> SerializationSetValue(IObservable<System.Reflection.FieldInfo> fi, IObservable<System.Object> target, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(fi, target, value, (fiLambda, targetLambda, valueLambda) => System.Runtime.Serialization.Formatters.InternalST.SerializationSetValue(fiLambda, targetLambda, valueLambda));
        }


        public static IObservable<System.Reflection.Assembly> LoadAssemblyFromString(IObservable<System.String> assemblyString)
        {
            return Observable.Select(assemblyString, (assemblyStringLambda) => System.Runtime.Serialization.Formatters.InternalST.LoadAssemblyFromString(assemblyStringLambda));
        }

    }
}