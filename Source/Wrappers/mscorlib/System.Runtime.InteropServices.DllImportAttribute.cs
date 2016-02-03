using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __DllImportAttribute
    {
        
        public static IObservable<System.String> get_Value(this IObservable<System.Runtime.InteropServices.DllImportAttribute> DllImportAttributeValue)
        {
            return Observable.Select(DllImportAttributeValue, (DllImportAttributeValueLambda) => DllImportAttributeValueLambda.Value);
        }

    }
}