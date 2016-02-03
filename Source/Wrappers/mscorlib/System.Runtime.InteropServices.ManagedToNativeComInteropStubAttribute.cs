using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __ManagedToNativeComInteropStubAttribute
    {
        
        public static IObservable<System.Type> get_ClassType(this IObservable<System.Runtime.InteropServices.ManagedToNativeComInteropStubAttribute> ManagedToNativeComInteropStubAttributeValue)
        {
            return Observable.Select(ManagedToNativeComInteropStubAttributeValue, (ManagedToNativeComInteropStubAttributeValueLambda) => ManagedToNativeComInteropStubAttributeValueLambda.ClassType);
        }


        public static IObservable<System.String> get_MethodName(this IObservable<System.Runtime.InteropServices.ManagedToNativeComInteropStubAttribute> ManagedToNativeComInteropStubAttributeValue)
        {
            return Observable.Select(ManagedToNativeComInteropStubAttributeValue, (ManagedToNativeComInteropStubAttributeValueLambda) => ManagedToNativeComInteropStubAttributeValueLambda.MethodName);
        }

    }
}