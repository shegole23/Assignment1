using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;

namespace EmployeeApp
{
   static class FileHelper
    {
        public async static void WriteTextFileAsync(string filename, string content)
        {
            var storagefolder = ApplicationData.Current.LocalFolder;
            var textfile = await storagefolder.CreateFileAsync(filename, CreationCollisionOption.OpenIfExists);
            var textStream = await textfile.OpenAsync(FileAccessMode.ReadWrite);
            var textWrite = new DataWriter(textStream);
            textWrite.WriteString(content);
            await textWrite.StoreAsync();
        }

        public async static Task<string> ReadTextFileAsync
            (string filename)
        {
            var storageFolder = ApplicationData.Current.LocalFolder;
            var textFile = await storageFolder.GetFileAsync(filename);
            var textStream = await textFile.OpenReadAsync();

            var textReader = new DataReader(textStream);
            var textLength = textStream.Size;
            await textReader.LoadAsync((uint)textLength);
            return textReader.ReadString((uint)textLength);
        }
    }
}
