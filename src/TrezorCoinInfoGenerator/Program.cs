using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Trezor.Net;

namespace TrezorCoinInfoGenerator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var coinInfos = new List<CoinInfo>();

            foreach (var fileName in Directory.GetFiles(@"C:\GitRepos\trezor-mcu\vendor\trezor-common\defs\bitcoin").Where(f => Path.GetExtension(f).ToLower() == ".json"))
            {
                var text = File.ReadAllText(fileName);
                var coinInfo = JsonConvert.DeserializeObject<RawCoinInfo>(text);
                coinInfos.Add(new CoinInfo(coinInfo.coin_name, AddressType.Bitcoin, coinInfo.segwit, coinInfo.slip44));
            }

            var contents = SerialiseObject(coinInfos);

            File.WriteAllText("Coins.xml", contents);
        }

        public static string SerialiseObject<SerialiseType>(SerialiseType theObject)
        {
            var sb = new StringBuilder();
            using (var streamWriter = new StringWriter(sb))
            {
                var xmlAttributes = new XmlAttributes();
                var attribOverrides = new XmlAttributeOverrides();

                xmlAttributes.XmlIgnore = true;
                attribOverrides.Add(theObject.GetType(), xmlAttributes);

                var serializer = new XmlSerializer(theObject.GetType(), attribOverrides);
                serializer.Serialize(streamWriter, theObject);
            }

            return sb.ToString();
        }

        public static SerialiseType DeserialiseObject<SerialiseType>(string objectXml)
        {
            var serializer = new XmlSerializer(typeof(SerialiseType));
            var sr = new StringReader(objectXml);
            var retVal = serializer.Deserialize(sr);
            return (SerialiseType)retVal;
        }
    }
}
