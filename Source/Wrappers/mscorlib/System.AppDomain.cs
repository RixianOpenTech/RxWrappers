using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __AppDomain
    {
        public static IObservable<System.Reflection.Emit.AssemblyBuilder> DefineDynamicAssembly(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.Reflection.AssemblyName> name,
            IObservable<System.Reflection.Emit.AssemblyBuilderAccess> access)
        {
            return Observable.Zip(AppDomainValue, name, access,
                (AppDomainValueLambda, nameLambda, accessLambda) =>
                    AppDomainValueLambda.DefineDynamicAssembly(nameLambda, accessLambda));
        }


        public static IObservable<System.Reflection.Emit.AssemblyBuilder> DefineDynamicAssembly(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.Reflection.AssemblyName> name,
            IObservable<System.Reflection.Emit.AssemblyBuilderAccess> access,
            IObservable<System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder>>
                assemblyAttributes)
        {
            return Observable.Zip(AppDomainValue, name, access, assemblyAttributes,
                (AppDomainValueLambda, nameLambda, accessLambda, assemblyAttributesLambda) =>
                    AppDomainValueLambda.DefineDynamicAssembly(nameLambda, accessLambda, assemblyAttributesLambda));
        }


        public static IObservable<System.Reflection.Emit.AssemblyBuilder> DefineDynamicAssembly(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.Reflection.AssemblyName> name,
            IObservable<System.Reflection.Emit.AssemblyBuilderAccess> access,
            IObservable<System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder>>
                assemblyAttributes, IObservable<System.Security.SecurityContextSource> securityContextSource)
        {
            return Observable.Zip(AppDomainValue, name, access, assemblyAttributes, securityContextSource,
                (AppDomainValueLambda, nameLambda, accessLambda, assemblyAttributesLambda, securityContextSourceLambda)
                    =>
                    AppDomainValueLambda.DefineDynamicAssembly(nameLambda, accessLambda, assemblyAttributesLambda,
                        securityContextSourceLambda));
        }


        public static IObservable<System.Reflection.Emit.AssemblyBuilder> DefineDynamicAssembly(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.Reflection.AssemblyName> name,
            IObservable<System.Reflection.Emit.AssemblyBuilderAccess> access, IObservable<System.String> dir)
        {
            return Observable.Zip(AppDomainValue, name, access, dir,
                (AppDomainValueLambda, nameLambda, accessLambda, dirLambda) =>
                    AppDomainValueLambda.DefineDynamicAssembly(nameLambda, accessLambda, dirLambda));
        }


        public static IObservable<System.Reflection.Emit.AssemblyBuilder> DefineDynamicAssembly(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.Reflection.AssemblyName> name,
            IObservable<System.Reflection.Emit.AssemblyBuilderAccess> access,
            IObservable<System.Security.Policy.Evidence> evidence)
        {
            return Observable.Zip(AppDomainValue, name, access, evidence,
                (AppDomainValueLambda, nameLambda, accessLambda, evidenceLambda) =>
                    AppDomainValueLambda.DefineDynamicAssembly(nameLambda, accessLambda, evidenceLambda));
        }


        public static IObservable<System.Reflection.Emit.AssemblyBuilder> DefineDynamicAssembly(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.Reflection.AssemblyName> name,
            IObservable<System.Reflection.Emit.AssemblyBuilderAccess> access,
            IObservable<System.Security.PermissionSet> requiredPermissions,
            IObservable<System.Security.PermissionSet> optionalPermissions,
            IObservable<System.Security.PermissionSet> refusedPermissions)
        {
            return Observable.Zip(AppDomainValue, name, access, requiredPermissions, optionalPermissions,
                refusedPermissions,
                (AppDomainValueLambda, nameLambda, accessLambda, requiredPermissionsLambda, optionalPermissionsLambda,
                    refusedPermissionsLambda) =>
                    AppDomainValueLambda.DefineDynamicAssembly(nameLambda, accessLambda, requiredPermissionsLambda,
                        optionalPermissionsLambda, refusedPermissionsLambda));
        }


        public static IObservable<System.Reflection.Emit.AssemblyBuilder> DefineDynamicAssembly(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.Reflection.AssemblyName> name,
            IObservable<System.Reflection.Emit.AssemblyBuilderAccess> access, IObservable<System.String> dir,
            IObservable<System.Security.Policy.Evidence> evidence)
        {
            return Observable.Zip(AppDomainValue, name, access, dir, evidence,
                (AppDomainValueLambda, nameLambda, accessLambda, dirLambda, evidenceLambda) =>
                    AppDomainValueLambda.DefineDynamicAssembly(nameLambda, accessLambda, dirLambda, evidenceLambda));
        }


        public static IObservable<System.Reflection.Emit.AssemblyBuilder> DefineDynamicAssembly(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.Reflection.AssemblyName> name,
            IObservable<System.Reflection.Emit.AssemblyBuilderAccess> access, IObservable<System.String> dir,
            IObservable<System.Security.PermissionSet> requiredPermissions,
            IObservable<System.Security.PermissionSet> optionalPermissions,
            IObservable<System.Security.PermissionSet> refusedPermissions)
        {
            return Observable.Zip(AppDomainValue, name, access, dir, requiredPermissions, optionalPermissions,
                refusedPermissions,
                (AppDomainValueLambda, nameLambda, accessLambda, dirLambda, requiredPermissionsLambda,
                    optionalPermissionsLambda, refusedPermissionsLambda) =>
                    AppDomainValueLambda.DefineDynamicAssembly(nameLambda, accessLambda, dirLambda,
                        requiredPermissionsLambda, optionalPermissionsLambda, refusedPermissionsLambda));
        }


        public static IObservable<System.Reflection.Emit.AssemblyBuilder> DefineDynamicAssembly(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.Reflection.AssemblyName> name,
            IObservable<System.Reflection.Emit.AssemblyBuilderAccess> access,
            IObservable<System.Security.Policy.Evidence> evidence,
            IObservable<System.Security.PermissionSet> requiredPermissions,
            IObservable<System.Security.PermissionSet> optionalPermissions,
            IObservable<System.Security.PermissionSet> refusedPermissions)
        {
            return Observable.Zip(AppDomainValue, name, access, evidence, requiredPermissions, optionalPermissions,
                refusedPermissions,
                (AppDomainValueLambda, nameLambda, accessLambda, evidenceLambda, requiredPermissionsLambda,
                    optionalPermissionsLambda, refusedPermissionsLambda) =>
                    AppDomainValueLambda.DefineDynamicAssembly(nameLambda, accessLambda, evidenceLambda,
                        requiredPermissionsLambda, optionalPermissionsLambda, refusedPermissionsLambda));
        }


        public static IObservable<System.Reflection.Emit.AssemblyBuilder> DefineDynamicAssembly(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.Reflection.AssemblyName> name,
            IObservable<System.Reflection.Emit.AssemblyBuilderAccess> access, IObservable<System.String> dir,
            IObservable<System.Security.Policy.Evidence> evidence,
            IObservable<System.Security.PermissionSet> requiredPermissions,
            IObservable<System.Security.PermissionSet> optionalPermissions,
            IObservable<System.Security.PermissionSet> refusedPermissions)
        {
            return Observable.Zip(AppDomainValue, name, access, dir, evidence, requiredPermissions, optionalPermissions,
                refusedPermissions,
                (AppDomainValueLambda, nameLambda, accessLambda, dirLambda, evidenceLambda, requiredPermissionsLambda,
                    optionalPermissionsLambda, refusedPermissionsLambda) =>
                    AppDomainValueLambda.DefineDynamicAssembly(nameLambda, accessLambda, dirLambda, evidenceLambda,
                        requiredPermissionsLambda, optionalPermissionsLambda, refusedPermissionsLambda));
        }


        public static IObservable<System.Reflection.Emit.AssemblyBuilder> DefineDynamicAssembly(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.Reflection.AssemblyName> name,
            IObservable<System.Reflection.Emit.AssemblyBuilderAccess> access, IObservable<System.String> dir,
            IObservable<System.Security.Policy.Evidence> evidence,
            IObservable<System.Security.PermissionSet> requiredPermissions,
            IObservable<System.Security.PermissionSet> optionalPermissions,
            IObservable<System.Security.PermissionSet> refusedPermissions, IObservable<System.Boolean> isSynchronized)
        {
            return Observable.Zip(AppDomainValue, name, access, dir, evidence, requiredPermissions, optionalPermissions,
                refusedPermissions, isSynchronized,
                (AppDomainValueLambda, nameLambda, accessLambda, dirLambda, evidenceLambda, requiredPermissionsLambda,
                    optionalPermissionsLambda, refusedPermissionsLambda, isSynchronizedLambda) =>
                    AppDomainValueLambda.DefineDynamicAssembly(nameLambda, accessLambda, dirLambda, evidenceLambda,
                        requiredPermissionsLambda, optionalPermissionsLambda, refusedPermissionsLambda,
                        isSynchronizedLambda));
        }


        public static IObservable<System.Reflection.Emit.AssemblyBuilder> DefineDynamicAssembly(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.Reflection.AssemblyName> name,
            IObservable<System.Reflection.Emit.AssemblyBuilderAccess> access, IObservable<System.String> dir,
            IObservable<System.Security.Policy.Evidence> evidence,
            IObservable<System.Security.PermissionSet> requiredPermissions,
            IObservable<System.Security.PermissionSet> optionalPermissions,
            IObservable<System.Security.PermissionSet> refusedPermissions, IObservable<System.Boolean> isSynchronized,
            IObservable<System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder>>
                assemblyAttributes)
        {
            return Observable.Zip(AppDomainValue, name, access, dir, evidence, requiredPermissions, optionalPermissions,
                refusedPermissions, isSynchronized, assemblyAttributes,
                (AppDomainValueLambda, nameLambda, accessLambda, dirLambda, evidenceLambda, requiredPermissionsLambda,
                    optionalPermissionsLambda, refusedPermissionsLambda, isSynchronizedLambda, assemblyAttributesLambda)
                    =>
                    AppDomainValueLambda.DefineDynamicAssembly(nameLambda, accessLambda, dirLambda, evidenceLambda,
                        requiredPermissionsLambda, optionalPermissionsLambda, refusedPermissionsLambda,
                        isSynchronizedLambda, assemblyAttributesLambda));
        }


        public static IObservable<System.Reflection.Emit.AssemblyBuilder> DefineDynamicAssembly(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.Reflection.AssemblyName> name,
            IObservable<System.Reflection.Emit.AssemblyBuilderAccess> access, IObservable<System.String> dir,
            IObservable<System.Boolean> isSynchronized,
            IObservable<System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder>>
                assemblyAttributes)
        {
            return Observable.Zip(AppDomainValue, name, access, dir, isSynchronized, assemblyAttributes,
                (AppDomainValueLambda, nameLambda, accessLambda, dirLambda, isSynchronizedLambda,
                    assemblyAttributesLambda) =>
                    AppDomainValueLambda.DefineDynamicAssembly(nameLambda, accessLambda, dirLambda, isSynchronizedLambda,
                        assemblyAttributesLambda));
        }


        public static IObservable<System.String> ApplyPolicy(this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.String> assemblyName)
        {
            return Observable.Zip(AppDomainValue, assemblyName,
                (AppDomainValueLambda, assemblyNameLambda) => AppDomainValueLambda.ApplyPolicy(assemblyNameLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstance(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.String> assemblyName,
            IObservable<System.String> typeName)
        {
            return Observable.Zip(AppDomainValue, assemblyName, typeName,
                (AppDomainValueLambda, assemblyNameLambda, typeNameLambda) =>
                    AppDomainValueLambda.CreateInstance(assemblyNameLambda, typeNameLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstanceFrom(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.String> assemblyFile,
            IObservable<System.String> typeName)
        {
            return Observable.Zip(AppDomainValue, assemblyFile, typeName,
                (AppDomainValueLambda, assemblyFileLambda, typeNameLambda) =>
                    AppDomainValueLambda.CreateInstanceFrom(assemblyFileLambda, typeNameLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateComInstanceFrom(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.String> assemblyName,
            IObservable<System.String> typeName)
        {
            return Observable.Zip(AppDomainValue, assemblyName, typeName,
                (AppDomainValueLambda, assemblyNameLambda, typeNameLambda) =>
                    AppDomainValueLambda.CreateComInstanceFrom(assemblyNameLambda, typeNameLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateComInstanceFrom(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.String> assemblyFile,
            IObservable<System.String> typeName, IObservable<System.Byte[]> hashValue,
            IObservable<System.Configuration.Assemblies.AssemblyHashAlgorithm> hashAlgorithm)
        {
            return Observable.Zip(AppDomainValue, assemblyFile, typeName, hashValue, hashAlgorithm,
                (AppDomainValueLambda, assemblyFileLambda, typeNameLambda, hashValueLambda, hashAlgorithmLambda) =>
                    AppDomainValueLambda.CreateComInstanceFrom(assemblyFileLambda, typeNameLambda, hashValueLambda,
                        hashAlgorithmLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstance(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.String> assemblyName,
            IObservable<System.String> typeName, IObservable<System.Object[]> activationAttributes)
        {
            return Observable.Zip(AppDomainValue, assemblyName, typeName, activationAttributes,
                (AppDomainValueLambda, assemblyNameLambda, typeNameLambda, activationAttributesLambda) =>
                    AppDomainValueLambda.CreateInstance(assemblyNameLambda, typeNameLambda, activationAttributesLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstanceFrom(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.String> assemblyFile,
            IObservable<System.String> typeName, IObservable<System.Object[]> activationAttributes)
        {
            return Observable.Zip(AppDomainValue, assemblyFile, typeName, activationAttributes,
                (AppDomainValueLambda, assemblyFileLambda, typeNameLambda, activationAttributesLambda) =>
                    AppDomainValueLambda.CreateInstanceFrom(assemblyFileLambda, typeNameLambda,
                        activationAttributesLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstance(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.String> assemblyName,
            IObservable<System.String> typeName, IObservable<System.Boolean> ignoreCase,
            IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder,
            IObservable<System.Object[]> args, IObservable<System.Globalization.CultureInfo> culture,
            IObservable<System.Object[]> activationAttributes,
            IObservable<System.Security.Policy.Evidence> securityAttributes)
        {
            return Observable.Zip(AppDomainValue, assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture,
                activationAttributes, securityAttributes,
                (AppDomainValueLambda, assemblyNameLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda,
                    binderLambda, argsLambda, cultureLambda, activationAttributesLambda, securityAttributesLambda) =>
                    AppDomainValueLambda.CreateInstance(assemblyNameLambda, typeNameLambda, ignoreCaseLambda,
                        bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda,
                        securityAttributesLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstance(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.String> assemblyName,
            IObservable<System.String> typeName, IObservable<System.Boolean> ignoreCase,
            IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder,
            IObservable<System.Object[]> args, IObservable<System.Globalization.CultureInfo> culture,
            IObservable<System.Object[]> activationAttributes)
        {
            return Observable.Zip(AppDomainValue, assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture,
                activationAttributes,
                (AppDomainValueLambda, assemblyNameLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda,
                    binderLambda, argsLambda, cultureLambda, activationAttributesLambda) =>
                    AppDomainValueLambda.CreateInstance(assemblyNameLambda, typeNameLambda, ignoreCaseLambda,
                        bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstanceFrom(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.String> assemblyFile,
            IObservable<System.String> typeName, IObservable<System.Boolean> ignoreCase,
            IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder,
            IObservable<System.Object[]> args, IObservable<System.Globalization.CultureInfo> culture,
            IObservable<System.Object[]> activationAttributes,
            IObservable<System.Security.Policy.Evidence> securityAttributes)
        {
            return Observable.Zip(AppDomainValue, assemblyFile, typeName, ignoreCase, bindingAttr, binder, args, culture,
                activationAttributes, securityAttributes,
                (AppDomainValueLambda, assemblyFileLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda,
                    binderLambda, argsLambda, cultureLambda, activationAttributesLambda, securityAttributesLambda) =>
                    AppDomainValueLambda.CreateInstanceFrom(assemblyFileLambda, typeNameLambda, ignoreCaseLambda,
                        bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda,
                        securityAttributesLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstanceFrom(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.String> assemblyFile,
            IObservable<System.String> typeName, IObservable<System.Boolean> ignoreCase,
            IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder,
            IObservable<System.Object[]> args, IObservable<System.Globalization.CultureInfo> culture,
            IObservable<System.Object[]> activationAttributes)
        {
            return Observable.Zip(AppDomainValue, assemblyFile, typeName, ignoreCase, bindingAttr, binder, args, culture,
                activationAttributes,
                (AppDomainValueLambda, assemblyFileLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda,
                    binderLambda, argsLambda, cultureLambda, activationAttributesLambda) =>
                    AppDomainValueLambda.CreateInstanceFrom(assemblyFileLambda, typeNameLambda, ignoreCaseLambda,
                        bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda));
        }


        public static IObservable<System.Reflection.Assembly> Load(this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.Reflection.AssemblyName> assemblyRef)
        {
            return Observable.Zip(AppDomainValue, assemblyRef,
                (AppDomainValueLambda, assemblyRefLambda) => AppDomainValueLambda.Load(assemblyRefLambda));
        }


        public static IObservable<System.Reflection.Assembly> Load(this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.String> assemblyString)
        {
            return Observable.Zip(AppDomainValue, assemblyString,
                (AppDomainValueLambda, assemblyStringLambda) => AppDomainValueLambda.Load(assemblyStringLambda));
        }


        public static IObservable<System.Reflection.Assembly> Load(this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.Byte[]> rawAssembly)
        {
            return Observable.Zip(AppDomainValue, rawAssembly,
                (AppDomainValueLambda, rawAssemblyLambda) => AppDomainValueLambda.Load(rawAssemblyLambda));
        }


        public static IObservable<System.Reflection.Assembly> Load(this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.Byte[]> rawAssembly, IObservable<System.Byte[]> rawSymbolStore)
        {
            return Observable.Zip(AppDomainValue, rawAssembly, rawSymbolStore,
                (AppDomainValueLambda, rawAssemblyLambda, rawSymbolStoreLambda) =>
                    AppDomainValueLambda.Load(rawAssemblyLambda, rawSymbolStoreLambda));
        }


        public static IObservable<System.Reflection.Assembly> Load(this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.Byte[]> rawAssembly, IObservable<System.Byte[]> rawSymbolStore,
            IObservable<System.Security.Policy.Evidence> securityEvidence)
        {
            return Observable.Zip(AppDomainValue, rawAssembly, rawSymbolStore, securityEvidence,
                (AppDomainValueLambda, rawAssemblyLambda, rawSymbolStoreLambda, securityEvidenceLambda) =>
                    AppDomainValueLambda.Load(rawAssemblyLambda, rawSymbolStoreLambda, securityEvidenceLambda));
        }


        public static IObservable<System.Reflection.Assembly> Load(this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.Reflection.AssemblyName> assemblyRef,
            IObservable<System.Security.Policy.Evidence> assemblySecurity)
        {
            return Observable.Zip(AppDomainValue, assemblyRef, assemblySecurity,
                (AppDomainValueLambda, assemblyRefLambda, assemblySecurityLambda) =>
                    AppDomainValueLambda.Load(assemblyRefLambda, assemblySecurityLambda));
        }


        public static IObservable<System.Reflection.Assembly> Load(this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.String> assemblyString, IObservable<System.Security.Policy.Evidence> assemblySecurity)
        {
            return Observable.Zip(AppDomainValue, assemblyString, assemblySecurity,
                (AppDomainValueLambda, assemblyStringLambda, assemblySecurityLambda) =>
                    AppDomainValueLambda.Load(assemblyStringLambda, assemblySecurityLambda));
        }


        public static IObservable<System.Int32> ExecuteAssembly(this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.String> assemblyFile)
        {
            return Observable.Zip(AppDomainValue, assemblyFile,
                (AppDomainValueLambda, assemblyFileLambda) => AppDomainValueLambda.ExecuteAssembly(assemblyFileLambda));
        }


        public static IObservable<System.Int32> ExecuteAssembly(this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.String> assemblyFile, IObservable<System.Security.Policy.Evidence> assemblySecurity)
        {
            return Observable.Zip(AppDomainValue, assemblyFile, assemblySecurity,
                (AppDomainValueLambda, assemblyFileLambda, assemblySecurityLambda) =>
                    AppDomainValueLambda.ExecuteAssembly(assemblyFileLambda, assemblySecurityLambda));
        }


        public static IObservable<System.Int32> ExecuteAssembly(this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.String> assemblyFile, IObservable<System.Security.Policy.Evidence> assemblySecurity,
            IObservable<System.String[]> args)
        {
            return Observable.Zip(AppDomainValue, assemblyFile, assemblySecurity, args,
                (AppDomainValueLambda, assemblyFileLambda, assemblySecurityLambda, argsLambda) =>
                    AppDomainValueLambda.ExecuteAssembly(assemblyFileLambda, assemblySecurityLambda, argsLambda));
        }


        public static IObservable<System.Int32> ExecuteAssembly(this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.String> assemblyFile, IObservable<System.String[]> args)
        {
            return Observable.Zip(AppDomainValue, assemblyFile, args,
                (AppDomainValueLambda, assemblyFileLambda, argsLambda) =>
                    AppDomainValueLambda.ExecuteAssembly(assemblyFileLambda, argsLambda));
        }


        public static IObservable<System.Int32> ExecuteAssembly(this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.String> assemblyFile, IObservable<System.Security.Policy.Evidence> assemblySecurity,
            IObservable<System.String[]> args, IObservable<System.Byte[]> hashValue,
            IObservable<System.Configuration.Assemblies.AssemblyHashAlgorithm> hashAlgorithm)
        {
            return Observable.Zip(AppDomainValue, assemblyFile, assemblySecurity, args, hashValue, hashAlgorithm,
                (AppDomainValueLambda, assemblyFileLambda, assemblySecurityLambda, argsLambda, hashValueLambda,
                    hashAlgorithmLambda) =>
                    AppDomainValueLambda.ExecuteAssembly(assemblyFileLambda, assemblySecurityLambda, argsLambda,
                        hashValueLambda, hashAlgorithmLambda));
        }


        public static IObservable<System.Int32> ExecuteAssembly(this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.String> assemblyFile, IObservable<System.String[]> args,
            IObservable<System.Byte[]> hashValue,
            IObservable<System.Configuration.Assemblies.AssemblyHashAlgorithm> hashAlgorithm)
        {
            return Observable.Zip(AppDomainValue, assemblyFile, args, hashValue, hashAlgorithm,
                (AppDomainValueLambda, assemblyFileLambda, argsLambda, hashValueLambda, hashAlgorithmLambda) =>
                    AppDomainValueLambda.ExecuteAssembly(assemblyFileLambda, argsLambda, hashValueLambda,
                        hashAlgorithmLambda));
        }


        public static IObservable<System.Int32> ExecuteAssemblyByName(this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.String> assemblyName)
        {
            return Observable.Zip(AppDomainValue, assemblyName,
                (AppDomainValueLambda, assemblyNameLambda) =>
                    AppDomainValueLambda.ExecuteAssemblyByName(assemblyNameLambda));
        }


        public static IObservable<System.Int32> ExecuteAssemblyByName(this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.String> assemblyName, IObservable<System.Security.Policy.Evidence> assemblySecurity)
        {
            return Observable.Zip(AppDomainValue, assemblyName, assemblySecurity,
                (AppDomainValueLambda, assemblyNameLambda, assemblySecurityLambda) =>
                    AppDomainValueLambda.ExecuteAssemblyByName(assemblyNameLambda, assemblySecurityLambda));
        }


        public static IObservable<System.Int32> ExecuteAssemblyByName(this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.String> assemblyName, IObservable<System.Security.Policy.Evidence> assemblySecurity,
            IObservable<System.String[]> args)
        {
            return Observable.Zip(AppDomainValue, assemblyName, assemblySecurity, args,
                (AppDomainValueLambda, assemblyNameLambda, assemblySecurityLambda, argsLambda) =>
                    AppDomainValueLambda.ExecuteAssemblyByName(assemblyNameLambda, assemblySecurityLambda, argsLambda));
        }


        public static IObservable<System.Int32> ExecuteAssemblyByName(this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.String> assemblyName, IObservable<System.String[]> args)
        {
            return Observable.Zip(AppDomainValue, assemblyName, args,
                (AppDomainValueLambda, assemblyNameLambda, argsLambda) =>
                    AppDomainValueLambda.ExecuteAssemblyByName(assemblyNameLambda, argsLambda));
        }


        public static IObservable<System.Int32> ExecuteAssemblyByName(this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.Reflection.AssemblyName> assemblyName,
            IObservable<System.Security.Policy.Evidence> assemblySecurity, IObservable<System.String[]> args)
        {
            return Observable.Zip(AppDomainValue, assemblyName, assemblySecurity, args,
                (AppDomainValueLambda, assemblyNameLambda, assemblySecurityLambda, argsLambda) =>
                    AppDomainValueLambda.ExecuteAssemblyByName(assemblyNameLambda, assemblySecurityLambda, argsLambda));
        }


        public static IObservable<System.Int32> ExecuteAssemblyByName(this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.Reflection.AssemblyName> assemblyName, IObservable<System.String[]> args)
        {
            return Observable.Zip(AppDomainValue, assemblyName, args,
                (AppDomainValueLambda, assemblyNameLambda, argsLambda) =>
                    AppDomainValueLambda.ExecuteAssemblyByName(assemblyNameLambda, argsLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.AppDomain> AppDomainValue)
        {
            return Observable.Select(AppDomainValue, (AppDomainValueLambda) => AppDomainValueLambda.ToString());
        }


        public static IObservable<System.Reflection.Assembly[]> GetAssemblies(
            this IObservable<System.AppDomain> AppDomainValue)
        {
            return Observable.Select(AppDomainValue, (AppDomainValueLambda) => AppDomainValueLambda.GetAssemblies());
        }


        public static IObservable<System.Reflection.Assembly[]> ReflectionOnlyGetAssemblies(
            this IObservable<System.AppDomain> AppDomainValue)
        {
            return Observable.Select(AppDomainValue,
                (AppDomainValueLambda) => AppDomainValueLambda.ReflectionOnlyGetAssemblies());
        }


        public static IObservable<System.Boolean> IsFinalizingForUnload(
            this IObservable<System.AppDomain> AppDomainValue)
        {
            return Observable.Select(AppDomainValue,
                (AppDomainValueLambda) => AppDomainValueLambda.IsFinalizingForUnload());
        }


        public static IObservable<System.Reactive.Unit> AppendPrivatePath(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.String> path)
        {
            return ObservableExt.ZipExecute(AppDomainValue, path,
                (AppDomainValueLambda, pathLambda) => AppDomainValueLambda.AppendPrivatePath(pathLambda));
        }


        public static IObservable<System.Reactive.Unit> ClearPrivatePath(
            this IObservable<System.AppDomain> AppDomainValue)
        {
            return
                Observable.Do(AppDomainValue, (AppDomainValueLambda) => AppDomainValueLambda.ClearPrivatePath())
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> ClearShadowCopyPath(
            this IObservable<System.AppDomain> AppDomainValue)
        {
            return
                Observable.Do(AppDomainValue, (AppDomainValueLambda) => AppDomainValueLambda.ClearShadowCopyPath())
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> SetCachePath(this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.String> path)
        {
            return ObservableExt.ZipExecute(AppDomainValue, path,
                (AppDomainValueLambda, pathLambda) => AppDomainValueLambda.SetCachePath(pathLambda));
        }


        public static IObservable<System.Reactive.Unit> SetData(this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.String> name, IObservable<System.Object> data)
        {
            return ObservableExt.ZipExecute(AppDomainValue, name, data,
                (AppDomainValueLambda, nameLambda, dataLambda) => AppDomainValueLambda.SetData(nameLambda, dataLambda));
        }


        public static IObservable<System.Reactive.Unit> SetData(this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.String> name, IObservable<System.Object> data,
            IObservable<System.Security.IPermission> permission)
        {
            return ObservableExt.ZipExecute(AppDomainValue, name, data, permission,
                (AppDomainValueLambda, nameLambda, dataLambda, permissionLambda) =>
                    AppDomainValueLambda.SetData(nameLambda, dataLambda, permissionLambda));
        }


        public static IObservable<System.Object> GetData(this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.String> name)
        {
            return Observable.Zip(AppDomainValue, name,
                (AppDomainValueLambda, nameLambda) => AppDomainValueLambda.GetData(nameLambda));
        }


        public static IObservable<System.Nullable<System.Boolean>> IsCompatibilitySwitchSet(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.String> value)
        {
            return Observable.Zip(AppDomainValue, value,
                (AppDomainValueLambda, valueLambda) => AppDomainValueLambda.IsCompatibilitySwitchSet(valueLambda));
        }


        public static IObservable<System.Int32> GetCurrentThreadId()
        {
            return ObservableExt.Factory(() => System.AppDomain.GetCurrentThreadId());
        }


        public static IObservable<System.Reactive.Unit> Unload(IObservable<System.AppDomain> domain)
        {
            return Observable.Do(domain, (domainLambda) => System.AppDomain.Unload(domainLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> SetAppDomainPolicy(
            this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.Security.Policy.PolicyLevel> domainPolicy)
        {
            return ObservableExt.ZipExecute(AppDomainValue, domainPolicy,
                (AppDomainValueLambda, domainPolicyLambda) =>
                    AppDomainValueLambda.SetAppDomainPolicy(domainPolicyLambda));
        }


        public static IObservable<System.Reactive.Unit> SetThreadPrincipal(
            this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.Security.Principal.IPrincipal> principal)
        {
            return ObservableExt.ZipExecute(AppDomainValue, principal,
                (AppDomainValueLambda, principalLambda) => AppDomainValueLambda.SetThreadPrincipal(principalLambda));
        }


        public static IObservable<System.Reactive.Unit> SetPrincipalPolicy(
            this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.Security.Principal.PrincipalPolicy> policy)
        {
            return ObservableExt.ZipExecute(AppDomainValue, policy,
                (AppDomainValueLambda, policyLambda) => AppDomainValueLambda.SetPrincipalPolicy(policyLambda));
        }


        public static IObservable<System.Object> InitializeLifetimeService(
            this IObservable<System.AppDomain> AppDomainValue)
        {
            return Observable.Select(AppDomainValue,
                (AppDomainValueLambda) => AppDomainValueLambda.InitializeLifetimeService());
        }


        public static IObservable<System.Reactive.Unit> DoCallBack(this IObservable<System.AppDomain> AppDomainValue,
            IObservable<System.CrossAppDomainDelegate> callBackDelegate)
        {
            return ObservableExt.ZipExecute(AppDomainValue, callBackDelegate,
                (AppDomainValueLambda, callBackDelegateLambda) =>
                    AppDomainValueLambda.DoCallBack(callBackDelegateLambda));
        }


        public static IObservable<System.AppDomain> CreateDomain(IObservable<System.String> friendlyName,
            IObservable<System.Security.Policy.Evidence> securityInfo)
        {
            return Observable.Zip(friendlyName, securityInfo,
                (friendlyNameLambda, securityInfoLambda) =>
                    System.AppDomain.CreateDomain(friendlyNameLambda, securityInfoLambda));
        }


        public static IObservable<System.AppDomain> CreateDomain(IObservable<System.String> friendlyName,
            IObservable<System.Security.Policy.Evidence> securityInfo, IObservable<System.String> appBasePath,
            IObservable<System.String> appRelativeSearchPath, IObservable<System.Boolean> shadowCopyFiles)
        {
            return Observable.Zip(friendlyName, securityInfo, appBasePath, appRelativeSearchPath, shadowCopyFiles,
                (friendlyNameLambda, securityInfoLambda, appBasePathLambda, appRelativeSearchPathLambda,
                    shadowCopyFilesLambda) =>
                    System.AppDomain.CreateDomain(friendlyNameLambda, securityInfoLambda, appBasePathLambda,
                        appRelativeSearchPathLambda, shadowCopyFilesLambda));
        }


        public static IObservable<System.AppDomain> CreateDomain(IObservable<System.String> friendlyName)
        {
            return Observable.Select(friendlyName,
                (friendlyNameLambda) => System.AppDomain.CreateDomain(friendlyNameLambda));
        }


        public static IObservable<System.AppDomain> CreateDomain(IObservable<System.String> friendlyName,
            IObservable<System.Security.Policy.Evidence> securityInfo, IObservable<System.AppDomainSetup> info)
        {
            return Observable.Zip(friendlyName, securityInfo, info,
                (friendlyNameLambda, securityInfoLambda, infoLambda) =>
                    System.AppDomain.CreateDomain(friendlyNameLambda, securityInfoLambda, infoLambda));
        }


        public static IObservable<System.AppDomain> CreateDomain(IObservable<System.String> friendlyName,
            IObservable<System.Security.Policy.Evidence> securityInfo, IObservable<System.AppDomainSetup> info,
            IObservable<System.Security.PermissionSet> grantSet,
            IObservable<System.Security.Policy.StrongName[]> fullTrustAssemblies)
        {
            return Observable.Zip(friendlyName, securityInfo, info, grantSet, fullTrustAssemblies,
                (friendlyNameLambda, securityInfoLambda, infoLambda, grantSetLambda, fullTrustAssembliesLambda) =>
                    System.AppDomain.CreateDomain(friendlyNameLambda, securityInfoLambda, infoLambda, grantSetLambda,
                        fullTrustAssembliesLambda));
        }


        public static IObservable<System.AppDomain> CreateDomain(IObservable<System.String> friendlyName,
            IObservable<System.Security.Policy.Evidence> securityInfo, IObservable<System.String> appBasePath,
            IObservable<System.String> appRelativeSearchPath, IObservable<System.Boolean> shadowCopyFiles,
            IObservable<System.AppDomainInitializer> adInit, IObservable<System.String[]> adInitArgs)
        {
            return Observable.Zip(friendlyName, securityInfo, appBasePath, appRelativeSearchPath, shadowCopyFiles,
                adInit, adInitArgs,
                (friendlyNameLambda, securityInfoLambda, appBasePathLambda, appRelativeSearchPathLambda,
                    shadowCopyFilesLambda, adInitLambda, adInitArgsLambda) =>
                    System.AppDomain.CreateDomain(friendlyNameLambda, securityInfoLambda, appBasePathLambda,
                        appRelativeSearchPathLambda, shadowCopyFilesLambda, adInitLambda, adInitArgsLambda));
        }


        public static IObservable<System.Reactive.Unit> SetShadowCopyPath(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.String> path)
        {
            return ObservableExt.ZipExecute(AppDomainValue, path,
                (AppDomainValueLambda, pathLambda) => AppDomainValueLambda.SetShadowCopyPath(pathLambda));
        }


        public static IObservable<System.Reactive.Unit> SetShadowCopyFiles(
            this IObservable<System.AppDomain> AppDomainValue)
        {
            return
                Observable.Do(AppDomainValue, (AppDomainValueLambda) => AppDomainValueLambda.SetShadowCopyFiles())
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> SetDynamicBase(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.String> path)
        {
            return ObservableExt.ZipExecute(AppDomainValue, path,
                (AppDomainValueLambda, pathLambda) => AppDomainValueLambda.SetDynamicBase(pathLambda));
        }


        public static IObservable<System.Object> CreateInstanceAndUnwrap(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.String> assemblyName,
            IObservable<System.String> typeName)
        {
            return Observable.Zip(AppDomainValue, assemblyName, typeName,
                (AppDomainValueLambda, assemblyNameLambda, typeNameLambda) =>
                    AppDomainValueLambda.CreateInstanceAndUnwrap(assemblyNameLambda, typeNameLambda));
        }


        public static IObservable<System.Object> CreateInstanceAndUnwrap(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.String> assemblyName,
            IObservable<System.String> typeName, IObservable<System.Object[]> activationAttributes)
        {
            return Observable.Zip(AppDomainValue, assemblyName, typeName, activationAttributes,
                (AppDomainValueLambda, assemblyNameLambda, typeNameLambda, activationAttributesLambda) =>
                    AppDomainValueLambda.CreateInstanceAndUnwrap(assemblyNameLambda, typeNameLambda,
                        activationAttributesLambda));
        }


        public static IObservable<System.Object> CreateInstanceAndUnwrap(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.String> assemblyName,
            IObservable<System.String> typeName, IObservable<System.Boolean> ignoreCase,
            IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder,
            IObservable<System.Object[]> args, IObservable<System.Globalization.CultureInfo> culture,
            IObservable<System.Object[]> activationAttributes,
            IObservable<System.Security.Policy.Evidence> securityAttributes)
        {
            return Observable.Zip(AppDomainValue, assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture,
                activationAttributes, securityAttributes,
                (AppDomainValueLambda, assemblyNameLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda,
                    binderLambda, argsLambda, cultureLambda, activationAttributesLambda, securityAttributesLambda) =>
                    AppDomainValueLambda.CreateInstanceAndUnwrap(assemblyNameLambda, typeNameLambda, ignoreCaseLambda,
                        bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda,
                        securityAttributesLambda));
        }


        public static IObservable<System.Object> CreateInstanceAndUnwrap(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.String> assemblyName,
            IObservable<System.String> typeName, IObservable<System.Boolean> ignoreCase,
            IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder,
            IObservable<System.Object[]> args, IObservable<System.Globalization.CultureInfo> culture,
            IObservable<System.Object[]> activationAttributes)
        {
            return Observable.Zip(AppDomainValue, assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture,
                activationAttributes,
                (AppDomainValueLambda, assemblyNameLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda,
                    binderLambda, argsLambda, cultureLambda, activationAttributesLambda) =>
                    AppDomainValueLambda.CreateInstanceAndUnwrap(assemblyNameLambda, typeNameLambda, ignoreCaseLambda,
                        bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda));
        }


        public static IObservable<System.Object> CreateInstanceFromAndUnwrap(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.String> assemblyName,
            IObservable<System.String> typeName)
        {
            return Observable.Zip(AppDomainValue, assemblyName, typeName,
                (AppDomainValueLambda, assemblyNameLambda, typeNameLambda) =>
                    AppDomainValueLambda.CreateInstanceFromAndUnwrap(assemblyNameLambda, typeNameLambda));
        }


        public static IObservable<System.Object> CreateInstanceFromAndUnwrap(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.String> assemblyName,
            IObservable<System.String> typeName, IObservable<System.Object[]> activationAttributes)
        {
            return Observable.Zip(AppDomainValue, assemblyName, typeName, activationAttributes,
                (AppDomainValueLambda, assemblyNameLambda, typeNameLambda, activationAttributesLambda) =>
                    AppDomainValueLambda.CreateInstanceFromAndUnwrap(assemblyNameLambda, typeNameLambda,
                        activationAttributesLambda));
        }


        public static IObservable<System.Object> CreateInstanceFromAndUnwrap(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.String> assemblyName,
            IObservable<System.String> typeName, IObservable<System.Boolean> ignoreCase,
            IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder,
            IObservable<System.Object[]> args, IObservable<System.Globalization.CultureInfo> culture,
            IObservable<System.Object[]> activationAttributes,
            IObservable<System.Security.Policy.Evidence> securityAttributes)
        {
            return Observable.Zip(AppDomainValue, assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture,
                activationAttributes, securityAttributes,
                (AppDomainValueLambda, assemblyNameLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda,
                    binderLambda, argsLambda, cultureLambda, activationAttributesLambda, securityAttributesLambda) =>
                    AppDomainValueLambda.CreateInstanceFromAndUnwrap(assemblyNameLambda, typeNameLambda,
                        ignoreCaseLambda, bindingAttrLambda, binderLambda, argsLambda, cultureLambda,
                        activationAttributesLambda, securityAttributesLambda));
        }


        public static IObservable<System.Object> CreateInstanceFromAndUnwrap(
            this IObservable<System.AppDomain> AppDomainValue, IObservable<System.String> assemblyFile,
            IObservable<System.String> typeName, IObservable<System.Boolean> ignoreCase,
            IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder,
            IObservable<System.Object[]> args, IObservable<System.Globalization.CultureInfo> culture,
            IObservable<System.Object[]> activationAttributes)
        {
            return Observable.Zip(AppDomainValue, assemblyFile, typeName, ignoreCase, bindingAttr, binder, args, culture,
                activationAttributes,
                (AppDomainValueLambda, assemblyFileLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda,
                    binderLambda, argsLambda, cultureLambda, activationAttributesLambda) =>
                    AppDomainValueLambda.CreateInstanceFromAndUnwrap(assemblyFileLambda, typeNameLambda,
                        ignoreCaseLambda, bindingAttrLambda, binderLambda, argsLambda, cultureLambda,
                        activationAttributesLambda));
        }


        public static IObservable<System.Boolean> IsDefaultAppDomain(this IObservable<System.AppDomain> AppDomainValue)
        {
            return Observable.Select(AppDomainValue, (AppDomainValueLambda) => AppDomainValueLambda.IsDefaultAppDomain());
        }


        public static IObservable<System.Type> GetType(this IObservable<System.AppDomain> AppDomainValue)
        {
            return Observable.Select(AppDomainValue, (AppDomainValueLambda) => AppDomainValueLambda.GetType());
        }


        public static IObservable<System.AppDomainManager> get_DomainManager(
            this IObservable<System.AppDomain> AppDomainValue)
        {
            return Observable.Select(AppDomainValue, (AppDomainValueLambda) => AppDomainValueLambda.DomainManager);
        }


        public static IObservable<System.AppDomain> get_CurrentDomain()
        {
            return ObservableExt.Factory(() => System.AppDomain.CurrentDomain);
        }


        public static IObservable<System.Security.Policy.Evidence> get_Evidence(
            this IObservable<System.AppDomain> AppDomainValue)
        {
            return Observable.Select(AppDomainValue, (AppDomainValueLambda) => AppDomainValueLambda.Evidence);
        }


        public static IObservable<System.String> get_FriendlyName(this IObservable<System.AppDomain> AppDomainValue)
        {
            return Observable.Select(AppDomainValue, (AppDomainValueLambda) => AppDomainValueLambda.FriendlyName);
        }


        public static IObservable<System.String> get_BaseDirectory(this IObservable<System.AppDomain> AppDomainValue)
        {
            return Observable.Select(AppDomainValue, (AppDomainValueLambda) => AppDomainValueLambda.BaseDirectory);
        }


        public static IObservable<System.String> get_RelativeSearchPath(
            this IObservable<System.AppDomain> AppDomainValue)
        {
            return Observable.Select(AppDomainValue, (AppDomainValueLambda) => AppDomainValueLambda.RelativeSearchPath);
        }


        public static IObservable<System.Boolean> get_ShadowCopyFiles(this IObservable<System.AppDomain> AppDomainValue)
        {
            return Observable.Select(AppDomainValue, (AppDomainValueLambda) => AppDomainValueLambda.ShadowCopyFiles);
        }


        public static IObservable<System.ActivationContext> get_ActivationContext(
            this IObservable<System.AppDomain> AppDomainValue)
        {
            return Observable.Select(AppDomainValue, (AppDomainValueLambda) => AppDomainValueLambda.ActivationContext);
        }


        public static IObservable<System.ApplicationIdentity> get_ApplicationIdentity(
            this IObservable<System.AppDomain> AppDomainValue)
        {
            return Observable.Select(AppDomainValue, (AppDomainValueLambda) => AppDomainValueLambda.ApplicationIdentity);
        }


        public static IObservable<System.Security.Policy.ApplicationTrust> get_ApplicationTrust(
            this IObservable<System.AppDomain> AppDomainValue)
        {
            return Observable.Select(AppDomainValue, (AppDomainValueLambda) => AppDomainValueLambda.ApplicationTrust);
        }


        public static IObservable<System.String> get_DynamicDirectory(this IObservable<System.AppDomain> AppDomainValue)
        {
            return Observable.Select(AppDomainValue, (AppDomainValueLambda) => AppDomainValueLambda.DynamicDirectory);
        }


        public static IObservable<System.AppDomainSetup> get_SetupInformation(
            this IObservable<System.AppDomain> AppDomainValue)
        {
            return Observable.Select(AppDomainValue, (AppDomainValueLambda) => AppDomainValueLambda.SetupInformation);
        }


        public static IObservable<System.Security.PermissionSet> get_PermissionSet(
            this IObservable<System.AppDomain> AppDomainValue)
        {
            return Observable.Select(AppDomainValue, (AppDomainValueLambda) => AppDomainValueLambda.PermissionSet);
        }


        public static IObservable<System.Boolean> get_IsFullyTrusted(this IObservable<System.AppDomain> AppDomainValue)
        {
            return Observable.Select(AppDomainValue, (AppDomainValueLambda) => AppDomainValueLambda.IsFullyTrusted);
        }


        public static IObservable<System.Boolean> get_IsHomogenous(this IObservable<System.AppDomain> AppDomainValue)
        {
            return Observable.Select(AppDomainValue, (AppDomainValueLambda) => AppDomainValueLambda.IsHomogenous);
        }


        public static IObservable<System.Int32> get_Id(this IObservable<System.AppDomain> AppDomainValue)
        {
            return Observable.Select(AppDomainValue, (AppDomainValueLambda) => AppDomainValueLambda.Id);
        }


        public static IObservable<System.Boolean> get_MonitoringIsEnabled()
        {
            return ObservableExt.Factory(() => System.AppDomain.MonitoringIsEnabled);
        }


        public static IObservable<System.TimeSpan> get_MonitoringTotalProcessorTime(
            this IObservable<System.AppDomain> AppDomainValue)
        {
            return Observable.Select(AppDomainValue,
                (AppDomainValueLambda) => AppDomainValueLambda.MonitoringTotalProcessorTime);
        }


        public static IObservable<System.Int64> get_MonitoringTotalAllocatedMemorySize(
            this IObservable<System.AppDomain> AppDomainValue)
        {
            return Observable.Select(AppDomainValue,
                (AppDomainValueLambda) => AppDomainValueLambda.MonitoringTotalAllocatedMemorySize);
        }


        public static IObservable<System.Int64> get_MonitoringSurvivedMemorySize(
            this IObservable<System.AppDomain> AppDomainValue)
        {
            return Observable.Select(AppDomainValue,
                (AppDomainValueLambda) => AppDomainValueLambda.MonitoringSurvivedMemorySize);
        }


        public static IObservable<System.Int64> get_MonitoringSurvivedProcessMemorySize()
        {
            return ObservableExt.Factory(() => System.AppDomain.MonitoringSurvivedProcessMemorySize);
        }


        public static IObservable<System.Reactive.Unit> set_MonitoringIsEnabled(IObservable<System.Boolean> value)
        {
            return Observable.Do(value, (valueLambda) => System.AppDomain.MonitoringIsEnabled = valueLambda).ToUnit();
        }
    }
}