using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
public static class _ICustomFactory
{
    
public static IObservable<System.MarshalByRefObject> CreateInstance(this IObservable<System.Runtime.InteropServices.ICustomFactory> ICustomFactoryValue, IObservable<System.Type> serverType)
{
    return Observable.Zip(ICustomFactoryValue, serverType, (ICustomFactoryValueLambda, serverTypeLambda) => ICustomFactoryValueLambda.CreateInstance(serverTypeLambda));
}

}
}