///Created by Lake Storey on sept. 21st, 2016
///purpose: to create a greeting card that informs the user about the Crux constellation  
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GreetingCard
{
    public partial class greetingCard : Form
    {
        public greetingCard()
        {
            InitializeComponent();
            //sets backgroundimage to resized photo from resources
            var bmp = new Bitmap(GreetingCard.Properties.Resources.stars);
            Bitmap starsCover = new Bitmap(bmp, new Size(440, 227));
            this.BackgroundImage = starsCover;
        }

        private void greetingCard_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            Font tnr16 = new Font("Times New Roman", 16, FontStyle.Bold);
            Font tnr18 = new Font("Times New Roman", 18, FontStyle.Bold);
            Font castellar7 = new Font("Castellar", 7);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            Pen yellowPen = new Pen(Color.Yellow, 4);

            SoundPlayer pewPew = new SoundPlayer(Properties.Resources.Pew_Pew_DKnight556_1379997159);
            SoundPlayer pingSound = new SoundPlayer(Properties.Resources.glass_ping_Go445_1207030150);
            SoundPlayer drummingSound = new SoundPlayer(Properties.Resources.Civil_War_Drummer__SoundBible_com_700036269);

            formGraphics.Clear(Color.Black);

            Thread.Sleep(100);
            formGraphics.DrawLine(yellowPen, 106, 75, 38, 104);
            formGraphics.FillEllipse(whiteBrush, 38, 98, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 106, 69, 10, 10);
            pewPew.Play();
            Thread.Sleep(300);
            formGraphics.DrawLine(yellowPen, 71, 49, 103, 152);
            formGraphics.FillEllipse(whiteBrush, 66, 45, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 99, 150, 10, 10);
            pewPew.Play();
            Thread.Sleep(100);
            formGraphics.DrawString("The Crux", tnr16, redBrush, 90, 40);
            formGraphics.DrawString("The Crux", tnr16, greenBrush, 90, 40);
            formGraphics.DrawString("The crux is a constellation located in the", castellar7, blueBrush, 130, 70);
            formGraphics.DrawString("southern sky in a bright portion of the milky", castellar7, blueBrush, 130, 85);
            formGraphics.DrawString("way. The Crux is bordered by Centaurus on", castellar7, blueBrush, 130, 100);
            formGraphics.DrawString("the eastern, northern and western front and", castellar7, blueBrush, 130, 115);
            formGraphics.DrawString("by Musca to the south. Crux is easily visible", castellar7, blueBrush, 130, 130);
            formGraphics.DrawString("From the south hemisphere.", castellar7, blueBrush, 130, 145);
            Thread.Sleep(100);

            for (int i = 0; i <=10; i++)
            {
                drummingSound.Play();
                Thread.Sleep(1000);
            }
        }
    }
}
