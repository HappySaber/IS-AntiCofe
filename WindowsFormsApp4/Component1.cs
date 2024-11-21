using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anticafe
{
    internal partial class Component1 : Component
    {
        public Component1(int i, string name, string cost, int count)
        {
            InitializeComponent();

            this.maskedTextBox1.Name += i.ToString();
            this.maskedTextBox1.ValidatingType = typeof(string);
            panel1.Controls.Add(maskedTextBox1);
            maskedTextBox1.Location = new Point(50, i);
            maskedTextBox1.Text = count.ToString();

            this.label1.Name += i.ToString();
            this.label1.Text = name;
            panel1.Controls.Add(label1);
            label1.Location = new Point(300, i);

            this.label2.Name += i.ToString();
            this.label2.Text = cost;
            panel1.Controls.Add(label2);
            label2.Location = new Point(450, i);
            SetHeight(47 * (i - 1));
        }

        public Component1(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public void SetHeight(int y)
        {
            this.panel1.Location = new System.Drawing.Point(panel1.Location.X, 250 + y);
        }
        public void addPanelInForm(AddOrder form)
        {
            form.Controls.Add(panel1);
            panel1.Size = new Size(1000, 47);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
        }
        public void addPanelInForm(ChangeOrder form)
        {
            form.Controls.Add(panel1);
            panel1.Size = new Size(1000, 47);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
        }
    }
}

