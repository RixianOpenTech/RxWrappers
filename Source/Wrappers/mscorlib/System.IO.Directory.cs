using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO
{
    public static class __Directory
    {
        
        public static IObservable<System.IO.DirectoryInfo> GetParent(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.Directory.GetParent(pathLambda));
        }


        public static IObservable<System.IO.DirectoryInfo> CreateDirectory(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.Directory.CreateDirectory(pathLambda));
        }


        public static IObservable<System.IO.DirectoryInfo> CreateDirectory(IObservable<System.String> path, IObservable<System.Security.AccessControl.DirectorySecurity> directorySecurity)
        {
            return Observable.Zip(path, directorySecurity, (pathLambda, directorySecurityLambda) => System.IO.Directory.CreateDirectory(pathLambda, directorySecurityLambda));
        }


        public static IObservable<System.Boolean> Exists(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.Directory.Exists(pathLambda));
        }


        public static IObservable<System.Reactive.Unit> SetCreationTime(IObservable<System.String> path, IObservable<System.DateTime> creationTime)
        {
            return ObservableExt.ZipExecute(path, creationTime, (pathLambda, creationTimeLambda) => System.IO.Directory.SetCreationTime(pathLambda, creationTimeLambda));
        }


        public static IObservable<System.Reactive.Unit> SetCreationTimeUtc(IObservable<System.String> path, IObservable<System.DateTime> creationTimeUtc)
        {
            return ObservableExt.ZipExecute(path, creationTimeUtc, (pathLambda, creationTimeUtcLambda) => System.IO.Directory.SetCreationTimeUtc(pathLambda, creationTimeUtcLambda));
        }


        public static IObservable<System.DateTime> GetCreationTime(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.Directory.GetCreationTime(pathLambda));
        }


        public static IObservable<System.DateTime> GetCreationTimeUtc(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.Directory.GetCreationTimeUtc(pathLambda));
        }


        public static IObservable<System.Reactive.Unit> SetLastWriteTime(IObservable<System.String> path, IObservable<System.DateTime> lastWriteTime)
        {
            return ObservableExt.ZipExecute(path, lastWriteTime, (pathLambda, lastWriteTimeLambda) => System.IO.Directory.SetLastWriteTime(pathLambda, lastWriteTimeLambda));
        }


        public static IObservable<System.Reactive.Unit> SetLastWriteTimeUtc(IObservable<System.String> path, IObservable<System.DateTime> lastWriteTimeUtc)
        {
            return ObservableExt.ZipExecute(path, lastWriteTimeUtc, (pathLambda, lastWriteTimeUtcLambda) => System.IO.Directory.SetLastWriteTimeUtc(pathLambda, lastWriteTimeUtcLambda));
        }


        public static IObservable<System.DateTime> GetLastWriteTime(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.Directory.GetLastWriteTime(pathLambda));
        }


        public static IObservable<System.DateTime> GetLastWriteTimeUtc(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.Directory.GetLastWriteTimeUtc(pathLambda));
        }


        public static IObservable<System.Reactive.Unit> SetLastAccessTime(IObservable<System.String> path, IObservable<System.DateTime> lastAccessTime)
        {
            return ObservableExt.ZipExecute(path, lastAccessTime, (pathLambda, lastAccessTimeLambda) => System.IO.Directory.SetLastAccessTime(pathLambda, lastAccessTimeLambda));
        }


        public static IObservable<System.Reactive.Unit> SetLastAccessTimeUtc(IObservable<System.String> path, IObservable<System.DateTime> lastAccessTimeUtc)
        {
            return ObservableExt.ZipExecute(path, lastAccessTimeUtc, (pathLambda, lastAccessTimeUtcLambda) => System.IO.Directory.SetLastAccessTimeUtc(pathLambda, lastAccessTimeUtcLambda));
        }


        public static IObservable<System.DateTime> GetLastAccessTime(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.Directory.GetLastAccessTime(pathLambda));
        }


        public static IObservable<System.DateTime> GetLastAccessTimeUtc(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.Directory.GetLastAccessTimeUtc(pathLambda));
        }


        public static IObservable<System.Security.AccessControl.DirectorySecurity> GetAccessControl(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.Directory.GetAccessControl(pathLambda));
        }


        public static IObservable<System.Security.AccessControl.DirectorySecurity> GetAccessControl(IObservable<System.String> path, IObservable<System.Security.AccessControl.AccessControlSections> includeSections)
        {
            return Observable.Zip(path, includeSections, (pathLambda, includeSectionsLambda) => System.IO.Directory.GetAccessControl(pathLambda, includeSectionsLambda));
        }


        public static IObservable<System.Reactive.Unit> SetAccessControl(IObservable<System.String> path, IObservable<System.Security.AccessControl.DirectorySecurity> directorySecurity)
        {
            return ObservableExt.ZipExecute(path, directorySecurity, (pathLambda, directorySecurityLambda) => System.IO.Directory.SetAccessControl(pathLambda, directorySecurityLambda));
        }


        public static IObservable<System.String[]> GetFiles(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.Directory.GetFiles(pathLambda));
        }


        public static IObservable<System.String[]> GetFiles(IObservable<System.String> path, IObservable<System.String> searchPattern)
        {
            return Observable.Zip(path, searchPattern, (pathLambda, searchPatternLambda) => System.IO.Directory.GetFiles(pathLambda, searchPatternLambda));
        }


        public static IObservable<System.String[]> GetFiles(IObservable<System.String> path, IObservable<System.String> searchPattern, IObservable<System.IO.SearchOption> searchOption)
        {
            return Observable.Zip(path, searchPattern, searchOption, (pathLambda, searchPatternLambda, searchOptionLambda) => System.IO.Directory.GetFiles(pathLambda, searchPatternLambda, searchOptionLambda));
        }


        public static IObservable<System.String[]> GetDirectories(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.Directory.GetDirectories(pathLambda));
        }


        public static IObservable<System.String[]> GetDirectories(IObservable<System.String> path, IObservable<System.String> searchPattern)
        {
            return Observable.Zip(path, searchPattern, (pathLambda, searchPatternLambda) => System.IO.Directory.GetDirectories(pathLambda, searchPatternLambda));
        }


        public static IObservable<System.String[]> GetDirectories(IObservable<System.String> path, IObservable<System.String> searchPattern, IObservable<System.IO.SearchOption> searchOption)
        {
            return Observable.Zip(path, searchPattern, searchOption, (pathLambda, searchPatternLambda, searchOptionLambda) => System.IO.Directory.GetDirectories(pathLambda, searchPatternLambda, searchOptionLambda));
        }


        public static IObservable<System.String[]> GetFileSystemEntries(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.Directory.GetFileSystemEntries(pathLambda));
        }


        public static IObservable<System.String[]> GetFileSystemEntries(IObservable<System.String> path, IObservable<System.String> searchPattern)
        {
            return Observable.Zip(path, searchPattern, (pathLambda, searchPatternLambda) => System.IO.Directory.GetFileSystemEntries(pathLambda, searchPatternLambda));
        }


        public static IObservable<System.String[]> GetFileSystemEntries(IObservable<System.String> path, IObservable<System.String> searchPattern, IObservable<System.IO.SearchOption> searchOption)
        {
            return Observable.Zip(path, searchPattern, searchOption, (pathLambda, searchPatternLambda, searchOptionLambda) => System.IO.Directory.GetFileSystemEntries(pathLambda, searchPatternLambda, searchOptionLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.String>> EnumerateDirectories(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.Directory.EnumerateDirectories(pathLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.String>> EnumerateDirectories(IObservable<System.String> path, IObservable<System.String> searchPattern)
        {
            return Observable.Zip(path, searchPattern, (pathLambda, searchPatternLambda) => System.IO.Directory.EnumerateDirectories(pathLambda, searchPatternLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.String>> EnumerateDirectories(IObservable<System.String> path, IObservable<System.String> searchPattern, IObservable<System.IO.SearchOption> searchOption)
        {
            return Observable.Zip(path, searchPattern, searchOption, (pathLambda, searchPatternLambda, searchOptionLambda) => System.IO.Directory.EnumerateDirectories(pathLambda, searchPatternLambda, searchOptionLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.String>> EnumerateFiles(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.Directory.EnumerateFiles(pathLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.String>> EnumerateFiles(IObservable<System.String> path, IObservable<System.String> searchPattern)
        {
            return Observable.Zip(path, searchPattern, (pathLambda, searchPatternLambda) => System.IO.Directory.EnumerateFiles(pathLambda, searchPatternLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.String>> EnumerateFiles(IObservable<System.String> path, IObservable<System.String> searchPattern, IObservable<System.IO.SearchOption> searchOption)
        {
            return Observable.Zip(path, searchPattern, searchOption, (pathLambda, searchPatternLambda, searchOptionLambda) => System.IO.Directory.EnumerateFiles(pathLambda, searchPatternLambda, searchOptionLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.String>> EnumerateFileSystemEntries(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.Directory.EnumerateFileSystemEntries(pathLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.String>> EnumerateFileSystemEntries(IObservable<System.String> path, IObservable<System.String> searchPattern)
        {
            return Observable.Zip(path, searchPattern, (pathLambda, searchPatternLambda) => System.IO.Directory.EnumerateFileSystemEntries(pathLambda, searchPatternLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.String>> EnumerateFileSystemEntries(IObservable<System.String> path, IObservable<System.String> searchPattern, IObservable<System.IO.SearchOption> searchOption)
        {
            return Observable.Zip(path, searchPattern, searchOption, (pathLambda, searchPatternLambda, searchOptionLambda) => System.IO.Directory.EnumerateFileSystemEntries(pathLambda, searchPatternLambda, searchOptionLambda));
        }


        public static IObservable<System.String[]> GetLogicalDrives()
        {
            return ObservableExt.Factory(() => System.IO.Directory.GetLogicalDrives());
        }


        public static IObservable<System.String> GetDirectoryRoot(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.Directory.GetDirectoryRoot(pathLambda));
        }


        public static IObservable<System.String> GetCurrentDirectory()
        {
            return ObservableExt.Factory(() => System.IO.Directory.GetCurrentDirectory());
        }


        public static IObservable<System.Reactive.Unit> SetCurrentDirectory(IObservable<System.String> path)
        {
            return Observable.Do(path, (pathLambda) => System.IO.Directory.SetCurrentDirectory(pathLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Move(IObservable<System.String> sourceDirName, IObservable<System.String> destDirName)
        {
            return ObservableExt.ZipExecute(sourceDirName, destDirName, (sourceDirNameLambda, destDirNameLambda) => System.IO.Directory.Move(sourceDirNameLambda, destDirNameLambda));
        }


        public static IObservable<System.Reactive.Unit> Delete(IObservable<System.String> path)
        {
            return Observable.Do(path, (pathLambda) => System.IO.Directory.Delete(pathLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Delete(IObservable<System.String> path, IObservable<System.Boolean> recursive)
        {
            return ObservableExt.ZipExecute(path, recursive, (pathLambda, recursiveLambda) => System.IO.Directory.Delete(pathLambda, recursiveLambda));
        }

    }
}