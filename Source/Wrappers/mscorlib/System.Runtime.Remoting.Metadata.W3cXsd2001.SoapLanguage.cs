using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    public static class __SoapLanguage
    {
        
        public static IObservable<System.String> GetXsdType(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapLanguage> SoapLanguageValue)
        {
            return Observable.Select(SoapLanguageValue, (SoapLanguageValueLambda) => SoapLanguageValueLambda.GetXsdType());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapLanguage> SoapLanguageValue)
        {
            return Observable.Select(SoapLanguageValue, (SoapLanguageValueLambda) => SoapLanguageValueLambda.ToString());
        }


        public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapLanguage> Parse(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapLanguage.Parse(valueLambda));
        }


        public static IObservable<System.String> get_XsdType()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapLanguage.XsdType);
        }


        public static IObservable<System.String> get_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapLanguage> SoapLanguageValue)
        {
            return Observable.Select(SoapLanguageValue, (SoapLanguageValueLambda) => SoapLanguageValueLambda.Value);
        }


        public static IObservable<System.Reactive.Unit> set_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapLanguage> SoapLanguageValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SoapLanguageValue, value, (SoapLanguageValueLambda, valueLambda) => SoapLanguageValueLambda.Value = valueLambda);
        }

    }
}