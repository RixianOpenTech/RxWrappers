using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __ITypeLibConverter
    {
        
        public static IObservable<System.Reflection.Emit.AssemblyBuilder> ConvertTypeLibToAssembly(this IObservable<System.Runtime.InteropServices.ITypeLibConverter> ITypeLibConverterValue, IObservable<System.Object> typeLib, IObservable<System.String> asmFileName, IObservable<System.Runtime.InteropServices.TypeLibImporterFlags> flags, IObservable<System.Runtime.InteropServices.ITypeLibImporterNotifySink> notifySink, IObservable<System.Byte[]> publicKey, IObservable<System.Reflection.StrongNameKeyPair> keyPair, IObservable<System.String> asmNamespace, IObservable<System.Version> asmVersion)
        {
            return Observable.Zip(ITypeLibConverterValue, typeLib, asmFileName, flags, notifySink, publicKey, keyPair, asmNamespace, asmVersion, (ITypeLibConverterValueLambda, typeLibLambda, asmFileNameLambda, flagsLambda, notifySinkLambda, publicKeyLambda, keyPairLambda, asmNamespaceLambda, asmVersionLambda) => ITypeLibConverterValueLambda.ConvertTypeLibToAssembly(typeLibLambda, asmFileNameLambda, flagsLambda, notifySinkLambda, publicKeyLambda, keyPairLambda, asmNamespaceLambda, asmVersionLambda));
        }


        public static IObservable<System.Object> ConvertAssemblyToTypeLib(this IObservable<System.Runtime.InteropServices.ITypeLibConverter> ITypeLibConverterValue, IObservable<System.Reflection.Assembly> assembly, IObservable<System.String> typeLibName, IObservable<System.Runtime.InteropServices.TypeLibExporterFlags> flags, IObservable<System.Runtime.InteropServices.ITypeLibExporterNotifySink> notifySink)
        {
            return Observable.Zip(ITypeLibConverterValue, assembly, typeLibName, flags, notifySink, (ITypeLibConverterValueLambda, assemblyLambda, typeLibNameLambda, flagsLambda, notifySinkLambda) => ITypeLibConverterValueLambda.ConvertAssemblyToTypeLib(assemblyLambda, typeLibNameLambda, flagsLambda, notifySinkLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.String, System.String>> GetPrimaryInteropAssembly(this IObservable<System.Runtime.InteropServices.ITypeLibConverter> ITypeLibConverterValue, IObservable<System.Guid> g, IObservable<System.Int32> major, IObservable<System.Int32> minor, IObservable<System.Int32> lcid)
        {
            return Observable.Zip(ITypeLibConverterValue, g, major, minor, lcid, (ITypeLibConverterValueLambda, gLambda, majorLambda, minorLambda, lcidLambda) => {
System.String asmNameOutput = default(System.String);
System.String asmCodeBaseOutput = default(System.String);
var result = ITypeLibConverterValueLambda.GetPrimaryInteropAssembly(gLambda, majorLambda, minorLambda, lcidLambda, out asmNameOutput, out asmCodeBaseOutput);
return Tuple.Create(result, asmNameOutput, asmCodeBaseOutput);
});
        }


        public static IObservable<System.Reflection.Emit.AssemblyBuilder> ConvertTypeLibToAssembly(this IObservable<System.Runtime.InteropServices.ITypeLibConverter> ITypeLibConverterValue, IObservable<System.Object> typeLib, IObservable<System.String> asmFileName, IObservable<System.Int32> flags, IObservable<System.Runtime.InteropServices.ITypeLibImporterNotifySink> notifySink, IObservable<System.Byte[]> publicKey, IObservable<System.Reflection.StrongNameKeyPair> keyPair, IObservable<System.Boolean> unsafeInterfaces)
        {
            return Observable.Zip(ITypeLibConverterValue, typeLib, asmFileName, flags, notifySink, publicKey, keyPair, unsafeInterfaces, (ITypeLibConverterValueLambda, typeLibLambda, asmFileNameLambda, flagsLambda, notifySinkLambda, publicKeyLambda, keyPairLambda, unsafeInterfacesLambda) => ITypeLibConverterValueLambda.ConvertTypeLibToAssembly(typeLibLambda, asmFileNameLambda, flagsLambda, notifySinkLambda, publicKeyLambda, keyPairLambda, unsafeInterfacesLambda));
        }

    }
}