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
using YamlDotNet.RepresentationModel;

namespace Record_R
{
    public partial class Form_IG_Search : Form
    {
        public Form_IG_Search()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Account");
            dt.Columns.Add("Level");
            DataRow row;

            try
            {
                using (var reader = new StreamReader("records/IG.yaml"))
                {
                    YamlStream yaml = new YamlStream();
                    yaml.Load(reader);
                    YamlSequenceNode seqNode = (YamlSequenceNode)yaml.Documents[0].RootNode;

                    for (int i = seqNode.Children.Count - 1; i >= 0; i--)
                    {
                        YamlNode yn = seqNode.Children[i];
                        row = dt.NewRow();
                        row["id"] = yn["id"];
                        row["account"] = yn["account"];
                        row["level"] = yn["level"];
                        dt.Rows.Add(row);
                    }
                    dgvResult.DataSource = dt;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}