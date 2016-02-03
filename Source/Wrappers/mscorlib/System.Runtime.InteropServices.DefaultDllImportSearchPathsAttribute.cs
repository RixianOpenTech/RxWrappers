using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __DefaultDllImportSearchPathsAttribute
    {
        
        public static IObservable<System.Runtime.InteropServices.DllImportSearchPath> get_Paths(this IObservable<System.Runtime.InteropServices.DefaultDllImportSearchPathsAttribute> DefaultDllImportSearchPathsAttributeValue)
        {
            return Observable.Select(DefaultDllImportSearchPathsAttributeValue, (DefaultDllImportSearchPathsAttributeValueLambda) => DefaultDllImportSearchPathsAttributeValueLambda.Paths);
        }

    }
}