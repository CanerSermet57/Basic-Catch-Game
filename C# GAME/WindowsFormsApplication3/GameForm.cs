using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication3
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }


        //Created By Caner Sermet       Created Date : 2017


        Random Rast = new Random();
        String Text = "0";
        //Access database 
        /*
        OleDbConnection Baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data.accdb");
        void VeriAl()
        {
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Tablo1", Baglantı);
            OleDbDataReader DataReader = komut.ExecuteReader();
            while (DataReader.Read())
            {
                Skor1.Text = DataReader["Nickname"].ToString();
            }
        }
        */
        void Bait()
        {
            color();
            int x = Rast.Next(1,115);
            x = x * 10;
            int y = Rast.Next(1, 65);
            y = y * 10;
            panel3.Location = new Point(x, y);
            Text = (Convert.ToInt32(Text) + 10).ToString();
            label1.Text = "Score : " + Text;
            if (Convert.ToInt32(Text) == 40 || Convert.ToInt32(Text) == 80 || Convert.ToInt32(Text) == 120 
                || Convert.ToInt32(Text) == 160 || Convert.ToInt32(Text) == 200 || Convert.ToInt32(Text) == 240)
            {
                Speed = Speed + 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //VeriAl();
            Text = "0";
            Bait();
            timer1.Start();
        }
        
        int color2;
        void color()
        {            
            color2= Rast.Next(1, 10);
            if (color2 == 1)
            {
                panel2.BackColor = Color.Pink;
            }
            else if (color2 == 2)
            {
                panel2.BackColor = Color.Blue;
            }
            else if (color2 == 3)
            {
                panel2.BackColor = Color.Red;
            }
            else if (color2 == 4)
            {
                panel2.BackColor = Color.Orange;
            }
            else if (color2 == 5)
            {
                panel2.BackColor = Color.Green;
            }
            else if (color2 == 6)
            {
                panel2.BackColor = Color.Black;
            }
            else if (color2 == 7)
            {
                panel2.BackColor = Color.Brown;
            }
            else if (color2 == 8)
            {
                panel2.BackColor = Color.Chocolate;
            }
            else if (color2 == 9)
            {
                panel2.BackColor = Color.BurlyWood;
            }
            else if (color2 == 10)
            {
                panel2.BackColor = Color.Gray;
            }
        }

        int number;
        int repeat = 0;
        DialogResult RetryCancell;
        int Speed = 12;
        private void timer1_Tick(object sender, EventArgs e)
        {
            repeat = 0;
            if (Convert.ToInt32(panel3.Location.X) <= ((Convert.ToInt32(panel2.Location.X)) + 20) && Convert.ToInt32(panel3.Location.X) >= ((Convert.ToInt32(panel2.Location.X)) - 20) && Convert.ToInt32(panel3.Location.Y) <= ((Convert.ToInt32(panel2.Location.Y)) + 20) && Convert.ToInt32(panel3.Location.Y) >= ((Convert.ToInt32(panel2.Location.Y)) - 20))
            {
                Bait();
            }
            int x = Convert.ToInt32(panel2.Location.X);
            int y = Convert.ToInt32(panel2.Location.Y);

            if (x <= 0 || y <= 0 || x >= 1180 || y >= 680) 
            {
                timer1.Stop();
                RetryCancell = MessageBox.Show("GAME OVER", label1.Text = "Score : " + Text,MessageBoxButtons.RetryCancel);
                Speed = 12;
                repeat++;
            }
            
            if (repeat == 0)
            {
                if (number == 1) { panel2.Location = new Point(x + Speed, y); }
                if (number == 2) { panel2.Location = new Point(x, y + Speed); }
                if (number == 3) { panel2.Location = new Point(x, y - Speed); }
                if (number == 4) { panel2.Location = new Point(x - Speed, y); }
                label3.Text = "Ivme :" + Speed.ToString();
                
            }
            else if (repeat == 1)
            {
                if (RetryCancell == DialogResult.Retry)
                {
                    panel2.Location = new Point(30, 20);
                    number = 0;
                    direction = 0;
                    Text =  Convert.ToString(0) ;
                    label1.Text = "Score : " + Text;
                    timer1.Start();
                }
                else if (RetryCancell == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }
        }
        int direction = 0;
        int times = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (direction == 3)
            {
                if (e.KeyData == Keys.Up)    { number = 3; direction = 3; }
                if (e.KeyData == Keys.Right) { number = 1; direction = 1; }
                if (e.KeyData == Keys.Left)  { number = 4; direction = 4; }   
            }
            else if (direction == 2)
            {
                if (e.KeyData == Keys.Right) { number = 1; direction = 1; }
                if (e.KeyData == Keys.Down)  { number = 2; direction = 2; }
                if (e.KeyData == Keys.Left)  { number = 4; direction = 4; }  
            }
            else if (direction == 1)
            {
                if (e.KeyData == Keys.Up)    { number = 3; direction = 3; }
                if (e.KeyData == Keys.Right) { number = 1; direction = 1; }
                if (e.KeyData == Keys.Down)  { number = 2; direction = 2; }
            }
            else if (direction == 4)
            {
                if (e.KeyData == Keys.Up)   { number = 3; direction = 3; }
                if (e.KeyData == Keys.Down) { number = 2; direction = 2; }
                if (e.KeyData == Keys.Left) { number = 4; direction = 4; }
            }
            else
            {
                if (e.KeyData == Keys.Up)    { number = 3; direction = 3; }
                if (e.KeyData == Keys.Right) { number = 1; direction = 1; }
                if (e.KeyData == Keys.Down)  { number = 2; direction = 2; }
                if (e.KeyData == Keys.Left)  { number = 4; direction = 4; }
            }
            if (e.KeyData == Keys.E)
            {
                times = times + 1;
            }
            if (times >= 5)
            {
                if (e.KeyData == Keys.O)
                {
                    Speed = Speed + 1;
                }
                if (e.KeyData == Keys.P)
                {
                    Speed = Speed - 1;
                } 
            }            
        }
    }
}
