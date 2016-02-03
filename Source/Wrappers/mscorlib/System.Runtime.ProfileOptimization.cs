using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime
{
public static class _ProfileOptimization
{
    
public static IObservable<System.Reactive.Unit> SetProfileRoot(IObservable<System.String> directoryPath)
{
    return Observable.Do(directoryPath, (directoryPathLambda) => System.Runtime.ProfileOptimization.SetProfileRoot(directoryPathLambda)).ToUnit();
}


public static IObservable<System.Reactive.Unit> StartProfile(IObservable<System.String> profile)
{
    return Observable.Do(profile, (profileLambda) => System.Runtime.ProfileOptimization.StartProfile(profileLambda)).ToUnit();
}

}
}