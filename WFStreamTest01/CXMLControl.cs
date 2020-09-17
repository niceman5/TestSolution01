using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WFStreamTest01
{
    class CXMLControl
    {
        public static string _TEXT_DATA = "TEXT_DATA";
        public static string _CBOX_DATA = "CBOX_DATA";
        public static string _NUMBER_DATA = "NUMBER_DATA";
        
        string strText = "";
        public Dictionary<string, string> Xml_Reader(string strXMLPath)
        {
            Dictionary<string, string> DXMLConfig = new Dictionary<string, string>();

            using (XmlReader xr = XmlReader.Create(strXMLPath))
            {
                while (xr.Read())
                {
                    if (xr.IsStartElement())
                    {
                        if (xr.Name.Equals("SETTING"))
                        {
                            string strId = xr["ID"];                            
                            xr.Read();

                            strText = xr.ReadElementContentAsString(_TEXT_DATA, "");
                            DXMLConfig.Add(_TEXT_DATA, strText);
                            strText = xr.ReadElementContentAsString(_CBOX_DATA, "");
                            DXMLConfig.Add(_CBOX_DATA, strText);
                            strText = xr.ReadElementContentAsString(_NUMBER_DATA, "");
                            DXMLConfig.Add(_NUMBER_DATA, strText);
                        }
                    }
                }

            }

            return DXMLConfig;
        }

        public void Xml_Writer(string strXMLPath, Dictionary<string, string> DXMLConfig)
        {
            using (XmlWriter xw = XmlWriter.Create(strXMLPath))
            {
                xw.WriteStartDocument();
                xw.WriteStartElement("SETTING");
                xw.WriteAttributeString("ID", "0001");
                xw.WriteElementString(_TEXT_DATA, DXMLConfig[_TEXT_DATA]);
                xw.WriteElementString(_CBOX_DATA, DXMLConfig[_CBOX_DATA]);
                xw.WriteElementString(_NUMBER_DATA, DXMLConfig[_NUMBER_DATA]);
                xw.WriteEndElement();
                xw.WriteEndDocument();

            }
        }
    }
}
