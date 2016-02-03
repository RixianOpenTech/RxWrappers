using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO
{
    public static class __File
    {
        public static IObservable<System.IO.StreamReader> OpenText(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.File.OpenText(pathLambda));
        }


        public static IObservable<System.IO.StreamWriter> CreateText(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.File.CreateText(pathLambda));
        }


        public static IObservable<System.IO.StreamWriter> AppendText(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.File.AppendText(pathLambda));
        }


        public static IObservable<System.Reactive.Unit> Copy(IObservable<System.String> sourceFileName,
            IObservable<System.String> destFileName)
        {
            return ObservableExt.ZipExecute(sourceFileName, destFileName,
                (sourceFileNameLambda, destFileNameLambda) =>
                    System.IO.File.Copy(sourceFileNameLambda, destFileNameLambda));
        }


        public static IObservable<System.Reactive.Unit> Copy(IObservable<System.String> sourceFileName,
            IObservable<System.String> destFileName, IObservable<System.Boolean> overwrite)
        {
            return ObservableExt.ZipExecute(sourceFileName, destFileName, overwrite,
                (sourceFileNameLambda, destFileNameLambda, overwriteLambda) =>
                    System.IO.File.Copy(sourceFileNameLambda, destFileNameLambda, overwriteLambda));
        }


        public static IObservable<System.IO.FileStream> Create(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.File.Create(pathLambda));
        }


        public static IObservable<System.IO.FileStream> Create(IObservable<System.String> path,
            IObservable<System.Int32> bufferSize)
        {
            return Observable.Zip(path, bufferSize,
                (pathLambda, bufferSizeLambda) => System.IO.File.Create(pathLambda, bufferSizeLambda));
        }


        public static IObservable<System.IO.FileStream> Create(IObservable<System.String> path,
            IObservable<System.Int32> bufferSize, IObservable<System.IO.FileOptions> options)
        {
            return Observable.Zip(path, bufferSize, options,
                (pathLambda, bufferSizeLambda, optionsLambda) =>
                    System.IO.File.Create(pathLambda, bufferSizeLambda, optionsLambda));
        }


        public static IObservable<System.IO.FileStream> Create(IObservable<System.String> path,
            IObservable<System.Int32> bufferSize, IObservable<System.IO.FileOptions> options,
            IObservable<System.Security.AccessControl.FileSecurity> fileSecurity)
        {
            return Observable.Zip(path, bufferSize, options, fileSecurity,
                (pathLambda, bufferSizeLambda, optionsLambda, fileSecurityLambda) =>
                    System.IO.File.Create(pathLambda, bufferSizeLambda, optionsLambda, fileSecurityLambda));
        }


        public static IObservable<System.Reactive.Unit> Delete(IObservable<System.String> path)
        {
            return Observable.Do(path, (pathLambda) => System.IO.File.Delete(pathLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Decrypt(IObservable<System.String> path)
        {
            return Observable.Do(path, (pathLambda) => System.IO.File.Decrypt(pathLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Encrypt(IObservable<System.String> path)
        {
            return Observable.Do(path, (pathLambda) => System.IO.File.Encrypt(pathLambda)).ToUnit();
        }


        public static IObservable<System.Boolean> Exists(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.File.Exists(pathLambda));
        }


        public static IObservable<System.IO.FileStream> Open(IObservable<System.String> path,
            IObservable<System.IO.FileMode> mode)
        {
            return Observable.Zip(path, mode, (pathLambda, modeLambda) => System.IO.File.Open(pathLambda, modeLambda));
        }


        public static IObservable<System.IO.FileStream> Open(IObservable<System.String> path,
            IObservable<System.IO.FileMode> mode, IObservable<System.IO.FileAccess> access)
        {
            return Observable.Zip(path, mode, access,
                (pathLambda, modeLambda, accessLambda) => System.IO.File.Open(pathLambda, modeLambda, accessLambda));
        }


        public static IObservable<System.IO.FileStream> Open(IObservable<System.String> path,
            IObservable<System.IO.FileMode> mode, IObservable<System.IO.FileAccess> access,
            IObservable<System.IO.FileShare> share)
        {
            return Observable.Zip(path, mode, access, share,
                (pathLambda, modeLambda, accessLambda, shareLambda) =>
                    System.IO.File.Open(pathLambda, modeLambda, accessLambda, shareLambda));
        }


        public static IObservable<System.Reactive.Unit> SetCreationTime(IObservable<System.String> path,
            IObservable<System.DateTime> creationTime)
        {
            return ObservableExt.ZipExecute(path, creationTime,
                (pathLambda, creationTimeLambda) => System.IO.File.SetCreationTime(pathLambda, creationTimeLambda));
        }


        public static IObservable<System.Reactive.Unit> SetCreationTimeUtc(IObservable<System.String> path,
            IObservable<System.DateTime> creationTimeUtc)
        {
            return ObservableExt.ZipExecute(path, creationTimeUtc,
                (pathLambda, creationTimeUtcLambda) =>
                    System.IO.File.SetCreationTimeUtc(pathLambda, creationTimeUtcLambda));
        }


        public static IObservable<System.DateTime> GetCreationTime(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.File.GetCreationTime(pathLambda));
        }


        public static IObservable<System.DateTime> GetCreationTimeUtc(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.File.GetCreationTimeUtc(pathLambda));
        }


        public static IObservable<System.Reactive.Unit> SetLastAccessTime(IObservable<System.String> path,
            IObservable<System.DateTime> lastAccessTime)
        {
            return ObservableExt.ZipExecute(path, lastAccessTime,
                (pathLambda, lastAccessTimeLambda) => System.IO.File.SetLastAccessTime(pathLambda, lastAccessTimeLambda));
        }


        public static IObservable<System.Reactive.Unit> SetLastAccessTimeUtc(IObservable<System.String> path,
            IObservable<System.DateTime> lastAccessTimeUtc)
        {
            return ObservableExt.ZipExecute(path, lastAccessTimeUtc,
                (pathLambda, lastAccessTimeUtcLambda) =>
                    System.IO.File.SetLastAccessTimeUtc(pathLambda, lastAccessTimeUtcLambda));
        }


        public static IObservable<System.DateTime> GetLastAccessTime(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.File.GetLastAccessTime(pathLambda));
        }


        public static IObservable<System.DateTime> GetLastAccessTimeUtc(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.File.GetLastAccessTimeUtc(pathLambda));
        }


        public static IObservable<System.Reactive.Unit> SetLastWriteTime(IObservable<System.String> path,
            IObservable<System.DateTime> lastWriteTime)
        {
            return ObservableExt.ZipExecute(path, lastWriteTime,
                (pathLambda, lastWriteTimeLambda) => System.IO.File.SetLastWriteTime(pathLambda, lastWriteTimeLambda));
        }


        public static IObservable<System.Reactive.Unit> SetLastWriteTimeUtc(IObservable<System.String> path,
            IObservable<System.DateTime> lastWriteTimeUtc)
        {
            return ObservableExt.ZipExecute(path, lastWriteTimeUtc,
                (pathLambda, lastWriteTimeUtcLambda) =>
                    System.IO.File.SetLastWriteTimeUtc(pathLambda, lastWriteTimeUtcLambda));
        }


        public static IObservable<System.DateTime> GetLastWriteTime(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.File.GetLastWriteTime(pathLambda));
        }


        public static IObservable<System.DateTime> GetLastWriteTimeUtc(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.File.GetLastWriteTimeUtc(pathLambda));
        }


        public static IObservable<System.IO.FileAttributes> GetAttributes(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.File.GetAttributes(pathLambda));
        }


        public static IObservable<System.Reactive.Unit> SetAttributes(IObservable<System.String> path,
            IObservable<System.IO.FileAttributes> fileAttributes)
        {
            return ObservableExt.ZipExecute(path, fileAttributes,
                (pathLambda, fileAttributesLambda) => System.IO.File.SetAttributes(pathLambda, fileAttributesLambda));
        }


        public static IObservable<System.Security.AccessControl.FileSecurity> GetAccessControl(
            IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.File.GetAccessControl(pathLambda));
        }


        public static IObservable<System.Security.AccessControl.FileSecurity> GetAccessControl(
            IObservable<System.String> path,
            IObservable<System.Security.AccessControl.AccessControlSections> includeSections)
        {
            return Observable.Zip(path, includeSections,
                (pathLambda, includeSectionsLambda) =>
                    System.IO.File.GetAccessControl(pathLambda, includeSectionsLambda));
        }


        public static IObservable<System.Reactive.Unit> SetAccessControl(IObservable<System.String> path,
            IObservable<System.Security.AccessControl.FileSecurity> fileSecurity)
        {
            return ObservableExt.ZipExecute(path, fileSecurity,
                (pathLambda, fileSecurityLambda) => System.IO.File.SetAccessControl(pathLambda, fileSecurityLambda));
        }


        public static IObservable<System.IO.FileStream> OpenRead(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.File.OpenRead(pathLambda));
        }


        public static IObservable<System.IO.FileStream> OpenWrite(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.File.OpenWrite(pathLambda));
        }


        public static IObservable<System.String> ReadAllText(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.File.ReadAllText(pathLambda));
        }


        public static IObservable<System.String> ReadAllText(IObservable<System.String> path,
            IObservable<System.Text.Encoding> encoding)
        {
            return Observable.Zip(path, encoding,
                (pathLambda, encodingLambda) => System.IO.File.ReadAllText(pathLambda, encodingLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteAllText(IObservable<System.String> path,
            IObservable<System.String> contents)
        {
            return ObservableExt.ZipExecute(path, contents,
                (pathLambda, contentsLambda) => System.IO.File.WriteAllText(pathLambda, contentsLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteAllText(IObservable<System.String> path,
            IObservable<System.String> contents, IObservable<System.Text.Encoding> encoding)
        {
            return ObservableExt.ZipExecute(path, contents, encoding,
                (pathLambda, contentsLambda, encodingLambda) =>
                    System.IO.File.WriteAllText(pathLambda, contentsLambda, encodingLambda));
        }


        public static IObservable<System.Byte[]> ReadAllBytes(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.File.ReadAllBytes(pathLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteAllBytes(IObservable<System.String> path,
            IObservable<System.Byte[]> bytes)
        {
            return ObservableExt.ZipExecute(path, bytes,
                (pathLambda, bytesLambda) => System.IO.File.WriteAllBytes(pathLambda, bytesLambda));
        }


        public static IObservable<System.String[]> ReadAllLines(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.File.ReadAllLines(pathLambda));
        }


        public static IObservable<System.String[]> ReadAllLines(IObservable<System.String> path,
            IObservable<System.Text.Encoding> encoding)
        {
            return Observable.Zip(path, encoding,
                (pathLambda, encodingLambda) => System.IO.File.ReadAllLines(pathLambda, encodingLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.String>> ReadLines(
            IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.File.ReadLines(pathLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.String>> ReadLines(
            IObservable<System.String> path, IObservable<System.Text.Encoding> encoding)
        {
            return Observable.Zip(path, encoding,
                (pathLambda, encodingLambda) => System.IO.File.ReadLines(pathLambda, encodingLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteAllLines(IObservable<System.String> path,
            IObservable<System.String[]> contents)
        {
            return ObservableExt.ZipExecute(path, contents,
                (pathLambda, contentsLambda) => System.IO.File.WriteAllLines(pathLambda, contentsLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteAllLines(IObservable<System.String> path,
            IObservable<System.String[]> contents, IObservable<System.Text.Encoding> encoding)
        {
            return ObservableExt.ZipExecute(path, contents, encoding,
                (pathLambda, contentsLambda, encodingLambda) =>
                    System.IO.File.WriteAllLines(pathLambda, contentsLambda, encodingLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteAllLines(IObservable<System.String> path,
            IObservable<System.Collections.Generic.IEnumerable<System.String>> contents)
        {
            return ObservableExt.ZipExecute(path, contents,
                (pathLambda, contentsLambda) => System.IO.File.WriteAllLines(pathLambda, contentsLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteAllLines(IObservable<System.String> path,
            IObservable<System.Collections.Generic.IEnumerable<System.String>> contents,
            IObservable<System.Text.Encoding> encoding)
        {
            return ObservableExt.ZipExecute(path, contents, encoding,
                (pathLambda, contentsLambda, encodingLambda) =>
                    System.IO.File.WriteAllLines(pathLambda, contentsLambda, encodingLambda));
        }


        public static IObservable<System.Reactive.Unit> AppendAllText(IObservable<System.String> path,
            IObservable<System.String> contents)
        {
            return ObservableExt.ZipExecute(path, contents,
                (pathLambda, contentsLambda) => System.IO.File.AppendAllText(pathLambda, contentsLambda));
        }


        public static IObservable<System.Reactive.Unit> AppendAllText(IObservable<System.String> path,
            IObservable<System.String> contents, IObservable<System.Text.Encoding> encoding)
        {
            return ObservableExt.ZipExecute(path, contents, encoding,
                (pathLambda, contentsLambda, encodingLambda) =>
                    System.IO.File.AppendAllText(pathLambda, contentsLambda, encodingLambda));
        }


        public static IObservable<System.Reactive.Unit> AppendAllLines(IObservable<System.String> path,
            IObservable<System.Collections.Generic.IEnumerable<System.String>> contents)
        {
            return ObservableExt.ZipExecute(path, contents,
                (pathLambda, contentsLambda) => System.IO.File.AppendAllLines(pathLambda, contentsLambda));
        }


        public static IObservable<System.Reactive.Unit> AppendAllLines(IObservable<System.String> path,
            IObservable<System.Collections.Generic.IEnumerable<System.String>> contents,
            IObservable<System.Text.Encoding> encoding)
        {
            return ObservableExt.ZipExecute(path, contents, encoding,
                (pathLambda, contentsLambda, encodingLambda) =>
                    System.IO.File.AppendAllLines(pathLambda, contentsLambda, encodingLambda));
        }


        public static IObservable<System.Reactive.Unit> Move(IObservable<System.String> sourceFileName,
            IObservable<System.String> destFileName)
        {
            return ObservableExt.ZipExecute(sourceFileName, destFileName,
                (sourceFileNameLambda, destFileNameLambda) =>
                    System.IO.File.Move(sourceFileNameLambda, destFileNameLambda));
        }


        public static IObservable<System.Reactive.Unit> Replace(IObservable<System.String> sourceFileName,
            IObservable<System.String> destinationFileName, IObservable<System.String> destinationBackupFileName)
        {
            return ObservableExt.ZipExecute(sourceFileName, destinationFileName, destinationBackupFileName,
                (sourceFileNameLambda, destinationFileNameLambda, destinationBackupFileNameLambda) =>
                    System.IO.File.Replace(sourceFileNameLambda, destinationFileNameLambda,
                        destinationBackupFileNameLambda));
        }


        public static IObservable<System.Reactive.Unit> Replace(IObservable<System.String> sourceFileName,
            IObservable<System.String> destinationFileName, IObservable<System.String> destinationBackupFileName,
            IObservable<System.Boolean> ignoreMetadataErrors)
        {
            return ObservableExt.ZipExecute(sourceFileName, destinationFileName, destinationBackupFileName,
                ignoreMetadataErrors,
                (sourceFileNameLambda, destinationFileNameLambda, destinationBackupFileNameLambda,
                    ignoreMetadataErrorsLambda) =>
                    System.IO.File.Replace(sourceFileNameLambda, destinationFileNameLambda,
                        destinationBackupFileNameLambda, ignoreMetadataErrorsLambda));
        }
    }
}