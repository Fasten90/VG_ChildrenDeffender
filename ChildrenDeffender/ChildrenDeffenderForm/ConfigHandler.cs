using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildrenDeffenderForm
{
    public class ConfigHandler
    {

        // Functions for Config
        
        public bool SaveConfigsToXML(ChildrenDeffenderConfig Config)
        {
            try
            {
                System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(ChildrenDeffenderConfig));

                System.IO.StreamWriter file = new System.IO.StreamWriter(
                    @"Config.xml");
                writer.Serialize(file, Config);
                file.Close();

                Log.SendEventLog("Config.xml file saved succesful.");

                return true;
            }
            catch (Exception e)
            {
                Log.SendErrorLog("Config.xml files saving has been failed: " + e.Message);
                return false;
            }

        }

        public ChildrenDeffenderConfig LoadConfigsFromXML(ChildrenDeffenderConfig config)
        {

            try
            {
                config = new ChildrenDeffenderConfig();

                System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(ChildrenDeffenderConfig));

                System.IO.StreamReader file = new System.IO.StreamReader(
                    @"Config.xml");
                config = (ChildrenDeffenderConfig)reader.Deserialize(file);
                file.Close();

                Log.SendEventLog("Config.xml file loaded succesful.");

                return config;

            }
            catch (Exception e)
            {
                Log.SendErrorLog("Config.xml files loading has been failed: " + e.Message);
                return null;
            }
           


        }

    }
}
