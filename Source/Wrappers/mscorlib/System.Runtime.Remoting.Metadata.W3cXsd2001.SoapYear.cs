using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    public static class __SoapYear
    {
        
        public static IObservable<System.String> GetXsdType(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYear> SoapYearValue)
        {
            return Observable.Select(SoapYearValue, (SoapYearValueLambda) => SoapYearValueLambda.GetXsdType());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYear> SoapYearValue)
        {
            return Observable.Select(SoapYearValue, (SoapYearValueLambda) => SoapYearValueLambda.ToString());
        }


        public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYear> Parse(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYear.Parse(valueLambda));
        }


        public static IObservable<System.String> get_XsdType()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYear.XsdType);
        }


        public static IObservable<System.DateTime> get_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYear> SoapYearValue)
        {
            return Observable.Select(SoapYearValue, (SoapYearValueLambda) => SoapYearValueLambda.Value);
        }


        public static IObservable<System.Int32> get_Sign(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYear> SoapYearValue)
        {
            return Observable.Select(SoapYearValue, (SoapYearValueLambda) => SoapYearValueLambda.Sign);
        }


        public static IObservable<System.Reactive.Unit> set_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYear> SoapYearValue, IObservable<System.DateTime> value)
        {
            return ObservableExt.ZipExecute(SoapYearValue, value, (SoapYearValueLambda, valueLambda) => SoapYearValueLambda.Value = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Sign(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYear> SoapYearValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(SoapYearValue, value, (SoapYearValueLambda, valueLambda) => SoapYearValueLambda.Sign = valueLambda);
        }

    }
}