using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.ComTypes
{
public static class _ITypeComp
{
    
public static IObservable<Tuple<System.Runtime.InteropServices.ComTypes.ITypeInfo, System.Runtime.InteropServices.ComTypes.DESCKIND, System.Runtime.InteropServices.ComTypes.BINDPTR>> Bind(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeComp> ITypeCompValue, IObservable<System.String> szName, IObservable<System.Int32> lHashVal, IObservable<System.Int16> wFlags)
{
    return Observable.Zip(ITypeCompValue, szName, lHashVal, wFlags, (ITypeCompValueLambda, szNameLambda, lHashValLambda, wFlagsLambda) => {
System.Runtime.InteropServices.ComTypes.ITypeInfo ppTInfoOutput = default(System.Runtime.InteropServices.ComTypes.ITypeInfo);
System.Runtime.InteropServices.ComTypes.DESCKIND pDescKindOutput = default(System.Runtime.InteropServices.ComTypes.DESCKIND);
System.Runtime.InteropServices.ComTypes.BINDPTR pBindPtrOutput = default(System.Runtime.InteropServices.ComTypes.BINDPTR);
ITypeCompValueLambda.Bind(szNameLambda, lHashValLambda, wFlagsLambda, out ppTInfoOutput, out pDescKindOutput, out pBindPtrOutput);
return Tuple.Create(ppTInfoOutput, pDescKindOutput, pBindPtrOutput);
});
}


public static IObservable<Tuple<System.Runtime.InteropServices.ComTypes.ITypeInfo, System.Runtime.InteropServices.ComTypes.ITypeComp>> BindType(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeComp> ITypeCompValue, IObservable<System.String> szName, IObservable<System.Int32> lHashVal)
{
    return Observable.Zip(ITypeCompValue, szName, lHashVal, (ITypeCompValueLambda, szNameLambda, lHashValLambda) => {
System.Runtime.InteropServices.ComTypes.ITypeInfo ppTInfoOutput = default(System.Runtime.InteropServices.ComTypes.ITypeInfo);
System.Runtime.InteropServices.ComTypes.ITypeComp ppTCompOutput = default(System.Runtime.InteropServices.ComTypes.ITypeComp);
ITypeCompValueLambda.BindType(szNameLambda, lHashValLambda, out ppTInfoOutput, out ppTCompOutput);
return Tuple.Create(ppTInfoOutput, ppTCompOutput);
});
}

}
}