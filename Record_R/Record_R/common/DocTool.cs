using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.RepresentationModel;

namespace Record_R.common
{
    static class DocTool
    {
        //public static string[] getFileName()
        //{
        //    List<string> names = new List<string>();
        //    string[] dir = Directory.GetFiles("records");

        //    foreach (string path in dir)
        //    {
        //        names.Add(Path.GetFileNameWithoutExtension(path));
        //    }
        //    return names.ToArray();
        //}

        public static int lastId(String item)
        {
            int index = 0;
            try
            {
                using (var reader = new StreamReader("records/" + item + ".yaml"))
                {
                    YamlStream yaml = new YamlStream();
                    yaml.Load(reader);
                    YamlSequenceNode seqNode = (YamlSequenceNode)yaml.Documents[0].RootNode;
                    int lastIndex = seqNode.Children.Count - 1;
                    YamlNode yn = seqNode.Children[lastIndex];
                    index = int.Parse(yn["id"].ToString());
                }
            }
            catch (Exception ex)
            {

            }
            return index;
        }
    }
}
