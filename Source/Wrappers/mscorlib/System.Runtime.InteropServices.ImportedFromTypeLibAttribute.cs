using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
public static class _ImportedFromTypeLibAttribute
{
    
public static IObservable<System.String> get_Value(this IObservable<System.Runtime.InteropServices.ImportedFromTypeLibAttribute> ImportedFromTypeLibAttributeValue)
{
    return Observable.Select(ImportedFromTypeLibAttributeValue, (ImportedFromTypeLibAttributeValueLambda) => ImportedFromTypeLibAttributeValueLambda.Value);
}

}
}