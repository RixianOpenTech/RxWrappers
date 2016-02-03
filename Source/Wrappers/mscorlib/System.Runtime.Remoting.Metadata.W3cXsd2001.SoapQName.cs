using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    public static class __SoapQName
    {
        public static IObservable<System.String> GetXsdType(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapQName> SoapQNameValue)
        {
            return Observable.Select(SoapQNameValue, (SoapQNameValueLambda) => SoapQNameValueLambda.GetXsdType());
        }


        public static IObservable<System.String> ToString(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapQName> SoapQNameValue)
        {
            return Observable.Select(SoapQNameValue, (SoapQNameValueLambda) => SoapQNameValueLambda.ToString());
        }


        public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapQName> Parse(
            IObservable<System.String> value)
        {
            return Observable.Select(value,
                (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapQName.Parse(valueLambda));
        }


        public static IObservable<System.String> get_XsdType()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapQName.XsdType);
        }


        public static IObservable<System.String> get_Name(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapQName> SoapQNameValue)
        {
            return Observable.Select(SoapQNameValue, (SoapQNameValueLambda) => SoapQNameValueLambda.Name);
        }


        public static IObservable<System.String> get_Namespace(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapQName> SoapQNameValue)
        {
            return Observable.Select(SoapQNameValue, (SoapQNameValueLambda) => SoapQNameValueLambda.Namespace);
        }


        public static IObservable<System.String> get_Key(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapQName> SoapQNameValue)
        {
            return Observable.Select(SoapQNameValue, (SoapQNameValueLambda) => SoapQNameValueLambda.Key);
        }


        public static IObservable<System.Reactive.Unit> set_Name(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapQName> SoapQNameValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SoapQNameValue, value,
                (SoapQNameValueLambda, valueLambda) => SoapQNameValueLambda.Name = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Namespace(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapQName> SoapQNameValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SoapQNameValue, value,
                (SoapQNameValueLambda, valueLambda) => SoapQNameValueLambda.Namespace = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Key(
            this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapQName> SoapQNameValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SoapQNameValue, value,
                (SoapQNameValueLambda, valueLambda) => SoapQNameValueLambda.Key = valueLambda);
        }
    }
}