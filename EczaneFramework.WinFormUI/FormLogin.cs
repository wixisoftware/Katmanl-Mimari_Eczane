using EczaneFramework.Business.Abstract;
using EczaneFramework.Core.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneFramework.WinFormUI
{
    public partial class FormLogin : Form
    {

        IKullanici _kullaniciService;
        

        public FormLogin(IKullanici kullaniciService )
        {
            _kullaniciService = kullaniciService;


            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            if (_kullaniciService.GenericIsLogin(textBox_UserName.Text, textBox_Password.Text))
            {

                this.Text = Thread.CurrentPrincipal.Identity.Name;

                var  frm = CompositionRoot.Resolve<Form1>();
                frm.ShowDialog();

            }
        }
    }
}
