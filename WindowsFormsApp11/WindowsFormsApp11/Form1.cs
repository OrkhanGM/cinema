using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Cinemaplus : Form
    {

         bool CheckStatus = true;
       

        public Cinemaplus()
        {
            InitializeComponent();
        }


        private void Cinemaplus_Load(object sender, EventArgs e)
        {
            var btn = new Button();
            btn.Click += new System.EventHandler(this.button_Click);
            

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.Red;
            if (CheckStatus)
            {
                button.BackColor = Color.GreenYellow;
                CheckStatus = false;
            }
            else
            {
                button.BackColor = Color.Red;
                CheckStatus = true;
            }

            
        }

      
    }
}
