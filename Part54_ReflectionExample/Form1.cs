using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part54_ReflectionExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string typeName = txtTypeName.Text;
            Type t = Type.GetType(typeName);

            listMethods.Items.Clear();
            listProperties.Items.Clear();
            listConstructor.Items.Clear();

            // Get methods
            var methods = t.GetMethods();
            foreach (var method in methods)
                listMethods.Items.Add(method.Name);

            // Get properties
            var properties = t.GetProperties();
            foreach (var property in properties)
                listProperties.Items.Add(property.Name);

            // Get constructors
            var constructors = t.GetConstructors();
            foreach (var constructor in constructors)
                listConstructor.Items.Add(constructor.Name);
        }
    }
}
