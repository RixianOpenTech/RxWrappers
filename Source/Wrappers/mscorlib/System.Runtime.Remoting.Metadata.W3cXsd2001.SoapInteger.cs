using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    public static class __SoapInteger
    {
        public static IObservable<System.String> GetXsdType(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapInteger> SoapIntegerValue)
        {
            return Observable.Select(SoapIntegerValue, (SoapIntegerValueLambda) => SoapIntegerValueLambda.GetXsdType());
        }


        public static IObservable<System.String> ToString(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapInteger> SoapIntegerValue)
        {
            return Observable.Select(SoapIntegerValue, (SoapIntegerValueLambda) => SoapIntegerValueLambda.ToString());
        }


        public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapInteger> Parse(
            IObservable<System.String> value)
        {
            return Observable.Select(value,
                (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapInteger.Parse(valueLambda));
        }


        public static IObservable<System.String> get_XsdType()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapInteger.XsdType);
        }


        public static IObservable<System.Decimal> get_Value(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapInteger> SoapIntegerValue)
        {
            return Observable.Select(SoapIntegerValue, (SoapIntegerValueLambda) => SoapIntegerValueLambda.Value);
        }


        public static IObservable<System.Reactive.Unit> set_Value(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapInteger> SoapIntegerValue,
            IObservable<System.Decimal> value)
        {
            return ObservableExt.ZipExecute(SoapIntegerValue, value,
                (SoapIntegerValueLambda, valueLambda) => SoapIntegerValueLambda.Value = valueLambda);
        }
    }
}