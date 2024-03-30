using EczaneFramework.Business.Abstract;
using EczaneFramework.Business.Concrate;
using EczaneFramework.Entities.Tables;
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
    public partial class Form1 : Form
    {
        //IEczane _eczane = new EczaneYonetimiGenric();
        //IRol _rolservice = new RoleYonetimiGP();
        //IKullanici _kullaniciService = new KullaniciYonetimiGP();

        IEczane _eczane;
        IRol _rolservice;
        IKullanici _kullaniciService;

        public Form1(IEczane eczaneServis, IRol rolServis, IKullanici kullaniciServis)
        {

            _eczane = eczaneServis;
            _rolservice = rolServis;
            _kullaniciService = kullaniciServis;


            InitializeComponent();
        }


        private void button_goster_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _eczane.GetAll();

            //dataGridView1.DataSource = _rolservice.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eczane _yeni = new Eczane();

            //textboxlardan bilgileri aktarıldı 

            _eczane.Add("Cenk", "Merkez", "Semsettin", "abc@mail.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //_eczane.Add("Test", "Test", "Test", "Test");
            Eczane eczane = new Eczane();
            eczane.Ad = "Test";
            eczane.Adress = "Test";
            eczane.Mail = "Test";
            eczane.Telefon = "Test";
            eczane.Yetkili = "Test";

            _eczane.Add(eczane);

            dataGridView1.DataSource = _eczane.GetAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var r = _eczane.GetAll().FirstOrDefault();
            _eczane.Delete(r.Id);
            dataGridView1.DataSource = _eczane.GetAll();


        }

        private void button_ekle2_Click(object sender, EventArgs e)
        {
            _eczane.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            dataGridView1.DataSource = _eczane.GetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _kullaniciService.GetAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _kullaniciService.Add(
                new Kullanici()
                {
                    KullaniciAdi = textBox1.Text,
                    Sifre = textBox2.Text
                }

                );
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 frm = CompositionRoot.Resolve<Form2>();

            frm.ShowDialog();
        }
    }
}
