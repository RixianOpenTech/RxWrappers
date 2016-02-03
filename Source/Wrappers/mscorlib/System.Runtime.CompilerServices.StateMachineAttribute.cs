using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
    public static class __StateMachineAttribute
    {
        
        public static IObservable<System.Type> get_StateMachineType(this IObservable<System.Runtime.CompilerServices.StateMachineAttribute> StateMachineAttributeValue)
        {
            return Observable.Select(StateMachineAttributeValue, (StateMachineAttributeValueLambda) => StateMachineAttributeValueLambda.StateMachineType);
        }

    }
}