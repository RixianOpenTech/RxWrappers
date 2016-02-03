using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    public static class __SoapNmtoken
    {
        public static IObservable<System.String> GetXsdType(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtoken> SoapNmtokenValue)
        {
            return Observable.Select(SoapNmtokenValue, (SoapNmtokenValueLambda) => SoapNmtokenValueLambda.GetXsdType());
        }


        public static IObservable<System.String> ToString(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtoken> SoapNmtokenValue)
        {
            return Observable.Select(SoapNmtokenValue, (SoapNmtokenValueLambda) => SoapNmtokenValueLambda.ToString());
        }


        public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtoken> Parse(
            IObservable<System.String> value)
        {
            return Observable.Select(value,
                (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtoken.Parse(valueLambda));
        }


        public static IObservable<System.String> get_XsdType()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtoken.XsdType);
        }


        public static IObservable<System.String> get_Value(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtoken> SoapNmtokenValue)
        {
            return Observable.Select(SoapNmtokenValue, (SoapNmtokenValueLambda) => SoapNmtokenValueLambda.Value);
        }


        public static IObservable<System.Reactive.Unit> set_Value(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtoken> SoapNmtokenValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SoapNmtokenValue, value,
                (SoapNmtokenValueLambda, valueLambda) => SoapNmtokenValueLambda.Value = valueLambda);
        }
    }
}