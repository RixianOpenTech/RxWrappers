using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __AssemblySignatureKeyAttribute
    {
        
        public static IObservable<System.String> get_PublicKey(this IObservable<System.Reflection.AssemblySignatureKeyAttribute> AssemblySignatureKeyAttributeValue)
        {
            return Observable.Select(AssemblySignatureKeyAttributeValue, (AssemblySignatureKeyAttributeValueLambda) => AssemblySignatureKeyAttributeValueLambda.PublicKey);
        }


        public static IObservable<System.String> get_Countersignature(this IObservable<System.Reflection.AssemblySignatureKeyAttribute> AssemblySignatureKeyAttributeValue)
        {
            return Observable.Select(AssemblySignatureKeyAttributeValue, (AssemblySignatureKeyAttributeValueLambda) => AssemblySignatureKeyAttributeValueLambda.Countersignature);
        }

    }
}