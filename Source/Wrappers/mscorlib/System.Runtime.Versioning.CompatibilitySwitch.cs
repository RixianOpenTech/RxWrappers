using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Versioning
{
public static class _CompatibilitySwitch
{
    
public static IObservable<System.Boolean> IsEnabled(IObservable<System.String> compatibilitySwitchName)
{
    return Observable.Select(compatibilitySwitchName, (compatibilitySwitchNameLambda) => System.Runtime.Versioning.CompatibilitySwitch.IsEnabled(compatibilitySwitchNameLambda));
}


public static IObservable<System.String> GetValue(IObservable<System.String> compatibilitySwitchName)
{
    return Observable.Select(compatibilitySwitchName, (compatibilitySwitchNameLambda) => System.Runtime.Versioning.CompatibilitySwitch.GetValue(compatibilitySwitchNameLambda));
}

}
}