using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __DefaultCharSetAttribute
    {
        
        public static IObservable<System.Runtime.InteropServices.CharSet> get_CharSet(this IObservable<System.Runtime.InteropServices.DefaultCharSetAttribute> DefaultCharSetAttributeValue)
        {
            return Observable.Select(DefaultCharSetAttributeValue, (DefaultCharSetAttributeValueLambda) => DefaultCharSetAttributeValueLambda.CharSet);
        }

    }
}