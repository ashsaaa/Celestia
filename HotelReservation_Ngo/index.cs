using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation_Ngo
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
            setcolor();
        }

        private void setcolor()
        {
            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#051927");
            panel3.BackColor = System.Drawing.ColorTranslator.FromHtml("#07263A");
            btn1.BackColor = System.Drawing.ColorTranslator.FromHtml("#07263A");
            btn1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D4D4D4");
            btn2.BackColor = System.Drawing.ColorTranslator.FromHtml("#07263A");
            btn2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D4D4D4");
            btn3.BackColor = System.Drawing.ColorTranslator.FromHtml("#07263A");
            btn3.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D4D4D4");
            btn4.BackColor = System.Drawing.ColorTranslator.FromHtml("#07263A");
            btn4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D4D4D4");
            btnLogout.BackColor = System.Drawing.ColorTranslator.FromHtml("#07263A");
            btnLogout.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D4D4D4");
            btn1.FlatAppearance.BorderSize = 0;
            btn2.FlatAppearance.BorderSize = 0;
            btn3.FlatAppearance.BorderSize = 0;
            btn4.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.BorderSize = 0;
        }

    }
}
