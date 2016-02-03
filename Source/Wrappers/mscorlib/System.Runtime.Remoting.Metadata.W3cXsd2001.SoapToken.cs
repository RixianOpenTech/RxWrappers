using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    public static class __SoapToken
    {
        public static IObservable<System.String> GetXsdType(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapToken> SoapTokenValue)
        {
            return Observable.Select(SoapTokenValue, (SoapTokenValueLambda) => SoapTokenValueLambda.GetXsdType());
        }


        public static IObservable<System.String> ToString(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapToken> SoapTokenValue)
        {
            return Observable.Select(SoapTokenValue, (SoapTokenValueLambda) => SoapTokenValueLambda.ToString());
        }


        public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapToken> Parse(
            IObservable<System.String> value)
        {
            return Observable.Select(value,
                (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapToken.Parse(valueLambda));
        }


        public static IObservable<System.String> get_XsdType()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapToken.XsdType);
        }


        public static IObservable<System.String> get_Value(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapToken> SoapTokenValue)
        {
            return Observable.Select(SoapTokenValue, (SoapTokenValueLambda) => SoapTokenValueLambda.Value);
        }


        public static IObservable<System.Reactive.Unit> set_Value(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapToken> SoapTokenValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SoapTokenValue, value,
                (SoapTokenValueLambda, valueLambda) => SoapTokenValueLambda.Value = valueLambda);
        }
    }
}