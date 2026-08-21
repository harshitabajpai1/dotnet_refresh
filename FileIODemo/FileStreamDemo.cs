using System.IO;
public class FileStreamDemo
{
    FileStream fs = null;
    public void CreateFile(string fileName)
    {
        StreamWriter sw = null;
        try
        {
            fs = new FileStream(fileName,FileMode.Create, FileAccess.Write);
            sw =new StreamWriter(fs);
            sw.WriteLine("this is just a sample file for file io Demo");
        }
        catch(FileNotFoundException e){
            System.Console.WriteLine(e.Message);
        }
        // catch ()
        // {
        //     System.Console.WriteLine(e.Message);
        // }
        finally
        {
            sw.Close();
            fs.Close();
        }
        
        
    }
    public void ReadFile(string fileName)
    {
        fs = new FileStream(fileName, FileMode.Open,FileAccess.Read);
        StreamReader sr = new StreamReader(fs);
        System.Console.WriteLine(sr.ReadToEnd());
        sr.Close();
        fs.Close();
    }
}