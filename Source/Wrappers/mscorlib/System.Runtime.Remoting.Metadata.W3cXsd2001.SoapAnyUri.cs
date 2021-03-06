using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    public static class __SoapAnyUri
    {
        public static IObservable<System.String> GetXsdType(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapAnyUri> SoapAnyUriValue)
        {
            return Observable.Select(SoapAnyUriValue, (SoapAnyUriValueLambda) => SoapAnyUriValueLambda.GetXsdType());
        }


        public static IObservable<System.String> ToString(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapAnyUri> SoapAnyUriValue)
        {
            return Observable.Select(SoapAnyUriValue, (SoapAnyUriValueLambda) => SoapAnyUriValueLambda.ToString());
        }


        public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapAnyUri> Parse(
            IObservable<System.String> value)
        {
            return Observable.Select(value,
                (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapAnyUri.Parse(valueLambda));
        }


        public static IObservable<System.String> get_XsdType()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapAnyUri.XsdType);
        }


        public static IObservable<System.String> get_Value(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapAnyUri> SoapAnyUriValue)
        {
            return Observable.Select(SoapAnyUriValue, (SoapAnyUriValueLambda) => SoapAnyUriValueLambda.Value);
        }


        public static IObservable<System.Reactive.Unit> set_Value(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapAnyUri> SoapAnyUriValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SoapAnyUriValue, value,
                (SoapAnyUriValueLambda, valueLambda) => SoapAnyUriValueLambda.Value = valueLambda);
        }
    }
}