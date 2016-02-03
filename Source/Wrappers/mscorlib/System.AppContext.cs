using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _AppContext
{
    
public static IObservable<Tuple<System.Boolean, System.Boolean>> TryGetSwitch(IObservable<System.String> switchName)
{
    return Observable.Select(switchName, (switchNameLambda) => {
System.Boolean isEnabledOutput = default(System.Boolean);
var result = System.AppContext.TryGetSwitch(switchNameLambda, out isEnabledOutput);
return Tuple.Create(result, isEnabledOutput);
});
}


public static IObservable<System.Reactive.Unit> SetSwitch(IObservable<System.String> switchName, IObservable<System.Boolean> isEnabled)
{
    return ObservableExt.ZipExecute(switchName, isEnabled, (switchNameLambda, isEnabledLambda) => System.AppContext.SetSwitch(switchNameLambda, isEnabledLambda));
}


public static IObservable<System.String> get_BaseDirectory()
{
    return ObservableExt.Factory(() => System.AppContext.BaseDirectory);
}

}
}