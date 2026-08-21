using System.IO;
public class DirectoryDemo
{
    public void DirectoryDemoFunc(string directoryname)
    {
        if (Directory.Exists(directoryname))
        {
            System.Console.WriteLine("Directory already exists.");
        }
        else
        {
            Directory.CreateDirectory(directoryname);
            System.Console.WriteLine("Directory created successfully.");
        }
    }

    public void DriveInfoFunc(string driveName)
    {
        DriveInfo dInfo = new DriveInfo(driveName);
        System.Console.WriteLine("Drive Name: " + dInfo.Name);
        System.Console.WriteLine("Drive File system: " + dInfo.DriveType);
        System.Console.WriteLine("Total Size: " + dInfo.TotalSize);
        System.Console.WriteLine("Available Free Space: " + dInfo.AvailableFreeSpace);
    }

    public void PathDemoFunc()
    {
        
    }
        
    
}