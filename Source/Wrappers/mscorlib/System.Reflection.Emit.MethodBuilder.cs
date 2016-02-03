using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
    public static class __MethodBuilder
    {
        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(MethodBuilderValue, obj,
                (MethodBuilderValueLambda, objLambda) => MethodBuilderValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue,
                (MethodBuilderValueLambda) => MethodBuilderValueLambda.GetHashCode());
        }


        public static IObservable<System.String> ToString(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue,
                (MethodBuilderValueLambda) => MethodBuilderValueLambda.ToString());
        }


        public static IObservable<System.Object> Invoke(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue, IObservable<System.Object> obj,
            IObservable<System.Reflection.BindingFlags> invokeAttr, IObservable<System.Reflection.Binder> binder,
            IObservable<System.Object[]> parameters, IObservable<System.Globalization.CultureInfo> culture)
        {
            return Observable.Zip(MethodBuilderValue, obj, invokeAttr, binder, parameters, culture,
                (MethodBuilderValueLambda, objLambda, invokeAttrLambda, binderLambda, parametersLambda, cultureLambda)
                    =>
                    MethodBuilderValueLambda.Invoke(objLambda, invokeAttrLambda, binderLambda, parametersLambda,
                        cultureLambda));
        }


        public static IObservable<System.Reflection.MethodImplAttributes> GetMethodImplementationFlags(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue,
                (MethodBuilderValueLambda) => MethodBuilderValueLambda.GetMethodImplementationFlags());
        }


        public static IObservable<System.Reflection.MethodInfo> GetBaseDefinition(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue,
                (MethodBuilderValueLambda) => MethodBuilderValueLambda.GetBaseDefinition());
        }


        public static IObservable<System.Reflection.ParameterInfo[]> GetParameters(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue,
                (MethodBuilderValueLambda) => MethodBuilderValueLambda.GetParameters());
        }


        public static IObservable<System.Object[]> GetCustomAttributes(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue,
            IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(MethodBuilderValue, inherit,
                (MethodBuilderValueLambda, inheritLambda) => MethodBuilderValueLambda.GetCustomAttributes(inheritLambda));
        }


        public static IObservable<System.Object[]> GetCustomAttributes(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue,
            IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(MethodBuilderValue, attributeType, inherit,
                (MethodBuilderValueLambda, attributeTypeLambda, inheritLambda) =>
                    MethodBuilderValueLambda.GetCustomAttributes(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Boolean> IsDefined(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue,
            IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(MethodBuilderValue, attributeType, inherit,
                (MethodBuilderValueLambda, attributeTypeLambda, inheritLambda) =>
                    MethodBuilderValueLambda.IsDefined(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetGenericMethodDefinition(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue,
                (MethodBuilderValueLambda) => MethodBuilderValueLambda.GetGenericMethodDefinition());
        }


        public static IObservable<System.Type[]> GetGenericArguments(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue,
                (MethodBuilderValueLambda) => MethodBuilderValueLambda.GetGenericArguments());
        }


        public static IObservable<System.Reflection.MethodInfo> MakeGenericMethod(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue,
            IObservable<System.Type[]> typeArguments)
        {
            return Observable.Zip(MethodBuilderValue, typeArguments,
                (MethodBuilderValueLambda, typeArgumentsLambda) =>
                    MethodBuilderValueLambda.MakeGenericMethod(typeArgumentsLambda));
        }


        public static IObservable<System.Reflection.Emit.GenericTypeParameterBuilder[]> DefineGenericParameters(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue,
            IObservable<System.String[]> names)
        {
            return Observable.Zip(MethodBuilderValue, names,
                (MethodBuilderValueLambda, namesLambda) => MethodBuilderValueLambda.DefineGenericParameters(namesLambda));
        }


        public static IObservable<System.Reflection.Emit.MethodToken> GetToken(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue,
                (MethodBuilderValueLambda) => MethodBuilderValueLambda.GetToken());
        }


        public static IObservable<System.Reactive.Unit> SetParameters(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue,
            IObservable<System.Type[]> parameterTypes)
        {
            return ObservableExt.ZipExecute(MethodBuilderValue, parameterTypes,
                (MethodBuilderValueLambda, parameterTypesLambda) =>
                    MethodBuilderValueLambda.SetParameters(parameterTypesLambda));
        }


        public static IObservable<System.Reactive.Unit> SetReturnType(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue,
            IObservable<System.Type> returnType)
        {
            return ObservableExt.ZipExecute(MethodBuilderValue, returnType,
                (MethodBuilderValueLambda, returnTypeLambda) => MethodBuilderValueLambda.SetReturnType(returnTypeLambda));
        }


        public static IObservable<System.Reactive.Unit> SetSignature(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue,
            IObservable<System.Type> returnType, IObservable<System.Type[]> returnTypeRequiredCustomModifiers,
            IObservable<System.Type[]> returnTypeOptionalCustomModifiers, IObservable<System.Type[]> parameterTypes,
            IObservable<System.Type[][]> parameterTypeRequiredCustomModifiers,
            IObservable<System.Type[][]> parameterTypeOptionalCustomModifiers)
        {
            return ObservableExt.ZipExecute(MethodBuilderValue, returnType, returnTypeRequiredCustomModifiers,
                returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers,
                parameterTypeOptionalCustomModifiers,
                (MethodBuilderValueLambda, returnTypeLambda, returnTypeRequiredCustomModifiersLambda,
                    returnTypeOptionalCustomModifiersLambda, parameterTypesLambda,
                    parameterTypeRequiredCustomModifiersLambda, parameterTypeOptionalCustomModifiersLambda) =>
                    MethodBuilderValueLambda.SetSignature(returnTypeLambda, returnTypeRequiredCustomModifiersLambda,
                        returnTypeOptionalCustomModifiersLambda, parameterTypesLambda,
                        parameterTypeRequiredCustomModifiersLambda, parameterTypeOptionalCustomModifiersLambda));
        }


        public static IObservable<System.Reflection.Emit.ParameterBuilder> DefineParameter(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue,
            IObservable<System.Int32> position, IObservable<System.Reflection.ParameterAttributes> attributes,
            IObservable<System.String> strParamName)
        {
            return Observable.Zip(MethodBuilderValue, position, attributes, strParamName,
                (MethodBuilderValueLambda, positionLambda, attributesLambda, strParamNameLambda) =>
                    MethodBuilderValueLambda.DefineParameter(positionLambda, attributesLambda, strParamNameLambda));
        }


        public static IObservable<System.Reactive.Unit> SetMarshal(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue,
            IObservable<System.Reflection.Emit.UnmanagedMarshal> unmanagedMarshal)
        {
            return ObservableExt.ZipExecute(MethodBuilderValue, unmanagedMarshal,
                (MethodBuilderValueLambda, unmanagedMarshalLambda) =>
                    MethodBuilderValueLambda.SetMarshal(unmanagedMarshalLambda));
        }


        public static IObservable<System.Reactive.Unit> SetSymCustomAttribute(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue, IObservable<System.String> name,
            IObservable<System.Byte[]> data)
        {
            return ObservableExt.ZipExecute(MethodBuilderValue, name, data,
                (MethodBuilderValueLambda, nameLambda, dataLambda) =>
                    MethodBuilderValueLambda.SetSymCustomAttribute(nameLambda, dataLambda));
        }


        public static IObservable<System.Reactive.Unit> AddDeclarativeSecurity(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue,
            IObservable<System.Security.Permissions.SecurityAction> action,
            IObservable<System.Security.PermissionSet> pset)
        {
            return ObservableExt.ZipExecute(MethodBuilderValue, action, pset,
                (MethodBuilderValueLambda, actionLambda, psetLambda) =>
                    MethodBuilderValueLambda.AddDeclarativeSecurity(actionLambda, psetLambda));
        }


        public static IObservable<System.Reactive.Unit> SetMethodBody(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue, IObservable<System.Byte[]> il,
            IObservable<System.Int32> maxStack, IObservable<System.Byte[]> localSignature,
            IObservable<System.Collections.Generic.IEnumerable<System.Reflection.Emit.ExceptionHandler>>
                exceptionHandlers, IObservable<System.Collections.Generic.IEnumerable<System.Int32>> tokenFixups)
        {
            return ObservableExt.ZipExecute(MethodBuilderValue, il, maxStack, localSignature, exceptionHandlers,
                tokenFixups,
                (MethodBuilderValueLambda, ilLambda, maxStackLambda, localSignatureLambda, exceptionHandlersLambda,
                    tokenFixupsLambda) =>
                    MethodBuilderValueLambda.SetMethodBody(ilLambda, maxStackLambda, localSignatureLambda,
                        exceptionHandlersLambda, tokenFixupsLambda));
        }


        public static IObservable<System.Reactive.Unit> CreateMethodBody(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue, IObservable<System.Byte[]> il,
            IObservable<System.Int32> count)
        {
            return ObservableExt.ZipExecute(MethodBuilderValue, il, count,
                (MethodBuilderValueLambda, ilLambda, countLambda) =>
                    MethodBuilderValueLambda.CreateMethodBody(ilLambda, countLambda));
        }


        public static IObservable<System.Reactive.Unit> SetImplementationFlags(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue,
            IObservable<System.Reflection.MethodImplAttributes> attributes)
        {
            return ObservableExt.ZipExecute(MethodBuilderValue, attributes,
                (MethodBuilderValueLambda, attributesLambda) =>
                    MethodBuilderValueLambda.SetImplementationFlags(attributesLambda));
        }


        public static IObservable<System.Reflection.Emit.ILGenerator> GetILGenerator(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue,
                (MethodBuilderValueLambda) => MethodBuilderValueLambda.GetILGenerator());
        }


        public static IObservable<System.Reflection.Emit.ILGenerator> GetILGenerator(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue, IObservable<System.Int32> size)
        {
            return Observable.Zip(MethodBuilderValue, size,
                (MethodBuilderValueLambda, sizeLambda) => MethodBuilderValueLambda.GetILGenerator(sizeLambda));
        }


        public static IObservable<System.Reflection.Module> GetModule(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue,
                (MethodBuilderValueLambda) => MethodBuilderValueLambda.GetModule());
        }


        public static IObservable<System.Reactive.Unit> SetCustomAttribute(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue,
            IObservable<System.Reflection.ConstructorInfo> con, IObservable<System.Byte[]> binaryAttribute)
        {
            return ObservableExt.ZipExecute(MethodBuilderValue, con, binaryAttribute,
                (MethodBuilderValueLambda, conLambda, binaryAttributeLambda) =>
                    MethodBuilderValueLambda.SetCustomAttribute(conLambda, binaryAttributeLambda));
        }


        public static IObservable<System.Reactive.Unit> SetCustomAttribute(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue,
            IObservable<System.Reflection.Emit.CustomAttributeBuilder> customBuilder)
        {
            return ObservableExt.ZipExecute(MethodBuilderValue, customBuilder,
                (MethodBuilderValueLambda, customBuilderLambda) =>
                    MethodBuilderValueLambda.SetCustomAttribute(customBuilderLambda));
        }


        public static IObservable<System.String> get_Name(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue, (MethodBuilderValueLambda) => MethodBuilderValueLambda.Name);
        }


        public static IObservable<System.Reflection.Module> get_Module(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue, (MethodBuilderValueLambda) => MethodBuilderValueLambda.Module);
        }


        public static IObservable<System.Type> get_DeclaringType(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue,
                (MethodBuilderValueLambda) => MethodBuilderValueLambda.DeclaringType);
        }


        public static IObservable<System.Reflection.ICustomAttributeProvider> get_ReturnTypeCustomAttributes(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue,
                (MethodBuilderValueLambda) => MethodBuilderValueLambda.ReturnTypeCustomAttributes);
        }


        public static IObservable<System.Type> get_ReflectedType(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue,
                (MethodBuilderValueLambda) => MethodBuilderValueLambda.ReflectedType);
        }


        public static IObservable<System.Reflection.MethodAttributes> get_Attributes(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue,
                (MethodBuilderValueLambda) => MethodBuilderValueLambda.Attributes);
        }


        public static IObservable<System.Reflection.CallingConventions> get_CallingConvention(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue,
                (MethodBuilderValueLambda) => MethodBuilderValueLambda.CallingConvention);
        }


        public static IObservable<System.RuntimeMethodHandle> get_MethodHandle(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue,
                (MethodBuilderValueLambda) => MethodBuilderValueLambda.MethodHandle);
        }


        public static IObservable<System.Boolean> get_IsSecurityCritical(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue,
                (MethodBuilderValueLambda) => MethodBuilderValueLambda.IsSecurityCritical);
        }


        public static IObservable<System.Boolean> get_IsSecuritySafeCritical(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue,
                (MethodBuilderValueLambda) => MethodBuilderValueLambda.IsSecuritySafeCritical);
        }


        public static IObservable<System.Boolean> get_IsSecurityTransparent(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue,
                (MethodBuilderValueLambda) => MethodBuilderValueLambda.IsSecurityTransparent);
        }


        public static IObservable<System.Type> get_ReturnType(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue,
                (MethodBuilderValueLambda) => MethodBuilderValueLambda.ReturnType);
        }


        public static IObservable<System.Reflection.ParameterInfo> get_ReturnParameter(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue,
                (MethodBuilderValueLambda) => MethodBuilderValueLambda.ReturnParameter);
        }


        public static IObservable<System.Boolean> get_IsGenericMethodDefinition(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue,
                (MethodBuilderValueLambda) => MethodBuilderValueLambda.IsGenericMethodDefinition);
        }


        public static IObservable<System.Boolean> get_ContainsGenericParameters(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue,
                (MethodBuilderValueLambda) => MethodBuilderValueLambda.ContainsGenericParameters);
        }


        public static IObservable<System.Boolean> get_IsGenericMethod(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue,
                (MethodBuilderValueLambda) => MethodBuilderValueLambda.IsGenericMethod);
        }


        public static IObservable<System.Boolean> get_InitLocals(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue,
                (MethodBuilderValueLambda) => MethodBuilderValueLambda.InitLocals);
        }


        public static IObservable<System.String> get_Signature(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue)
        {
            return Observable.Select(MethodBuilderValue,
                (MethodBuilderValueLambda) => MethodBuilderValueLambda.Signature);
        }


        public static IObservable<System.Reactive.Unit> set_InitLocals(
            this IObservable<System.Reflection.Emit.MethodBuilder> MethodBuilderValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(MethodBuilderValue, value,
                (MethodBuilderValueLambda, valueLambda) => MethodBuilderValueLambda.InitLocals = valueLambda);
        }
    }
}