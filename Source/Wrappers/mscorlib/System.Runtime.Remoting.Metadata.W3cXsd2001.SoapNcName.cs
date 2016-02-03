using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    public static class __SoapNcName
    {
        
        public static IObservable<System.String> GetXsdType(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNcName> SoapNcNameValue)
        {
            return Observable.Select(SoapNcNameValue, (SoapNcNameValueLambda) => SoapNcNameValueLambda.GetXsdType());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNcName> SoapNcNameValue)
        {
            return Observable.Select(SoapNcNameValue, (SoapNcNameValueLambda) => SoapNcNameValueLambda.ToString());
        }


        public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNcName> Parse(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNcName.Parse(valueLambda));
        }


        public static IObservable<System.String> get_XsdType()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNcName.XsdType);
        }


        public static IObservable<System.String> get_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNcName> SoapNcNameValue)
        {
            return Observable.Select(SoapNcNameValue, (SoapNcNameValueLambda) => SoapNcNameValueLambda.Value);
        }


        public static IObservable<System.Reactive.Unit> set_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNcName> SoapNcNameValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SoapNcNameValue, value, (SoapNcNameValueLambda, valueLambda) => SoapNcNameValueLambda.Value = valueLambda);
        }

    }
}