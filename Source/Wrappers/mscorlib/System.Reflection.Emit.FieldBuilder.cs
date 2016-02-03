using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
public static class _FieldBuilder
{
    
public static IObservable<System.Object> GetValue(this IObservable<System.Reflection.Emit.FieldBuilder> FieldBuilderValue, IObservable<System.Object> obj)
{
    return Observable.Zip(FieldBuilderValue, obj, (FieldBuilderValueLambda, objLambda) => FieldBuilderValueLambda.GetValue(objLambda));
}


public static IObservable<System.Reactive.Unit> SetValue(this IObservable<System.Reflection.Emit.FieldBuilder> FieldBuilderValue, IObservable<System.Object> obj, IObservable<System.Object> val, IObservable<System.Reflection.BindingFlags> invokeAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Globalization.CultureInfo> culture)
{
    return ObservableExt.ZipExecute(FieldBuilderValue, obj, val, invokeAttr, binder, culture, (FieldBuilderValueLambda, objLambda, valLambda, invokeAttrLambda, binderLambda, cultureLambda) => FieldBuilderValueLambda.SetValue(objLambda, valLambda, invokeAttrLambda, binderLambda, cultureLambda));
}


public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Reflection.Emit.FieldBuilder> FieldBuilderValue, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(FieldBuilderValue, inherit, (FieldBuilderValueLambda, inheritLambda) => FieldBuilderValueLambda.GetCustomAttributes(inheritLambda));
}


public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Reflection.Emit.FieldBuilder> FieldBuilderValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(FieldBuilderValue, attributeType, inherit, (FieldBuilderValueLambda, attributeTypeLambda, inheritLambda) => FieldBuilderValueLambda.GetCustomAttributes(attributeTypeLambda, inheritLambda));
}


public static IObservable<System.Boolean> IsDefined(this IObservable<System.Reflection.Emit.FieldBuilder> FieldBuilderValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(FieldBuilderValue, attributeType, inherit, (FieldBuilderValueLambda, attributeTypeLambda, inheritLambda) => FieldBuilderValueLambda.IsDefined(attributeTypeLambda, inheritLambda));
}


public static IObservable<System.Reflection.Emit.FieldToken> GetToken(this IObservable<System.Reflection.Emit.FieldBuilder> FieldBuilderValue)
{
    return Observable.Select(FieldBuilderValue, (FieldBuilderValueLambda) => FieldBuilderValueLambda.GetToken());
}


public static IObservable<System.Reactive.Unit> SetOffset(this IObservable<System.Reflection.Emit.FieldBuilder> FieldBuilderValue, IObservable<System.Int32> iOffset)
{
    return ObservableExt.ZipExecute(FieldBuilderValue, iOffset, (FieldBuilderValueLambda, iOffsetLambda) => FieldBuilderValueLambda.SetOffset(iOffsetLambda));
}


public static IObservable<System.Reactive.Unit> SetMarshal(this IObservable<System.Reflection.Emit.FieldBuilder> FieldBuilderValue, IObservable<System.Reflection.Emit.UnmanagedMarshal> unmanagedMarshal)
{
    return ObservableExt.ZipExecute(FieldBuilderValue, unmanagedMarshal, (FieldBuilderValueLambda, unmanagedMarshalLambda) => FieldBuilderValueLambda.SetMarshal(unmanagedMarshalLambda));
}


public static IObservable<System.Reactive.Unit> SetConstant(this IObservable<System.Reflection.Emit.FieldBuilder> FieldBuilderValue, IObservable<System.Object> defaultValue)
{
    return ObservableExt.ZipExecute(FieldBuilderValue, defaultValue, (FieldBuilderValueLambda, defaultValueLambda) => FieldBuilderValueLambda.SetConstant(defaultValueLambda));
}


public static IObservable<System.Reactive.Unit> SetCustomAttribute(this IObservable<System.Reflection.Emit.FieldBuilder> FieldBuilderValue, IObservable<System.Reflection.ConstructorInfo> con, IObservable<System.Byte[]> binaryAttribute)
{
    return ObservableExt.ZipExecute(FieldBuilderValue, con, binaryAttribute, (FieldBuilderValueLambda, conLambda, binaryAttributeLambda) => FieldBuilderValueLambda.SetCustomAttribute(conLambda, binaryAttributeLambda));
}


public static IObservable<System.Reactive.Unit> SetCustomAttribute(this IObservable<System.Reflection.Emit.FieldBuilder> FieldBuilderValue, IObservable<System.Reflection.Emit.CustomAttributeBuilder> customBuilder)
{
    return ObservableExt.ZipExecute(FieldBuilderValue, customBuilder, (FieldBuilderValueLambda, customBuilderLambda) => FieldBuilderValueLambda.SetCustomAttribute(customBuilderLambda));
}


public static IObservable<System.Reflection.Module> get_Module(this IObservable<System.Reflection.Emit.FieldBuilder> FieldBuilderValue)
{
    return Observable.Select(FieldBuilderValue, (FieldBuilderValueLambda) => FieldBuilderValueLambda.Module);
}


public static IObservable<System.String> get_Name(this IObservable<System.Reflection.Emit.FieldBuilder> FieldBuilderValue)
{
    return Observable.Select(FieldBuilderValue, (FieldBuilderValueLambda) => FieldBuilderValueLambda.Name);
}


public static IObservable<System.Type> get_DeclaringType(this IObservable<System.Reflection.Emit.FieldBuilder> FieldBuilderValue)
{
    return Observable.Select(FieldBuilderValue, (FieldBuilderValueLambda) => FieldBuilderValueLambda.DeclaringType);
}


public static IObservable<System.Type> get_ReflectedType(this IObservable<System.Reflection.Emit.FieldBuilder> FieldBuilderValue)
{
    return Observable.Select(FieldBuilderValue, (FieldBuilderValueLambda) => FieldBuilderValueLambda.ReflectedType);
}


public static IObservable<System.Type> get_FieldType(this IObservable<System.Reflection.Emit.FieldBuilder> FieldBuilderValue)
{
    return Observable.Select(FieldBuilderValue, (FieldBuilderValueLambda) => FieldBuilderValueLambda.FieldType);
}


public static IObservable<System.RuntimeFieldHandle> get_FieldHandle(this IObservable<System.Reflection.Emit.FieldBuilder> FieldBuilderValue)
{
    return Observable.Select(FieldBuilderValue, (FieldBuilderValueLambda) => FieldBuilderValueLambda.FieldHandle);
}


public static IObservable<System.Reflection.FieldAttributes> get_Attributes(this IObservable<System.Reflection.Emit.FieldBuilder> FieldBuilderValue)
{
    return Observable.Select(FieldBuilderValue, (FieldBuilderValueLambda) => FieldBuilderValueLambda.Attributes);
}

}
}