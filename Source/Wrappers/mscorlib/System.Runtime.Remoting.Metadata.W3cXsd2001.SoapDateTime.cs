using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    public static class __SoapDateTime
    {
        
        public static IObservable<System.String> ToString(IObservable<System.DateTime> value)
        {
            return Observable.Select(value, (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDateTime.ToString(valueLambda));
        }


        public static IObservable<System.DateTime> Parse(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDateTime.Parse(valueLambda));
        }


        public static IObservable<System.String> get_XsdType()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDateTime.XsdType);
        }

    }
}