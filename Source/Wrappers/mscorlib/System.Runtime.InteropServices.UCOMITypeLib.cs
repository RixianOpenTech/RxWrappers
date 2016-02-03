using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __UCOMITypeLib
    {
        public static IObservable<System.Int32> GetTypeInfoCount(
            this IObservable<System.Runtime.InteropServices.UCOMITypeLib> UCOMITypeLibValue)
        {
            return Observable.Select(UCOMITypeLibValue,
                (UCOMITypeLibValueLambda) => UCOMITypeLibValueLambda.GetTypeInfoCount());
        }


        public static IObservable<System.Runtime.InteropServices.UCOMITypeInfo> GetTypeInfo(
            this IObservable<System.Runtime.InteropServices.UCOMITypeLib> UCOMITypeLibValue,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(UCOMITypeLibValue, index, (UCOMITypeLibValueLambda, indexLambda) =>
            {
                System.Runtime.InteropServices.UCOMITypeInfo ppTIOutput =
                    default(System.Runtime.InteropServices.UCOMITypeInfo);
                UCOMITypeLibValueLambda.GetTypeInfo(indexLambda, out ppTIOutput);
                return ppTIOutput;
            });
        }


        public static IObservable<System.Runtime.InteropServices.TYPEKIND> GetTypeInfoType(
            this IObservable<System.Runtime.InteropServices.UCOMITypeLib> UCOMITypeLibValue,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(UCOMITypeLibValue, index, (UCOMITypeLibValueLambda, indexLambda) =>
            {
                System.Runtime.InteropServices.TYPEKIND pTKindOutput = default(System.Runtime.InteropServices.TYPEKIND);
                UCOMITypeLibValueLambda.GetTypeInfoType(indexLambda, out pTKindOutput);
                return pTKindOutput;
            });
        }


        public static IObservable<Tuple<System.Guid, System.Runtime.InteropServices.UCOMITypeInfo>> GetTypeInfoOfGuid(
            this IObservable<System.Runtime.InteropServices.UCOMITypeLib> UCOMITypeLibValue,
            IObservable<System.Guid> guid)
        {
            return Observable.Zip(UCOMITypeLibValue, guid, (UCOMITypeLibValueLambda, guidLambda) =>
            {
                System.Runtime.InteropServices.UCOMITypeInfo ppTInfoOutput =
                    default(System.Runtime.InteropServices.UCOMITypeInfo);
                UCOMITypeLibValueLambda.GetTypeInfoOfGuid(ref guidLambda, out ppTInfoOutput);
                return Tuple.Create(guidLambda, ppTInfoOutput);
            });
        }


        public static IObservable<System.IntPtr> GetLibAttr(
            this IObservable<System.Runtime.InteropServices.UCOMITypeLib> UCOMITypeLibValue)
        {
            return Observable.Select(UCOMITypeLibValue, (UCOMITypeLibValueLambda) =>
            {
                System.IntPtr ppTLibAttrOutput = default(System.IntPtr);
                UCOMITypeLibValueLambda.GetLibAttr(out ppTLibAttrOutput);
                return ppTLibAttrOutput;
            });
        }


        public static IObservable<System.Runtime.InteropServices.UCOMITypeComp> GetTypeComp(
            this IObservable<System.Runtime.InteropServices.UCOMITypeLib> UCOMITypeLibValue)
        {
            return Observable.Select(UCOMITypeLibValue, (UCOMITypeLibValueLambda) =>
            {
                System.Runtime.InteropServices.UCOMITypeComp ppTCompOutput =
                    default(System.Runtime.InteropServices.UCOMITypeComp);
                UCOMITypeLibValueLambda.GetTypeComp(out ppTCompOutput);
                return ppTCompOutput;
            });
        }


        public static IObservable<Tuple<System.String, System.String, System.Int32, System.String>> GetDocumentation(
            this IObservable<System.Runtime.InteropServices.UCOMITypeLib> UCOMITypeLibValue,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(UCOMITypeLibValue, index, (UCOMITypeLibValueLambda, indexLambda) =>
            {
                System.String strNameOutput = default(System.String);
                System.String strDocStringOutput = default(System.String);
                System.Int32 dwHelpContextOutput = default(System.Int32);
                System.String strHelpFileOutput = default(System.String);
                UCOMITypeLibValueLambda.GetDocumentation(indexLambda, out strNameOutput, out strDocStringOutput,
                    out dwHelpContextOutput, out strHelpFileOutput);
                return Tuple.Create(strNameOutput, strDocStringOutput, dwHelpContextOutput, strHelpFileOutput);
            });
        }


        public static IObservable<System.Boolean> IsName(
            this IObservable<System.Runtime.InteropServices.UCOMITypeLib> UCOMITypeLibValue,
            IObservable<System.String> szNameBuf, IObservable<System.Int32> lHashVal)
        {
            return Observable.Zip(UCOMITypeLibValue, szNameBuf, lHashVal,
                (UCOMITypeLibValueLambda, szNameBufLambda, lHashValLambda) =>
                    UCOMITypeLibValueLambda.IsName(szNameBufLambda, lHashValLambda));
        }


        public static IObservable<short> FindName(
            this IObservable<System.Runtime.InteropServices.UCOMITypeLib> UCOMITypeLibValue,
            IObservable<System.String> szNameBuf, IObservable<System.Int32> lHashVal,
            IObservable<System.Runtime.InteropServices.UCOMITypeInfo[]> ppTInfo, IObservable<System.Int32[]> rgMemId,
            IObservable<System.Int16> pcFound)
        {
            return Observable.Zip(UCOMITypeLibValue, szNameBuf, lHashVal, ppTInfo, rgMemId, pcFound,
                (UCOMITypeLibValueLambda, szNameBufLambda, lHashValLambda, ppTInfoLambda, rgMemIdLambda, pcFoundLambda)
                    =>
                {
                    UCOMITypeLibValueLambda.FindName(szNameBufLambda, lHashValLambda, ppTInfoLambda, rgMemIdLambda,
                        ref pcFoundLambda);
                    return pcFoundLambda;
                });
        }


        public static IObservable<System.Reactive.Unit> ReleaseTLibAttr(
            this IObservable<System.Runtime.InteropServices.UCOMITypeLib> UCOMITypeLibValue,
            IObservable<System.IntPtr> pTLibAttr)
        {
            return ObservableExt.ZipExecute(UCOMITypeLibValue, pTLibAttr,
                (UCOMITypeLibValueLambda, pTLibAttrLambda) => UCOMITypeLibValueLambda.ReleaseTLibAttr(pTLibAttrLambda));
        }
    }
}