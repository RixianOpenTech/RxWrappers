using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization.Formatters
{
    public static class __SoapFault
    {
        public static IObservable<System.Reactive.Unit> GetObjectData(
            this IObservable<System.Runtime.Serialization.Formatters.SoapFault> SoapFaultValue,
            IObservable<System.Runtime.Serialization.SerializationInfo> info,
            IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(SoapFaultValue, info, context,
                (SoapFaultValueLambda, infoLambda, contextLambda) =>
                    SoapFaultValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.String> get_FaultCode(
            this IObservable<System.Runtime.Serialization.Formatters.SoapFault> SoapFaultValue)
        {
            return Observable.Select(SoapFaultValue, (SoapFaultValueLambda) => SoapFaultValueLambda.FaultCode);
        }


        public static IObservable<System.String> get_FaultString(
            this IObservable<System.Runtime.Serialization.Formatters.SoapFault> SoapFaultValue)
        {
            return Observable.Select(SoapFaultValue, (SoapFaultValueLambda) => SoapFaultValueLambda.FaultString);
        }


        public static IObservable<System.String> get_FaultActor(
            this IObservable<System.Runtime.Serialization.Formatters.SoapFault> SoapFaultValue)
        {
            return Observable.Select(SoapFaultValue, (SoapFaultValueLambda) => SoapFaultValueLambda.FaultActor);
        }


        public static IObservable<System.Object> get_Detail(
            this IObservable<System.Runtime.Serialization.Formatters.SoapFault> SoapFaultValue)
        {
            return Observable.Select(SoapFaultValue, (SoapFaultValueLambda) => SoapFaultValueLambda.Detail);
        }


        public static IObservable<System.Reactive.Unit> set_FaultCode(
            this IObservable<System.Runtime.Serialization.Formatters.SoapFault> SoapFaultValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SoapFaultValue, value,
                (SoapFaultValueLambda, valueLambda) => SoapFaultValueLambda.FaultCode = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_FaultString(
            this IObservable<System.Runtime.Serialization.Formatters.SoapFault> SoapFaultValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SoapFaultValue, value,
                (SoapFaultValueLambda, valueLambda) => SoapFaultValueLambda.FaultString = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_FaultActor(
            this IObservable<System.Runtime.Serialization.Formatters.SoapFault> SoapFaultValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SoapFaultValue, value,
                (SoapFaultValueLambda, valueLambda) => SoapFaultValueLambda.FaultActor = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Detail(
            this IObservable<System.Runtime.Serialization.Formatters.SoapFault> SoapFaultValue,
            IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(SoapFaultValue, value,
                (SoapFaultValueLambda, valueLambda) => SoapFaultValueLambda.Detail = valueLambda);
        }
    }
}