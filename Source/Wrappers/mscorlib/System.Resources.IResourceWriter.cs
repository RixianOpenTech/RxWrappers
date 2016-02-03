using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Resources
{
public static class _IResourceWriter
{
    
public static IObservable<System.Reactive.Unit> AddResource(this IObservable<System.Resources.IResourceWriter> IResourceWriterValue, IObservable<System.String> name, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(IResourceWriterValue, name, value, (IResourceWriterValueLambda, nameLambda, valueLambda) => IResourceWriterValueLambda.AddResource(nameLambda, valueLambda));
}


public static IObservable<System.Reactive.Unit> AddResource(this IObservable<System.Resources.IResourceWriter> IResourceWriterValue, IObservable<System.String> name, IObservable<System.Object> value)
{
    return ObservableExt.ZipExecute(IResourceWriterValue, name, value, (IResourceWriterValueLambda, nameLambda, valueLambda) => IResourceWriterValueLambda.AddResource(nameLambda, valueLambda));
}


public static IObservable<System.Reactive.Unit> AddResource(this IObservable<System.Resources.IResourceWriter> IResourceWriterValue, IObservable<System.String> name, IObservable<System.Byte[]> value)
{
    return ObservableExt.ZipExecute(IResourceWriterValue, name, value, (IResourceWriterValueLambda, nameLambda, valueLambda) => IResourceWriterValueLambda.AddResource(nameLambda, valueLambda));
}


public static IObservable<System.Reactive.Unit> Close(this IObservable<System.Resources.IResourceWriter> IResourceWriterValue)
{
    return Observable.Do(IResourceWriterValue, (IResourceWriterValueLambda) => IResourceWriterValueLambda.Close()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Generate(this IObservable<System.Resources.IResourceWriter> IResourceWriterValue)
{
    return Observable.Do(IResourceWriterValue, (IResourceWriterValueLambda) => IResourceWriterValueLambda.Generate()).ToUnit();
}

}
}