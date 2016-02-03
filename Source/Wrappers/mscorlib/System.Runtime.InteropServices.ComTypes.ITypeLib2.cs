using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.ComTypes
{
    public static class __ITypeLib2
    {
        
        public static IObservable<System.Int32> GetTypeInfoCount(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeLib2> ITypeLib2Value)
        {
            return Observable.Select(ITypeLib2Value, (ITypeLib2ValueLambda) => ITypeLib2ValueLambda.GetTypeInfoCount());
        }


        public static IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo> GetTypeInfo(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeLib2> ITypeLib2Value, IObservable<System.Int32> index)
        {
            return Observable.Zip(ITypeLib2Value, index, (ITypeLib2ValueLambda, indexLambda) => {
System.Runtime.InteropServices.ComTypes.ITypeInfo ppTIOutput = default(System.Runtime.InteropServices.ComTypes.ITypeInfo);
ITypeLib2ValueLambda.GetTypeInfo(indexLambda, out ppTIOutput);
return ppTIOutput;
});
        }


        public static IObservable<System.Runtime.InteropServices.ComTypes.TYPEKIND> GetTypeInfoType(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeLib2> ITypeLib2Value, IObservable<System.Int32> index)
        {
            return Observable.Zip(ITypeLib2Value, index, (ITypeLib2ValueLambda, indexLambda) => {
System.Runtime.InteropServices.ComTypes.TYPEKIND pTKindOutput = default(System.Runtime.InteropServices.ComTypes.TYPEKIND);
ITypeLib2ValueLambda.GetTypeInfoType(indexLambda, out pTKindOutput);
return pTKindOutput;
});
        }


        public static IObservable<Tuple<System.Guid, System.Runtime.InteropServices.ComTypes.ITypeInfo>> GetTypeInfoOfGuid(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeLib2> ITypeLib2Value, IObservable<System.Guid> guid)
        {
            return Observable.Zip(ITypeLib2Value, guid, (ITypeLib2ValueLambda, guidLambda) => {
System.Runtime.InteropServices.ComTypes.ITypeInfo ppTInfoOutput = default(System.Runtime.InteropServices.ComTypes.ITypeInfo);
ITypeLib2ValueLambda.GetTypeInfoOfGuid(ref guidLambda, out ppTInfoOutput);
return Tuple.Create(guidLambda, ppTInfoOutput);
});
        }


        public static IObservable<System.IntPtr> GetLibAttr(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeLib2> ITypeLib2Value)
        {
            return Observable.Select(ITypeLib2Value, (ITypeLib2ValueLambda) => {
System.IntPtr ppTLibAttrOutput = default(System.IntPtr);
ITypeLib2ValueLambda.GetLibAttr(out ppTLibAttrOutput);
return ppTLibAttrOutput;
});
        }


        public static IObservable<System.Runtime.InteropServices.ComTypes.ITypeComp> GetTypeComp(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeLib2> ITypeLib2Value)
        {
            return Observable.Select(ITypeLib2Value, (ITypeLib2ValueLambda) => {
System.Runtime.InteropServices.ComTypes.ITypeComp ppTCompOutput = default(System.Runtime.InteropServices.ComTypes.ITypeComp);
ITypeLib2ValueLambda.GetTypeComp(out ppTCompOutput);
return ppTCompOutput;
});
        }


        public static IObservable<Tuple<System.String, System.String, System.Int32, System.String>> GetDocumentation(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeLib2> ITypeLib2Value, IObservable<System.Int32> index)
        {
            return Observable.Zip(ITypeLib2Value, index, (ITypeLib2ValueLambda, indexLambda) => {
System.String strNameOutput = default(System.String);
System.String strDocStringOutput = default(System.String);
System.Int32 dwHelpContextOutput = default(System.Int32);
System.String strHelpFileOutput = default(System.String);
ITypeLib2ValueLambda.GetDocumentation(indexLambda, out strNameOutput, out strDocStringOutput, out dwHelpContextOutput, out strHelpFileOutput);
return Tuple.Create(strNameOutput, strDocStringOutput, dwHelpContextOutput, strHelpFileOutput);
});
        }


        public static IObservable<System.Boolean> IsName(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeLib2> ITypeLib2Value, IObservable<System.String> szNameBuf, IObservable<System.Int32> lHashVal)
        {
            return Observable.Zip(ITypeLib2Value, szNameBuf, lHashVal, (ITypeLib2ValueLambda, szNameBufLambda, lHashValLambda) => ITypeLib2ValueLambda.IsName(szNameBufLambda, lHashValLambda));
        }


        public static IObservable<short> FindName(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeLib2> ITypeLib2Value, IObservable<System.String> szNameBuf, IObservable<System.Int32> lHashVal, IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo[]> ppTInfo, IObservable<System.Int32[]> rgMemId, IObservable<System.Int16> pcFound)
        {
            return Observable.Zip(ITypeLib2Value, szNameBuf, lHashVal, ppTInfo, rgMemId, pcFound, (ITypeLib2ValueLambda, szNameBufLambda, lHashValLambda, ppTInfoLambda, rgMemIdLambda, pcFoundLambda) => {
ITypeLib2ValueLambda.FindName(szNameBufLambda, lHashValLambda, ppTInfoLambda, rgMemIdLambda, ref pcFoundLambda);
return pcFoundLambda;
});
        }


        public static IObservable<System.Reactive.Unit> ReleaseTLibAttr(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeLib2> ITypeLib2Value, IObservable<System.IntPtr> pTLibAttr)
        {
            return ObservableExt.ZipExecute(ITypeLib2Value, pTLibAttr, (ITypeLib2ValueLambda, pTLibAttrLambda) => ITypeLib2ValueLambda.ReleaseTLibAttr(pTLibAttrLambda));
        }


        public static IObservable<Tuple<System.Guid, System.Object>> GetCustData(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeLib2> ITypeLib2Value, IObservable<System.Guid> guid)
        {
            return Observable.Zip(ITypeLib2Value, guid, (ITypeLib2ValueLambda, guidLambda) => {
System.Object pVarValOutput = default(System.Object);
ITypeLib2ValueLambda.GetCustData(ref guidLambda, out pVarValOutput);
return Tuple.Create(guidLambda, pVarValOutput);
});
        }


        public static IObservable<Tuple<System.String, System.Int32, System.String>> GetDocumentation2(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeLib2> ITypeLib2Value, IObservable<System.Int32> index)
        {
            return Observable.Zip(ITypeLib2Value, index, (ITypeLib2ValueLambda, indexLambda) => {
System.String pbstrHelpStringOutput = default(System.String);
System.Int32 pdwHelpStringContextOutput = default(System.Int32);
System.String pbstrHelpStringDllOutput = default(System.String);
ITypeLib2ValueLambda.GetDocumentation2(indexLambda, out pbstrHelpStringOutput, out pdwHelpStringContextOutput, out pbstrHelpStringDllOutput);
return Tuple.Create(pbstrHelpStringOutput, pdwHelpStringContextOutput, pbstrHelpStringDllOutput);
});
        }


        public static IObservable<System.Int32> GetLibStatistics(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeLib2> ITypeLib2Value, IObservable<System.IntPtr> pcUniqueNames)
        {
            return Observable.Zip(ITypeLib2Value, pcUniqueNames, (ITypeLib2ValueLambda, pcUniqueNamesLambda) => {
System.Int32 pcchUniqueNamesOutput = default(System.Int32);
ITypeLib2ValueLambda.GetLibStatistics(pcUniqueNamesLambda, out pcchUniqueNamesOutput);
return pcchUniqueNamesOutput;
});
        }


        public static IObservable<System.Reactive.Unit> GetAllCustData(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeLib2> ITypeLib2Value, IObservable<System.IntPtr> pCustData)
        {
            return ObservableExt.ZipExecute(ITypeLib2Value, pCustData, (ITypeLib2ValueLambda, pCustDataLambda) => ITypeLib2ValueLambda.GetAllCustData(pCustDataLambda));
        }

    }
}