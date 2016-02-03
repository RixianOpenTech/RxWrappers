using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
public static class _AssemblyCopyrightAttribute
{
    
public static IObservable<System.String> get_Copyright(this IObservable<System.Reflection.AssemblyCopyrightAttribute> AssemblyCopyrightAttributeValue)
{
    return Observable.Select(AssemblyCopyrightAttributeValue, (AssemblyCopyrightAttributeValueLambda) => AssemblyCopyrightAttributeValueLambda.Copyright);
}

}
}