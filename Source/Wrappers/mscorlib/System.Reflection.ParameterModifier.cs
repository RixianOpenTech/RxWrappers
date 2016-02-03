using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
public static class _ParameterModifier
{
    
public static IObservable<System.Boolean> get_Item(this IObservable<System.Reflection.ParameterModifier> ParameterModifierValue, IObservable<System.Int32> index)
{
    return Observable.Zip(ParameterModifierValue, index, (ParameterModifierValueLambda, indexLambda) => ParameterModifierValueLambda.Item);
}


public static IObservable<System.Reactive.Unit> set_Item(this IObservable<System.Reflection.ParameterModifier> ParameterModifierValue, IObservable<System.Int32> index, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(ParameterModifierValue, index, value, (ParameterModifierValueLambda, indexLambda, valueLambda) => ParameterModifierValueLambda.Item = valueLambda);
}

}
}