using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    public static class __SoapDuration
    {
        
        public static IObservable<System.String> ToString(IObservable<System.TimeSpan> timeSpan)
        {
            return Observable.Select(timeSpan, (timeSpanLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDuration.ToString(timeSpanLambda));
        }


        public static IObservable<System.TimeSpan> Parse(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDuration.Parse(valueLambda));
        }


        public static IObservable<System.String> get_XsdType()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDuration.XsdType);
        }

    }
}