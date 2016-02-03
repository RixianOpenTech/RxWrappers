using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.Contracts
{
public static class _Contract
{
    
public static IObservable<System.Reactive.Unit> Assume(IObservable<System.Boolean> condition)
{
    return Observable.Do(condition, (conditionLambda) => System.Diagnostics.Contracts.Contract.Assume(conditionLambda)).ToUnit();
}


public static IObservable<System.Reactive.Unit> Assume(IObservable<System.Boolean> condition, IObservable<System.String> userMessage)
{
    return ObservableExt.ZipExecute(condition, userMessage, (conditionLambda, userMessageLambda) => System.Diagnostics.Contracts.Contract.Assume(conditionLambda, userMessageLambda));
}


public static IObservable<System.Reactive.Unit> Assert(IObservable<System.Boolean> condition)
{
    return Observable.Do(condition, (conditionLambda) => System.Diagnostics.Contracts.Contract.Assert(conditionLambda)).ToUnit();
}


public static IObservable<System.Reactive.Unit> Assert(IObservable<System.Boolean> condition, IObservable<System.String> userMessage)
{
    return ObservableExt.ZipExecute(condition, userMessage, (conditionLambda, userMessageLambda) => System.Diagnostics.Contracts.Contract.Assert(conditionLambda, userMessageLambda));
}


public static IObservable<System.Reactive.Unit> Requires(IObservable<System.Boolean> condition)
{
    return Observable.Do(condition, (conditionLambda) => System.Diagnostics.Contracts.Contract.Requires(conditionLambda)).ToUnit();
}


public static IObservable<System.Reactive.Unit> Requires(IObservable<System.Boolean> condition, IObservable<System.String> userMessage)
{
    return ObservableExt.ZipExecute(condition, userMessage, (conditionLambda, userMessageLambda) => System.Diagnostics.Contracts.Contract.Requires(conditionLambda, userMessageLambda));
}


public static IObservable<System.Reactive.Unit> Requires<TException>(IObservable<System.Boolean> condition)
{
    return Observable.Do(condition, (conditionLambda) => System.Diagnostics.Contracts.Contract.Requires(conditionLambda)).ToUnit();
}


public static IObservable<System.Reactive.Unit> Requires<TException>(IObservable<System.Boolean> condition, IObservable<System.String> userMessage)
{
    return ObservableExt.ZipExecute(condition, userMessage, (conditionLambda, userMessageLambda) => System.Diagnostics.Contracts.Contract.Requires(conditionLambda, userMessageLambda));
}


public static IObservable<System.Reactive.Unit> Ensures(IObservable<System.Boolean> condition)
{
    return Observable.Do(condition, (conditionLambda) => System.Diagnostics.Contracts.Contract.Ensures(conditionLambda)).ToUnit();
}


public static IObservable<System.Reactive.Unit> Ensures(IObservable<System.Boolean> condition, IObservable<System.String> userMessage)
{
    return ObservableExt.ZipExecute(condition, userMessage, (conditionLambda, userMessageLambda) => System.Diagnostics.Contracts.Contract.Ensures(conditionLambda, userMessageLambda));
}


public static IObservable<System.Reactive.Unit> EnsuresOnThrow<TException>(IObservable<System.Boolean> condition)
{
    return Observable.Do(condition, (conditionLambda) => System.Diagnostics.Contracts.Contract.EnsuresOnThrow(conditionLambda)).ToUnit();
}


public static IObservable<System.Reactive.Unit> EnsuresOnThrow<TException>(IObservable<System.Boolean> condition, IObservable<System.String> userMessage)
{
    return ObservableExt.ZipExecute(condition, userMessage, (conditionLambda, userMessageLambda) => System.Diagnostics.Contracts.Contract.EnsuresOnThrow(conditionLambda, userMessageLambda));
}


public static IObservable<T> Result<T>()
{
    return ObservableExt.Factory(() => System.Diagnostics.Contracts.Contract.Result());
}


public static IObservable<Tuple<T, T>> ValueAtReturn<T>()
{
    return ObservableExt.Factory(() => {
T valueOutput = default(T);
var result = System.Diagnostics.Contracts.Contract.ValueAtReturn(out valueOutput);
return Tuple.Create(result, valueOutput);
});
}


public static IObservable<T> OldValue<T>(IObservable<T> value)
{
    return Observable.Select(value, (valueLambda) => System.Diagnostics.Contracts.Contract.OldValue(valueLambda));
}


public static IObservable<System.Reactive.Unit> Invariant(IObservable<System.Boolean> condition)
{
    return Observable.Do(condition, (conditionLambda) => System.Diagnostics.Contracts.Contract.Invariant(conditionLambda)).ToUnit();
}


public static IObservable<System.Reactive.Unit> Invariant(IObservable<System.Boolean> condition, IObservable<System.String> userMessage)
{
    return ObservableExt.ZipExecute(condition, userMessage, (conditionLambda, userMessageLambda) => System.Diagnostics.Contracts.Contract.Invariant(conditionLambda, userMessageLambda));
}


public static IObservable<System.Boolean> ForAll(IObservable<System.Int32> fromInclusive, IObservable<System.Int32> toExclusive, IObservable<System.Predicate<System.Int32>> predicate)
{
    return Observable.Zip(fromInclusive, toExclusive, predicate, (fromInclusiveLambda, toExclusiveLambda, predicateLambda) => System.Diagnostics.Contracts.Contract.ForAll(fromInclusiveLambda, toExclusiveLambda, predicateLambda));
}


public static IObservable<System.Boolean> ForAll<T>(IObservable<IEnumerable<T>> collection, IObservable<Predicate<T>> predicate)
{
    return Observable.Zip(collection, predicate, (collectionLambda, predicateLambda) => System.Diagnostics.Contracts.Contract.ForAll(collectionLambda, predicateLambda));
}


public static IObservable<System.Boolean> Exists(IObservable<System.Int32> fromInclusive, IObservable<System.Int32> toExclusive, IObservable<System.Predicate<System.Int32>> predicate)
{
    return Observable.Zip(fromInclusive, toExclusive, predicate, (fromInclusiveLambda, toExclusiveLambda, predicateLambda) => System.Diagnostics.Contracts.Contract.Exists(fromInclusiveLambda, toExclusiveLambda, predicateLambda));
}


public static IObservable<System.Boolean> Exists<T>(IObservable<IEnumerable<T>> collection, IObservable<Predicate<T>> predicate)
{
    return Observable.Zip(collection, predicate, (collectionLambda, predicateLambda) => System.Diagnostics.Contracts.Contract.Exists(collectionLambda, predicateLambda));
}


public static IObservable<System.Reactive.Unit> EndContractBlock()
{
    return ObservableExt.Factory(() => System.Diagnostics.Contracts.Contract.EndContractBlock());
}

}
}