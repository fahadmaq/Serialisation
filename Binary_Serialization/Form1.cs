using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//binary serialization
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

using System.Xml.Serialization;
//xml serialization
//SOap
using System.Runtime.Serialization.Formatters.Soap;
//json
using System.Text.Json;


namespace Binary_Serialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4\product.dat";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Write);
                BinaryFormatter formatter = new BinaryFormatter();
                Product p1 = new Product();
                p1.Id = Convert.ToInt32(teId.Text);
                p1.Name = txName.Text;
                p1.Price = Convert.ToInt32(txPrice.Text);
                formatter.Serialize(fileStream, p1);
                fileStream.Close();
                MessageBox.Show("Done");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void bBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4\product.dat";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                Product p1 = new Product();
                // we done explicit type casting from Object --> Product
                p1 = (Product)formatter.Deserialize(fileStream);
                teId.Text = p1.Id.ToString();
                txName.Text = p1.Name;
                txPrice.Text = p1.Price.ToString();

                fileStream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4\product.xml";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product)); Product p1 = new Product();
                p1.Id = Convert.ToInt32(teId.Text);
                p1.Name = txName.Text;
                p1.Price = Convert.ToInt32(txPrice.Text);
                xmlSerializer.Serialize(fileStream, p1);
                fileStream.Close();
                MessageBox.Show("Done");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4\product.xml";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product)); Product p1 = new Product();
                // we done explicit type casting from Object --> Product
                p1 = (Product)xmlSerializer.Deserialize(fileStream);
                teId.Text = p1.Id.ToString();
                txName.Text = p1.Name;
                txPrice.Text = p1.Price.ToString();

                fileStream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4\product.soap";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
               SoapFormatter SoapFormatter = new SoapFormatter();
                Product p1 = new Product();
                p1.Id = Convert.ToInt32(teId.Text);
                p1.Name = txName.Text;
                p1.Price = Convert.ToInt32(txPrice.Text);
                SoapFormatter.Serialize(fileStream, p1);
                fileStream.Close();
                MessageBox.Show("Done");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bSOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4\product.xml";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                SoapFormatter soapFormatter = new SoapFormatter();
                // we done explicit type casting from Object --> Product
                Product p1 = new Product();
                p1 = (Product)soapFormatter.Deserialize(fileStream);
                teId.Text = p1.Id.ToString();
                txName.Text = p1.Name;
                txPrice.Text = p1.Price.ToString();

                fileStream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4\product.json";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                
                Product p1 = new Product();
                p1.Id = Convert.ToInt32(teId.Text);
                p1.Name = txName.Text;
                p1.Price = Convert.ToInt32(txPrice.Text);
                JsonSerializer.Serialize<Product>(fileStream, p1);
                fileStream.Close();
                MessageBox.Show("Done");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bJSONRead_Click(object sender, EventArgs e)
        {

            try
            {
                string path = @"D:\DP4\product.json";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
               
                // we done explicit type casting from Object --> Product
                Product p1 = new Product();
                p1 = JsonSerializer.Deserialize<Product>(fileStream);

                teId.Text = p1.Id.ToString();
                txName.Text = p1.Name;
                txPrice.Text = p1.Price.ToString();

                fileStream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
