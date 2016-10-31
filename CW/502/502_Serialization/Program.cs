using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace _502_Serialization
{
    [Serializable]
    public class DataSerializationClass
    {
        public int IntData { get; set; }
        public double DoubleData { get; set; }
        public string StringData { get; set; }

        [NonSerialized]
        public string IdDataSerialization;
    }

    [Serializable]
    public class DataCustomSerializationClass : ISerializable
    {
        public int IntData { get; set; }
        public double DoubleData { get; set; }
        public string StringData { get; set; }

        public DataCustomSerializationClass()
        {
        }

        protected DataCustomSerializationClass(SerializationInfo info, StreamingContext context)
        {
            IntData = info.GetInt32("a");
            DoubleData = info.GetDouble("b");
            StringData = info.GetString("c");
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("i", IntData);
            info.AddValue("j", DoubleData);
            info.AddValue("k", StringData);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FirstSample();
        }

        private static void FirstSample()
        {
            DataSerializationClass obj = new DataSerializationClass
            {
                IntData = 1,
                DoubleData = 5.5,
                StringData = "Some String",
                IdDataSerialization = Guid.NewGuid().ToString("N").ToUpper()
            };

            IFormatter formatter = new BinaryFormatter();
            IFormatter soapFormatter = new SoapFormatter();
            XmlSerializer wr = new XmlSerializer(typeof(DataSerializationClass));
            Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            Stream soapStream = new FileStream("MySoapFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            FileStream fs = new FileStream("MyXMLFile.xml", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, obj);
            soapFormatter.Serialize(soapStream, obj);
            wr.Serialize(fs, obj);
            stream.Close();
            soapStream.Close();
            IFormatter formatter2 = new BinaryFormatter();
            IFormatter soapFormatter2 = new SoapFormatter();
            XmlSerializer read = new XmlSerializer(typeof(DataSerializationClass));
            Stream stream2 = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Stream soapStream2 = new FileStream("MySoapFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            FileStream fs2 = new FileStream("MyXMLFile.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            DataSerializationClass obj2 = (DataSerializationClass)formatter.Deserialize(stream2);
            DataSerializationClass soapObj2 = (DataSerializationClass)soapFormatter.Deserialize(soapStream2);
            DataSerializationClass XMLObj2 = (DataSerializationClass)read.Deserialize(fs2);
            stream.Close();
            soapStream.Close();
            fs2.Close();
            Console.WriteLine("Binary - int: {0}, double: {1}, str: {2}", obj2.IntData, obj2.DoubleData,
                obj2.StringData);
            Console.WriteLine("SOAP - int: {0}, double: {1}, str: {2}", soapObj2.IntData, soapObj2.DoubleData,
                soapObj2.StringData);
            Console.WriteLine("XML - int: {0}, double: {1}, str: {2}", XMLObj2.IntData, XMLObj2.DoubleData,
                XMLObj2.StringData);
        }
    }

}