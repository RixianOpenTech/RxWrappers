using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
    public static class __ConstructorBuilder
    {
        
        public static IObservable<System.String> ToString(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue)
        {
            return Observable.Select(ConstructorBuilderValue, (ConstructorBuilderValueLambda) => ConstructorBuilderValueLambda.ToString());
        }


        public static IObservable<System.Object> Invoke(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue, IObservable<System.Object> obj, IObservable<System.Reflection.BindingFlags> invokeAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object[]> parameters, IObservable<System.Globalization.CultureInfo> culture)
        {
            return Observable.Zip(ConstructorBuilderValue, obj, invokeAttr, binder, parameters, culture, (ConstructorBuilderValueLambda, objLambda, invokeAttrLambda, binderLambda, parametersLambda, cultureLambda) => ConstructorBuilderValueLambda.Invoke(objLambda, invokeAttrLambda, binderLambda, parametersLambda, cultureLambda));
        }


        public static IObservable<System.Reflection.ParameterInfo[]> GetParameters(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue)
        {
            return Observable.Select(ConstructorBuilderValue, (ConstructorBuilderValueLambda) => ConstructorBuilderValueLambda.GetParameters());
        }


        public static IObservable<System.Reflection.MethodImplAttributes> GetMethodImplementationFlags(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue)
        {
            return Observable.Select(ConstructorBuilderValue, (ConstructorBuilderValueLambda) => ConstructorBuilderValueLambda.GetMethodImplementationFlags());
        }


        public static IObservable<System.Object> Invoke(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue, IObservable<System.Reflection.BindingFlags> invokeAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object[]> parameters, IObservable<System.Globalization.CultureInfo> culture)
        {
            return Observable.Zip(ConstructorBuilderValue, invokeAttr, binder, parameters, culture, (ConstructorBuilderValueLambda, invokeAttrLambda, binderLambda, parametersLambda, cultureLambda) => ConstructorBuilderValueLambda.Invoke(invokeAttrLambda, binderLambda, parametersLambda, cultureLambda));
        }


        public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(ConstructorBuilderValue, inherit, (ConstructorBuilderValueLambda, inheritLambda) => ConstructorBuilderValueLambda.GetCustomAttributes(inheritLambda));
        }


        public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(ConstructorBuilderValue, attributeType, inherit, (ConstructorBuilderValueLambda, attributeTypeLambda, inheritLambda) => ConstructorBuilderValueLambda.GetCustomAttributes(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Boolean> IsDefined(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(ConstructorBuilderValue, attributeType, inherit, (ConstructorBuilderValueLambda, attributeTypeLambda, inheritLambda) => ConstructorBuilderValueLambda.IsDefined(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Reflection.Emit.MethodToken> GetToken(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue)
        {
            return Observable.Select(ConstructorBuilderValue, (ConstructorBuilderValueLambda) => ConstructorBuilderValueLambda.GetToken());
        }


        public static IObservable<System.Reflection.Emit.ParameterBuilder> DefineParameter(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue, IObservable<System.Int32> iSequence, IObservable<System.Reflection.ParameterAttributes> attributes, IObservable<System.String> strParamName)
        {
            return Observable.Zip(ConstructorBuilderValue, iSequence, attributes, strParamName, (ConstructorBuilderValueLambda, iSequenceLambda, attributesLambda, strParamNameLambda) => ConstructorBuilderValueLambda.DefineParameter(iSequenceLambda, attributesLambda, strParamNameLambda));
        }


        public static IObservable<System.Reactive.Unit> SetSymCustomAttribute(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue, IObservable<System.String> name, IObservable<System.Byte[]> data)
        {
            return ObservableExt.ZipExecute(ConstructorBuilderValue, name, data, (ConstructorBuilderValueLambda, nameLambda, dataLambda) => ConstructorBuilderValueLambda.SetSymCustomAttribute(nameLambda, dataLambda));
        }


        public static IObservable<System.Reflection.Emit.ILGenerator> GetILGenerator(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue)
        {
            return Observable.Select(ConstructorBuilderValue, (ConstructorBuilderValueLambda) => ConstructorBuilderValueLambda.GetILGenerator());
        }


        public static IObservable<System.Reflection.Emit.ILGenerator> GetILGenerator(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue, IObservable<System.Int32> streamSize)
        {
            return Observable.Zip(ConstructorBuilderValue, streamSize, (ConstructorBuilderValueLambda, streamSizeLambda) => ConstructorBuilderValueLambda.GetILGenerator(streamSizeLambda));
        }


        public static IObservable<System.Reactive.Unit> SetMethodBody(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue, IObservable<System.Byte[]> il, IObservable<System.Int32> maxStack, IObservable<System.Byte[]> localSignature, IObservable<System.Collections.Generic.IEnumerable<System.Reflection.Emit.ExceptionHandler>> exceptionHandlers, IObservable<System.Collections.Generic.IEnumerable<System.Int32>> tokenFixups)
        {
            return ObservableExt.ZipExecute(ConstructorBuilderValue, il, maxStack, localSignature, exceptionHandlers, tokenFixups, (ConstructorBuilderValueLambda, ilLambda, maxStackLambda, localSignatureLambda, exceptionHandlersLambda, tokenFixupsLambda) => ConstructorBuilderValueLambda.SetMethodBody(ilLambda, maxStackLambda, localSignatureLambda, exceptionHandlersLambda, tokenFixupsLambda));
        }


        public static IObservable<System.Reactive.Unit> AddDeclarativeSecurity(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue, IObservable<System.Security.Permissions.SecurityAction> action, IObservable<System.Security.PermissionSet> pset)
        {
            return ObservableExt.ZipExecute(ConstructorBuilderValue, action, pset, (ConstructorBuilderValueLambda, actionLambda, psetLambda) => ConstructorBuilderValueLambda.AddDeclarativeSecurity(actionLambda, psetLambda));
        }


        public static IObservable<System.Reflection.Module> GetModule(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue)
        {
            return Observable.Select(ConstructorBuilderValue, (ConstructorBuilderValueLambda) => ConstructorBuilderValueLambda.GetModule());
        }


        public static IObservable<System.Reactive.Unit> SetCustomAttribute(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue, IObservable<System.Reflection.ConstructorInfo> con, IObservable<System.Byte[]> binaryAttribute)
        {
            return ObservableExt.ZipExecute(ConstructorBuilderValue, con, binaryAttribute, (ConstructorBuilderValueLambda, conLambda, binaryAttributeLambda) => ConstructorBuilderValueLambda.SetCustomAttribute(conLambda, binaryAttributeLambda));
        }


        public static IObservable<System.Reactive.Unit> SetCustomAttribute(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue, IObservable<System.Reflection.Emit.CustomAttributeBuilder> customBuilder)
        {
            return ObservableExt.ZipExecute(ConstructorBuilderValue, customBuilder, (ConstructorBuilderValueLambda, customBuilderLambda) => ConstructorBuilderValueLambda.SetCustomAttribute(customBuilderLambda));
        }


        public static IObservable<System.Reactive.Unit> SetImplementationFlags(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue, IObservable<System.Reflection.MethodImplAttributes> attributes)
        {
            return ObservableExt.ZipExecute(ConstructorBuilderValue, attributes, (ConstructorBuilderValueLambda, attributesLambda) => ConstructorBuilderValueLambda.SetImplementationFlags(attributesLambda));
        }


        public static IObservable<System.Reflection.Module> get_Module(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue)
        {
            return Observable.Select(ConstructorBuilderValue, (ConstructorBuilderValueLambda) => ConstructorBuilderValueLambda.Module);
        }


        public static IObservable<System.Type> get_ReflectedType(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue)
        {
            return Observable.Select(ConstructorBuilderValue, (ConstructorBuilderValueLambda) => ConstructorBuilderValueLambda.ReflectedType);
        }


        public static IObservable<System.Type> get_DeclaringType(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue)
        {
            return Observable.Select(ConstructorBuilderValue, (ConstructorBuilderValueLambda) => ConstructorBuilderValueLambda.DeclaringType);
        }


        public static IObservable<System.String> get_Name(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue)
        {
            return Observable.Select(ConstructorBuilderValue, (ConstructorBuilderValueLambda) => ConstructorBuilderValueLambda.Name);
        }


        public static IObservable<System.Reflection.MethodAttributes> get_Attributes(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue)
        {
            return Observable.Select(ConstructorBuilderValue, (ConstructorBuilderValueLambda) => ConstructorBuilderValueLambda.Attributes);
        }


        public static IObservable<System.RuntimeMethodHandle> get_MethodHandle(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue)
        {
            return Observable.Select(ConstructorBuilderValue, (ConstructorBuilderValueLambda) => ConstructorBuilderValueLambda.MethodHandle);
        }


        public static IObservable<System.Reflection.CallingConventions> get_CallingConvention(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue)
        {
            return Observable.Select(ConstructorBuilderValue, (ConstructorBuilderValueLambda) => ConstructorBuilderValueLambda.CallingConvention);
        }


        public static IObservable<System.Type> get_ReturnType(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue)
        {
            return Observable.Select(ConstructorBuilderValue, (ConstructorBuilderValueLambda) => ConstructorBuilderValueLambda.ReturnType);
        }


        public static IObservable<System.String> get_Signature(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue)
        {
            return Observable.Select(ConstructorBuilderValue, (ConstructorBuilderValueLambda) => ConstructorBuilderValueLambda.Signature);
        }


        public static IObservable<System.Boolean> get_InitLocals(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue)
        {
            return Observable.Select(ConstructorBuilderValue, (ConstructorBuilderValueLambda) => ConstructorBuilderValueLambda.InitLocals);
        }


        public static IObservable<System.Reactive.Unit> set_InitLocals(this IObservable<System.Reflection.Emit.ConstructorBuilder> ConstructorBuilderValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(ConstructorBuilderValue, value, (ConstructorBuilderValueLambda, valueLambda) => ConstructorBuilderValueLambda.InitLocals = valueLambda);
        }

    }
}