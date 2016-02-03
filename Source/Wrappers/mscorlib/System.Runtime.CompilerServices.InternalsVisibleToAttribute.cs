using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
public static class _InternalsVisibleToAttribute
{
    
public static IObservable<System.String> get_AssemblyName(this IObservable<System.Runtime.CompilerServices.InternalsVisibleToAttribute> InternalsVisibleToAttributeValue)
{
    return Observable.Select(InternalsVisibleToAttributeValue, (InternalsVisibleToAttributeValueLambda) => InternalsVisibleToAttributeValueLambda.AssemblyName);
}


public static IObservable<System.Boolean> get_AllInternalsVisible(this IObservable<System.Runtime.CompilerServices.InternalsVisibleToAttribute> InternalsVisibleToAttributeValue)
{
    return Observable.Select(InternalsVisibleToAttributeValue, (InternalsVisibleToAttributeValueLambda) => InternalsVisibleToAttributeValueLambda.AllInternalsVisible);
}


public static IObservable<System.Reactive.Unit> set_AllInternalsVisible(this IObservable<System.Runtime.CompilerServices.InternalsVisibleToAttribute> InternalsVisibleToAttributeValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(InternalsVisibleToAttributeValue, value, (InternalsVisibleToAttributeValueLambda, valueLambda) => InternalsVisibleToAttributeValueLambda.AllInternalsVisible = valueLambda);
}

}
}