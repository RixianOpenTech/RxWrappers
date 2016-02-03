using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class ___AppDomain
    {
        public static IObservable<System.UInt32> GetTypeInfoCount(this IObservable<System._AppDomain> _AppDomainValue)
        {
            return Observable.Select(_AppDomainValue, (_AppDomainValueLambda) =>
            {
                System.UInt32 pcTInfoOutput = default(System.UInt32);
                _AppDomainValueLambda.GetTypeInfoCount(out pcTInfoOutput);
                return pcTInfoOutput;
            });
        }


        public static IObservable<System.Reactive.Unit> GetTypeInfo(this IObservable<System._AppDomain> _AppDomainValue,
            IObservable<System.UInt32> iTInfo, IObservable<System.UInt32> lcid, IObservable<System.IntPtr> ppTInfo)
        {
            return ObservableExt.ZipExecute(_AppDomainValue, iTInfo, lcid, ppTInfo,
                (_AppDomainValueLambda, iTInfoLambda, lcidLambda, ppTInfoLambda) =>
                    _AppDomainValueLambda.GetTypeInfo(iTInfoLambda, lcidLambda, ppTInfoLambda));
        }


        public static IObservable<System.Guid> GetIDsOfNames(this IObservable<System._AppDomain> _AppDomainValue,
            IObservable<System.Guid> riid, IObservable<System.IntPtr> rgszNames, IObservable<System.UInt32> cNames,
            IObservable<System.UInt32> lcid, IObservable<System.IntPtr> rgDispId)
        {
            return Observable.Zip(_AppDomainValue, riid, rgszNames, cNames, lcid, rgDispId,
                (_AppDomainValueLambda, riidLambda, rgszNamesLambda, cNamesLambda, lcidLambda, rgDispIdLambda) =>
                {
                    _AppDomainValueLambda.GetIDsOfNames(ref riidLambda, rgszNamesLambda, cNamesLambda, lcidLambda,
                        rgDispIdLambda);
                    return riidLambda;
                });
        }


        public static IObservable<System.Guid> Invoke(this IObservable<System._AppDomain> _AppDomainValue,
            IObservable<System.UInt32> dispIdMember, IObservable<System.Guid> riid, IObservable<System.UInt32> lcid,
            IObservable<System.Int16> wFlags, IObservable<System.IntPtr> pDispParams,
            IObservable<System.IntPtr> pVarResult, IObservable<System.IntPtr> pExcepInfo,
            IObservable<System.IntPtr> puArgErr)
        {
            return Observable.Zip(_AppDomainValue, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo,
                puArgErr,
                (_AppDomainValueLambda, dispIdMemberLambda, riidLambda, lcidLambda, wFlagsLambda, pDispParamsLambda,
                    pVarResultLambda, pExcepInfoLambda, puArgErrLambda) =>
                {
                    _AppDomainValueLambda.Invoke(dispIdMemberLambda, ref riidLambda, lcidLambda, wFlagsLambda,
                        pDispParamsLambda, pVarResultLambda, pExcepInfoLambda, puArgErrLambda);
                    return riidLambda;
                });
        }


        public static IObservable<System.String> ToString(this IObservable<System._AppDomain> _AppDomainValue)
        {
            return Observable.Select(_AppDomainValue, (_AppDomainValueLambda) => _AppDomainValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System._AppDomain> _AppDomainValue,
            IObservable<System.Object> other)
        {
            return Observable.Zip(_AppDomainValue, other,
                (_AppDomainValueLambda, otherLambda) => _AppDomainValueLambda.Equals(otherLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System._AppDomain> _AppDomainValue)
        {
            return Observable.Select(_AppDomainValue, (_AppDomainValueLambda) => _AppDomainValueLambda.GetHashCode());
        }


        public static IObservable<System.Type> GetType(this IObservable<System._AppDomain> _AppDomainValue)
        {
            return Observable.Select(_AppDomainValue, (_AppDomainValueLambda) => _AppDomainValueLambda.GetType());
        }


        public static IObservable<System.Object> InitializeLifetimeService(
            this IObservable<System._AppDomain> _AppDomainValue)
        {
            return Observable.Select(_AppDomainValue,
                (_AppDomainValueLambda) => _AppDomainValueLambda.InitializeLifetimeService());
        }


        public static IObservable<System.Object> GetLifetimeService(this IObservable<System._AppDomain> _AppDomainValue)
        {
            return Observable.Select(_AppDomainValue,
                (_AppDomainValueLambda) => _AppDomainValueLambda.GetLifetimeService());
        }


        public static IObservable<System.Reflection.Emit.AssemblyBuilder> DefineDynamicAssembly(
            this IObservable<System._AppDomain> _AppDomainValue, IObservable<System.Reflection.AssemblyName> name,
            IObservable<System.Reflection.Emit.AssemblyBuilderAccess> access)
        {
            return Observable.Zip(_AppDomainValue, name, access,
                (_AppDomainValueLambda, nameLambda, accessLambda) =>
                    _AppDomainValueLambda.DefineDynamicAssembly(nameLambda, accessLambda));
        }


        public static IObservable<System.Reflection.Emit.AssemblyBuilder> DefineDynamicAssembly(
            this IObservable<System._AppDomain> _AppDomainValue, IObservable<System.Reflection.AssemblyName> name,
            IObservable<System.Reflection.Emit.AssemblyBuilderAccess> access, IObservable<System.String> dir)
        {
            return Observable.Zip(_AppDomainValue, name, access, dir,
                (_AppDomainValueLambda, nameLambda, accessLambda, dirLambda) =>
                    _AppDomainValueLambda.DefineDynamicAssembly(nameLambda, accessLambda, dirLambda));
        }


        public static IObservable<System.Reflection.Emit.AssemblyBuilder> DefineDynamicAssembly(
            this IObservable<System._AppDomain> _AppDomainValue, IObservable<System.Reflection.AssemblyName> name,
            IObservable<System.Reflection.Emit.AssemblyBuilderAccess> access,
            IObservable<System.Security.Policy.Evidence> evidence)
        {
            return Observable.Zip(_AppDomainValue, name, access, evidence,
                (_AppDomainValueLambda, nameLambda, accessLambda, evidenceLambda) =>
                    _AppDomainValueLambda.DefineDynamicAssembly(nameLambda, accessLambda, evidenceLambda));
        }


        public static IObservable<System.Reflection.Emit.AssemblyBuilder> DefineDynamicAssembly(
            this IObservable<System._AppDomain> _AppDomainValue, IObservable<System.Reflection.AssemblyName> name,
            IObservable<System.Reflection.Emit.AssemblyBuilderAccess> access,
            IObservable<System.Security.PermissionSet> requiredPermissions,
            IObservable<System.Security.PermissionSet> optionalPermissions,
            IObservable<System.Security.PermissionSet> refusedPermissions)
        {
            return Observable.Zip(_AppDomainValue, name, access, requiredPermissions, optionalPermissions,
                refusedPermissions,
                (_AppDomainValueLambda, nameLambda, accessLambda, requiredPermissionsLambda, optionalPermissionsLambda,
                    refusedPermissionsLambda) =>
                    _AppDomainValueLambda.DefineDynamicAssembly(nameLambda, accessLambda, requiredPermissionsLambda,
                        optionalPermissionsLambda, refusedPermissionsLambda));
        }


        public static IObservable<System.Reflection.Emit.AssemblyBuilder> DefineDynamicAssembly(
            this IObservable<System._AppDomain> _AppDomainValue, IObservable<System.Reflection.AssemblyName> name,
            IObservable<System.Reflection.Emit.AssemblyBuilderAccess> access, IObservable<System.String> dir,
            IObservable<System.Security.Policy.Evidence> evidence)
        {
            return Observable.Zip(_AppDomainValue, name, access, dir, evidence,
                (_AppDomainValueLambda, nameLambda, accessLambda, dirLambda, evidenceLambda) =>
                    _AppDomainValueLambda.DefineDynamicAssembly(nameLambda, accessLambda, dirLambda, evidenceLambda));
        }


        public static IObservable<System.Reflection.Emit.AssemblyBuilder> DefineDynamicAssembly(
            this IObservable<System._AppDomain> _AppDomainValue, IObservable<System.Reflection.AssemblyName> name,
            IObservable<System.Reflection.Emit.AssemblyBuilderAccess> access, IObservable<System.String> dir,
            IObservable<System.Security.PermissionSet> requiredPermissions,
            IObservable<System.Security.PermissionSet> optionalPermissions,
            IObservable<System.Security.PermissionSet> refusedPermissions)
        {
            return Observable.Zip(_AppDomainValue, name, access, dir, requiredPermissions, optionalPermissions,
                refusedPermissions,
                (_AppDomainValueLambda, nameLambda, accessLambda, dirLambda, requiredPermissionsLambda,
                    optionalPermissionsLambda, refusedPermissionsLambda) =>
                    _AppDomainValueLambda.DefineDynamicAssembly(nameLambda, accessLambda, dirLambda,
                        requiredPermissionsLambda, optionalPermissionsLambda, refusedPermissionsLambda));
        }


        public static IObservable<System.Reflection.Emit.AssemblyBuilder> DefineDynamicAssembly(
            this IObservable<System._AppDomain> _AppDomainValue, IObservable<System.Reflection.AssemblyName> name,
            IObservable<System.Reflection.Emit.AssemblyBuilderAccess> access,
            IObservable<System.Security.Policy.Evidence> evidence,
            IObservable<System.Security.PermissionSet> requiredPermissions,
            IObservable<System.Security.PermissionSet> optionalPermissions,
            IObservable<System.Security.PermissionSet> refusedPermissions)
        {
            return Observable.Zip(_AppDomainValue, name, access, evidence, requiredPermissions, optionalPermissions,
                refusedPermissions,
                (_AppDomainValueLambda, nameLambda, accessLambda, evidenceLambda, requiredPermissionsLambda,
                    optionalPermissionsLambda, refusedPermissionsLambda) =>
                    _AppDomainValueLambda.DefineDynamicAssembly(nameLambda, accessLambda, evidenceLambda,
                        requiredPermissionsLambda, optionalPermissionsLambda, refusedPermissionsLambda));
        }


        public static IObservable<System.Reflection.Emit.AssemblyBuilder> DefineDynamicAssembly(
            this IObservable<System._AppDomain> _AppDomainValue, IObservable<System.Reflection.AssemblyName> name,
            IObservable<System.Reflection.Emit.AssemblyBuilderAccess> access, IObservable<System.String> dir,
            IObservable<System.Security.Policy.Evidence> evidence,
            IObservable<System.Security.PermissionSet> requiredPermissions,
            IObservable<System.Security.PermissionSet> optionalPermissions,
            IObservable<System.Security.PermissionSet> refusedPermissions)
        {
            return Observable.Zip(_AppDomainValue, name, access, dir, evidence, requiredPermissions, optionalPermissions,
                refusedPermissions,
                (_AppDomainValueLambda, nameLambda, accessLambda, dirLambda, evidenceLambda, requiredPermissionsLambda,
                    optionalPermissionsLambda, refusedPermissionsLambda) =>
                    _AppDomainValueLambda.DefineDynamicAssembly(nameLambda, accessLambda, dirLambda, evidenceLambda,
                        requiredPermissionsLambda, optionalPermissionsLambda, refusedPermissionsLambda));
        }


        public static IObservable<System.Reflection.Emit.AssemblyBuilder> DefineDynamicAssembly(
            this IObservable<System._AppDomain> _AppDomainValue, IObservable<System.Reflection.AssemblyName> name,
            IObservable<System.Reflection.Emit.AssemblyBuilderAccess> access, IObservable<System.String> dir,
            IObservable<System.Security.Policy.Evidence> evidence,
            IObservable<System.Security.PermissionSet> requiredPermissions,
            IObservable<System.Security.PermissionSet> optionalPermissions,
            IObservable<System.Security.PermissionSet> refusedPermissions, IObservable<System.Boolean> isSynchronized)
        {
            return Observable.Zip(_AppDomainValue, name, access, dir, evidence, requiredPermissions, optionalPermissions,
                refusedPermissions, isSynchronized,
                (_AppDomainValueLambda, nameLambda, accessLambda, dirLambda, evidenceLambda, requiredPermissionsLambda,
                    optionalPermissionsLambda, refusedPermissionsLambda, isSynchronizedLambda) =>
                    _AppDomainValueLambda.DefineDynamicAssembly(nameLambda, accessLambda, dirLambda, evidenceLambda,
                        requiredPermissionsLambda, optionalPermissionsLambda, refusedPermissionsLambda,
                        isSynchronizedLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstance(
            this IObservable<System._AppDomain> _AppDomainValue, IObservable<System.String> assemblyName,
            IObservable<System.String> typeName)
        {
            return Observable.Zip(_AppDomainValue, assemblyName, typeName,
                (_AppDomainValueLambda, assemblyNameLambda, typeNameLambda) =>
                    _AppDomainValueLambda.CreateInstance(assemblyNameLambda, typeNameLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstanceFrom(
            this IObservable<System._AppDomain> _AppDomainValue, IObservable<System.String> assemblyFile,
            IObservable<System.String> typeName)
        {
            return Observable.Zip(_AppDomainValue, assemblyFile, typeName,
                (_AppDomainValueLambda, assemblyFileLambda, typeNameLambda) =>
                    _AppDomainValueLambda.CreateInstanceFrom(assemblyFileLambda, typeNameLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstance(
            this IObservable<System._AppDomain> _AppDomainValue, IObservable<System.String> assemblyName,
            IObservable<System.String> typeName, IObservable<System.Object[]> activationAttributes)
        {
            return Observable.Zip(_AppDomainValue, assemblyName, typeName, activationAttributes,
                (_AppDomainValueLambda, assemblyNameLambda, typeNameLambda, activationAttributesLambda) =>
                    _AppDomainValueLambda.CreateInstance(assemblyNameLambda, typeNameLambda, activationAttributesLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstanceFrom(
            this IObservable<System._AppDomain> _AppDomainValue, IObservable<System.String> assemblyFile,
            IObservable<System.String> typeName, IObservable<System.Object[]> activationAttributes)
        {
            return Observable.Zip(_AppDomainValue, assemblyFile, typeName, activationAttributes,
                (_AppDomainValueLambda, assemblyFileLambda, typeNameLambda, activationAttributesLambda) =>
                    _AppDomainValueLambda.CreateInstanceFrom(assemblyFileLambda, typeNameLambda,
                        activationAttributesLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstance(
            this IObservable<System._AppDomain> _AppDomainValue, IObservable<System.String> assemblyName,
            IObservable<System.String> typeName, IObservable<System.Boolean> ignoreCase,
            IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder,
            IObservable<System.Object[]> args, IObservable<System.Globalization.CultureInfo> culture,
            IObservable<System.Object[]> activationAttributes,
            IObservable<System.Security.Policy.Evidence> securityAttributes)
        {
            return Observable.Zip(_AppDomainValue, assemblyName, typeName, ignoreCase, bindingAttr, binder, args,
                culture, activationAttributes, securityAttributes,
                (_AppDomainValueLambda, assemblyNameLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda,
                    binderLambda, argsLambda, cultureLambda, activationAttributesLambda, securityAttributesLambda) =>
                    _AppDomainValueLambda.CreateInstance(assemblyNameLambda, typeNameLambda, ignoreCaseLambda,
                        bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda,
                        securityAttributesLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstanceFrom(
            this IObservable<System._AppDomain> _AppDomainValue, IObservable<System.String> assemblyFile,
            IObservable<System.String> typeName, IObservable<System.Boolean> ignoreCase,
            IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder,
            IObservable<System.Object[]> args, IObservable<System.Globalization.CultureInfo> culture,
            IObservable<System.Object[]> activationAttributes,
            IObservable<System.Security.Policy.Evidence> securityAttributes)
        {
            return Observable.Zip(_AppDomainValue, assemblyFile, typeName, ignoreCase, bindingAttr, binder, args,
                culture, activationAttributes, securityAttributes,
                (_AppDomainValueLambda, assemblyFileLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda,
                    binderLambda, argsLambda, cultureLambda, activationAttributesLambda, securityAttributesLambda) =>
                    _AppDomainValueLambda.CreateInstanceFrom(assemblyFileLambda, typeNameLambda, ignoreCaseLambda,
                        bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda,
                        securityAttributesLambda));
        }


        public static IObservable<System.Reflection.Assembly> Load(this IObservable<System._AppDomain> _AppDomainValue,
            IObservable<System.Reflection.AssemblyName> assemblyRef)
        {
            return Observable.Zip(_AppDomainValue, assemblyRef,
                (_AppDomainValueLambda, assemblyRefLambda) => _AppDomainValueLambda.Load(assemblyRefLambda));
        }


        public static IObservable<System.Reflection.Assembly> Load(this IObservable<System._AppDomain> _AppDomainValue,
            IObservable<System.String> assemblyString)
        {
            return Observable.Zip(_AppDomainValue, assemblyString,
                (_AppDomainValueLambda, assemblyStringLambda) => _AppDomainValueLambda.Load(assemblyStringLambda));
        }


        public static IObservable<System.Reflection.Assembly> Load(this IObservable<System._AppDomain> _AppDomainValue,
            IObservable<System.Byte[]> rawAssembly)
        {
            return Observable.Zip(_AppDomainValue, rawAssembly,
                (_AppDomainValueLambda, rawAssemblyLambda) => _AppDomainValueLambda.Load(rawAssemblyLambda));
        }


        public static IObservable<System.Reflection.Assembly> Load(this IObservable<System._AppDomain> _AppDomainValue,
            IObservable<System.Byte[]> rawAssembly, IObservable<System.Byte[]> rawSymbolStore)
        {
            return Observable.Zip(_AppDomainValue, rawAssembly, rawSymbolStore,
                (_AppDomainValueLambda, rawAssemblyLambda, rawSymbolStoreLambda) =>
                    _AppDomainValueLambda.Load(rawAssemblyLambda, rawSymbolStoreLambda));
        }


        public static IObservable<System.Reflection.Assembly> Load(this IObservable<System._AppDomain> _AppDomainValue,
            IObservable<System.Byte[]> rawAssembly, IObservable<System.Byte[]> rawSymbolStore,
            IObservable<System.Security.Policy.Evidence> securityEvidence)
        {
            return Observable.Zip(_AppDomainValue, rawAssembly, rawSymbolStore, securityEvidence,
                (_AppDomainValueLambda, rawAssemblyLambda, rawSymbolStoreLambda, securityEvidenceLambda) =>
                    _AppDomainValueLambda.Load(rawAssemblyLambda, rawSymbolStoreLambda, securityEvidenceLambda));
        }


        public static IObservable<System.Reflection.Assembly> Load(this IObservable<System._AppDomain> _AppDomainValue,
            IObservable<System.Reflection.AssemblyName> assemblyRef,
            IObservable<System.Security.Policy.Evidence> assemblySecurity)
        {
            return Observable.Zip(_AppDomainValue, assemblyRef, assemblySecurity,
                (_AppDomainValueLambda, assemblyRefLambda, assemblySecurityLambda) =>
                    _AppDomainValueLambda.Load(assemblyRefLambda, assemblySecurityLambda));
        }


        public static IObservable<System.Reflection.Assembly> Load(this IObservable<System._AppDomain> _AppDomainValue,
            IObservable<System.String> assemblyString, IObservable<System.Security.Policy.Evidence> assemblySecurity)
        {
            return Observable.Zip(_AppDomainValue, assemblyString, assemblySecurity,
                (_AppDomainValueLambda, assemblyStringLambda, assemblySecurityLambda) =>
                    _AppDomainValueLambda.Load(assemblyStringLambda, assemblySecurityLambda));
        }


        public static IObservable<System.Int32> ExecuteAssembly(this IObservable<System._AppDomain> _AppDomainValue,
            IObservable<System.String> assemblyFile, IObservable<System.Security.Policy.Evidence> assemblySecurity)
        {
            return Observable.Zip(_AppDomainValue, assemblyFile, assemblySecurity,
                (_AppDomainValueLambda, assemblyFileLambda, assemblySecurityLambda) =>
                    _AppDomainValueLambda.ExecuteAssembly(assemblyFileLambda, assemblySecurityLambda));
        }


        public static IObservable<System.Int32> ExecuteAssembly(this IObservable<System._AppDomain> _AppDomainValue,
            IObservable<System.String> assemblyFile)
        {
            return Observable.Zip(_AppDomainValue, assemblyFile,
                (_AppDomainValueLambda, assemblyFileLambda) => _AppDomainValueLambda.ExecuteAssembly(assemblyFileLambda));
        }


        public static IObservable<System.Int32> ExecuteAssembly(this IObservable<System._AppDomain> _AppDomainValue,
            IObservable<System.String> assemblyFile, IObservable<System.Security.Policy.Evidence> assemblySecurity,
            IObservable<System.String[]> args)
        {
            return Observable.Zip(_AppDomainValue, assemblyFile, assemblySecurity, args,
                (_AppDomainValueLambda, assemblyFileLambda, assemblySecurityLambda, argsLambda) =>
                    _AppDomainValueLambda.ExecuteAssembly(assemblyFileLambda, assemblySecurityLambda, argsLambda));
        }


        public static IObservable<System.Reflection.Assembly[]> GetAssemblies(
            this IObservable<System._AppDomain> _AppDomainValue)
        {
            return Observable.Select(_AppDomainValue, (_AppDomainValueLambda) => _AppDomainValueLambda.GetAssemblies());
        }


        public static IObservable<System.Reactive.Unit> AppendPrivatePath(
            this IObservable<System._AppDomain> _AppDomainValue, IObservable<System.String> path)
        {
            return ObservableExt.ZipExecute(_AppDomainValue, path,
                (_AppDomainValueLambda, pathLambda) => _AppDomainValueLambda.AppendPrivatePath(pathLambda));
        }


        public static IObservable<System.Reactive.Unit> ClearPrivatePath(
            this IObservable<System._AppDomain> _AppDomainValue)
        {
            return
                Observable.Do(_AppDomainValue, (_AppDomainValueLambda) => _AppDomainValueLambda.ClearPrivatePath())
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> SetShadowCopyPath(
            this IObservable<System._AppDomain> _AppDomainValue, IObservable<System.String> s)
        {
            return ObservableExt.ZipExecute(_AppDomainValue, s,
                (_AppDomainValueLambda, sLambda) => _AppDomainValueLambda.SetShadowCopyPath(sLambda));
        }


        public static IObservable<System.Reactive.Unit> ClearShadowCopyPath(
            this IObservable<System._AppDomain> _AppDomainValue)
        {
            return
                Observable.Do(_AppDomainValue, (_AppDomainValueLambda) => _AppDomainValueLambda.ClearShadowCopyPath())
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> SetCachePath(
            this IObservable<System._AppDomain> _AppDomainValue, IObservable<System.String> s)
        {
            return ObservableExt.ZipExecute(_AppDomainValue, s,
                (_AppDomainValueLambda, sLambda) => _AppDomainValueLambda.SetCachePath(sLambda));
        }


        public static IObservable<System.Reactive.Unit> SetData(this IObservable<System._AppDomain> _AppDomainValue,
            IObservable<System.String> name, IObservable<System.Object> data)
        {
            return ObservableExt.ZipExecute(_AppDomainValue, name, data,
                (_AppDomainValueLambda, nameLambda, dataLambda) => _AppDomainValueLambda.SetData(nameLambda, dataLambda));
        }


        public static IObservable<System.Object> GetData(this IObservable<System._AppDomain> _AppDomainValue,
            IObservable<System.String> name)
        {
            return Observable.Zip(_AppDomainValue, name,
                (_AppDomainValueLambda, nameLambda) => _AppDomainValueLambda.GetData(nameLambda));
        }


        public static IObservable<System.Reactive.Unit> SetAppDomainPolicy(
            this IObservable<System._AppDomain> _AppDomainValue,
            IObservable<System.Security.Policy.PolicyLevel> domainPolicy)
        {
            return ObservableExt.ZipExecute(_AppDomainValue, domainPolicy,
                (_AppDomainValueLambda, domainPolicyLambda) =>
                    _AppDomainValueLambda.SetAppDomainPolicy(domainPolicyLambda));
        }


        public static IObservable<System.Reactive.Unit> SetThreadPrincipal(
            this IObservable<System._AppDomain> _AppDomainValue,
            IObservable<System.Security.Principal.IPrincipal> principal)
        {
            return ObservableExt.ZipExecute(_AppDomainValue, principal,
                (_AppDomainValueLambda, principalLambda) => _AppDomainValueLambda.SetThreadPrincipal(principalLambda));
        }


        public static IObservable<System.Reactive.Unit> SetPrincipalPolicy(
            this IObservable<System._AppDomain> _AppDomainValue,
            IObservable<System.Security.Principal.PrincipalPolicy> policy)
        {
            return ObservableExt.ZipExecute(_AppDomainValue, policy,
                (_AppDomainValueLambda, policyLambda) => _AppDomainValueLambda.SetPrincipalPolicy(policyLambda));
        }


        public static IObservable<System.Reactive.Unit> DoCallBack(this IObservable<System._AppDomain> _AppDomainValue,
            IObservable<System.CrossAppDomainDelegate> theDelegate)
        {
            return ObservableExt.ZipExecute(_AppDomainValue, theDelegate,
                (_AppDomainValueLambda, theDelegateLambda) => _AppDomainValueLambda.DoCallBack(theDelegateLambda));
        }


        public static IObservable<System.Security.Policy.Evidence> get_Evidence(
            this IObservable<System._AppDomain> _AppDomainValue)
        {
            return Observable.Select(_AppDomainValue, (_AppDomainValueLambda) => _AppDomainValueLambda.Evidence);
        }


        public static IObservable<System.String> get_FriendlyName(this IObservable<System._AppDomain> _AppDomainValue)
        {
            return Observable.Select(_AppDomainValue, (_AppDomainValueLambda) => _AppDomainValueLambda.FriendlyName);
        }


        public static IObservable<System.String> get_BaseDirectory(this IObservable<System._AppDomain> _AppDomainValue)
        {
            return Observable.Select(_AppDomainValue, (_AppDomainValueLambda) => _AppDomainValueLambda.BaseDirectory);
        }


        public static IObservable<System.String> get_RelativeSearchPath(
            this IObservable<System._AppDomain> _AppDomainValue)
        {
            return Observable.Select(_AppDomainValue,
                (_AppDomainValueLambda) => _AppDomainValueLambda.RelativeSearchPath);
        }


        public static IObservable<System.Boolean> get_ShadowCopyFiles(
            this IObservable<System._AppDomain> _AppDomainValue)
        {
            return Observable.Select(_AppDomainValue, (_AppDomainValueLambda) => _AppDomainValueLambda.ShadowCopyFiles);
        }


        public static IObservable<System.String> get_DynamicDirectory(
            this IObservable<System._AppDomain> _AppDomainValue)
        {
            return Observable.Select(_AppDomainValue, (_AppDomainValueLambda) => _AppDomainValueLambda.DynamicDirectory);
        }
    }
}