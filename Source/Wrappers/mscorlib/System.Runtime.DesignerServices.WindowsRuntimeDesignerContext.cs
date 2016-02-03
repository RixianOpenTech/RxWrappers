using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.DesignerServices
{
public static class _WindowsRuntimeDesignerContext
{
    
public static IObservable<System.Reactive.Unit> InitializeSharedContext(IObservable<System.Collections.Generic.IEnumerable<System.String>> paths)
{
    return Observable.Do(paths, (pathsLambda) => System.Runtime.DesignerServices.WindowsRuntimeDesignerContext.InitializeSharedContext(pathsLambda)).ToUnit();
}


public static IObservable<System.Reactive.Unit> SetIterationContext(IObservable<System.Runtime.DesignerServices.WindowsRuntimeDesignerContext> context)
{
    return Observable.Do(context, (contextLambda) => System.Runtime.DesignerServices.WindowsRuntimeDesignerContext.SetIterationContext(contextLambda)).ToUnit();
}


public static IObservable<System.Reflection.Assembly> GetAssembly(this IObservable<System.Runtime.DesignerServices.WindowsRuntimeDesignerContext> WindowsRuntimeDesignerContextValue, IObservable<System.String> assemblyName)
{
    return Observable.Zip(WindowsRuntimeDesignerContextValue, assemblyName, (WindowsRuntimeDesignerContextValueLambda, assemblyNameLambda) => WindowsRuntimeDesignerContextValueLambda.GetAssembly(assemblyNameLambda));
}


public static IObservable<System.Type> GetType(this IObservable<System.Runtime.DesignerServices.WindowsRuntimeDesignerContext> WindowsRuntimeDesignerContextValue, IObservable<System.String> typeName)
{
    return Observable.Zip(WindowsRuntimeDesignerContextValue, typeName, (WindowsRuntimeDesignerContextValueLambda, typeNameLambda) => WindowsRuntimeDesignerContextValueLambda.GetType(typeNameLambda));
}


public static IObservable<System.String> get_Name(this IObservable<System.Runtime.DesignerServices.WindowsRuntimeDesignerContext> WindowsRuntimeDesignerContextValue)
{
    return Observable.Select(WindowsRuntimeDesignerContextValue, (WindowsRuntimeDesignerContextValueLambda) => WindowsRuntimeDesignerContextValueLambda.Name);
}

}
}