using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    public static class __SoapIdrefs
    {
        
        public static IObservable<System.String> GetXsdType(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdrefs> SoapIdrefsValue)
        {
            return Observable.Select(SoapIdrefsValue, (SoapIdrefsValueLambda) => SoapIdrefsValueLambda.GetXsdType());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdrefs> SoapIdrefsValue)
        {
            return Observable.Select(SoapIdrefsValue, (SoapIdrefsValueLambda) => SoapIdrefsValueLambda.ToString());
        }


        public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdrefs> Parse(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdrefs.Parse(valueLambda));
        }


        public static IObservable<System.String> get_XsdType()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdrefs.XsdType);
        }


        public static IObservable<System.String> get_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdrefs> SoapIdrefsValue)
        {
            return Observable.Select(SoapIdrefsValue, (SoapIdrefsValueLambda) => SoapIdrefsValueLambda.Value);
        }


        public static IObservable<System.Reactive.Unit> set_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdrefs> SoapIdrefsValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SoapIdrefsValue, value, (SoapIdrefsValueLambda, valueLambda) => SoapIdrefsValueLambda.Value = valueLambda);
        }

    }
}