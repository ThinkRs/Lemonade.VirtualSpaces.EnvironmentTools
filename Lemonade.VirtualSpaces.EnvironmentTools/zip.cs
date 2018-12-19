using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;

public class SharpZip
{ 
    public static  void UnZip(string  directoryName, string outPutPath,string password)
    { 
        using (FileStream fileStreamIn = new FileStream(directoryName, FileMode.Open, FileAccess.Read))
        {
            using (ZipInputStream zipInStream = new ZipInputStream(fileStreamIn))
            {
                zipInStream.Password = password;
                ZipEntry zipEntry = zipInStream.GetNextEntry();  
                do
                {
                    if (zipEntry.IsFile)
                    {
                        string framename = outPutPath +"\\"+ zipEntry.Name.Substring(zipEntry.Name.IndexOf('/')+1,zipEntry.Name.Length- zipEntry.Name.IndexOf('/')-1);
                        using (FileStream fileStreamOut = new FileStream(framename, FileMode.Create, FileAccess.Write))
                        {

                            int size = 2048;
                            byte[] buffer = new byte[2048];
                            do
                            {
                                size = zipInStream.Read(buffer, 0, buffer.Length);
                                fileStreamOut.Write(buffer, 0, size);
                            } while (size > 0);
                        }
                    }
                    
                } while ((zipEntry = zipInStream.GetNextEntry()) != null);
            }
        }
    }
    
}
  