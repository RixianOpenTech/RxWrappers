using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization
{
    public static class __IObjectReference
    {
        
        public static IObservable<System.Object> GetRealObject(this IObservable<System.Runtime.Serialization.IObjectReference> IObjectReferenceValue, IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return Observable.Zip(IObjectReferenceValue, context, (IObjectReferenceValueLambda, contextLambda) => IObjectReferenceValueLambda.GetRealObject(contextLambda));
        }

    }
}