using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __Module
    {
        public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.Module> ModuleValue,
            IObservable<System.Object> o)
        {
            return Observable.Zip(ModuleValue, o, (ModuleValueLambda, oLambda) => ModuleValueLambda.Equals(oLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Reflection.Module> ModuleValue)
        {
            return Observable.Select(ModuleValue, (ModuleValueLambda) => ModuleValueLambda.GetHashCode());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Reflection.Module> ModuleValue)
        {
            return Observable.Select(ModuleValue, (ModuleValueLambda) => ModuleValueLambda.ToString());
        }


        public static IObservable<System.Object[]> GetCustomAttributes(
            this IObservable<System.Reflection.Module> ModuleValue, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(ModuleValue, inherit,
                (ModuleValueLambda, inheritLambda) => ModuleValueLambda.GetCustomAttributes(inheritLambda));
        }


        public static IObservable<System.Object[]> GetCustomAttributes(
            this IObservable<System.Reflection.Module> ModuleValue, IObservable<System.Type> attributeType,
            IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(ModuleValue, attributeType, inherit,
                (ModuleValueLambda, attributeTypeLambda, inheritLambda) =>
                    ModuleValueLambda.GetCustomAttributes(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Boolean> IsDefined(this IObservable<System.Reflection.Module> ModuleValue,
            IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(ModuleValue, attributeType, inherit,
                (ModuleValueLambda, attributeTypeLambda, inheritLambda) =>
                    ModuleValueLambda.IsDefined(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Collections.Generic.IList<System.Reflection.CustomAttributeData>>
            GetCustomAttributesData(this IObservable<System.Reflection.Module> ModuleValue)
        {
            return Observable.Select(ModuleValue, (ModuleValueLambda) => ModuleValueLambda.GetCustomAttributesData());
        }


        public static IObservable<System.Reflection.MethodBase> ResolveMethod(
            this IObservable<System.Reflection.Module> ModuleValue, IObservable<System.Int32> metadataToken)
        {
            return Observable.Zip(ModuleValue, metadataToken,
                (ModuleValueLambda, metadataTokenLambda) => ModuleValueLambda.ResolveMethod(metadataTokenLambda));
        }


        public static IObservable<System.Reflection.MethodBase> ResolveMethod(
            this IObservable<System.Reflection.Module> ModuleValue, IObservable<System.Int32> metadataToken,
            IObservable<System.Type[]> genericTypeArguments, IObservable<System.Type[]> genericMethodArguments)
        {
            return Observable.Zip(ModuleValue, metadataToken, genericTypeArguments, genericMethodArguments,
                (ModuleValueLambda, metadataTokenLambda, genericTypeArgumentsLambda, genericMethodArgumentsLambda) =>
                    ModuleValueLambda.ResolveMethod(metadataTokenLambda, genericTypeArgumentsLambda,
                        genericMethodArgumentsLambda));
        }


        public static IObservable<System.Reflection.FieldInfo> ResolveField(
            this IObservable<System.Reflection.Module> ModuleValue, IObservable<System.Int32> metadataToken)
        {
            return Observable.Zip(ModuleValue, metadataToken,
                (ModuleValueLambda, metadataTokenLambda) => ModuleValueLambda.ResolveField(metadataTokenLambda));
        }


        public static IObservable<System.Reflection.FieldInfo> ResolveField(
            this IObservable<System.Reflection.Module> ModuleValue, IObservable<System.Int32> metadataToken,
            IObservable<System.Type[]> genericTypeArguments, IObservable<System.Type[]> genericMethodArguments)
        {
            return Observable.Zip(ModuleValue, metadataToken, genericTypeArguments, genericMethodArguments,
                (ModuleValueLambda, metadataTokenLambda, genericTypeArgumentsLambda, genericMethodArgumentsLambda) =>
                    ModuleValueLambda.ResolveField(metadataTokenLambda, genericTypeArgumentsLambda,
                        genericMethodArgumentsLambda));
        }


        public static IObservable<System.Type> ResolveType(this IObservable<System.Reflection.Module> ModuleValue,
            IObservable<System.Int32> metadataToken)
        {
            return Observable.Zip(ModuleValue, metadataToken,
                (ModuleValueLambda, metadataTokenLambda) => ModuleValueLambda.ResolveType(metadataTokenLambda));
        }


        public static IObservable<System.Type> ResolveType(this IObservable<System.Reflection.Module> ModuleValue,
            IObservable<System.Int32> metadataToken, IObservable<System.Type[]> genericTypeArguments,
            IObservable<System.Type[]> genericMethodArguments)
        {
            return Observable.Zip(ModuleValue, metadataToken, genericTypeArguments, genericMethodArguments,
                (ModuleValueLambda, metadataTokenLambda, genericTypeArgumentsLambda, genericMethodArgumentsLambda) =>
                    ModuleValueLambda.ResolveType(metadataTokenLambda, genericTypeArgumentsLambda,
                        genericMethodArgumentsLambda));
        }


        public static IObservable<System.Reflection.MemberInfo> ResolveMember(
            this IObservable<System.Reflection.Module> ModuleValue, IObservable<System.Int32> metadataToken)
        {
            return Observable.Zip(ModuleValue, metadataToken,
                (ModuleValueLambda, metadataTokenLambda) => ModuleValueLambda.ResolveMember(metadataTokenLambda));
        }


        public static IObservable<System.Reflection.MemberInfo> ResolveMember(
            this IObservable<System.Reflection.Module> ModuleValue, IObservable<System.Int32> metadataToken,
            IObservable<System.Type[]> genericTypeArguments, IObservable<System.Type[]> genericMethodArguments)
        {
            return Observable.Zip(ModuleValue, metadataToken, genericTypeArguments, genericMethodArguments,
                (ModuleValueLambda, metadataTokenLambda, genericTypeArgumentsLambda, genericMethodArgumentsLambda) =>
                    ModuleValueLambda.ResolveMember(metadataTokenLambda, genericTypeArgumentsLambda,
                        genericMethodArgumentsLambda));
        }


        public static IObservable<System.Byte[]> ResolveSignature(
            this IObservable<System.Reflection.Module> ModuleValue, IObservable<System.Int32> metadataToken)
        {
            return Observable.Zip(ModuleValue, metadataToken,
                (ModuleValueLambda, metadataTokenLambda) => ModuleValueLambda.ResolveSignature(metadataTokenLambda));
        }


        public static IObservable<System.String> ResolveString(this IObservable<System.Reflection.Module> ModuleValue,
            IObservable<System.Int32> metadataToken)
        {
            return Observable.Zip(ModuleValue, metadataToken,
                (ModuleValueLambda, metadataTokenLambda) => ModuleValueLambda.ResolveString(metadataTokenLambda));
        }


        public static IObservable<Tuple<System.Reflection.PortableExecutableKinds, System.Reflection.ImageFileMachine>>
            GetPEKind(this IObservable<System.Reflection.Module> ModuleValue)
        {
            return Observable.Select(ModuleValue, (ModuleValueLambda) =>
            {
                System.Reflection.PortableExecutableKinds peKindOutput =
                    default(System.Reflection.PortableExecutableKinds);
                System.Reflection.ImageFileMachine machineOutput = default(System.Reflection.ImageFileMachine);
                ModuleValueLambda.GetPEKind(out peKindOutput, out machineOutput);
                return Tuple.Create(peKindOutput, machineOutput);
            });
        }


        public static IObservable<System.Reactive.Unit> GetObjectData(
            this IObservable<System.Reflection.Module> ModuleValue,
            IObservable<System.Runtime.Serialization.SerializationInfo> info,
            IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(ModuleValue, info, context,
                (ModuleValueLambda, infoLambda, contextLambda) =>
                    ModuleValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.Type> GetType(this IObservable<System.Reflection.Module> ModuleValue,
            IObservable<System.String> className, IObservable<System.Boolean> ignoreCase)
        {
            return Observable.Zip(ModuleValue, className, ignoreCase,
                (ModuleValueLambda, classNameLambda, ignoreCaseLambda) =>
                    ModuleValueLambda.GetType(classNameLambda, ignoreCaseLambda));
        }


        public static IObservable<System.Type> GetType(this IObservable<System.Reflection.Module> ModuleValue,
            IObservable<System.String> className)
        {
            return Observable.Zip(ModuleValue, className,
                (ModuleValueLambda, classNameLambda) => ModuleValueLambda.GetType(classNameLambda));
        }


        public static IObservable<System.Type> GetType(this IObservable<System.Reflection.Module> ModuleValue,
            IObservable<System.String> className, IObservable<System.Boolean> throwOnError,
            IObservable<System.Boolean> ignoreCase)
        {
            return Observable.Zip(ModuleValue, className, throwOnError, ignoreCase,
                (ModuleValueLambda, classNameLambda, throwOnErrorLambda, ignoreCaseLambda) =>
                    ModuleValueLambda.GetType(classNameLambda, throwOnErrorLambda, ignoreCaseLambda));
        }


        public static IObservable<System.Type[]> FindTypes(this IObservable<System.Reflection.Module> ModuleValue,
            IObservable<System.Reflection.TypeFilter> filter, IObservable<System.Object> filterCriteria)
        {
            return Observable.Zip(ModuleValue, filter, filterCriteria,
                (ModuleValueLambda, filterLambda, filterCriteriaLambda) =>
                    ModuleValueLambda.FindTypes(filterLambda, filterCriteriaLambda));
        }


        public static IObservable<System.Type[]> GetTypes(this IObservable<System.Reflection.Module> ModuleValue)
        {
            return Observable.Select(ModuleValue, (ModuleValueLambda) => ModuleValueLambda.GetTypes());
        }


        public static IObservable<System.Boolean> IsResource(this IObservable<System.Reflection.Module> ModuleValue)
        {
            return Observable.Select(ModuleValue, (ModuleValueLambda) => ModuleValueLambda.IsResource());
        }


        public static IObservable<System.Reflection.FieldInfo[]> GetFields(
            this IObservable<System.Reflection.Module> ModuleValue)
        {
            return Observable.Select(ModuleValue, (ModuleValueLambda) => ModuleValueLambda.GetFields());
        }


        public static IObservable<System.Reflection.FieldInfo[]> GetFields(
            this IObservable<System.Reflection.Module> ModuleValue,
            IObservable<System.Reflection.BindingFlags> bindingFlags)
        {
            return Observable.Zip(ModuleValue, bindingFlags,
                (ModuleValueLambda, bindingFlagsLambda) => ModuleValueLambda.GetFields(bindingFlagsLambda));
        }


        public static IObservable<System.Reflection.FieldInfo> GetField(
            this IObservable<System.Reflection.Module> ModuleValue, IObservable<System.String> name)
        {
            return Observable.Zip(ModuleValue, name,
                (ModuleValueLambda, nameLambda) => ModuleValueLambda.GetField(nameLambda));
        }


        public static IObservable<System.Reflection.FieldInfo> GetField(
            this IObservable<System.Reflection.Module> ModuleValue, IObservable<System.String> name,
            IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(ModuleValue, name, bindingAttr,
                (ModuleValueLambda, nameLambda, bindingAttrLambda) =>
                    ModuleValueLambda.GetField(nameLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.MethodInfo[]> GetMethods(
            this IObservable<System.Reflection.Module> ModuleValue)
        {
            return Observable.Select(ModuleValue, (ModuleValueLambda) => ModuleValueLambda.GetMethods());
        }


        public static IObservable<System.Reflection.MethodInfo[]> GetMethods(
            this IObservable<System.Reflection.Module> ModuleValue,
            IObservable<System.Reflection.BindingFlags> bindingFlags)
        {
            return Observable.Zip(ModuleValue, bindingFlags,
                (ModuleValueLambda, bindingFlagsLambda) => ModuleValueLambda.GetMethods(bindingFlagsLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetMethod(
            this IObservable<System.Reflection.Module> ModuleValue, IObservable<System.String> name,
            IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder,
            IObservable<System.Reflection.CallingConventions> callConvention, IObservable<System.Type[]> types,
            IObservable<System.Reflection.ParameterModifier[]> modifiers)
        {
            return Observable.Zip(ModuleValue, name, bindingAttr, binder, callConvention, types, modifiers,
                (ModuleValueLambda, nameLambda, bindingAttrLambda, binderLambda, callConventionLambda, typesLambda,
                    modifiersLambda) =>
                    ModuleValueLambda.GetMethod(nameLambda, bindingAttrLambda, binderLambda, callConventionLambda,
                        typesLambda, modifiersLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetMethod(
            this IObservable<System.Reflection.Module> ModuleValue, IObservable<System.String> name,
            IObservable<System.Type[]> types)
        {
            return Observable.Zip(ModuleValue, name, types,
                (ModuleValueLambda, nameLambda, typesLambda) => ModuleValueLambda.GetMethod(nameLambda, typesLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetMethod(
            this IObservable<System.Reflection.Module> ModuleValue, IObservable<System.String> name)
        {
            return Observable.Zip(ModuleValue, name,
                (ModuleValueLambda, nameLambda) => ModuleValueLambda.GetMethod(nameLambda));
        }


        public static IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> GetSignerCertificate(
            this IObservable<System.Reflection.Module> ModuleValue)
        {
            return Observable.Select(ModuleValue, (ModuleValueLambda) => ModuleValueLambda.GetSignerCertificate());
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>>
            get_CustomAttributes(this IObservable<System.Reflection.Module> ModuleValue)
        {
            return Observable.Select(ModuleValue, (ModuleValueLambda) => ModuleValueLambda.CustomAttributes);
        }


        public static IObservable<System.Int32> get_MDStreamVersion(
            this IObservable<System.Reflection.Module> ModuleValue)
        {
            return Observable.Select(ModuleValue, (ModuleValueLambda) => ModuleValueLambda.MDStreamVersion);
        }


        public static IObservable<System.String> get_FullyQualifiedName(
            this IObservable<System.Reflection.Module> ModuleValue)
        {
            return Observable.Select(ModuleValue, (ModuleValueLambda) => ModuleValueLambda.FullyQualifiedName);
        }


        public static IObservable<System.Guid> get_ModuleVersionId(
            this IObservable<System.Reflection.Module> ModuleValue)
        {
            return Observable.Select(ModuleValue, (ModuleValueLambda) => ModuleValueLambda.ModuleVersionId);
        }


        public static IObservable<System.Int32> get_MetadataToken(this IObservable<System.Reflection.Module> ModuleValue)
        {
            return Observable.Select(ModuleValue, (ModuleValueLambda) => ModuleValueLambda.MetadataToken);
        }


        public static IObservable<System.String> get_ScopeName(this IObservable<System.Reflection.Module> ModuleValue)
        {
            return Observable.Select(ModuleValue, (ModuleValueLambda) => ModuleValueLambda.ScopeName);
        }


        public static IObservable<System.String> get_Name(this IObservable<System.Reflection.Module> ModuleValue)
        {
            return Observable.Select(ModuleValue, (ModuleValueLambda) => ModuleValueLambda.Name);
        }


        public static IObservable<System.Reflection.Assembly> get_Assembly(
            this IObservable<System.Reflection.Module> ModuleValue)
        {
            return Observable.Select(ModuleValue, (ModuleValueLambda) => ModuleValueLambda.Assembly);
        }


        public static IObservable<System.ModuleHandle> get_ModuleHandle(
            this IObservable<System.Reflection.Module> ModuleValue)
        {
            return Observable.Select(ModuleValue, (ModuleValueLambda) => ModuleValueLambda.ModuleHandle);
        }
    }
}