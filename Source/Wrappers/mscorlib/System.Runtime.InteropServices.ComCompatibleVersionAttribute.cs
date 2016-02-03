using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
public static class _ComCompatibleVersionAttribute
{
    
public static IObservable<System.Int32> get_MajorVersion(this IObservable<System.Runtime.InteropServices.ComCompatibleVersionAttribute> ComCompatibleVersionAttributeValue)
{
    return Observable.Select(ComCompatibleVersionAttributeValue, (ComCompatibleVersionAttributeValueLambda) => ComCompatibleVersionAttributeValueLambda.MajorVersion);
}


public static IObservable<System.Int32> get_MinorVersion(this IObservable<System.Runtime.InteropServices.ComCompatibleVersionAttribute> ComCompatibleVersionAttributeValue)
{
    return Observable.Select(ComCompatibleVersionAttributeValue, (ComCompatibleVersionAttributeValueLambda) => ComCompatibleVersionAttributeValueLambda.MinorVersion);
}


public static IObservable<System.Int32> get_BuildNumber(this IObservable<System.Runtime.InteropServices.ComCompatibleVersionAttribute> ComCompatibleVersionAttributeValue)
{
    return Observable.Select(ComCompatibleVersionAttributeValue, (ComCompatibleVersionAttributeValueLambda) => ComCompatibleVersionAttributeValueLambda.BuildNumber);
}


public static IObservable<System.Int32> get_RevisionNumber(this IObservable<System.Runtime.InteropServices.ComCompatibleVersionAttribute> ComCompatibleVersionAttributeValue)
{
    return Observable.Select(ComCompatibleVersionAttributeValue, (ComCompatibleVersionAttributeValueLambda) => ComCompatibleVersionAttributeValueLambda.RevisionNumber);
}

}
}