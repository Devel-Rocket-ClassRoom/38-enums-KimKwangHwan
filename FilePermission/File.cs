using System;
using System.Collections.Generic;
using System.Text;

public class File
{
    public FilePermission p;
    public File()
    {
        p = FilePermission.None;
    }
    [Flags]
    public enum FilePermission
    {
        None = 0,
        Read = 1,
        Write = 1 << 1,
        Execute = 1 << 2
    }

    public override string ToString()
    {
        return $"{p}";
    }
}