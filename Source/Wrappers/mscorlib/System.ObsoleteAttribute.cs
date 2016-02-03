using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __ObsoleteAttribute
    {
        
        public static IObservable<System.String> get_Message(this IObservable<System.ObsoleteAttribute> ObsoleteAttributeValue)
        {
            return Observable.Select(ObsoleteAttributeValue, (ObsoleteAttributeValueLambda) => ObsoleteAttributeValueLambda.Message);
        }


        public static IObservable<System.Boolean> get_IsError(this IObservable<System.ObsoleteAttribute> ObsoleteAttributeValue)
        {
            return Observable.Select(ObsoleteAttributeValue, (ObsoleteAttributeValueLambda) => ObsoleteAttributeValueLambda.IsError);
        }

    }
}