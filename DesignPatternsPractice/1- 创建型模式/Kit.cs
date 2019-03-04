using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignPatternsPractice
{
    [Serializable]
    public class Kit
    {
        public Kit()
        {
            Thread.Sleep(1000);
        }

        public IMouse Mouse { set; get; } = null;
        public IKeyBoard Keyboard { set; get; } = null;

        public object Clone()
        {
            return this.DeepCloneWithBinaryFormatter();
        }

        private object DeepCloneWithXmlSerializer()
        {
            object resultObj;

            using (MemoryStream stream = new MemoryStream())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Kit));
                serializer.Serialize(stream, this);
                stream.Seek(0, SeekOrigin.Begin);
                resultObj = serializer.Deserialize(stream);
            }

            return resultObj;
        }

        private object DeepCloneWithDataContractSerializer()
        {
            object resultObj;

            using (MemoryStream stream = new MemoryStream())
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(Kit));
                serializer.WriteObject(stream, this);
                stream.Seek(0, SeekOrigin.Begin);
                resultObj = serializer.ReadObject(stream);
            }

            return resultObj;
        }

        private object DeepCloneWithBinaryFormatter()
        {
            object resultObj;

            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(stream, this);
                stream.Seek(0, SeekOrigin.Begin);
                resultObj = serializer.Deserialize(stream);
            }

            return resultObj;
        }

        private object DeepCloneWithReflection(object obj, Dictionary<int, object> clonedObjDict, Dictionary<int, object> newObjDict)
        {
            if (obj == null)
            {
                return null;
            }

            if (clonedObjDict == null)
            {
                clonedObjDict = new Dictionary<int, object>();
            }

            if (newObjDict == null)
            {
                newObjDict = new Dictionary<int, object>();
            }

            Type objType = obj.GetType();

            if (obj is string
                || objType.IsValueType)
            {
                return obj;
            }

            if (objType.IsArray)
            {
                Type elementType = Type.GetType(objType.FullName.Replace("[]", string.Empty));
                Array array = obj as Array;
                Array newArray = Array.CreateInstance(elementType, array.Length);
                for (int i = 0, len = array.Length; i < len; i++)
                {
                    newArray.SetValue(this.DeepCloneWithReflection(array.GetValue(i), clonedObjDict, newObjDict), i);
                }

                return Convert.ChangeType(newArray, objType);
            }

            //判断是否存在循环引用
            int clonedObjKey = -1;
            foreach (var clonedObj in clonedObjDict)
            {
                if (object.ReferenceEquals(obj, clonedObj.Value))
                {
                    clonedObjKey = clonedObj.Key;
                    break;
                }
            }

            if (clonedObjKey > -1)
            {
                return newObjDict[clonedObjKey];
            }

            var newObj = Activator.CreateInstance(objType);
            int newKey = clonedObjDict.Count;
            clonedObjDict.Add(newKey, obj);
            newObjDict.Add(newKey, newObj);

            PropertyInfo[] properties = objType.GetProperties(BindingFlags.Public
                                                                | BindingFlags.NonPublic
                                                                | BindingFlags.Instance
                                                                | BindingFlags.Static);

            foreach (var property in properties)
            {
                object propValue = property.GetValue(obj);
                if (propValue != null)
                {
                    property.SetValue(newObj, this.DeepCloneWithReflection(propValue, clonedObjDict, newObjDict));
                }
            }

            return newObj;
        }
    }
}
