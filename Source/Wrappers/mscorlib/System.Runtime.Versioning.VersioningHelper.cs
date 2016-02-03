using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Versioning
{
public static class _VersioningHelper
{
    
public static IObservable<System.String> MakeVersionSafeName(IObservable<System.String> name, IObservable<System.Runtime.Versioning.ResourceScope> from, IObservable<System.Runtime.Versioning.ResourceScope> to, IObservable<System.Type> type)
{
    return Observable.Zip(name, from, to, type, (nameLambda, fromLambda, toLambda, typeLambda) => System.Runtime.Versioning.VersioningHelper.MakeVersionSafeName(nameLambda, fromLambda, toLambda, typeLambda));
}


public static IObservable<System.String> MakeVersionSafeName(IObservable<System.String> name, IObservable<System.Runtime.Versioning.ResourceScope> from, IObservable<System.Runtime.Versioning.ResourceScope> to)
{
    return Observable.Zip(name, from, to, (nameLambda, fromLambda, toLambda) => System.Runtime.Versioning.VersioningHelper.MakeVersionSafeName(nameLambda, fromLambda, toLambda));
}

}
}