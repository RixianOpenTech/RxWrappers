using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    public static class __SoapMonthDay
    {
        
        public static IObservable<System.String> GetXsdType(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonthDay> SoapMonthDayValue)
        {
            return Observable.Select(SoapMonthDayValue, (SoapMonthDayValueLambda) => SoapMonthDayValueLambda.GetXsdType());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonthDay> SoapMonthDayValue)
        {
            return Observable.Select(SoapMonthDayValue, (SoapMonthDayValueLambda) => SoapMonthDayValueLambda.ToString());
        }


        public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonthDay> Parse(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonthDay.Parse(valueLambda));
        }


        public static IObservable<System.String> get_XsdType()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonthDay.XsdType);
        }


        public static IObservable<System.DateTime> get_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonthDay> SoapMonthDayValue)
        {
            return Observable.Select(SoapMonthDayValue, (SoapMonthDayValueLambda) => SoapMonthDayValueLambda.Value);
        }


        public static IObservable<System.Reactive.Unit> set_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonthDay> SoapMonthDayValue, IObservable<System.DateTime> value)
        {
            return ObservableExt.ZipExecute(SoapMonthDayValue, value, (SoapMonthDayValueLambda, valueLambda) => SoapMonthDayValueLambda.Value = valueLambda);
        }

    }
}