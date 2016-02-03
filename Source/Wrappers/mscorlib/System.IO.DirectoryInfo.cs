using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO
{
public static class _DirectoryInfo
{
    
public static IObservable<System.IO.DirectoryInfo> CreateSubdirectory(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue, IObservable<System.String> path)
{
    return Observable.Zip(DirectoryInfoValue, path, (DirectoryInfoValueLambda, pathLambda) => DirectoryInfoValueLambda.CreateSubdirectory(pathLambda));
}


public static IObservable<System.IO.DirectoryInfo> CreateSubdirectory(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue, IObservable<System.String> path, IObservable<System.Security.AccessControl.DirectorySecurity> directorySecurity)
{
    return Observable.Zip(DirectoryInfoValue, path, directorySecurity, (DirectoryInfoValueLambda, pathLambda, directorySecurityLambda) => DirectoryInfoValueLambda.CreateSubdirectory(pathLambda, directorySecurityLambda));
}


public static IObservable<System.Reactive.Unit> Create(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue)
{
    return Observable.Do(DirectoryInfoValue, (DirectoryInfoValueLambda) => DirectoryInfoValueLambda.Create()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Create(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue, IObservable<System.Security.AccessControl.DirectorySecurity> directorySecurity)
{
    return ObservableExt.ZipExecute(DirectoryInfoValue, directorySecurity, (DirectoryInfoValueLambda, directorySecurityLambda) => DirectoryInfoValueLambda.Create(directorySecurityLambda));
}


public static IObservable<System.Security.AccessControl.DirectorySecurity> GetAccessControl(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue)
{
    return Observable.Select(DirectoryInfoValue, (DirectoryInfoValueLambda) => DirectoryInfoValueLambda.GetAccessControl());
}


public static IObservable<System.Security.AccessControl.DirectorySecurity> GetAccessControl(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue, IObservable<System.Security.AccessControl.AccessControlSections> includeSections)
{
    return Observable.Zip(DirectoryInfoValue, includeSections, (DirectoryInfoValueLambda, includeSectionsLambda) => DirectoryInfoValueLambda.GetAccessControl(includeSectionsLambda));
}


public static IObservable<System.Reactive.Unit> SetAccessControl(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue, IObservable<System.Security.AccessControl.DirectorySecurity> directorySecurity)
{
    return ObservableExt.ZipExecute(DirectoryInfoValue, directorySecurity, (DirectoryInfoValueLambda, directorySecurityLambda) => DirectoryInfoValueLambda.SetAccessControl(directorySecurityLambda));
}


public static IObservable<System.IO.FileInfo[]> GetFiles(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue, IObservable<System.String> searchPattern)
{
    return Observable.Zip(DirectoryInfoValue, searchPattern, (DirectoryInfoValueLambda, searchPatternLambda) => DirectoryInfoValueLambda.GetFiles(searchPatternLambda));
}


public static IObservable<System.IO.FileInfo[]> GetFiles(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue, IObservable<System.String> searchPattern, IObservable<System.IO.SearchOption> searchOption)
{
    return Observable.Zip(DirectoryInfoValue, searchPattern, searchOption, (DirectoryInfoValueLambda, searchPatternLambda, searchOptionLambda) => DirectoryInfoValueLambda.GetFiles(searchPatternLambda, searchOptionLambda));
}


public static IObservable<System.IO.FileInfo[]> GetFiles(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue)
{
    return Observable.Select(DirectoryInfoValue, (DirectoryInfoValueLambda) => DirectoryInfoValueLambda.GetFiles());
}


public static IObservable<System.IO.DirectoryInfo[]> GetDirectories(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue)
{
    return Observable.Select(DirectoryInfoValue, (DirectoryInfoValueLambda) => DirectoryInfoValueLambda.GetDirectories());
}


public static IObservable<System.IO.FileSystemInfo[]> GetFileSystemInfos(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue, IObservable<System.String> searchPattern)
{
    return Observable.Zip(DirectoryInfoValue, searchPattern, (DirectoryInfoValueLambda, searchPatternLambda) => DirectoryInfoValueLambda.GetFileSystemInfos(searchPatternLambda));
}


public static IObservable<System.IO.FileSystemInfo[]> GetFileSystemInfos(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue, IObservable<System.String> searchPattern, IObservable<System.IO.SearchOption> searchOption)
{
    return Observable.Zip(DirectoryInfoValue, searchPattern, searchOption, (DirectoryInfoValueLambda, searchPatternLambda, searchOptionLambda) => DirectoryInfoValueLambda.GetFileSystemInfos(searchPatternLambda, searchOptionLambda));
}


public static IObservable<System.IO.FileSystemInfo[]> GetFileSystemInfos(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue)
{
    return Observable.Select(DirectoryInfoValue, (DirectoryInfoValueLambda) => DirectoryInfoValueLambda.GetFileSystemInfos());
}


public static IObservable<System.IO.DirectoryInfo[]> GetDirectories(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue, IObservable<System.String> searchPattern)
{
    return Observable.Zip(DirectoryInfoValue, searchPattern, (DirectoryInfoValueLambda, searchPatternLambda) => DirectoryInfoValueLambda.GetDirectories(searchPatternLambda));
}


public static IObservable<System.IO.DirectoryInfo[]> GetDirectories(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue, IObservable<System.String> searchPattern, IObservable<System.IO.SearchOption> searchOption)
{
    return Observable.Zip(DirectoryInfoValue, searchPattern, searchOption, (DirectoryInfoValueLambda, searchPatternLambda, searchOptionLambda) => DirectoryInfoValueLambda.GetDirectories(searchPatternLambda, searchOptionLambda));
}


public static IObservable<System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo>> EnumerateDirectories(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue)
{
    return Observable.Select(DirectoryInfoValue, (DirectoryInfoValueLambda) => DirectoryInfoValueLambda.EnumerateDirectories());
}


public static IObservable<System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo>> EnumerateDirectories(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue, IObservable<System.String> searchPattern)
{
    return Observable.Zip(DirectoryInfoValue, searchPattern, (DirectoryInfoValueLambda, searchPatternLambda) => DirectoryInfoValueLambda.EnumerateDirectories(searchPatternLambda));
}


public static IObservable<System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo>> EnumerateDirectories(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue, IObservable<System.String> searchPattern, IObservable<System.IO.SearchOption> searchOption)
{
    return Observable.Zip(DirectoryInfoValue, searchPattern, searchOption, (DirectoryInfoValueLambda, searchPatternLambda, searchOptionLambda) => DirectoryInfoValueLambda.EnumerateDirectories(searchPatternLambda, searchOptionLambda));
}


public static IObservable<System.Collections.Generic.IEnumerable<System.IO.FileInfo>> EnumerateFiles(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue)
{
    return Observable.Select(DirectoryInfoValue, (DirectoryInfoValueLambda) => DirectoryInfoValueLambda.EnumerateFiles());
}


public static IObservable<System.Collections.Generic.IEnumerable<System.IO.FileInfo>> EnumerateFiles(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue, IObservable<System.String> searchPattern)
{
    return Observable.Zip(DirectoryInfoValue, searchPattern, (DirectoryInfoValueLambda, searchPatternLambda) => DirectoryInfoValueLambda.EnumerateFiles(searchPatternLambda));
}


public static IObservable<System.Collections.Generic.IEnumerable<System.IO.FileInfo>> EnumerateFiles(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue, IObservable<System.String> searchPattern, IObservable<System.IO.SearchOption> searchOption)
{
    return Observable.Zip(DirectoryInfoValue, searchPattern, searchOption, (DirectoryInfoValueLambda, searchPatternLambda, searchOptionLambda) => DirectoryInfoValueLambda.EnumerateFiles(searchPatternLambda, searchOptionLambda));
}


public static IObservable<System.Collections.Generic.IEnumerable<System.IO.FileSystemInfo>> EnumerateFileSystemInfos(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue)
{
    return Observable.Select(DirectoryInfoValue, (DirectoryInfoValueLambda) => DirectoryInfoValueLambda.EnumerateFileSystemInfos());
}


public static IObservable<System.Collections.Generic.IEnumerable<System.IO.FileSystemInfo>> EnumerateFileSystemInfos(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue, IObservable<System.String> searchPattern)
{
    return Observable.Zip(DirectoryInfoValue, searchPattern, (DirectoryInfoValueLambda, searchPatternLambda) => DirectoryInfoValueLambda.EnumerateFileSystemInfos(searchPatternLambda));
}


public static IObservable<System.Collections.Generic.IEnumerable<System.IO.FileSystemInfo>> EnumerateFileSystemInfos(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue, IObservable<System.String> searchPattern, IObservable<System.IO.SearchOption> searchOption)
{
    return Observable.Zip(DirectoryInfoValue, searchPattern, searchOption, (DirectoryInfoValueLambda, searchPatternLambda, searchOptionLambda) => DirectoryInfoValueLambda.EnumerateFileSystemInfos(searchPatternLambda, searchOptionLambda));
}


public static IObservable<System.Reactive.Unit> MoveTo(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue, IObservable<System.String> destDirName)
{
    return ObservableExt.ZipExecute(DirectoryInfoValue, destDirName, (DirectoryInfoValueLambda, destDirNameLambda) => DirectoryInfoValueLambda.MoveTo(destDirNameLambda));
}


public static IObservable<System.Reactive.Unit> Delete(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue)
{
    return Observable.Do(DirectoryInfoValue, (DirectoryInfoValueLambda) => DirectoryInfoValueLambda.Delete()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Delete(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue, IObservable<System.Boolean> recursive)
{
    return ObservableExt.ZipExecute(DirectoryInfoValue, recursive, (DirectoryInfoValueLambda, recursiveLambda) => DirectoryInfoValueLambda.Delete(recursiveLambda));
}


public static IObservable<System.String> ToString(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue)
{
    return Observable.Select(DirectoryInfoValue, (DirectoryInfoValueLambda) => DirectoryInfoValueLambda.ToString());
}


public static IObservable<System.String> get_Name(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue)
{
    return Observable.Select(DirectoryInfoValue, (DirectoryInfoValueLambda) => DirectoryInfoValueLambda.Name);
}


public static IObservable<System.IO.DirectoryInfo> get_Parent(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue)
{
    return Observable.Select(DirectoryInfoValue, (DirectoryInfoValueLambda) => DirectoryInfoValueLambda.Parent);
}


public static IObservable<System.Boolean> get_Exists(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue)
{
    return Observable.Select(DirectoryInfoValue, (DirectoryInfoValueLambda) => DirectoryInfoValueLambda.Exists);
}


public static IObservable<System.IO.DirectoryInfo> get_Root(this IObservable<System.IO.DirectoryInfo> DirectoryInfoValue)
{
    return Observable.Select(DirectoryInfoValue, (DirectoryInfoValueLambda) => DirectoryInfoValueLambda.Root);
}

}
}