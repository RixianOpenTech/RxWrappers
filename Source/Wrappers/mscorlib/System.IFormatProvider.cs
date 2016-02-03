using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __IFormatProvider
    {
        
        public static IObservable<System.Object> GetFormat(this IObservable<System.IFormatProvider> IFormatProviderValue, IObservable<System.Type> formatType)
        {
            return Observable.Zip(IFormatProviderValue, formatType, (IFormatProviderValueLambda, formatTypeLambda) => IFormatProviderValueLambda.GetFormat(formatTypeLambda));
        }

    }
}