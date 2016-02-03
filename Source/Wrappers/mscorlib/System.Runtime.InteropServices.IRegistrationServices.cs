using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __IRegistrationServices
    {
        public static IObservable<System.Boolean> RegisterAssembly(
            this IObservable<System.Runtime.InteropServices.IRegistrationServices> IRegistrationServicesValue,
            IObservable<System.Reflection.Assembly> assembly,
            IObservable<System.Runtime.InteropServices.AssemblyRegistrationFlags> flags)
        {
            return Observable.Zip(IRegistrationServicesValue, assembly, flags,
                (IRegistrationServicesValueLambda, assemblyLambda, flagsLambda) =>
                    IRegistrationServicesValueLambda.RegisterAssembly(assemblyLambda, flagsLambda));
        }


        public static IObservable<System.Boolean> UnregisterAssembly(
            this IObservable<System.Runtime.InteropServices.IRegistrationServices> IRegistrationServicesValue,
            IObservable<System.Reflection.Assembly> assembly)
        {
            return Observable.Zip(IRegistrationServicesValue, assembly,
                (IRegistrationServicesValueLambda, assemblyLambda) =>
                    IRegistrationServicesValueLambda.UnregisterAssembly(assemblyLambda));
        }


        public static IObservable<System.Type[]> GetRegistrableTypesInAssembly(
            this IObservable<System.Runtime.InteropServices.IRegistrationServices> IRegistrationServicesValue,
            IObservable<System.Reflection.Assembly> assembly)
        {
            return Observable.Zip(IRegistrationServicesValue, assembly,
                (IRegistrationServicesValueLambda, assemblyLambda) =>
                    IRegistrationServicesValueLambda.GetRegistrableTypesInAssembly(assemblyLambda));
        }


        public static IObservable<System.String> GetProgIdForType(
            this IObservable<System.Runtime.InteropServices.IRegistrationServices> IRegistrationServicesValue,
            IObservable<System.Type> type)
        {
            return Observable.Zip(IRegistrationServicesValue, type,
                (IRegistrationServicesValueLambda, typeLambda) =>
                    IRegistrationServicesValueLambda.GetProgIdForType(typeLambda));
        }


        public static IObservable<System.Guid> RegisterTypeForComClients(
            this IObservable<System.Runtime.InteropServices.IRegistrationServices> IRegistrationServicesValue,
            IObservable<System.Type> type, IObservable<System.Guid> g)
        {
            return Observable.Zip(IRegistrationServicesValue, type, g,
                (IRegistrationServicesValueLambda, typeLambda, gLambda) =>
                {
                    IRegistrationServicesValueLambda.RegisterTypeForComClients(typeLambda, ref gLambda);
                    return gLambda;
                });
        }


        public static IObservable<System.Guid> GetManagedCategoryGuid(
            this IObservable<System.Runtime.InteropServices.IRegistrationServices> IRegistrationServicesValue)
        {
            return Observable.Select(IRegistrationServicesValue,
                (IRegistrationServicesValueLambda) => IRegistrationServicesValueLambda.GetManagedCategoryGuid());
        }


        public static IObservable<System.Boolean> TypeRequiresRegistration(
            this IObservable<System.Runtime.InteropServices.IRegistrationServices> IRegistrationServicesValue,
            IObservable<System.Type> type)
        {
            return Observable.Zip(IRegistrationServicesValue, type,
                (IRegistrationServicesValueLambda, typeLambda) =>
                    IRegistrationServicesValueLambda.TypeRequiresRegistration(typeLambda));
        }


        public static IObservable<System.Boolean> TypeRepresentsComType(
            this IObservable<System.Runtime.InteropServices.IRegistrationServices> IRegistrationServicesValue,
            IObservable<System.Type> type)
        {
            return Observable.Zip(IRegistrationServicesValue, type,
                (IRegistrationServicesValueLambda, typeLambda) =>
                    IRegistrationServicesValueLambda.TypeRepresentsComType(typeLambda));
        }
    }
}