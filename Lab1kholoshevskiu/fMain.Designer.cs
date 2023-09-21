namespace Lab1kholoshevskiu
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnMain = new Panel();
            pnTools = new Panel();
            btnRightFar = new Button();
            btnRight = new Button();
            btnLeft = new Button();
            btnLeftFar = new Button();
            btnDownFar = new Button();
            btnDown = new Button();
            btnCollapse = new Button();
            btnExpand = new Button();
            btnUp = new Button();
            btnUpFar = new Button();
            btnShow = new Button();
            btnHide = new Button();
            btnCreateNew = new Button();
            cbCircles = new ComboBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pnTools.SuspendLayout();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.White;
            pnMain.BorderStyle = BorderStyle.FixedSingle;
            pnMain.Location = new Point(0, -1);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(889, 759);
            pnMain.TabIndex = 0;
            pnMain.Paint += pnMain_Paint;
            // 
            // pnTools
            // 
            pnTools.BackColor = Color.Gray;
            pnTools.Controls.Add(btnRightFar);
            pnTools.Controls.Add(btnRight);
            pnTools.Controls.Add(btnLeft);
            pnTools.Controls.Add(btnLeftFar);
            pnTools.Controls.Add(btnDownFar);
            pnTools.Controls.Add(btnDown);
            pnTools.Controls.Add(btnCollapse);
            pnTools.Controls.Add(btnExpand);
            pnTools.Controls.Add(btnUp);
            pnTools.Controls.Add(btnUpFar);
            pnTools.Controls.Add(btnShow);
            pnTools.Controls.Add(btnHide);
            pnTools.Controls.Add(btnCreateNew);
            pnTools.Controls.Add(cbCircles);
            pnTools.Controls.Add(label1);
            pnTools.Location = new Point(895, -1);
            pnTools.Name = "pnTools";
            pnTools.Size = new Size(269, 759);
            pnTools.TabIndex = 1;
            pnTools.Paint += pnTools_Paint;
            // 
            // btnRightFar
            // 
            btnRightFar.Location = new Point(214, 208);
            btnRightFar.Name = "btnRightFar";
            btnRightFar.Size = new Size(41, 61);
            btnRightFar.TabIndex = 14;
            btnRightFar.Text = "Right Far";
            btnRightFar.UseVisualStyleBackColor = true;
            btnRightFar.Click += btnRightFar_Click;
            // 
            // btnRight
            // 
            btnRight.Location = new Point(168, 208);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(40, 61);
            btnRight.TabIndex = 13;
            btnRight.Text = "Right";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += btnRight_Click;
            // 
            // btnLeft
            // 
            btnLeft.Location = new Point(47, 208);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(35, 61);
            btnLeft.TabIndex = 12;
            btnLeft.Text = "Left";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnLeftFar
            // 
            btnLeftFar.Location = new Point(3, 210);
            btnLeftFar.Name = "btnLeftFar";
            btnLeftFar.Size = new Size(38, 61);
            btnLeftFar.TabIndex = 11;
            btnLeftFar.Text = "Left Far";
            btnLeftFar.UseVisualStyleBackColor = true;
            btnLeftFar.Click += btnLeftFar_Click;
            // 
            // btnDownFar
            // 
            btnDownFar.Location = new Point(90, 298);
            btnDownFar.Name = "btnDownFar";
            btnDownFar.Size = new Size(75, 23);
            btnDownFar.TabIndex = 10;
            btnDownFar.Text = "DownFar";
            btnDownFar.UseVisualStyleBackColor = true;
            btnDownFar.Click += btnDownFar_Click;
            // 
            // btnDown
            // 
            btnDown.Location = new Point(90, 269);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(75, 23);
            btnDown.TabIndex = 9;
            btnDown.Text = "Down";
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += btnDown_Click;
            // 
            // btnCollapse
            // 
            btnCollapse.Location = new Point(90, 240);
            btnCollapse.Name = "btnCollapse";
            btnCollapse.Size = new Size(75, 23);
            btnCollapse.TabIndex = 8;
            btnCollapse.Text = "-";
            btnCollapse.UseVisualStyleBackColor = true;
            btnCollapse.Click += btnCollapse_Click;
            // 
            // btnExpand
            // 
            btnExpand.Location = new Point(90, 210);
            btnExpand.Name = "btnExpand";
            btnExpand.Size = new Size(75, 24);
            btnExpand.TabIndex = 7;
            btnExpand.Text = "+";
            btnExpand.UseVisualStyleBackColor = true;
            btnExpand.Click += btnExpand_Click;
            // 
            // btnUp
            // 
            btnUp.Location = new Point(90, 181);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(75, 23);
            btnUp.TabIndex = 6;
            btnUp.Text = "Up";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUp_Click;
            // 
            // btnUpFar
            // 
            btnUpFar.Location = new Point(90, 152);
            btnUpFar.Name = "btnUpFar";
            btnUpFar.Size = new Size(75, 23);
            btnUpFar.TabIndex = 5;
            btnUpFar.Text = "UpFar";
            btnUpFar.UseVisualStyleBackColor = true;
            btnUpFar.Click += btnUpFar_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(36, 111);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(170, 23);
            btnShow.TabIndex = 4;
            btnShow.Text = "Показати об'єкт";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnHide
            // 
            btnHide.Location = new Point(36, 82);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(170, 23);
            btnHide.TabIndex = 3;
            btnHide.Text = "Приховати об'єкт";
            btnHide.UseVisualStyleBackColor = true;
            btnHide.Click += btnHide_Click;
            // 
            // btnCreateNew
            // 
            btnCreateNew.Location = new Point(36, 53);
            btnCreateNew.Name = "btnCreateNew";
            btnCreateNew.Size = new Size(170, 23);
            btnCreateNew.TabIndex = 2;
            btnCreateNew.Text = "Створити новий об'єкт";
            btnCreateNew.UseVisualStyleBackColor = true;
            btnCreateNew.Click += btnCreateNew_Click;
            // 
            // cbCircles
            // 
            cbCircles.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCircles.FormattingEnabled = true;
            cbCircles.Location = new Point(17, 24);
            cbCircles.Name = "cbCircles";
            cbCircles.Size = new Size(205, 23);
            cbCircles.TabIndex = 1;
            cbCircles.SelectedIndexChanged += cbCircles_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 6);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Перелік об'єктів";
            label1.Click += label1_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 756);
            Controls.Add(pnTools);
            Controls.Add(pnMain);
            Name = "fMain";
            Text = "Лабараторна робота №1 Холошевський Артем";
            Load += fMain_Load;
            pnTools.ResumeLayout(false);
            pnTools.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMain;
        private Panel pnTools;
        private Button btnShow;
        private Button btnHide;
        private Button btnCreateNew;
        private ComboBox cbCircles;
        private Label label1;
        private Button btnLeft;
        private Button btnLeftFar;
        private Button btnDownFar;
        private Button btnDown;
        private Button btnCollapse;
        private Button btnExpand;
        private Button btnUp;
        private Button btnUpFar;
        private Button btnRightFar;
        private Button btnRight;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}