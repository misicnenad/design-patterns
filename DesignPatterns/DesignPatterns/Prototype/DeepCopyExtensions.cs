using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DesignPatterns.DesignPatterns.Prototype
{
    static class DeepCopyExtensions
    {
        public static T DeepCopy<T>(this T self)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, self);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }
    }
}
