using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
public static class _Binder
{
    
public static IObservable<Tuple<System.Reflection.MethodBase, System.Object[], System.Object>> BindToMethod(this IObservable<System.Reflection.Binder> BinderValue, IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.MethodBase[]> match, IObservable<System.Object[]> args, IObservable<System.Reflection.ParameterModifier[]> modifiers, IObservable<System.Globalization.CultureInfo> culture, IObservable<System.String[]> names)
{
    return Observable.Zip(BinderValue, bindingAttr, match, args, modifiers, culture, names, (BinderValueLambda, bindingAttrLambda, matchLambda, argsLambda, modifiersLambda, cultureLambda, namesLambda) => {
System.Object stateOutput = default(System.Object);
var result = BinderValueLambda.BindToMethod(bindingAttrLambda, matchLambda, ref argsLambda, modifiersLambda, cultureLambda, namesLambda, out stateOutput);
return Tuple.Create(result, argsLambda, stateOutput);
});
}


public static IObservable<System.Reflection.FieldInfo> BindToField(this IObservable<System.Reflection.Binder> BinderValue, IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.FieldInfo[]> match, IObservable<System.Object> value, IObservable<System.Globalization.CultureInfo> culture)
{
    return Observable.Zip(BinderValue, bindingAttr, match, value, culture, (BinderValueLambda, bindingAttrLambda, matchLambda, valueLambda, cultureLambda) => BinderValueLambda.BindToField(bindingAttrLambda, matchLambda, valueLambda, cultureLambda));
}


public static IObservable<System.Reflection.MethodBase> SelectMethod(this IObservable<System.Reflection.Binder> BinderValue, IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.MethodBase[]> match, IObservable<System.Type[]> types, IObservable<System.Reflection.ParameterModifier[]> modifiers)
{
    return Observable.Zip(BinderValue, bindingAttr, match, types, modifiers, (BinderValueLambda, bindingAttrLambda, matchLambda, typesLambda, modifiersLambda) => BinderValueLambda.SelectMethod(bindingAttrLambda, matchLambda, typesLambda, modifiersLambda));
}


public static IObservable<System.Reflection.PropertyInfo> SelectProperty(this IObservable<System.Reflection.Binder> BinderValue, IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.PropertyInfo[]> match, IObservable<System.Type> returnType, IObservable<System.Type[]> indexes, IObservable<System.Reflection.ParameterModifier[]> modifiers)
{
    return Observable.Zip(BinderValue, bindingAttr, match, returnType, indexes, modifiers, (BinderValueLambda, bindingAttrLambda, matchLambda, returnTypeLambda, indexesLambda, modifiersLambda) => BinderValueLambda.SelectProperty(bindingAttrLambda, matchLambda, returnTypeLambda, indexesLambda, modifiersLambda));
}


public static IObservable<System.Object> ChangeType(this IObservable<System.Reflection.Binder> BinderValue, IObservable<System.Object> value, IObservable<System.Type> type, IObservable<System.Globalization.CultureInfo> culture)
{
    return Observable.Zip(BinderValue, value, type, culture, (BinderValueLambda, valueLambda, typeLambda, cultureLambda) => BinderValueLambda.ChangeType(valueLambda, typeLambda, cultureLambda));
}


public static IObservable<System.Object[]> ReorderArgumentArray(this IObservable<System.Reflection.Binder> BinderValue, IObservable<System.Object[]> args, IObservable<System.Object> state)
{
    return Observable.Zip(BinderValue, args, state, (BinderValueLambda, argsLambda, stateLambda) => {
BinderValueLambda.ReorderArgumentArray(ref argsLambda, stateLambda);
return argsLambda;
});
}

}
}