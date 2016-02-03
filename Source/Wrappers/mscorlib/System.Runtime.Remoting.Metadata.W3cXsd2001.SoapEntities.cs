using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    public static class __SoapEntities
    {
        public static IObservable<System.String> GetXsdType(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntities> SoapEntitiesValue)
        {
            return Observable.Select(SoapEntitiesValue,
                (SoapEntitiesValueLambda) => SoapEntitiesValueLambda.GetXsdType());
        }


        public static IObservable<System.String> ToString(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntities> SoapEntitiesValue)
        {
            return Observable.Select(SoapEntitiesValue, (SoapEntitiesValueLambda) => SoapEntitiesValueLambda.ToString());
        }


        public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntities> Parse(
            IObservable<System.String> value)
        {
            return Observable.Select(value,
                (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntities.Parse(valueLambda));
        }


        public static IObservable<System.String> get_XsdType()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntities.XsdType);
        }


        public static IObservable<System.String> get_Value(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntities> SoapEntitiesValue)
        {
            return Observable.Select(SoapEntitiesValue, (SoapEntitiesValueLambda) => SoapEntitiesValueLambda.Value);
        }


        public static IObservable<System.Reactive.Unit> set_Value(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntities> SoapEntitiesValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SoapEntitiesValue, value,
                (SoapEntitiesValueLambda, valueLambda) => SoapEntitiesValueLambda.Value = valueLambda);
        }
    }
}