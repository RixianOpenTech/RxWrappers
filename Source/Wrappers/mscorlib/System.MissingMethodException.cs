using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __MissingMethodException
    {
        
        public static IObservable<System.String> get_Message(this IObservable<System.MissingMethodException> MissingMethodExceptionValue)
        {
            return Observable.Select(MissingMethodExceptionValue, (MissingMethodExceptionValueLambda) => MissingMethodExceptionValueLambda.Message);
        }

    }
}