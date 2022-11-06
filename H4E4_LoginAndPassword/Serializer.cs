using System.IO;
using System.Xml.Serialization;

namespace H4E4_LoginAndPassword
{
    public class Serializer
    {
        public static void SerializeData(Account account)
        {
            var serializer = new XmlSerializer(typeof(Account));
            using (var stream = new FileStream($"{nameof(Account)}.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, account);
            }
        }

        public static Account DeserializeData()
        {
            var serializer = new XmlSerializer(typeof(Account));
            using (var stream = new FileStream($"{nameof(Account)}.xml", FileMode.Open))
            {
                var account = (Account)serializer.Deserialize(stream);
                return account;
            }          
        }
    }
}