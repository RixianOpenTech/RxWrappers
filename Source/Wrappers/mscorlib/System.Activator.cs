using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Activator
    {
        
        public static IObservable<System.Object> CreateInstance(IObservable<System.Type> type, IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object[]> args, IObservable<System.Globalization.CultureInfo> culture)
        {
            return Observable.Zip(type, bindingAttr, binder, args, culture, (typeLambda, bindingAttrLambda, binderLambda, argsLambda, cultureLambda) => System.Activator.CreateInstance(typeLambda, bindingAttrLambda, binderLambda, argsLambda, cultureLambda));
        }


        public static IObservable<System.Object> CreateInstance(IObservable<System.Type> type, IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object[]> args, IObservable<System.Globalization.CultureInfo> culture, IObservable<System.Object[]> activationAttributes)
        {
            return Observable.Zip(type, bindingAttr, binder, args, culture, activationAttributes, (typeLambda, bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda) => System.Activator.CreateInstance(typeLambda, bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda));
        }


        public static IObservable<System.Object> CreateInstance(IObservable<System.Type> type, IObservable<System.Object[]> args)
        {
            return Observable.Zip(type, args, (typeLambda, argsLambda) => System.Activator.CreateInstance(typeLambda, argsLambda));
        }


        public static IObservable<System.Object> CreateInstance(IObservable<System.Type> type, IObservable<System.Object[]> args, IObservable<System.Object[]> activationAttributes)
        {
            return Observable.Zip(type, args, activationAttributes, (typeLambda, argsLambda, activationAttributesLambda) => System.Activator.CreateInstance(typeLambda, argsLambda, activationAttributesLambda));
        }


        public static IObservable<System.Object> CreateInstance(IObservable<System.Type> type)
        {
            return Observable.Select(type, (typeLambda) => System.Activator.CreateInstance(typeLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstance(IObservable<System.String> assemblyName, IObservable<System.String> typeName)
        {
            return Observable.Zip(assemblyName, typeName, (assemblyNameLambda, typeNameLambda) => System.Activator.CreateInstance(assemblyNameLambda, typeNameLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstance(IObservable<System.String> assemblyName, IObservable<System.String> typeName, IObservable<System.Object[]> activationAttributes)
        {
            return Observable.Zip(assemblyName, typeName, activationAttributes, (assemblyNameLambda, typeNameLambda, activationAttributesLambda) => System.Activator.CreateInstance(assemblyNameLambda, typeNameLambda, activationAttributesLambda));
        }


        public static IObservable<System.Object> CreateInstance(IObservable<System.Type> type, IObservable<System.Boolean> nonPublic)
        {
            return Observable.Zip(type, nonPublic, (typeLambda, nonPublicLambda) => System.Activator.CreateInstance(typeLambda, nonPublicLambda));
        }


        public static IObservable<T> CreateInstance<T>()
        {
            return ObservableExt.Factory(() => System.Activator.CreateInstance<T>());
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstanceFrom(IObservable<System.String> assemblyFile, IObservable<System.String> typeName)
        {
            return Observable.Zip(assemblyFile, typeName, (assemblyFileLambda, typeNameLambda) => System.Activator.CreateInstanceFrom(assemblyFileLambda, typeNameLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstanceFrom(IObservable<System.String> assemblyFile, IObservable<System.String> typeName, IObservable<System.Object[]> activationAttributes)
        {
            return Observable.Zip(assemblyFile, typeName, activationAttributes, (assemblyFileLambda, typeNameLambda, activationAttributesLambda) => System.Activator.CreateInstanceFrom(assemblyFileLambda, typeNameLambda, activationAttributesLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstance(IObservable<System.String> assemblyName, IObservable<System.String> typeName, IObservable<System.Boolean> ignoreCase, IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object[]> args, IObservable<System.Globalization.CultureInfo> culture, IObservable<System.Object[]> activationAttributes, IObservable<System.Security.Policy.Evidence> securityInfo)
        {
            return Observable.Zip(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, securityInfo, (assemblyNameLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda, securityInfoLambda) => System.Activator.CreateInstance(assemblyNameLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda, securityInfoLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstance(IObservable<System.String> assemblyName, IObservable<System.String> typeName, IObservable<System.Boolean> ignoreCase, IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object[]> args, IObservable<System.Globalization.CultureInfo> culture, IObservable<System.Object[]> activationAttributes)
        {
            return Observable.Zip(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, (assemblyNameLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda) => System.Activator.CreateInstance(assemblyNameLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstanceFrom(IObservable<System.String> assemblyFile, IObservable<System.String> typeName, IObservable<System.Boolean> ignoreCase, IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object[]> args, IObservable<System.Globalization.CultureInfo> culture, IObservable<System.Object[]> activationAttributes, IObservable<System.Security.Policy.Evidence> securityInfo)
        {
            return Observable.Zip(assemblyFile, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, securityInfo, (assemblyFileLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda, securityInfoLambda) => System.Activator.CreateInstanceFrom(assemblyFileLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda, securityInfoLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstanceFrom(IObservable<System.String> assemblyFile, IObservable<System.String> typeName, IObservable<System.Boolean> ignoreCase, IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object[]> args, IObservable<System.Globalization.CultureInfo> culture, IObservable<System.Object[]> activationAttributes)
        {
            return Observable.Zip(assemblyFile, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, (assemblyFileLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda) => System.Activator.CreateInstanceFrom(assemblyFileLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstance(IObservable<System.AppDomain> domain, IObservable<System.String> assemblyName, IObservable<System.String> typeName)
        {
            return Observable.Zip(domain, assemblyName, typeName, (domainLambda, assemblyNameLambda, typeNameLambda) => System.Activator.CreateInstance(domainLambda, assemblyNameLambda, typeNameLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstance(IObservable<System.AppDomain> domain, IObservable<System.String> assemblyName, IObservable<System.String> typeName, IObservable<System.Boolean> ignoreCase, IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object[]> args, IObservable<System.Globalization.CultureInfo> culture, IObservable<System.Object[]> activationAttributes, IObservable<System.Security.Policy.Evidence> securityAttributes)
        {
            return Observable.Zip(domain, assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, securityAttributes, (domainLambda, assemblyNameLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda, securityAttributesLambda) => System.Activator.CreateInstance(domainLambda, assemblyNameLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda, securityAttributesLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstance(IObservable<System.AppDomain> domain, IObservable<System.String> assemblyName, IObservable<System.String> typeName, IObservable<System.Boolean> ignoreCase, IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object[]> args, IObservable<System.Globalization.CultureInfo> culture, IObservable<System.Object[]> activationAttributes)
        {
            return Observable.Zip(domain, assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, (domainLambda, assemblyNameLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda) => System.Activator.CreateInstance(domainLambda, assemblyNameLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstanceFrom(IObservable<System.AppDomain> domain, IObservable<System.String> assemblyFile, IObservable<System.String> typeName)
        {
            return Observable.Zip(domain, assemblyFile, typeName, (domainLambda, assemblyFileLambda, typeNameLambda) => System.Activator.CreateInstanceFrom(domainLambda, assemblyFileLambda, typeNameLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstanceFrom(IObservable<System.AppDomain> domain, IObservable<System.String> assemblyFile, IObservable<System.String> typeName, IObservable<System.Boolean> ignoreCase, IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object[]> args, IObservable<System.Globalization.CultureInfo> culture, IObservable<System.Object[]> activationAttributes, IObservable<System.Security.Policy.Evidence> securityAttributes)
        {
            return Observable.Zip(domain, assemblyFile, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, securityAttributes, (domainLambda, assemblyFileLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda, securityAttributesLambda) => System.Activator.CreateInstanceFrom(domainLambda, assemblyFileLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda, securityAttributesLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstanceFrom(IObservable<System.AppDomain> domain, IObservable<System.String> assemblyFile, IObservable<System.String> typeName, IObservable<System.Boolean> ignoreCase, IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object[]> args, IObservable<System.Globalization.CultureInfo> culture, IObservable<System.Object[]> activationAttributes)
        {
            return Observable.Zip(domain, assemblyFile, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, (domainLambda, assemblyFileLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda) => System.Activator.CreateInstanceFrom(domainLambda, assemblyFileLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstance(IObservable<System.ActivationContext> activationContext)
        {
            return Observable.Select(activationContext, (activationContextLambda) => System.Activator.CreateInstance(activationContextLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstance(IObservable<System.ActivationContext> activationContext, IObservable<System.String[]> activationCustomData)
        {
            return Observable.Zip(activationContext, activationCustomData, (activationContextLambda, activationCustomDataLambda) => System.Activator.CreateInstance(activationContextLambda, activationCustomDataLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateComInstanceFrom(IObservable<System.String> assemblyName, IObservable<System.String> typeName)
        {
            return Observable.Zip(assemblyName, typeName, (assemblyNameLambda, typeNameLambda) => System.Activator.CreateComInstanceFrom(assemblyNameLambda, typeNameLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateComInstanceFrom(IObservable<System.String> assemblyName, IObservable<System.String> typeName, IObservable<System.Byte[]> hashValue, IObservable<System.Configuration.Assemblies.AssemblyHashAlgorithm> hashAlgorithm)
        {
            return Observable.Zip(assemblyName, typeName, hashValue, hashAlgorithm, (assemblyNameLambda, typeNameLambda, hashValueLambda, hashAlgorithmLambda) => System.Activator.CreateComInstanceFrom(assemblyNameLambda, typeNameLambda, hashValueLambda, hashAlgorithmLambda));
        }


        public static IObservable<System.Object> GetObject(IObservable<System.Type> type, IObservable<System.String> url)
        {
            return Observable.Zip(type, url, (typeLambda, urlLambda) => System.Activator.GetObject(typeLambda, urlLambda));
        }


        public static IObservable<System.Object> GetObject(IObservable<System.Type> type, IObservable<System.String> url, IObservable<System.Object> state)
        {
            return Observable.Zip(type, url, state, (typeLambda, urlLambda, stateLambda) => System.Activator.GetObject(typeLambda, urlLambda, stateLambda));
        }

    }
}