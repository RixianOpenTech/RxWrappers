using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
public static class _MemberInfo
{
    
public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Reflection.MemberInfo> MemberInfoValue, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(MemberInfoValue, inherit, (MemberInfoValueLambda, inheritLambda) => MemberInfoValueLambda.GetCustomAttributes(inheritLambda));
}


public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Reflection.MemberInfo> MemberInfoValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(MemberInfoValue, attributeType, inherit, (MemberInfoValueLambda, attributeTypeLambda, inheritLambda) => MemberInfoValueLambda.GetCustomAttributes(attributeTypeLambda, inheritLambda));
}


public static IObservable<System.Boolean> IsDefined(this IObservable<System.Reflection.MemberInfo> MemberInfoValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(MemberInfoValue, attributeType, inherit, (MemberInfoValueLambda, attributeTypeLambda, inheritLambda) => MemberInfoValueLambda.IsDefined(attributeTypeLambda, inheritLambda));
}


public static IObservable<System.Collections.Generic.IList<System.Reflection.CustomAttributeData>> GetCustomAttributesData(this IObservable<System.Reflection.MemberInfo> MemberInfoValue)
{
    return Observable.Select(MemberInfoValue, (MemberInfoValueLambda) => MemberInfoValueLambda.GetCustomAttributesData());
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.MemberInfo> MemberInfoValue, IObservable<System.Object> obj)
{
    return Observable.Zip(MemberInfoValue, obj, (MemberInfoValueLambda, objLambda) => MemberInfoValueLambda.Equals(objLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Reflection.MemberInfo> MemberInfoValue)
{
    return Observable.Select(MemberInfoValue, (MemberInfoValueLambda) => MemberInfoValueLambda.GetHashCode());
}


public static IObservable<System.Reflection.MemberTypes> get_MemberType(this IObservable<System.Reflection.MemberInfo> MemberInfoValue)
{
    return Observable.Select(MemberInfoValue, (MemberInfoValueLambda) => MemberInfoValueLambda.MemberType);
}


public static IObservable<System.String> get_Name(this IObservable<System.Reflection.MemberInfo> MemberInfoValue)
{
    return Observable.Select(MemberInfoValue, (MemberInfoValueLambda) => MemberInfoValueLambda.Name);
}


public static IObservable<System.Type> get_DeclaringType(this IObservable<System.Reflection.MemberInfo> MemberInfoValue)
{
    return Observable.Select(MemberInfoValue, (MemberInfoValueLambda) => MemberInfoValueLambda.DeclaringType);
}


public static IObservable<System.Type> get_ReflectedType(this IObservable<System.Reflection.MemberInfo> MemberInfoValue)
{
    return Observable.Select(MemberInfoValue, (MemberInfoValueLambda) => MemberInfoValueLambda.ReflectedType);
}


public static IObservable<System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>> get_CustomAttributes(this IObservable<System.Reflection.MemberInfo> MemberInfoValue)
{
    return Observable.Select(MemberInfoValue, (MemberInfoValueLambda) => MemberInfoValueLambda.CustomAttributes);
}


public static IObservable<System.Int32> get_MetadataToken(this IObservable<System.Reflection.MemberInfo> MemberInfoValue)
{
    return Observable.Select(MemberInfoValue, (MemberInfoValueLambda) => MemberInfoValueLambda.MetadataToken);
}


public static IObservable<System.Reflection.Module> get_Module(this IObservable<System.Reflection.MemberInfo> MemberInfoValue)
{
    return Observable.Select(MemberInfoValue, (MemberInfoValueLambda) => MemberInfoValueLambda.Module);
}

}
}