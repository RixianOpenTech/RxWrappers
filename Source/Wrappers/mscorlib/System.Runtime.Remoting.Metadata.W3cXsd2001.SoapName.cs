using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    public static class __SoapName
    {
        public static IObservable<System.String> GetXsdType(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapName> SoapNameValue)
        {
            return Observable.Select(SoapNameValue, (SoapNameValueLambda) => SoapNameValueLambda.GetXsdType());
        }


        public static IObservable<System.String> ToString(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapName> SoapNameValue)
        {
            return Observable.Select(SoapNameValue, (SoapNameValueLambda) => SoapNameValueLambda.ToString());
        }


        public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapName> Parse(
            IObservable<System.String> value)
        {
            return Observable.Select(value,
                (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapName.Parse(valueLambda));
        }


        public static IObservable<System.String> get_XsdType()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapName.XsdType);
        }


        public static IObservable<System.String> get_Value(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapName> SoapNameValue)
        {
            return Observable.Select(SoapNameValue, (SoapNameValueLambda) => SoapNameValueLambda.Value);
        }


        public static IObservable<System.Reactive.Unit> set_Value(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapName> SoapNameValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SoapNameValue, value,
                (SoapNameValueLambda, valueLambda) => SoapNameValueLambda.Value = valueLambda);
        }
    }
}