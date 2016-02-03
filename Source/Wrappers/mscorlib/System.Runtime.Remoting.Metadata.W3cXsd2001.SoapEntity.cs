using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    public static class __SoapEntity
    {
        
        public static IObservable<System.String> GetXsdType(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntity> SoapEntityValue)
        {
            return Observable.Select(SoapEntityValue, (SoapEntityValueLambda) => SoapEntityValueLambda.GetXsdType());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntity> SoapEntityValue)
        {
            return Observable.Select(SoapEntityValue, (SoapEntityValueLambda) => SoapEntityValueLambda.ToString());
        }


        public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntity> Parse(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntity.Parse(valueLambda));
        }


        public static IObservable<System.String> get_XsdType()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntity.XsdType);
        }


        public static IObservable<System.String> get_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntity> SoapEntityValue)
        {
            return Observable.Select(SoapEntityValue, (SoapEntityValueLambda) => SoapEntityValueLambda.Value);
        }


        public static IObservable<System.Reactive.Unit> set_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntity> SoapEntityValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SoapEntityValue, value, (SoapEntityValueLambda, valueLambda) => SoapEntityValueLambda.Value = valueLambda);
        }

    }
}