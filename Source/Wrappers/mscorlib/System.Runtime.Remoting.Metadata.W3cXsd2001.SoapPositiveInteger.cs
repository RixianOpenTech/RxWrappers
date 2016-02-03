using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    public static class __SoapPositiveInteger
    {
        
        public static IObservable<System.String> GetXsdType(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapPositiveInteger> SoapPositiveIntegerValue)
        {
            return Observable.Select(SoapPositiveIntegerValue, (SoapPositiveIntegerValueLambda) => SoapPositiveIntegerValueLambda.GetXsdType());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapPositiveInteger> SoapPositiveIntegerValue)
        {
            return Observable.Select(SoapPositiveIntegerValue, (SoapPositiveIntegerValueLambda) => SoapPositiveIntegerValueLambda.ToString());
        }


        public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapPositiveInteger> Parse(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapPositiveInteger.Parse(valueLambda));
        }


        public static IObservable<System.String> get_XsdType()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapPositiveInteger.XsdType);
        }


        public static IObservable<System.Decimal> get_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapPositiveInteger> SoapPositiveIntegerValue)
        {
            return Observable.Select(SoapPositiveIntegerValue, (SoapPositiveIntegerValueLambda) => SoapPositiveIntegerValueLambda.Value);
        }


        public static IObservable<System.Reactive.Unit> set_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapPositiveInteger> SoapPositiveIntegerValue, IObservable<System.Decimal> value)
        {
            return ObservableExt.ZipExecute(SoapPositiveIntegerValue, value, (SoapPositiveIntegerValueLambda, valueLambda) => SoapPositiveIntegerValueLambda.Value = valueLambda);
        }

    }
}