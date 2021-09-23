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
    public partial class Form_IG_Create : Form
    {
        public Form_IG_Create()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            List<Ig> list = new List<Ig>();
            if (checkValue())
            {
                Ig doc = new Ig()
                {
                    id = DocTool.lastId("IG") + 1,
                    account = tbAccount.Text,
                    level = int.Parse(cbLevel.SelectedItem.ToString())
                };
                list.Add(doc);
                ISerializer sb = new SerializerBuilder().Build();
                string str = sb.Serialize(list);
                File.AppendAllText("records/IG.yaml", str);
                clear();
            }
        }
        private bool checkValue()
        {
            if (string.IsNullOrEmpty(tbAccount.Text) || cbLevel.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private void clear()
        {
            tbAccount.Clear();
            cbLevel.SelectedIndex = -1;
        }

        private void Form_IG_Create_Load(object sender, EventArgs e)
        {
            tbAccount.Focus();
        }
    }
}
