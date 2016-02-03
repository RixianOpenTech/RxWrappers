using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    public static class __SoapNmtokens
    {
        public static IObservable<System.String> GetXsdType(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtokens> SoapNmtokensValue)
        {
            return Observable.Select(SoapNmtokensValue,
                (SoapNmtokensValueLambda) => SoapNmtokensValueLambda.GetXsdType());
        }


        public static IObservable<System.String> ToString(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtokens> SoapNmtokensValue)
        {
            return Observable.Select(SoapNmtokensValue, (SoapNmtokensValueLambda) => SoapNmtokensValueLambda.ToString());
        }


        public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtokens> Parse(
            IObservable<System.String> value)
        {
            return Observable.Select(value,
                (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtokens.Parse(valueLambda));
        }


        public static IObservable<System.String> get_XsdType()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtokens.XsdType);
        }


        public static IObservable<System.String> get_Value(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtokens> SoapNmtokensValue)
        {
            return Observable.Select(SoapNmtokensValue, (SoapNmtokensValueLambda) => SoapNmtokensValueLambda.Value);
        }


        public static IObservable<System.Reactive.Unit> set_Value(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtokens> SoapNmtokensValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SoapNmtokensValue, value,
                (SoapNmtokensValueLambda, valueLambda) => SoapNmtokensValueLambda.Value = valueLambda);
        }
    }
}