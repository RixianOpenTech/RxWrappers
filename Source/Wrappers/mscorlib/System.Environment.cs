using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Environment
    {
        public static IObservable<System.Reactive.Unit> Exit(IObservable<System.Int32> exitCode)
        {
            return Observable.Do(exitCode, (exitCodeLambda) => System.Environment.Exit(exitCodeLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> FailFast(IObservable<System.String> message)
        {
            return Observable.Do(message, (messageLambda) => System.Environment.FailFast(messageLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> FailFast(IObservable<System.String> message,
            IObservable<System.Exception> exception)
        {
            return ObservableExt.ZipExecute(message, exception,
                (messageLambda, exceptionLambda) => System.Environment.FailFast(messageLambda, exceptionLambda));
        }


        public static IObservable<System.String> ExpandEnvironmentVariables(IObservable<System.String> name)
        {
            return Observable.Select(name, (nameLambda) => System.Environment.ExpandEnvironmentVariables(nameLambda));
        }


        public static IObservable<System.String[]> GetCommandLineArgs()
        {
            return ObservableExt.Factory(() => System.Environment.GetCommandLineArgs());
        }


        public static IObservable<System.String> GetEnvironmentVariable(IObservable<System.String> variable)
        {
            return Observable.Select(variable,
                (variableLambda) => System.Environment.GetEnvironmentVariable(variableLambda));
        }


        public static IObservable<System.String> GetEnvironmentVariable(IObservable<System.String> variable,
            IObservable<System.EnvironmentVariableTarget> target)
        {
            return Observable.Zip(variable, target,
                (variableLambda, targetLambda) =>
                    System.Environment.GetEnvironmentVariable(variableLambda, targetLambda));
        }


        public static IObservable<System.Collections.IDictionary> GetEnvironmentVariables()
        {
            return ObservableExt.Factory(() => System.Environment.GetEnvironmentVariables());
        }


        public static IObservable<System.Collections.IDictionary> GetEnvironmentVariables(
            IObservable<System.EnvironmentVariableTarget> target)
        {
            return Observable.Select(target, (targetLambda) => System.Environment.GetEnvironmentVariables(targetLambda));
        }


        public static IObservable<System.Reactive.Unit> SetEnvironmentVariable(IObservable<System.String> variable,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(variable, value,
                (variableLambda, valueLambda) => System.Environment.SetEnvironmentVariable(variableLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> SetEnvironmentVariable(IObservable<System.String> variable,
            IObservable<System.String> value, IObservable<System.EnvironmentVariableTarget> target)
        {
            return ObservableExt.ZipExecute(variable, value, target,
                (variableLambda, valueLambda, targetLambda) =>
                    System.Environment.SetEnvironmentVariable(variableLambda, valueLambda, targetLambda));
        }


        public static IObservable<System.String[]> GetLogicalDrives()
        {
            return ObservableExt.Factory(() => System.Environment.GetLogicalDrives());
        }


        public static IObservable<System.String> GetFolderPath(IObservable<System.Environment.SpecialFolder> folder)
        {
            return Observable.Select(folder, (folderLambda) => System.Environment.GetFolderPath(folderLambda));
        }


        public static IObservable<System.String> GetFolderPath(IObservable<System.Environment.SpecialFolder> folder,
            IObservable<System.Environment.SpecialFolderOption> option)
        {
            return Observable.Zip(folder, option,
                (folderLambda, optionLambda) => System.Environment.GetFolderPath(folderLambda, optionLambda));
        }


        public static IObservable<System.Int32> get_TickCount()
        {
            return ObservableExt.Factory(() => System.Environment.TickCount);
        }


        public static IObservable<System.Int32> get_ExitCode()
        {
            return ObservableExt.Factory(() => System.Environment.ExitCode);
        }


        public static IObservable<System.String> get_CommandLine()
        {
            return ObservableExt.Factory(() => System.Environment.CommandLine);
        }


        public static IObservable<System.String> get_CurrentDirectory()
        {
            return ObservableExt.Factory(() => System.Environment.CurrentDirectory);
        }


        public static IObservable<System.String> get_SystemDirectory()
        {
            return ObservableExt.Factory(() => System.Environment.SystemDirectory);
        }


        public static IObservable<System.String> get_MachineName()
        {
            return ObservableExt.Factory(() => System.Environment.MachineName);
        }


        public static IObservable<System.Int32> get_ProcessorCount()
        {
            return ObservableExt.Factory(() => System.Environment.ProcessorCount);
        }


        public static IObservable<System.Int32> get_SystemPageSize()
        {
            return ObservableExt.Factory(() => System.Environment.SystemPageSize);
        }


        public static IObservable<System.String> get_NewLine()
        {
            return ObservableExt.Factory(() => System.Environment.NewLine);
        }


        public static IObservable<System.Version> get_Version()
        {
            return ObservableExt.Factory(() => System.Environment.Version);
        }


        public static IObservable<System.Int64> get_WorkingSet()
        {
            return ObservableExt.Factory(() => System.Environment.WorkingSet);
        }


        public static IObservable<System.OperatingSystem> get_OSVersion()
        {
            return ObservableExt.Factory(() => System.Environment.OSVersion);
        }


        public static IObservable<System.String> get_StackTrace()
        {
            return ObservableExt.Factory(() => System.Environment.StackTrace);
        }


        public static IObservable<System.Boolean> get_Is64BitProcess()
        {
            return ObservableExt.Factory(() => System.Environment.Is64BitProcess);
        }


        public static IObservable<System.Boolean> get_Is64BitOperatingSystem()
        {
            return ObservableExt.Factory(() => System.Environment.Is64BitOperatingSystem);
        }


        public static IObservable<System.Boolean> get_HasShutdownStarted()
        {
            return ObservableExt.Factory(() => System.Environment.HasShutdownStarted);
        }


        public static IObservable<System.String> get_UserName()
        {
            return ObservableExt.Factory(() => System.Environment.UserName);
        }


        public static IObservable<System.Boolean> get_UserInteractive()
        {
            return ObservableExt.Factory(() => System.Environment.UserInteractive);
        }


        public static IObservable<System.String> get_UserDomainName()
        {
            return ObservableExt.Factory(() => System.Environment.UserDomainName);
        }


        public static IObservable<System.Int32> get_CurrentManagedThreadId()
        {
            return ObservableExt.Factory(() => System.Environment.CurrentManagedThreadId);
        }


        public static IObservable<System.Reactive.Unit> set_ExitCode(IObservable<System.Int32> value)
        {
            return Observable.Do(value, (valueLambda) => System.Environment.ExitCode = valueLambda).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> set_CurrentDirectory(IObservable<System.String> value)
        {
            return Observable.Do(value, (valueLambda) => System.Environment.CurrentDirectory = valueLambda).ToUnit();
        }
    }
}