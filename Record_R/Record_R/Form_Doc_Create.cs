using Record_R.common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.Core;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;

namespace Record_R
{
    public partial class Form_Doc_Create : Form
    {
        public Form_Doc_Create()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            List<Document> list = new List<Document>();
            if (checkValue())
            {
                Document doc = new Document()
                {
                    id = DocTool.lastId("Web") + 1,
                    description = tbDesc.Text,
                    url = tbUrl.Text
                };
                list.Add(doc);
                ISerializer sb = new SerializerBuilder().Build();
                string str = sb.Serialize(list);
                File.AppendAllText("records/Web.yaml", str);
                clear();
            }
        }

        private bool checkValue()
        {
            if (string.IsNullOrEmpty(tbDesc.Text) || string.IsNullOrEmpty(tbUrl.Text))
            {
                return false;
            }
            return true;
        }

        private void clear()
        {
            tbDesc.Clear();
            tbUrl.Clear();
        }

    }
}
