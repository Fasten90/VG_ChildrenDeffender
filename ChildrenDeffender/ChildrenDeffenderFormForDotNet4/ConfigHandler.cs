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

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }

        public bool LoadConfigsFromXML(ChildrenDeffenderConfig Config)
        {

            try
            {
                System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(ChildrenDeffenderConfig));

                System.IO.StreamReader file = new System.IO.StreamReader(
                    @"Config.xml");
                Config = (ChildrenDeffenderConfig)reader.Deserialize(file);
                file.Close();

                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
           


        }

    }
}
