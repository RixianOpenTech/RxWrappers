using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
public static class _Evidence
{
    
public static IObservable<System.Reactive.Unit> AddHost(this IObservable<System.Security.Policy.Evidence> EvidenceValue, IObservable<System.Object> id)
{
    return ObservableExt.ZipExecute(EvidenceValue, id, (EvidenceValueLambda, idLambda) => EvidenceValueLambda.AddHost(idLambda));
}


public static IObservable<System.Reactive.Unit> AddAssembly(this IObservable<System.Security.Policy.Evidence> EvidenceValue, IObservable<System.Object> id)
{
    return ObservableExt.ZipExecute(EvidenceValue, id, (EvidenceValueLambda, idLambda) => EvidenceValueLambda.AddAssembly(idLambda));
}


public static IObservable<System.Reactive.Unit> AddAssemblyEvidence<T>(this IObservable<System.Security.Policy.Evidence> EvidenceValue, IObservable<T> evidence)
{
    return ObservableExt.ZipExecute(EvidenceValue, evidence, (EvidenceValueLambda, evidenceLambda) => EvidenceValueLambda.AddAssemblyEvidence(evidenceLambda));
}


public static IObservable<System.Reactive.Unit> AddHostEvidence<T>(this IObservable<System.Security.Policy.Evidence> EvidenceValue, IObservable<T> evidence)
{
    return ObservableExt.ZipExecute(EvidenceValue, evidence, (EvidenceValueLambda, evidenceLambda) => EvidenceValueLambda.AddHostEvidence(evidenceLambda));
}


public static IObservable<System.Reactive.Unit> Merge(this IObservable<System.Security.Policy.Evidence> EvidenceValue, IObservable<System.Security.Policy.Evidence> evidence)
{
    return ObservableExt.ZipExecute(EvidenceValue, evidence, (EvidenceValueLambda, evidenceLambda) => EvidenceValueLambda.Merge(evidenceLambda));
}


public static IObservable<System.Reactive.Unit> CopyTo(this IObservable<System.Security.Policy.Evidence> EvidenceValue, IObservable<System.Array> array, IObservable<System.Int32> index)
{
    return ObservableExt.ZipExecute(EvidenceValue, array, index, (EvidenceValueLambda, arrayLambda, indexLambda) => EvidenceValueLambda.CopyTo(arrayLambda, indexLambda));
}


public static IObservable<System.Collections.IEnumerator> GetHostEnumerator(this IObservable<System.Security.Policy.Evidence> EvidenceValue)
{
    return Observable.Select(EvidenceValue, (EvidenceValueLambda) => EvidenceValueLambda.GetHostEnumerator());
}


public static IObservable<System.Collections.IEnumerator> GetAssemblyEnumerator(this IObservable<System.Security.Policy.Evidence> EvidenceValue)
{
    return Observable.Select(EvidenceValue, (EvidenceValueLambda) => EvidenceValueLambda.GetAssemblyEnumerator());
}


public static IObservable<System.Collections.IEnumerator> GetEnumerator(this IObservable<System.Security.Policy.Evidence> EvidenceValue)
{
    return Observable.Select(EvidenceValue, (EvidenceValueLambda) => EvidenceValueLambda.GetEnumerator());
}


public static IObservable<T> GetAssemblyEvidence<T>(this IObservable<System.Security.Policy.Evidence> EvidenceValue)
{
    return Observable.Select(EvidenceValue, (EvidenceValueLambda) => EvidenceValueLambda.GetAssemblyEvidence());
}


public static IObservable<T> GetHostEvidence<T>(this IObservable<System.Security.Policy.Evidence> EvidenceValue)
{
    return Observable.Select(EvidenceValue, (EvidenceValueLambda) => EvidenceValueLambda.GetHostEvidence());
}


public static IObservable<System.Security.Policy.Evidence> Clone(this IObservable<System.Security.Policy.Evidence> EvidenceValue)
{
    return Observable.Select(EvidenceValue, (EvidenceValueLambda) => EvidenceValueLambda.Clone());
}


public static IObservable<System.Reactive.Unit> Clear(this IObservable<System.Security.Policy.Evidence> EvidenceValue)
{
    return Observable.Do(EvidenceValue, (EvidenceValueLambda) => EvidenceValueLambda.Clear()).ToUnit();
}


public static IObservable<System.Reactive.Unit> RemoveType(this IObservable<System.Security.Policy.Evidence> EvidenceValue, IObservable<System.Type> t)
{
    return ObservableExt.ZipExecute(EvidenceValue, t, (EvidenceValueLambda, tLambda) => EvidenceValueLambda.RemoveType(tLambda));
}


public static IObservable<System.Boolean> get_Locked(this IObservable<System.Security.Policy.Evidence> EvidenceValue)
{
    return Observable.Select(EvidenceValue, (EvidenceValueLambda) => EvidenceValueLambda.Locked);
}


public static IObservable<System.Int32> get_Count(this IObservable<System.Security.Policy.Evidence> EvidenceValue)
{
    return Observable.Select(EvidenceValue, (EvidenceValueLambda) => EvidenceValueLambda.Count);
}


public static IObservable<System.Object> get_SyncRoot(this IObservable<System.Security.Policy.Evidence> EvidenceValue)
{
    return Observable.Select(EvidenceValue, (EvidenceValueLambda) => EvidenceValueLambda.SyncRoot);
}


public static IObservable<System.Boolean> get_IsSynchronized(this IObservable<System.Security.Policy.Evidence> EvidenceValue)
{
    return Observable.Select(EvidenceValue, (EvidenceValueLambda) => EvidenceValueLambda.IsSynchronized);
}


public static IObservable<System.Boolean> get_IsReadOnly(this IObservable<System.Security.Policy.Evidence> EvidenceValue)
{
    return Observable.Select(EvidenceValue, (EvidenceValueLambda) => EvidenceValueLambda.IsReadOnly);
}


public static IObservable<System.Reactive.Unit> set_Locked(this IObservable<System.Security.Policy.Evidence> EvidenceValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(EvidenceValue, value, (EvidenceValueLambda, valueLambda) => EvidenceValueLambda.Locked = valueLambda);
}

}
}