using EczaneFramework.Business.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneFramework.WinFormUI
{
    public partial class Form2 : Form
    {

        IKullanici _kullaniciService;
        public Form2(IKullanici kullaniciService )
        {
            _kullaniciService = kullaniciService;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _kullaniciService.GetAll();
        }
    }
}
