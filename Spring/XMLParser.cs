using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using System.Xml.Linq;

namespace Spring
{

    class XMLParser
    {
        public static Ground XMLReader(String MapFileName)
        {
            Ground g;
            var stream = TitleContainer.OpenStream("Maps/" + MapFileName + ".xml");        
            XElement maps = XDocument.Load(stream).Element("maps");
            
            //TODO
            var map = maps.Element("map");
            //REPLACE BY FOLLOWING when multi maps
            //foreach (var map in maps.Element("maps").Descendants("map"))

            {
                g = new Ground();
                g.id = int.Parse(map.Element("id").Value.ToString());
                g.name = map.Element("name").Value;
                g.width = int.Parse(map.Element("widht").Value.ToString());
                g.height = int.Parse(map.Element("height").Value.ToString());
                g.spriteSheet = map.Element("spritesheet").Value;
                g.layersNumber = int.Parse(map.Element("layersNumber").Value.ToString());
                g.layers = new Layer[g.layersNumber];


                for (int l = 0; l < g.layersNumber; l++)
                {
                    g.layers[l] = new Layer(g.width, g.height);
                    foreach (var layer in map.Element("layers").Descendants("layer"))
                    {
                        String s = layer.Value;
                        String[] rows = s.Split('/');
                        int i = 0;
                        foreach (String row in rows)
                        {
                            String[] column = row.Split(',');
                            int j = 0;
                            foreach (String data in column)
                            {
                                g.layers[l].layer[j,i] = int.Parse(data);
                                j++;
                            }
                        i++;
                        }
                    }
                }
            }            
            return g;
        }
    }
}
