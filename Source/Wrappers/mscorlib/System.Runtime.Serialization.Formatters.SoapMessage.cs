using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization.Formatters
{
    public static class __SoapMessage
    {
        public static IObservable<System.String[]> get_ParamNames(
            this IObservable<System.Runtime.Serialization.Formatters.SoapMessage> SoapMessageValue)
        {
            return Observable.Select(SoapMessageValue, (SoapMessageValueLambda) => SoapMessageValueLambda.ParamNames);
        }


        public static IObservable<System.Object[]> get_ParamValues(
            this IObservable<System.Runtime.Serialization.Formatters.SoapMessage> SoapMessageValue)
        {
            return Observable.Select(SoapMessageValue, (SoapMessageValueLambda) => SoapMessageValueLambda.ParamValues);
        }


        public static IObservable<System.Type[]> get_ParamTypes(
            this IObservable<System.Runtime.Serialization.Formatters.SoapMessage> SoapMessageValue)
        {
            return Observable.Select(SoapMessageValue, (SoapMessageValueLambda) => SoapMessageValueLambda.ParamTypes);
        }


        public static IObservable<System.String> get_MethodName(
            this IObservable<System.Runtime.Serialization.Formatters.SoapMessage> SoapMessageValue)
        {
            return Observable.Select(SoapMessageValue, (SoapMessageValueLambda) => SoapMessageValueLambda.MethodName);
        }


        public static IObservable<System.String> get_XmlNameSpace(
            this IObservable<System.Runtime.Serialization.Formatters.SoapMessage> SoapMessageValue)
        {
            return Observable.Select(SoapMessageValue, (SoapMessageValueLambda) => SoapMessageValueLambda.XmlNameSpace);
        }


        public static IObservable<System.Runtime.Remoting.Messaging.Header[]> get_Headers(
            this IObservable<System.Runtime.Serialization.Formatters.SoapMessage> SoapMessageValue)
        {
            return Observable.Select(SoapMessageValue, (SoapMessageValueLambda) => SoapMessageValueLambda.Headers);
        }


        public static IObservable<System.Reactive.Unit> set_ParamNames(
            this IObservable<System.Runtime.Serialization.Formatters.SoapMessage> SoapMessageValue,
            IObservable<System.String[]> value)
        {
            return ObservableExt.ZipExecute(SoapMessageValue, value,
                (SoapMessageValueLambda, valueLambda) => SoapMessageValueLambda.ParamNames = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ParamValues(
            this IObservable<System.Runtime.Serialization.Formatters.SoapMessage> SoapMessageValue,
            IObservable<System.Object[]> value)
        {
            return ObservableExt.ZipExecute(SoapMessageValue, value,
                (SoapMessageValueLambda, valueLambda) => SoapMessageValueLambda.ParamValues = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ParamTypes(
            this IObservable<System.Runtime.Serialization.Formatters.SoapMessage> SoapMessageValue,
            IObservable<System.Type[]> value)
        {
            return ObservableExt.ZipExecute(SoapMessageValue, value,
                (SoapMessageValueLambda, valueLambda) => SoapMessageValueLambda.ParamTypes = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MethodName(
            this IObservable<System.Runtime.Serialization.Formatters.SoapMessage> SoapMessageValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SoapMessageValue, value,
                (SoapMessageValueLambda, valueLambda) => SoapMessageValueLambda.MethodName = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_XmlNameSpace(
            this IObservable<System.Runtime.Serialization.Formatters.SoapMessage> SoapMessageValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SoapMessageValue, value,
                (SoapMessageValueLambda, valueLambda) => SoapMessageValueLambda.XmlNameSpace = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Headers(
            this IObservable<System.Runtime.Serialization.Formatters.SoapMessage> SoapMessageValue,
            IObservable<System.Runtime.Remoting.Messaging.Header[]> value)
        {
            return ObservableExt.ZipExecute(SoapMessageValue, value,
                (SoapMessageValueLambda, valueLambda) => SoapMessageValueLambda.Headers = valueLambda);
        }
    }
}