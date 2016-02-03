using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __TypeIdentifierAttribute
    {
        
        public static IObservable<System.String> get_Scope(this IObservable<System.Runtime.InteropServices.TypeIdentifierAttribute> TypeIdentifierAttributeValue)
        {
            return Observable.Select(TypeIdentifierAttributeValue, (TypeIdentifierAttributeValueLambda) => TypeIdentifierAttributeValueLambda.Scope);
        }


        public static IObservable<System.String> get_Identifier(this IObservable<System.Runtime.InteropServices.TypeIdentifierAttribute> TypeIdentifierAttributeValue)
        {
            return Observable.Select(TypeIdentifierAttributeValue, (TypeIdentifierAttributeValueLambda) => TypeIdentifierAttributeValueLambda.Identifier);
        }

    }
}