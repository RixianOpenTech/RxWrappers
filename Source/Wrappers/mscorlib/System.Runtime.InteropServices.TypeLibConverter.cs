using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __TypeLibConverter
    {
        
        public static IObservable<System.Reflection.Emit.AssemblyBuilder> ConvertTypeLibToAssembly(this IObservable<System.Runtime.InteropServices.TypeLibConverter> TypeLibConverterValue, IObservable<System.Object> typeLib, IObservable<System.String> asmFileName, IObservable<System.Int32> flags, IObservable<System.Runtime.InteropServices.ITypeLibImporterNotifySink> notifySink, IObservable<System.Byte[]> publicKey, IObservable<System.Reflection.StrongNameKeyPair> keyPair, IObservable<System.Boolean> unsafeInterfaces)
        {
            return Observable.Zip(TypeLibConverterValue, typeLib, asmFileName, flags, notifySink, publicKey, keyPair, unsafeInterfaces, (TypeLibConverterValueLambda, typeLibLambda, asmFileNameLambda, flagsLambda, notifySinkLambda, publicKeyLambda, keyPairLambda, unsafeInterfacesLambda) => TypeLibConverterValueLambda.ConvertTypeLibToAssembly(typeLibLambda, asmFileNameLambda, flagsLambda, notifySinkLambda, publicKeyLambda, keyPairLambda, unsafeInterfacesLambda));
        }


        public static IObservable<System.Reflection.Emit.AssemblyBuilder> ConvertTypeLibToAssembly(this IObservable<System.Runtime.InteropServices.TypeLibConverter> TypeLibConverterValue, IObservable<System.Object> typeLib, IObservable<System.String> asmFileName, IObservable<System.Runtime.InteropServices.TypeLibImporterFlags> flags, IObservable<System.Runtime.InteropServices.ITypeLibImporterNotifySink> notifySink, IObservable<System.Byte[]> publicKey, IObservable<System.Reflection.StrongNameKeyPair> keyPair, IObservable<System.String> asmNamespace, IObservable<System.Version> asmVersion)
        {
            return Observable.Zip(TypeLibConverterValue, typeLib, asmFileName, flags, notifySink, publicKey, keyPair, asmNamespace, asmVersion, (TypeLibConverterValueLambda, typeLibLambda, asmFileNameLambda, flagsLambda, notifySinkLambda, publicKeyLambda, keyPairLambda, asmNamespaceLambda, asmVersionLambda) => TypeLibConverterValueLambda.ConvertTypeLibToAssembly(typeLibLambda, asmFileNameLambda, flagsLambda, notifySinkLambda, publicKeyLambda, keyPairLambda, asmNamespaceLambda, asmVersionLambda));
        }


        public static IObservable<System.Object> ConvertAssemblyToTypeLib(this IObservable<System.Runtime.InteropServices.TypeLibConverter> TypeLibConverterValue, IObservable<System.Reflection.Assembly> assembly, IObservable<System.String> strTypeLibName, IObservable<System.Runtime.InteropServices.TypeLibExporterFlags> flags, IObservable<System.Runtime.InteropServices.ITypeLibExporterNotifySink> notifySink)
        {
            return Observable.Zip(TypeLibConverterValue, assembly, strTypeLibName, flags, notifySink, (TypeLibConverterValueLambda, assemblyLambda, strTypeLibNameLambda, flagsLambda, notifySinkLambda) => TypeLibConverterValueLambda.ConvertAssemblyToTypeLib(assemblyLambda, strTypeLibNameLambda, flagsLambda, notifySinkLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.String, System.String>> GetPrimaryInteropAssembly(this IObservable<System.Runtime.InteropServices.TypeLibConverter> TypeLibConverterValue, IObservable<System.Guid> g, IObservable<System.Int32> major, IObservable<System.Int32> minor, IObservable<System.Int32> lcid)
        {
            return Observable.Zip(TypeLibConverterValue, g, major, minor, lcid, (TypeLibConverterValueLambda, gLambda, majorLambda, minorLambda, lcidLambda) => {
System.String asmNameOutput = default(System.String);
System.String asmCodeBaseOutput = default(System.String);
var result = TypeLibConverterValueLambda.GetPrimaryInteropAssembly(gLambda, majorLambda, minorLambda, lcidLambda, out asmNameOutput, out asmCodeBaseOutput);
return Tuple.Create(result, asmNameOutput, asmCodeBaseOutput);
});
        }

    }
}