using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __AssemblyMetadataAttribute
    {
        
        public static IObservable<System.String> get_Key(this IObservable<System.Reflection.AssemblyMetadataAttribute> AssemblyMetadataAttributeValue)
        {
            return Observable.Select(AssemblyMetadataAttributeValue, (AssemblyMetadataAttributeValueLambda) => AssemblyMetadataAttributeValueLambda.Key);
        }


        public static IObservable<System.String> get_Value(this IObservable<System.Reflection.AssemblyMetadataAttribute> AssemblyMetadataAttributeValue)
        {
            return Observable.Select(AssemblyMetadataAttributeValue, (AssemblyMetadataAttributeValueLambda) => AssemblyMetadataAttributeValueLambda.Value);
        }

    }
}