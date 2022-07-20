using System.Drawing;
namespace Timers
{
    public partial class Form1 : Form
    {
        private Button buttonOK = new Button();
        private int kol = 0;
        public Form1()
        {
            InitializeComponent();
            Size = new Size(700, 350);

            buttonOK.Size = new Size(70, 70);
            buttonOK.Text = "@";
            buttonOK.BackColor = Color.Bisque;
            Controls.Add(buttonOK);
            buttonOK.Location = new Point(10, 100);  
            buttonOK.Click += new EventHandler(this.ButtonOK_Move);
            
            
         
        }
       

        private void ButtonOK_Move(object? sender, EventArgs e)
        {
            
            int numb = 0;
            int width1 = Size.Width;
            for (int i = 0; i < width1 / 10 - 10; i++)
            {

                buttonOK.Location = new Point(10 + 10 * i, 100);
                Thread.Sleep(300);
                numb+= DateTime.Now.Millisecond;
                Text = numb.ToString()+"  Milisec";
                int y = new Random().Next(0, 255);
                int x = new Random().Next(0, 255);
                int z = new Random().Next(0, 255);
                BackColor = Color.FromArgb(x, y, z);
                
            }
             
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
    }
}    

    
