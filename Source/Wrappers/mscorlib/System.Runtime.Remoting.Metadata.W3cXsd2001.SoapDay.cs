using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    public static class __SoapDay
    {
        public static IObservable<System.String> GetXsdType(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDay> SoapDayValue)
        {
            return Observable.Select(SoapDayValue, (SoapDayValueLambda) => SoapDayValueLambda.GetXsdType());
        }


        public static IObservable<System.String> ToString(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDay> SoapDayValue)
        {
            return Observable.Select(SoapDayValue, (SoapDayValueLambda) => SoapDayValueLambda.ToString());
        }


        public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDay> Parse(
            IObservable<System.String> value)
        {
            return Observable.Select(value,
                (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDay.Parse(valueLambda));
        }


        public static IObservable<System.String> get_XsdType()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDay.XsdType);
        }


        public static IObservable<System.DateTime> get_Value(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDay> SoapDayValue)
        {
            return Observable.Select(SoapDayValue, (SoapDayValueLambda) => SoapDayValueLambda.Value);
        }


        public static IObservable<System.Reactive.Unit> set_Value(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDay> SoapDayValue,
            IObservable<System.DateTime> value)
        {
            return ObservableExt.ZipExecute(SoapDayValue, value,
                (SoapDayValueLambda, valueLambda) => SoapDayValueLambda.Value = valueLambda);
        }
    }
}