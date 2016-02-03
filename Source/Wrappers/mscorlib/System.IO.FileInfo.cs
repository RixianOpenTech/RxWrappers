using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO
{
    public static class __FileInfo
    {
        public static IObservable<System.Security.AccessControl.FileSecurity> GetAccessControl(
            this IObservable<System.IO.FileInfo> FileInfoValue)
        {
            return Observable.Select(FileInfoValue, (FileInfoValueLambda) => FileInfoValueLambda.GetAccessControl());
        }


        public static IObservable<System.Security.AccessControl.FileSecurity> GetAccessControl(
            this IObservable<System.IO.FileInfo> FileInfoValue,
            IObservable<System.Security.AccessControl.AccessControlSections> includeSections)
        {
            return Observable.Zip(FileInfoValue, includeSections,
                (FileInfoValueLambda, includeSectionsLambda) =>
                    FileInfoValueLambda.GetAccessControl(includeSectionsLambda));
        }


        public static IObservable<System.Reactive.Unit> SetAccessControl(
            this IObservable<System.IO.FileInfo> FileInfoValue,
            IObservable<System.Security.AccessControl.FileSecurity> fileSecurity)
        {
            return ObservableExt.ZipExecute(FileInfoValue, fileSecurity,
                (FileInfoValueLambda, fileSecurityLambda) => FileInfoValueLambda.SetAccessControl(fileSecurityLambda));
        }


        public static IObservable<System.IO.StreamReader> OpenText(this IObservable<System.IO.FileInfo> FileInfoValue)
        {
            return Observable.Select(FileInfoValue, (FileInfoValueLambda) => FileInfoValueLambda.OpenText());
        }


        public static IObservable<System.IO.StreamWriter> CreateText(this IObservable<System.IO.FileInfo> FileInfoValue)
        {
            return Observable.Select(FileInfoValue, (FileInfoValueLambda) => FileInfoValueLambda.CreateText());
        }


        public static IObservable<System.IO.StreamWriter> AppendText(this IObservable<System.IO.FileInfo> FileInfoValue)
        {
            return Observable.Select(FileInfoValue, (FileInfoValueLambda) => FileInfoValueLambda.AppendText());
        }


        public static IObservable<System.IO.FileInfo> CopyTo(this IObservable<System.IO.FileInfo> FileInfoValue,
            IObservable<System.String> destFileName)
        {
            return Observable.Zip(FileInfoValue, destFileName,
                (FileInfoValueLambda, destFileNameLambda) => FileInfoValueLambda.CopyTo(destFileNameLambda));
        }


        public static IObservable<System.IO.FileInfo> CopyTo(this IObservable<System.IO.FileInfo> FileInfoValue,
            IObservable<System.String> destFileName, IObservable<System.Boolean> overwrite)
        {
            return Observable.Zip(FileInfoValue, destFileName, overwrite,
                (FileInfoValueLambda, destFileNameLambda, overwriteLambda) =>
                    FileInfoValueLambda.CopyTo(destFileNameLambda, overwriteLambda));
        }


        public static IObservable<System.IO.FileStream> Create(this IObservable<System.IO.FileInfo> FileInfoValue)
        {
            return Observable.Select(FileInfoValue, (FileInfoValueLambda) => FileInfoValueLambda.Create());
        }


        public static IObservable<System.Reactive.Unit> Delete(this IObservable<System.IO.FileInfo> FileInfoValue)
        {
            return Observable.Do(FileInfoValue, (FileInfoValueLambda) => FileInfoValueLambda.Delete()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Decrypt(this IObservable<System.IO.FileInfo> FileInfoValue)
        {
            return Observable.Do(FileInfoValue, (FileInfoValueLambda) => FileInfoValueLambda.Decrypt()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Encrypt(this IObservable<System.IO.FileInfo> FileInfoValue)
        {
            return Observable.Do(FileInfoValue, (FileInfoValueLambda) => FileInfoValueLambda.Encrypt()).ToUnit();
        }


        public static IObservable<System.IO.FileStream> Open(this IObservable<System.IO.FileInfo> FileInfoValue,
            IObservable<System.IO.FileMode> mode)
        {
            return Observable.Zip(FileInfoValue, mode,
                (FileInfoValueLambda, modeLambda) => FileInfoValueLambda.Open(modeLambda));
        }


        public static IObservable<System.IO.FileStream> Open(this IObservable<System.IO.FileInfo> FileInfoValue,
            IObservable<System.IO.FileMode> mode, IObservable<System.IO.FileAccess> access)
        {
            return Observable.Zip(FileInfoValue, mode, access,
                (FileInfoValueLambda, modeLambda, accessLambda) => FileInfoValueLambda.Open(modeLambda, accessLambda));
        }


        public static IObservable<System.IO.FileStream> Open(this IObservable<System.IO.FileInfo> FileInfoValue,
            IObservable<System.IO.FileMode> mode, IObservable<System.IO.FileAccess> access,
            IObservable<System.IO.FileShare> share)
        {
            return Observable.Zip(FileInfoValue, mode, access, share,
                (FileInfoValueLambda, modeLambda, accessLambda, shareLambda) =>
                    FileInfoValueLambda.Open(modeLambda, accessLambda, shareLambda));
        }


        public static IObservable<System.IO.FileStream> OpenRead(this IObservable<System.IO.FileInfo> FileInfoValue)
        {
            return Observable.Select(FileInfoValue, (FileInfoValueLambda) => FileInfoValueLambda.OpenRead());
        }


        public static IObservable<System.IO.FileStream> OpenWrite(this IObservable<System.IO.FileInfo> FileInfoValue)
        {
            return Observable.Select(FileInfoValue, (FileInfoValueLambda) => FileInfoValueLambda.OpenWrite());
        }


        public static IObservable<System.Reactive.Unit> MoveTo(this IObservable<System.IO.FileInfo> FileInfoValue,
            IObservable<System.String> destFileName)
        {
            return ObservableExt.ZipExecute(FileInfoValue, destFileName,
                (FileInfoValueLambda, destFileNameLambda) => FileInfoValueLambda.MoveTo(destFileNameLambda));
        }


        public static IObservable<System.IO.FileInfo> Replace(this IObservable<System.IO.FileInfo> FileInfoValue,
            IObservable<System.String> destinationFileName, IObservable<System.String> destinationBackupFileName)
        {
            return Observable.Zip(FileInfoValue, destinationFileName, destinationBackupFileName,
                (FileInfoValueLambda, destinationFileNameLambda, destinationBackupFileNameLambda) =>
                    FileInfoValueLambda.Replace(destinationFileNameLambda, destinationBackupFileNameLambda));
        }


        public static IObservable<System.IO.FileInfo> Replace(this IObservable<System.IO.FileInfo> FileInfoValue,
            IObservable<System.String> destinationFileName, IObservable<System.String> destinationBackupFileName,
            IObservable<System.Boolean> ignoreMetadataErrors)
        {
            return Observable.Zip(FileInfoValue, destinationFileName, destinationBackupFileName, ignoreMetadataErrors,
                (FileInfoValueLambda, destinationFileNameLambda, destinationBackupFileNameLambda,
                    ignoreMetadataErrorsLambda) =>
                    FileInfoValueLambda.Replace(destinationFileNameLambda, destinationBackupFileNameLambda,
                        ignoreMetadataErrorsLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.IO.FileInfo> FileInfoValue)
        {
            return Observable.Select(FileInfoValue, (FileInfoValueLambda) => FileInfoValueLambda.ToString());
        }


        public static IObservable<System.String> get_Name(this IObservable<System.IO.FileInfo> FileInfoValue)
        {
            return Observable.Select(FileInfoValue, (FileInfoValueLambda) => FileInfoValueLambda.Name);
        }


        public static IObservable<System.Int64> get_Length(this IObservable<System.IO.FileInfo> FileInfoValue)
        {
            return Observable.Select(FileInfoValue, (FileInfoValueLambda) => FileInfoValueLambda.Length);
        }


        public static IObservable<System.String> get_DirectoryName(this IObservable<System.IO.FileInfo> FileInfoValue)
        {
            return Observable.Select(FileInfoValue, (FileInfoValueLambda) => FileInfoValueLambda.DirectoryName);
        }


        public static IObservable<System.IO.DirectoryInfo> get_Directory(
            this IObservable<System.IO.FileInfo> FileInfoValue)
        {
            return Observable.Select(FileInfoValue, (FileInfoValueLambda) => FileInfoValueLambda.Directory);
        }


        public static IObservable<System.Boolean> get_IsReadOnly(this IObservable<System.IO.FileInfo> FileInfoValue)
        {
            return Observable.Select(FileInfoValue, (FileInfoValueLambda) => FileInfoValueLambda.IsReadOnly);
        }


        public static IObservable<System.Boolean> get_Exists(this IObservable<System.IO.FileInfo> FileInfoValue)
        {
            return Observable.Select(FileInfoValue, (FileInfoValueLambda) => FileInfoValueLambda.Exists);
        }


        public static IObservable<System.Reactive.Unit> set_IsReadOnly(
            this IObservable<System.IO.FileInfo> FileInfoValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(FileInfoValue, value,
                (FileInfoValueLambda, valueLambda) => FileInfoValueLambda.IsReadOnly = valueLambda);
        }
    }
}