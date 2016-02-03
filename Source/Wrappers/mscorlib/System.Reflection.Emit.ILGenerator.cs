using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
    public static class __ILGenerator
    {
        public static IObservable<System.Reactive.Unit> Emit(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue,
            IObservable<System.Reflection.Emit.OpCode> opcode)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, opcode,
                (ILGeneratorValueLambda, opcodeLambda) => ILGeneratorValueLambda.Emit(opcodeLambda));
        }


        public static IObservable<System.Reactive.Unit> Emit(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue,
            IObservable<System.Reflection.Emit.OpCode> opcode, IObservable<System.Byte> arg)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, opcode, arg,
                (ILGeneratorValueLambda, opcodeLambda, argLambda) =>
                    ILGeneratorValueLambda.Emit(opcodeLambda, argLambda));
        }


        public static IObservable<System.Reactive.Unit> Emit(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue,
            IObservable<System.Reflection.Emit.OpCode> opcode, IObservable<System.SByte> arg)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, opcode, arg,
                (ILGeneratorValueLambda, opcodeLambda, argLambda) =>
                    ILGeneratorValueLambda.Emit(opcodeLambda, argLambda));
        }


        public static IObservable<System.Reactive.Unit> Emit(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue,
            IObservable<System.Reflection.Emit.OpCode> opcode, IObservable<System.Int16> arg)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, opcode, arg,
                (ILGeneratorValueLambda, opcodeLambda, argLambda) =>
                    ILGeneratorValueLambda.Emit(opcodeLambda, argLambda));
        }


        public static IObservable<System.Reactive.Unit> Emit(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue,
            IObservable<System.Reflection.Emit.OpCode> opcode, IObservable<System.Int32> arg)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, opcode, arg,
                (ILGeneratorValueLambda, opcodeLambda, argLambda) =>
                    ILGeneratorValueLambda.Emit(opcodeLambda, argLambda));
        }


        public static IObservable<System.Reactive.Unit> Emit(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue,
            IObservable<System.Reflection.Emit.OpCode> opcode, IObservable<System.Reflection.MethodInfo> meth)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, opcode, meth,
                (ILGeneratorValueLambda, opcodeLambda, methLambda) =>
                    ILGeneratorValueLambda.Emit(opcodeLambda, methLambda));
        }


        public static IObservable<System.Reactive.Unit> EmitCalli(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue,
            IObservable<System.Reflection.Emit.OpCode> opcode,
            IObservable<System.Reflection.CallingConventions> callingConvention, IObservable<System.Type> returnType,
            IObservable<System.Type[]> parameterTypes, IObservable<System.Type[]> optionalParameterTypes)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, opcode, callingConvention, returnType, parameterTypes,
                optionalParameterTypes,
                (ILGeneratorValueLambda, opcodeLambda, callingConventionLambda, returnTypeLambda, parameterTypesLambda,
                    optionalParameterTypesLambda) =>
                    ILGeneratorValueLambda.EmitCalli(opcodeLambda, callingConventionLambda, returnTypeLambda,
                        parameterTypesLambda, optionalParameterTypesLambda));
        }


        public static IObservable<System.Reactive.Unit> EmitCalli(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue,
            IObservable<System.Reflection.Emit.OpCode> opcode,
            IObservable<System.Runtime.InteropServices.CallingConvention> unmanagedCallConv,
            IObservable<System.Type> returnType, IObservable<System.Type[]> parameterTypes)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, opcode, unmanagedCallConv, returnType, parameterTypes,
                (ILGeneratorValueLambda, opcodeLambda, unmanagedCallConvLambda, returnTypeLambda, parameterTypesLambda)
                    =>
                    ILGeneratorValueLambda.EmitCalli(opcodeLambda, unmanagedCallConvLambda, returnTypeLambda,
                        parameterTypesLambda));
        }


        public static IObservable<System.Reactive.Unit> EmitCall(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue,
            IObservable<System.Reflection.Emit.OpCode> opcode, IObservable<System.Reflection.MethodInfo> methodInfo,
            IObservable<System.Type[]> optionalParameterTypes)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, opcode, methodInfo, optionalParameterTypes,
                (ILGeneratorValueLambda, opcodeLambda, methodInfoLambda, optionalParameterTypesLambda) =>
                    ILGeneratorValueLambda.EmitCall(opcodeLambda, methodInfoLambda, optionalParameterTypesLambda));
        }


        public static IObservable<System.Reactive.Unit> Emit(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue,
            IObservable<System.Reflection.Emit.OpCode> opcode,
            IObservable<System.Reflection.Emit.SignatureHelper> signature)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, opcode, signature,
                (ILGeneratorValueLambda, opcodeLambda, signatureLambda) =>
                    ILGeneratorValueLambda.Emit(opcodeLambda, signatureLambda));
        }


        public static IObservable<System.Reactive.Unit> Emit(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue,
            IObservable<System.Reflection.Emit.OpCode> opcode, IObservable<System.Reflection.ConstructorInfo> con)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, opcode, con,
                (ILGeneratorValueLambda, opcodeLambda, conLambda) =>
                    ILGeneratorValueLambda.Emit(opcodeLambda, conLambda));
        }


        public static IObservable<System.Reactive.Unit> Emit(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue,
            IObservable<System.Reflection.Emit.OpCode> opcode, IObservable<System.Type> cls)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, opcode, cls,
                (ILGeneratorValueLambda, opcodeLambda, clsLambda) =>
                    ILGeneratorValueLambda.Emit(opcodeLambda, clsLambda));
        }


        public static IObservable<System.Reactive.Unit> Emit(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue,
            IObservable<System.Reflection.Emit.OpCode> opcode, IObservable<System.Int64> arg)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, opcode, arg,
                (ILGeneratorValueLambda, opcodeLambda, argLambda) =>
                    ILGeneratorValueLambda.Emit(opcodeLambda, argLambda));
        }


        public static IObservable<System.Reactive.Unit> Emit(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue,
            IObservable<System.Reflection.Emit.OpCode> opcode, IObservable<System.Single> arg)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, opcode, arg,
                (ILGeneratorValueLambda, opcodeLambda, argLambda) =>
                    ILGeneratorValueLambda.Emit(opcodeLambda, argLambda));
        }


        public static IObservable<System.Reactive.Unit> Emit(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue,
            IObservable<System.Reflection.Emit.OpCode> opcode, IObservable<System.Double> arg)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, opcode, arg,
                (ILGeneratorValueLambda, opcodeLambda, argLambda) =>
                    ILGeneratorValueLambda.Emit(opcodeLambda, argLambda));
        }


        public static IObservable<System.Reactive.Unit> Emit(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue,
            IObservable<System.Reflection.Emit.OpCode> opcode, IObservable<System.Reflection.Emit.Label> label)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, opcode, label,
                (ILGeneratorValueLambda, opcodeLambda, labelLambda) =>
                    ILGeneratorValueLambda.Emit(opcodeLambda, labelLambda));
        }


        public static IObservable<System.Reactive.Unit> Emit(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue,
            IObservable<System.Reflection.Emit.OpCode> opcode, IObservable<System.Reflection.Emit.Label[]> labels)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, opcode, labels,
                (ILGeneratorValueLambda, opcodeLambda, labelsLambda) =>
                    ILGeneratorValueLambda.Emit(opcodeLambda, labelsLambda));
        }


        public static IObservable<System.Reactive.Unit> Emit(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue,
            IObservable<System.Reflection.Emit.OpCode> opcode, IObservable<System.Reflection.FieldInfo> field)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, opcode, field,
                (ILGeneratorValueLambda, opcodeLambda, fieldLambda) =>
                    ILGeneratorValueLambda.Emit(opcodeLambda, fieldLambda));
        }


        public static IObservable<System.Reactive.Unit> Emit(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue,
            IObservable<System.Reflection.Emit.OpCode> opcode, IObservable<System.String> str)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, opcode, str,
                (ILGeneratorValueLambda, opcodeLambda, strLambda) =>
                    ILGeneratorValueLambda.Emit(opcodeLambda, strLambda));
        }


        public static IObservable<System.Reactive.Unit> Emit(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue,
            IObservable<System.Reflection.Emit.OpCode> opcode, IObservable<System.Reflection.Emit.LocalBuilder> local)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, opcode, local,
                (ILGeneratorValueLambda, opcodeLambda, localLambda) =>
                    ILGeneratorValueLambda.Emit(opcodeLambda, localLambda));
        }


        public static IObservable<System.Reflection.Emit.Label> BeginExceptionBlock(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue)
        {
            return Observable.Select(ILGeneratorValue,
                (ILGeneratorValueLambda) => ILGeneratorValueLambda.BeginExceptionBlock());
        }


        public static IObservable<System.Reactive.Unit> EndExceptionBlock(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue)
        {
            return
                Observable.Do(ILGeneratorValue, (ILGeneratorValueLambda) => ILGeneratorValueLambda.EndExceptionBlock())
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> BeginExceptFilterBlock(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue)
        {
            return
                Observable.Do(ILGeneratorValue,
                    (ILGeneratorValueLambda) => ILGeneratorValueLambda.BeginExceptFilterBlock()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> BeginCatchBlock(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue,
            IObservable<System.Type> exceptionType)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, exceptionType,
                (ILGeneratorValueLambda, exceptionTypeLambda) =>
                    ILGeneratorValueLambda.BeginCatchBlock(exceptionTypeLambda));
        }


        public static IObservable<System.Reactive.Unit> BeginFaultBlock(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue)
        {
            return
                Observable.Do(ILGeneratorValue, (ILGeneratorValueLambda) => ILGeneratorValueLambda.BeginFaultBlock())
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> BeginFinallyBlock(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue)
        {
            return
                Observable.Do(ILGeneratorValue, (ILGeneratorValueLambda) => ILGeneratorValueLambda.BeginFinallyBlock())
                    .ToUnit();
        }


        public static IObservable<System.Reflection.Emit.Label> DefineLabel(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue)
        {
            return Observable.Select(ILGeneratorValue, (ILGeneratorValueLambda) => ILGeneratorValueLambda.DefineLabel());
        }


        public static IObservable<System.Reactive.Unit> MarkLabel(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue,
            IObservable<System.Reflection.Emit.Label> loc)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, loc,
                (ILGeneratorValueLambda, locLambda) => ILGeneratorValueLambda.MarkLabel(locLambda));
        }


        public static IObservable<System.Reactive.Unit> ThrowException(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue, IObservable<System.Type> excType)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, excType,
                (ILGeneratorValueLambda, excTypeLambda) => ILGeneratorValueLambda.ThrowException(excTypeLambda));
        }


        public static IObservable<System.Reactive.Unit> EmitWriteLine(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, value,
                (ILGeneratorValueLambda, valueLambda) => ILGeneratorValueLambda.EmitWriteLine(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> EmitWriteLine(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue,
            IObservable<System.Reflection.Emit.LocalBuilder> localBuilder)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, localBuilder,
                (ILGeneratorValueLambda, localBuilderLambda) => ILGeneratorValueLambda.EmitWriteLine(localBuilderLambda));
        }


        public static IObservable<System.Reactive.Unit> EmitWriteLine(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue,
            IObservable<System.Reflection.FieldInfo> fld)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, fld,
                (ILGeneratorValueLambda, fldLambda) => ILGeneratorValueLambda.EmitWriteLine(fldLambda));
        }


        public static IObservable<System.Reflection.Emit.LocalBuilder> DeclareLocal(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue, IObservable<System.Type> localType)
        {
            return Observable.Zip(ILGeneratorValue, localType,
                (ILGeneratorValueLambda, localTypeLambda) => ILGeneratorValueLambda.DeclareLocal(localTypeLambda));
        }


        public static IObservable<System.Reflection.Emit.LocalBuilder> DeclareLocal(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue, IObservable<System.Type> localType,
            IObservable<System.Boolean> pinned)
        {
            return Observable.Zip(ILGeneratorValue, localType, pinned,
                (ILGeneratorValueLambda, localTypeLambda, pinnedLambda) =>
                    ILGeneratorValueLambda.DeclareLocal(localTypeLambda, pinnedLambda));
        }


        public static IObservable<System.Reactive.Unit> UsingNamespace(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue,
            IObservable<System.String> usingNamespace)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, usingNamespace,
                (ILGeneratorValueLambda, usingNamespaceLambda) =>
                    ILGeneratorValueLambda.UsingNamespace(usingNamespaceLambda));
        }


        public static IObservable<System.Reactive.Unit> MarkSequencePoint(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue,
            IObservable<System.Diagnostics.SymbolStore.ISymbolDocumentWriter> document,
            IObservable<System.Int32> startLine, IObservable<System.Int32> startColumn,
            IObservable<System.Int32> endLine, IObservable<System.Int32> endColumn)
        {
            return ObservableExt.ZipExecute(ILGeneratorValue, document, startLine, startColumn, endLine, endColumn,
                (ILGeneratorValueLambda, documentLambda, startLineLambda, startColumnLambda, endLineLambda,
                    endColumnLambda) =>
                    ILGeneratorValueLambda.MarkSequencePoint(documentLambda, startLineLambda, startColumnLambda,
                        endLineLambda, endColumnLambda));
        }


        public static IObservable<System.Reactive.Unit> BeginScope(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue)
        {
            return
                Observable.Do(ILGeneratorValue, (ILGeneratorValueLambda) => ILGeneratorValueLambda.BeginScope())
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> EndScope(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue)
        {
            return
                Observable.Do(ILGeneratorValue, (ILGeneratorValueLambda) => ILGeneratorValueLambda.EndScope()).ToUnit();
        }


        public static IObservable<System.Int32> get_ILOffset(
            this IObservable<System.Reflection.Emit.ILGenerator> ILGeneratorValue)
        {
            return Observable.Select(ILGeneratorValue, (ILGeneratorValueLambda) => ILGeneratorValueLambda.ILOffset);
        }
    }
}