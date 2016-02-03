using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
public static class _ISoapXsd
{
    
public static IObservable<System.String> GetXsdType(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd> ISoapXsdValue)
{
    return Observable.Select(ISoapXsdValue, (ISoapXsdValueLambda) => ISoapXsdValueLambda.GetXsdType());
}

}
}