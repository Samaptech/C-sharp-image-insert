using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insert_image_in_C_Sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string imgName;
        SqlConnection con = new SqlConnection("Data Source=COMPUTER;Initial Catalog=onlyImageUpload;Integrated Security=True");

        private void imgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.png; *.jpeg)|*.jpg; *.png; *.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                productImage.Image = Image.FromFile(ofd.FileName);
                pathName.Text = ofd.FileName;
                fileName.Text = Path.GetFileName(ofd.FileName);
                imgName = Path.GetFileName(ofd.FileName);

                if (!Directory.Exists(Path.Combine(Application.StartupPath,"Product_Image")))
                {
                    Directory.CreateDirectory(Path.Combine(Application.StartupPath, "Product_Image"));
                }
                String destFileName = Path.Combine(Application.StartupPath, "Product_Image", imgName);
                File.Copy(ofd.FileName, destFileName, true);
            }
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO product VALUES(@img)", con);
            cmd.Parameters.AddWithValue("@img" , imgName);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted");
            con.Close();
        }
    }
}
