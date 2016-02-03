using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
    public static class __OpCodes
    {
        
        public static IObservable<System.Boolean> TakesSingleByteArgument(IObservable<System.Reflection.Emit.OpCode> inst)
        {
            return Observable.Select(inst, (instLambda) => System.Reflection.Emit.OpCodes.TakesSingleByteArgument(instLambda));
        }

    }
}