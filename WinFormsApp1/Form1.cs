using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class frmMovImg : Form
    {
        bool collision;
        string[] imageArr;  //reading all file names from 
        int counter;//counts number of clicks on moving image


        public frmMovImg()
        {
            InitializeComponent();
            createRandomImageArray();
            changeImage(picB2);
            changeImage(picB1);
        }

        
        //read file names from Resources directory in the project
        //to array and create a random order 
        private void createRandomImageArray()
        {
            //read file names from Resources directory in the project
            imageArr = Directory.GetFiles(@"../../../Resources/");
            shuffle(imageArr);
        }

        // basic Knuth shuffle algorithm :: courtesy of Wikipedia :)
        private void  shuffle(string[] arr)
        {
            Random rnd = new Random();
            for (int t = 0; t < arr.Length; t++)
            {
                string tmp = arr[t];
                int r = rnd.Next(arr.Length);
                arr[t] = arr[r];  //swap 2 elements
                arr[r] = tmp;
            }
        }
        private void timerImageMove_Tick(object sender, EventArgs e)
        {
            if (picB1.Location.X + picB1.Width <= picB2.Location.X && collision==false )
                picB1.Location = new Point(picB1.Location.X + 10, picB1.Location.Y);
            else //collision happened
                if (picB1.Location.X + picB1.Width > picB2.Location.X && collision == false)
                {   collision = true;
                //change image
                changeImage(picB2);
                }
               //moving before reaching the Width of Form
               else if(picB2.Location.X + picB2.Width <= this.Width-10) //stop at the end of form
                picB2.Location = new Point(picB2.Location.X + 10, picB2.Location.Y);
        }

        private void changeImage(PictureBox p)
        {
            Random rnd = new Random();
            int r = rnd.Next(imageArr.Length);
            p.ImageLocation = imageArr[r];
        }
        private void btnMove_Click(object sender, EventArgs e)
        {
            timerImageMove.Start();
        }

        private void btnStopMove_Click(object sender, EventArgs e)
        {
            timerImageMove.Stop();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            collision = false;
            picB1.Location = new System.Drawing.Point(1, 104);
            picB2.Location = new System.Drawing.Point(364, 104);
            changeImage(picB2);
            changeImage(picB1);
        }

        private void picB1_MouseClick(object sender, MouseEventArgs e)
        {
            //increase and show click counter only if image is moving
            if (timerImageMove.Enabled == true && collision==false)
            {
                //show image name and click counter
                lblClickCount.Visible = true;
                //image location
                string name = ((PictureBox)sender).ImageLocation.ToString();
                char[] delimiterChars = { '.' , '/'};
                string[] arr = name.Split(delimiterChars);
                //only image name
                name = arr[arr.Length - 2];
                lblClickCount.Text = "number of clicks on moving " + name + ++counter;
            }
           
        }
    }
}
