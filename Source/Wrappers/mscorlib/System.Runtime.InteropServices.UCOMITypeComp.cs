using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __UCOMITypeComp
    {
        public static
            IObservable
                <
                    Tuple
                        <System.Runtime.InteropServices.UCOMITypeInfo, System.Runtime.InteropServices.DESCKIND,
                            System.Runtime.InteropServices.BINDPTR>> Bind(
            this IObservable<System.Runtime.InteropServices.UCOMITypeComp> UCOMITypeCompValue,
            IObservable<System.String> szName, IObservable<System.Int32> lHashVal, IObservable<System.Int16> wFlags)
        {
            return Observable.Zip(UCOMITypeCompValue, szName, lHashVal, wFlags,
                (UCOMITypeCompValueLambda, szNameLambda, lHashValLambda, wFlagsLambda) =>
                {
                    System.Runtime.InteropServices.UCOMITypeInfo ppTInfoOutput =
                        default(System.Runtime.InteropServices.UCOMITypeInfo);
                    System.Runtime.InteropServices.DESCKIND pDescKindOutput =
                        default(System.Runtime.InteropServices.DESCKIND);
                    System.Runtime.InteropServices.BINDPTR pBindPtrOutput =
                        default(System.Runtime.InteropServices.BINDPTR);
                    UCOMITypeCompValueLambda.Bind(szNameLambda, lHashValLambda, wFlagsLambda, out ppTInfoOutput,
                        out pDescKindOutput, out pBindPtrOutput);
                    return Tuple.Create(ppTInfoOutput, pDescKindOutput, pBindPtrOutput);
                });
        }


        public static
            IObservable
                <Tuple<System.Runtime.InteropServices.UCOMITypeInfo, System.Runtime.InteropServices.UCOMITypeComp>>
            BindType(this IObservable<System.Runtime.InteropServices.UCOMITypeComp> UCOMITypeCompValue,
                IObservable<System.String> szName, IObservable<System.Int32> lHashVal)
        {
            return Observable.Zip(UCOMITypeCompValue, szName, lHashVal,
                (UCOMITypeCompValueLambda, szNameLambda, lHashValLambda) =>
                {
                    System.Runtime.InteropServices.UCOMITypeInfo ppTInfoOutput =
                        default(System.Runtime.InteropServices.UCOMITypeInfo);
                    System.Runtime.InteropServices.UCOMITypeComp ppTCompOutput =
                        default(System.Runtime.InteropServices.UCOMITypeComp);
                    UCOMITypeCompValueLambda.BindType(szNameLambda, lHashValLambda, out ppTInfoOutput, out ppTCompOutput);
                    return Tuple.Create(ppTInfoOutput, ppTCompOutput);
                });
        }
    }
}