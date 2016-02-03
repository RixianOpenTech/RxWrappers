using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.ComTypes
{
    public static class __ITypeLib
    {
        
        public static IObservable<System.Int32> GetTypeInfoCount(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeLib> ITypeLibValue)
        {
            return Observable.Select(ITypeLibValue, (ITypeLibValueLambda) => ITypeLibValueLambda.GetTypeInfoCount());
        }


        public static IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo> GetTypeInfo(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeLib> ITypeLibValue, IObservable<System.Int32> index)
        {
            return Observable.Zip(ITypeLibValue, index, (ITypeLibValueLambda, indexLambda) => {
System.Runtime.InteropServices.ComTypes.ITypeInfo ppTIOutput = default(System.Runtime.InteropServices.ComTypes.ITypeInfo);
ITypeLibValueLambda.GetTypeInfo(indexLambda, out ppTIOutput);
return ppTIOutput;
});
        }


        public static IObservable<System.Runtime.InteropServices.ComTypes.TYPEKIND> GetTypeInfoType(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeLib> ITypeLibValue, IObservable<System.Int32> index)
        {
            return Observable.Zip(ITypeLibValue, index, (ITypeLibValueLambda, indexLambda) => {
System.Runtime.InteropServices.ComTypes.TYPEKIND pTKindOutput = default(System.Runtime.InteropServices.ComTypes.TYPEKIND);
ITypeLibValueLambda.GetTypeInfoType(indexLambda, out pTKindOutput);
return pTKindOutput;
});
        }


        public static IObservable<Tuple<System.Guid, System.Runtime.InteropServices.ComTypes.ITypeInfo>> GetTypeInfoOfGuid(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeLib> ITypeLibValue, IObservable<System.Guid> guid)
        {
            return Observable.Zip(ITypeLibValue, guid, (ITypeLibValueLambda, guidLambda) => {
System.Runtime.InteropServices.ComTypes.ITypeInfo ppTInfoOutput = default(System.Runtime.InteropServices.ComTypes.ITypeInfo);
ITypeLibValueLambda.GetTypeInfoOfGuid(ref guidLambda, out ppTInfoOutput);
return Tuple.Create(guidLambda, ppTInfoOutput);
});
        }


        public static IObservable<System.IntPtr> GetLibAttr(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeLib> ITypeLibValue)
        {
            return Observable.Select(ITypeLibValue, (ITypeLibValueLambda) => {
System.IntPtr ppTLibAttrOutput = default(System.IntPtr);
ITypeLibValueLambda.GetLibAttr(out ppTLibAttrOutput);
return ppTLibAttrOutput;
});
        }


        public static IObservable<System.Runtime.InteropServices.ComTypes.ITypeComp> GetTypeComp(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeLib> ITypeLibValue)
        {
            return Observable.Select(ITypeLibValue, (ITypeLibValueLambda) => {
System.Runtime.InteropServices.ComTypes.ITypeComp ppTCompOutput = default(System.Runtime.InteropServices.ComTypes.ITypeComp);
ITypeLibValueLambda.GetTypeComp(out ppTCompOutput);
return ppTCompOutput;
});
        }


        public static IObservable<Tuple<System.String, System.String, System.Int32, System.String>> GetDocumentation(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeLib> ITypeLibValue, IObservable<System.Int32> index)
        {
            return Observable.Zip(ITypeLibValue, index, (ITypeLibValueLambda, indexLambda) => {
System.String strNameOutput = default(System.String);
System.String strDocStringOutput = default(System.String);
System.Int32 dwHelpContextOutput = default(System.Int32);
System.String strHelpFileOutput = default(System.String);
ITypeLibValueLambda.GetDocumentation(indexLambda, out strNameOutput, out strDocStringOutput, out dwHelpContextOutput, out strHelpFileOutput);
return Tuple.Create(strNameOutput, strDocStringOutput, dwHelpContextOutput, strHelpFileOutput);
});
        }


        public static IObservable<System.Boolean> IsName(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeLib> ITypeLibValue, IObservable<System.String> szNameBuf, IObservable<System.Int32> lHashVal)
        {
            return Observable.Zip(ITypeLibValue, szNameBuf, lHashVal, (ITypeLibValueLambda, szNameBufLambda, lHashValLambda) => ITypeLibValueLambda.IsName(szNameBufLambda, lHashValLambda));
        }


        public static IObservable<short> FindName(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeLib> ITypeLibValue, IObservable<System.String> szNameBuf, IObservable<System.Int32> lHashVal, IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo[]> ppTInfo, IObservable<System.Int32[]> rgMemId, IObservable<System.Int16> pcFound)
        {
            return Observable.Zip(ITypeLibValue, szNameBuf, lHashVal, ppTInfo, rgMemId, pcFound, (ITypeLibValueLambda, szNameBufLambda, lHashValLambda, ppTInfoLambda, rgMemIdLambda, pcFoundLambda) => {
ITypeLibValueLambda.FindName(szNameBufLambda, lHashValLambda, ppTInfoLambda, rgMemIdLambda, ref pcFoundLambda);
return pcFoundLambda;
});
        }


        public static IObservable<System.Reactive.Unit> ReleaseTLibAttr(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeLib> ITypeLibValue, IObservable<System.IntPtr> pTLibAttr)
        {
            return ObservableExt.ZipExecute(ITypeLibValue, pTLibAttr, (ITypeLibValueLambda, pTLibAttrLambda) => ITypeLibValueLambda.ReleaseTLibAttr(pTLibAttrLambda));
        }

    }
}