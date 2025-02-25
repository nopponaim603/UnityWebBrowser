#if UNITY_EDITOR_LINUX || UNITY_STANDALONE_LINUX

using System.IO;
using Mono.Unix;

namespace UnityWebBrowser.UnixSupport
{
    /// <summary>
    ///     Unix support file permissions
    /// </summary>
    internal static class PermissionsManager
    {
        /// <summary>
        ///     Checks and sets (if needed) a file permission with UserReadWriteExecute
        /// </summary>
        /// <param name="fileLocation"></param>
        /// <exception cref="FileNotFoundException"></exception>
        public static bool CheckAndSetIfNeededFileExecutablePermission(string fileLocation)
        {
            UnixFileInfo fileInfo = new(fileLocation);
            if (!fileInfo.Exists)
                throw new FileNotFoundException("File was not found!", fileLocation);

            if (fileInfo.FileAccessPermissions.HasFlag(FileAccessPermissions.UserReadWriteExecute)) 
                return false;
        
            fileInfo.FileAccessPermissions |=
                fileInfo.FileAccessPermissions | FileAccessPermissions.UserReadWriteExecute;
            fileInfo.Refresh();
            return true;
        }
    }
}

#endif