using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __ICustomQueryInterface
    {
        
        public static IObservable<Tuple<System.Runtime.InteropServices.CustomQueryInterfaceResult, System.Guid, System.IntPtr>> GetInterface(this IObservable<System.Runtime.InteropServices.ICustomQueryInterface> ICustomQueryInterfaceValue, IObservable<System.Guid> iid)
        {
            return Observable.Zip(ICustomQueryInterfaceValue, iid, (ICustomQueryInterfaceValueLambda, iidLambda) => {
System.IntPtr ppvOutput = default(System.IntPtr);
var result = ICustomQueryInterfaceValueLambda.GetInterface(ref iidLambda, out ppvOutput);
return Tuple.Create(result, iidLambda, ppvOutput);
});
        }

    }
}