using System.DirectoryServices.ActiveDirectory;

namespace Lab1kholoshevskiu
{
    public partial class fMain : Form
    {
        CEmblem[] circles;
        CEmblem[] squares;
        CEmblem[] triagles;
        int CircleCount = 0;
        int SquareCount = 0;
        int TriagleCount = 0;
        int CurrentCircleIndex;
        int CurrentSquareIndex;
        int CurrentTriagleIndex;


        public fMain()
        {


            {
                InitializeComponent();
                // Створення масиву для об'єктів - кіл
                circles = new CEmblem[100];
                squares = new CEmblem[100];
                triagles = new CEmblem[100];
            }
        }

        private void fMain_Load(object sender, EventArgs e)
        {



        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            if (CircleCount >= 99)
            {
                MessageBox.Show("Досягнуто межі кількості об'єктів!");
                return;
            }





            Graphics graphics = pnMain.CreateGraphics();
            CurrentCircleIndex = CircleCount;


            // Створення нового об'єкта - екземпляра класу CCircle
            circles[CurrentCircleIndex] =
             new CEmblem(graphics, pnMain.Width / 2,
             pnMain.Height / 2, 50);
            circles[CurrentCircleIndex].Show();
            CircleCount++;
            cbCircles.Items.Add("об'єкт No" + (CircleCount - 1).ToString());
            cbCircles.SelectedIndex = CircleCount - 1;

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            circles[CurrentCircleIndex].Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            // Відображення поточного об'єкта
            circles[CurrentCircleIndex].Show();
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            // Розширення поточного об'єкта - екземпляра класу CCircle
            circles[CurrentCircleIndex].Expand(5);
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            // Стискання поточного об'єкта - екземпляра класу CCircle
            circles[CurrentCircleIndex].Collapse(5);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            // Переміщення вверх поточного об'єкта
            circles[CurrentCircleIndex].Move(0, -10);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            // Переміщення вниз поточного об'єкта
            circles[CurrentCircleIndex].Move(0, 10);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            // Переміщення вправо поточного об'єкта
            circles[CurrentCircleIndex].Move(10, 0);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            // Переміщення вліво поточного об'єкта
            circles[CurrentCircleIndex].Move(-10, 0);
        }

        private void btnRightFar_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            // Переміщення поточного об'єкта вправо на більшу відстань
            for (int i = 0; i < 100; i++)
            {
                circles[CurrentCircleIndex].Move(1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnLeftFar_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            // Переміщення поточного об'єкта вліво на більшу відстань
            for (int i = 0; i < 100; i++)
            {
                circles[CurrentCircleIndex].Move(-1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnUpFar_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            // Переміщення поточного об'єкта вверх на більшу відстань
            for (int i = 0; i < 100; i++)
            {
                circles[CurrentCircleIndex].Move(0, -1);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnDownFar_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            // Переміщення поточного об'єкта вниз на більшу відстань
            for (int i = 0; i < 100; i++)
            {
                circles[CurrentCircleIndex].Move(0, 1);
                System.Threading.Thread.Sleep(5);

            }
        }

       

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnTools_Paint(object sender, PaintEventArgs e)
        {
        }

        private void cbCircles_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
        }
    }
}