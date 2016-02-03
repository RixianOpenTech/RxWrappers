using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __RegistrationServices
    {
        
        public static IObservable<System.Boolean> RegisterAssembly(this IObservable<System.Runtime.InteropServices.RegistrationServices> RegistrationServicesValue, IObservable<System.Reflection.Assembly> assembly, IObservable<System.Runtime.InteropServices.AssemblyRegistrationFlags> flags)
        {
            return Observable.Zip(RegistrationServicesValue, assembly, flags, (RegistrationServicesValueLambda, assemblyLambda, flagsLambda) => RegistrationServicesValueLambda.RegisterAssembly(assemblyLambda, flagsLambda));
        }


        public static IObservable<System.Boolean> UnregisterAssembly(this IObservable<System.Runtime.InteropServices.RegistrationServices> RegistrationServicesValue, IObservable<System.Reflection.Assembly> assembly)
        {
            return Observable.Zip(RegistrationServicesValue, assembly, (RegistrationServicesValueLambda, assemblyLambda) => RegistrationServicesValueLambda.UnregisterAssembly(assemblyLambda));
        }


        public static IObservable<System.Type[]> GetRegistrableTypesInAssembly(this IObservable<System.Runtime.InteropServices.RegistrationServices> RegistrationServicesValue, IObservable<System.Reflection.Assembly> assembly)
        {
            return Observable.Zip(RegistrationServicesValue, assembly, (RegistrationServicesValueLambda, assemblyLambda) => RegistrationServicesValueLambda.GetRegistrableTypesInAssembly(assemblyLambda));
        }


        public static IObservable<System.String> GetProgIdForType(this IObservable<System.Runtime.InteropServices.RegistrationServices> RegistrationServicesValue, IObservable<System.Type> type)
        {
            return Observable.Zip(RegistrationServicesValue, type, (RegistrationServicesValueLambda, typeLambda) => RegistrationServicesValueLambda.GetProgIdForType(typeLambda));
        }


        public static IObservable<System.Guid> RegisterTypeForComClients(this IObservable<System.Runtime.InteropServices.RegistrationServices> RegistrationServicesValue, IObservable<System.Type> type, IObservable<System.Guid> g)
        {
            return Observable.Zip(RegistrationServicesValue, type, g, (RegistrationServicesValueLambda, typeLambda, gLambda) => {
RegistrationServicesValueLambda.RegisterTypeForComClients(typeLambda, ref gLambda);
return gLambda;
});
        }


        public static IObservable<System.Guid> GetManagedCategoryGuid(this IObservable<System.Runtime.InteropServices.RegistrationServices> RegistrationServicesValue)
        {
            return Observable.Select(RegistrationServicesValue, (RegistrationServicesValueLambda) => RegistrationServicesValueLambda.GetManagedCategoryGuid());
        }


        public static IObservable<System.Boolean> TypeRequiresRegistration(this IObservable<System.Runtime.InteropServices.RegistrationServices> RegistrationServicesValue, IObservable<System.Type> type)
        {
            return Observable.Zip(RegistrationServicesValue, type, (RegistrationServicesValueLambda, typeLambda) => RegistrationServicesValueLambda.TypeRequiresRegistration(typeLambda));
        }


        public static IObservable<System.Boolean> TypeRepresentsComType(this IObservable<System.Runtime.InteropServices.RegistrationServices> RegistrationServicesValue, IObservable<System.Type> type)
        {
            return Observable.Zip(RegistrationServicesValue, type, (RegistrationServicesValueLambda, typeLambda) => RegistrationServicesValueLambda.TypeRepresentsComType(typeLambda));
        }


        public static IObservable<System.Int32> RegisterTypeForComClients(this IObservable<System.Runtime.InteropServices.RegistrationServices> RegistrationServicesValue, IObservable<System.Type> type, IObservable<System.Runtime.InteropServices.RegistrationClassContext> classContext, IObservable<System.Runtime.InteropServices.RegistrationConnectionType> flags)
        {
            return Observable.Zip(RegistrationServicesValue, type, classContext, flags, (RegistrationServicesValueLambda, typeLambda, classContextLambda, flagsLambda) => RegistrationServicesValueLambda.RegisterTypeForComClients(typeLambda, classContextLambda, flagsLambda));
        }


        public static IObservable<System.Reactive.Unit> UnregisterTypeForComClients(this IObservable<System.Runtime.InteropServices.RegistrationServices> RegistrationServicesValue, IObservable<System.Int32> cookie)
        {
            return ObservableExt.ZipExecute(RegistrationServicesValue, cookie, (RegistrationServicesValueLambda, cookieLambda) => RegistrationServicesValueLambda.UnregisterTypeForComClients(cookieLambda));
        }

    }
}