using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Uppg1DAL
{
    public class Serialization
    {
        public static T BinaryDeserialize<T>(string fileName)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(fileName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                return (T)bf.Deserialize(fileStream);
            }
            finally
            {
                if(fileStream != null)
                {
                    fileStream.Close();
                }
            }

        }
        public static T Binaryserialize<T>(T list, string fileName)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(fileName, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fileStream, list);
                return list;
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
        }
        }
}
