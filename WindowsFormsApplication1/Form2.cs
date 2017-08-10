using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string xmlStr = @"
<xml>
    <menulist>
        <menu code=""PG0000101"" parentcode=""PG00001"">
            <path>\Upload\Index</path>
        </menu>
        <menu code=""PG0000102"" parentcode=""PG00001"">
            <path>\Upload1\Index1</path>
        </menu>
        <menu code=""PG0000301"" parentcode=""PG00003"">
            <path>\Import\Index</path>
        </menu> 
    </menulist>
</xml>";


            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(xmlStr);//載入xml檔

            string xPathExpression2 = "xml/menulist/menu[@code='PG0000102'][@parentcode='PG00001']";
            //string xPathExpression2 = "xml/menulist/menu[@parentcode='PG00001']";
            //string xPathExpression2 = "xml/menulist/menu[@code='PG0000102']";
            XmlNodeList nodelist = xmldoc.SelectNodes(xPathExpression2);

            //XmlNode node = xmldoc.SelectSingleNode(xPathExpression2);//single node




        }
    }
}
