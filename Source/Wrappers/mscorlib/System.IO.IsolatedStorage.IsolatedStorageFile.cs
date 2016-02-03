using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO.IsolatedStorage
{
    public static class __IsolatedStorageFile
    {
        public static IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> GetUserStoreForDomain()
        {
            return ObservableExt.Factory(() => System.IO.IsolatedStorage.IsolatedStorageFile.GetUserStoreForDomain());
        }


        public static IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> GetUserStoreForAssembly()
        {
            return ObservableExt.Factory(() => System.IO.IsolatedStorage.IsolatedStorageFile.GetUserStoreForAssembly());
        }


        public static IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> GetUserStoreForApplication()
        {
            return
                ObservableExt.Factory(() => System.IO.IsolatedStorage.IsolatedStorageFile.GetUserStoreForApplication());
        }


        public static IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> GetUserStoreForSite()
        {
            return ObservableExt.Factory(() => System.IO.IsolatedStorage.IsolatedStorageFile.GetUserStoreForSite());
        }


        public static IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> GetMachineStoreForDomain()
        {
            return ObservableExt.Factory(() => System.IO.IsolatedStorage.IsolatedStorageFile.GetMachineStoreForDomain());
        }


        public static IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> GetMachineStoreForAssembly()
        {
            return
                ObservableExt.Factory(() => System.IO.IsolatedStorage.IsolatedStorageFile.GetMachineStoreForAssembly());
        }


        public static IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> GetMachineStoreForApplication()
        {
            return
                ObservableExt.Factory(
                    () => System.IO.IsolatedStorage.IsolatedStorageFile.GetMachineStoreForApplication());
        }


        public static IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> GetStore(
            IObservable<System.IO.IsolatedStorage.IsolatedStorageScope> scope,
            IObservable<System.Type> domainEvidenceType, IObservable<System.Type> assemblyEvidenceType)
        {
            return Observable.Zip(scope, domainEvidenceType, assemblyEvidenceType,
                (scopeLambda, domainEvidenceTypeLambda, assemblyEvidenceTypeLambda) =>
                    System.IO.IsolatedStorage.IsolatedStorageFile.GetStore(scopeLambda, domainEvidenceTypeLambda,
                        assemblyEvidenceTypeLambda));
        }


        public static IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> GetStore(
            IObservable<System.IO.IsolatedStorage.IsolatedStorageScope> scope, IObservable<System.Object> domainIdentity,
            IObservable<System.Object> assemblyIdentity)
        {
            return Observable.Zip(scope, domainIdentity, assemblyIdentity,
                (scopeLambda, domainIdentityLambda, assemblyIdentityLambda) =>
                    System.IO.IsolatedStorage.IsolatedStorageFile.GetStore(scopeLambda, domainIdentityLambda,
                        assemblyIdentityLambda));
        }


        public static IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> GetStore(
            IObservable<System.IO.IsolatedStorage.IsolatedStorageScope> scope,
            IObservable<System.Security.Policy.Evidence> domainEvidence, IObservable<System.Type> domainEvidenceType,
            IObservable<System.Security.Policy.Evidence> assemblyEvidence, IObservable<System.Type> assemblyEvidenceType)
        {
            return Observable.Zip(scope, domainEvidence, domainEvidenceType, assemblyEvidence, assemblyEvidenceType,
                (scopeLambda, domainEvidenceLambda, domainEvidenceTypeLambda, assemblyEvidenceLambda,
                    assemblyEvidenceTypeLambda) =>
                    System.IO.IsolatedStorage.IsolatedStorageFile.GetStore(scopeLambda, domainEvidenceLambda,
                        domainEvidenceTypeLambda, assemblyEvidenceLambda, assemblyEvidenceTypeLambda));
        }


        public static IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> GetStore(
            IObservable<System.IO.IsolatedStorage.IsolatedStorageScope> scope,
            IObservable<System.Type> applicationEvidenceType)
        {
            return Observable.Zip(scope, applicationEvidenceType,
                (scopeLambda, applicationEvidenceTypeLambda) =>
                    System.IO.IsolatedStorage.IsolatedStorageFile.GetStore(scopeLambda, applicationEvidenceTypeLambda));
        }


        public static IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> GetStore(
            IObservable<System.IO.IsolatedStorage.IsolatedStorageScope> scope,
            IObservable<System.Object> applicationIdentity)
        {
            return Observable.Zip(scope, applicationIdentity,
                (scopeLambda, applicationIdentityLambda) =>
                    System.IO.IsolatedStorage.IsolatedStorageFile.GetStore(scopeLambda, applicationIdentityLambda));
        }


        public static IObservable<System.Boolean> IncreaseQuotaTo(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue,
            IObservable<System.Int64> newQuotaSize)
        {
            return Observable.Zip(IsolatedStorageFileValue, newQuotaSize,
                (IsolatedStorageFileValueLambda, newQuotaSizeLambda) =>
                    IsolatedStorageFileValueLambda.IncreaseQuotaTo(newQuotaSizeLambda));
        }


        public static IObservable<System.Reactive.Unit> DeleteFile(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue,
            IObservable<System.String> file)
        {
            return ObservableExt.ZipExecute(IsolatedStorageFileValue, file,
                (IsolatedStorageFileValueLambda, fileLambda) => IsolatedStorageFileValueLambda.DeleteFile(fileLambda));
        }


        public static IObservable<System.Boolean> FileExists(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue,
            IObservable<System.String> path)
        {
            return Observable.Zip(IsolatedStorageFileValue, path,
                (IsolatedStorageFileValueLambda, pathLambda) => IsolatedStorageFileValueLambda.FileExists(pathLambda));
        }


        public static IObservable<System.Boolean> DirectoryExists(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue,
            IObservable<System.String> path)
        {
            return Observable.Zip(IsolatedStorageFileValue, path,
                (IsolatedStorageFileValueLambda, pathLambda) =>
                    IsolatedStorageFileValueLambda.DirectoryExists(pathLambda));
        }


        public static IObservable<System.Reactive.Unit> CreateDirectory(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue,
            IObservable<System.String> dir)
        {
            return ObservableExt.ZipExecute(IsolatedStorageFileValue, dir,
                (IsolatedStorageFileValueLambda, dirLambda) => IsolatedStorageFileValueLambda.CreateDirectory(dirLambda));
        }


        public static IObservable<System.DateTimeOffset> GetCreationTime(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue,
            IObservable<System.String> path)
        {
            return Observable.Zip(IsolatedStorageFileValue, path,
                (IsolatedStorageFileValueLambda, pathLambda) =>
                    IsolatedStorageFileValueLambda.GetCreationTime(pathLambda));
        }


        public static IObservable<System.DateTimeOffset> GetLastAccessTime(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue,
            IObservable<System.String> path)
        {
            return Observable.Zip(IsolatedStorageFileValue, path,
                (IsolatedStorageFileValueLambda, pathLambda) =>
                    IsolatedStorageFileValueLambda.GetLastAccessTime(pathLambda));
        }


        public static IObservable<System.DateTimeOffset> GetLastWriteTime(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue,
            IObservable<System.String> path)
        {
            return Observable.Zip(IsolatedStorageFileValue, path,
                (IsolatedStorageFileValueLambda, pathLambda) =>
                    IsolatedStorageFileValueLambda.GetLastWriteTime(pathLambda));
        }


        public static IObservable<System.Reactive.Unit> CopyFile(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue,
            IObservable<System.String> sourceFileName, IObservable<System.String> destinationFileName)
        {
            return ObservableExt.ZipExecute(IsolatedStorageFileValue, sourceFileName, destinationFileName,
                (IsolatedStorageFileValueLambda, sourceFileNameLambda, destinationFileNameLambda) =>
                    IsolatedStorageFileValueLambda.CopyFile(sourceFileNameLambda, destinationFileNameLambda));
        }


        public static IObservable<System.Reactive.Unit> CopyFile(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue,
            IObservable<System.String> sourceFileName, IObservable<System.String> destinationFileName,
            IObservable<System.Boolean> overwrite)
        {
            return ObservableExt.ZipExecute(IsolatedStorageFileValue, sourceFileName, destinationFileName, overwrite,
                (IsolatedStorageFileValueLambda, sourceFileNameLambda, destinationFileNameLambda, overwriteLambda) =>
                    IsolatedStorageFileValueLambda.CopyFile(sourceFileNameLambda, destinationFileNameLambda,
                        overwriteLambda));
        }


        public static IObservable<System.Reactive.Unit> MoveFile(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue,
            IObservable<System.String> sourceFileName, IObservable<System.String> destinationFileName)
        {
            return ObservableExt.ZipExecute(IsolatedStorageFileValue, sourceFileName, destinationFileName,
                (IsolatedStorageFileValueLambda, sourceFileNameLambda, destinationFileNameLambda) =>
                    IsolatedStorageFileValueLambda.MoveFile(sourceFileNameLambda, destinationFileNameLambda));
        }


        public static IObservable<System.Reactive.Unit> MoveDirectory(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue,
            IObservable<System.String> sourceDirectoryName, IObservable<System.String> destinationDirectoryName)
        {
            return ObservableExt.ZipExecute(IsolatedStorageFileValue, sourceDirectoryName, destinationDirectoryName,
                (IsolatedStorageFileValueLambda, sourceDirectoryNameLambda, destinationDirectoryNameLambda) =>
                    IsolatedStorageFileValueLambda.MoveDirectory(sourceDirectoryNameLambda,
                        destinationDirectoryNameLambda));
        }


        public static IObservable<System.Reactive.Unit> DeleteDirectory(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue,
            IObservable<System.String> dir)
        {
            return ObservableExt.ZipExecute(IsolatedStorageFileValue, dir,
                (IsolatedStorageFileValueLambda, dirLambda) => IsolatedStorageFileValueLambda.DeleteDirectory(dirLambda));
        }


        public static IObservable<System.String[]> GetFileNames(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue)
        {
            return Observable.Select(IsolatedStorageFileValue,
                (IsolatedStorageFileValueLambda) => IsolatedStorageFileValueLambda.GetFileNames());
        }


        public static IObservable<System.String[]> GetFileNames(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue,
            IObservable<System.String> searchPattern)
        {
            return Observable.Zip(IsolatedStorageFileValue, searchPattern,
                (IsolatedStorageFileValueLambda, searchPatternLambda) =>
                    IsolatedStorageFileValueLambda.GetFileNames(searchPatternLambda));
        }


        public static IObservable<System.String[]> GetDirectoryNames(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue)
        {
            return Observable.Select(IsolatedStorageFileValue,
                (IsolatedStorageFileValueLambda) => IsolatedStorageFileValueLambda.GetDirectoryNames());
        }


        public static IObservable<System.String[]> GetDirectoryNames(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue,
            IObservable<System.String> searchPattern)
        {
            return Observable.Zip(IsolatedStorageFileValue, searchPattern,
                (IsolatedStorageFileValueLambda, searchPatternLambda) =>
                    IsolatedStorageFileValueLambda.GetDirectoryNames(searchPatternLambda));
        }


        public static IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> OpenFile(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue,
            IObservable<System.String> path, IObservable<System.IO.FileMode> mode)
        {
            return Observable.Zip(IsolatedStorageFileValue, path, mode,
                (IsolatedStorageFileValueLambda, pathLambda, modeLambda) =>
                    IsolatedStorageFileValueLambda.OpenFile(pathLambda, modeLambda));
        }


        public static IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> OpenFile(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue,
            IObservable<System.String> path, IObservable<System.IO.FileMode> mode,
            IObservable<System.IO.FileAccess> access)
        {
            return Observable.Zip(IsolatedStorageFileValue, path, mode, access,
                (IsolatedStorageFileValueLambda, pathLambda, modeLambda, accessLambda) =>
                    IsolatedStorageFileValueLambda.OpenFile(pathLambda, modeLambda, accessLambda));
        }


        public static IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> OpenFile(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue,
            IObservable<System.String> path, IObservable<System.IO.FileMode> mode,
            IObservable<System.IO.FileAccess> access, IObservable<System.IO.FileShare> share)
        {
            return Observable.Zip(IsolatedStorageFileValue, path, mode, access, share,
                (IsolatedStorageFileValueLambda, pathLambda, modeLambda, accessLambda, shareLambda) =>
                    IsolatedStorageFileValueLambda.OpenFile(pathLambda, modeLambda, accessLambda, shareLambda));
        }


        public static IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> CreateFile(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue,
            IObservable<System.String> path)
        {
            return Observable.Zip(IsolatedStorageFileValue, path,
                (IsolatedStorageFileValueLambda, pathLambda) => IsolatedStorageFileValueLambda.CreateFile(pathLambda));
        }


        public static IObservable<System.Reactive.Unit> Remove(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue)
        {
            return
                Observable.Do(IsolatedStorageFileValue,
                    (IsolatedStorageFileValueLambda) => IsolatedStorageFileValueLambda.Remove()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Close(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue)
        {
            return
                Observable.Do(IsolatedStorageFileValue,
                    (IsolatedStorageFileValueLambda) => IsolatedStorageFileValueLambda.Close()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Dispose(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue)
        {
            return
                Observable.Do(IsolatedStorageFileValue,
                    (IsolatedStorageFileValueLambda) => IsolatedStorageFileValueLambda.Dispose()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Remove(
            IObservable<System.IO.IsolatedStorage.IsolatedStorageScope> scope)
        {
            return
                Observable.Do(scope, (scopeLambda) => System.IO.IsolatedStorage.IsolatedStorageFile.Remove(scopeLambda))
                    .ToUnit();
        }


        public static IObservable<System.Collections.IEnumerator> GetEnumerator(
            IObservable<System.IO.IsolatedStorage.IsolatedStorageScope> scope)
        {
            return Observable.Select(scope,
                (scopeLambda) => System.IO.IsolatedStorage.IsolatedStorageFile.GetEnumerator(scopeLambda));
        }


        public static IObservable<System.Int64> get_UsedSize(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue)
        {
            return Observable.Select(IsolatedStorageFileValue,
                (IsolatedStorageFileValueLambda) => IsolatedStorageFileValueLambda.UsedSize);
        }


        public static IObservable<System.UInt64> get_CurrentSize(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue)
        {
            return Observable.Select(IsolatedStorageFileValue,
                (IsolatedStorageFileValueLambda) => IsolatedStorageFileValueLambda.CurrentSize);
        }


        public static IObservable<System.Int64> get_AvailableFreeSpace(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue)
        {
            return Observable.Select(IsolatedStorageFileValue,
                (IsolatedStorageFileValueLambda) => IsolatedStorageFileValueLambda.AvailableFreeSpace);
        }


        public static IObservable<System.Int64> get_Quota(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue)
        {
            return Observable.Select(IsolatedStorageFileValue,
                (IsolatedStorageFileValueLambda) => IsolatedStorageFileValueLambda.Quota);
        }


        public static IObservable<System.Boolean> get_IsEnabled()
        {
            return ObservableExt.Factory(() => System.IO.IsolatedStorage.IsolatedStorageFile.IsEnabled);
        }


        public static IObservable<System.UInt64> get_MaximumSize(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorageFile> IsolatedStorageFileValue)
        {
            return Observable.Select(IsolatedStorageFileValue,
                (IsolatedStorageFileValueLambda) => IsolatedStorageFileValueLambda.MaximumSize);
        }
    }
}