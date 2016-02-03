using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __RuntimeEnvironment
    {
        
        public static IObservable<System.Boolean> FromGlobalAccessCache(IObservable<System.Reflection.Assembly> a)
        {
            return Observable.Select(a, (aLambda) => System.Runtime.InteropServices.RuntimeEnvironment.FromGlobalAccessCache(aLambda));
        }


        public static IObservable<System.String> GetSystemVersion()
        {
            return ObservableExt.Factory(() => System.Runtime.InteropServices.RuntimeEnvironment.GetSystemVersion());
        }


        public static IObservable<System.String> GetRuntimeDirectory()
        {
            return ObservableExt.Factory(() => System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory());
        }


        public static IObservable<System.IntPtr> GetRuntimeInterfaceAsIntPtr(IObservable<System.Guid> clsid, IObservable<System.Guid> riid)
        {
            return Observable.Zip(clsid, riid, (clsidLambda, riidLambda) => System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeInterfaceAsIntPtr(clsidLambda, riidLambda));
        }


        public static IObservable<System.Object> GetRuntimeInterfaceAsObject(IObservable<System.Guid> clsid, IObservable<System.Guid> riid)
        {
            return Observable.Zip(clsid, riid, (clsidLambda, riidLambda) => System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeInterfaceAsObject(clsidLambda, riidLambda));
        }


        public static IObservable<System.String> get_SystemConfigurationFile()
        {
            return ObservableExt.Factory(() => System.Runtime.InteropServices.RuntimeEnvironment.SystemConfigurationFile);
        }

    }
}