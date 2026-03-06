using System;
using System.Collections.Generic;
using System.Text;
using static File;

public class FileSystem
{
    private File file;
    public FileSystem()
    {
        file = new File();
    }
    public FileSystem(File file)
    {
        this.file = file; 
    }
    
    public void AddFlag(FilePermission p)
    {
        file.p |= p;
    }
    public bool HasFlag(FilePermission p)
    {
        return ((file.p & p) != 0);
    }

    public void DeleteFlag(FilePermission p)
    {
        file.p &= ~p;
    }

    public FilePermission GetCurrentFlag()
    {
        return file.p;
    }
}
