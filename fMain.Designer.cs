
namespace Lr_7
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
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnTools = new System.Windows.Forms.Panel();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnUpFar = new System.Windows.Forms.Button();
            this.btnDownFar = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRightFar = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeftFar = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.cbCircles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.SystemColors.Window;
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(470, 351);
            this.pnMain.TabIndex = 0;
            // 
            // pnTools
            // 
            this.pnTools.Controls.Add(this.btnCollapse);
            this.pnTools.Controls.Add(this.btnExpand);
            this.pnTools.Controls.Add(this.btnUp);
            this.pnTools.Controls.Add(this.btnUpFar);
            this.pnTools.Controls.Add(this.btnDownFar);
            this.pnTools.Controls.Add(this.btnDown);
            this.pnTools.Controls.Add(this.btnRightFar);
            this.pnTools.Controls.Add(this.btnRight);
            this.pnTools.Controls.Add(this.btnLeftFar);
            this.pnTools.Controls.Add(this.btnLeft);
            this.pnTools.Controls.Add(this.btnShow);
            this.pnTools.Controls.Add(this.btnHide);
            this.pnTools.Controls.Add(this.btnCreateNew);
            this.pnTools.Controls.Add(this.cbCircles);
            this.pnTools.Controls.Add(this.label1);
            this.pnTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTools.Location = new System.Drawing.Point(470, 0);
            this.pnTools.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnTools.Name = "pnTools";
            this.pnTools.Size = new System.Drawing.Size(268, 351);
            this.pnTools.TabIndex = 1;
            // 
            // btnCollapse
            // 
            this.btnCollapse.BackColor = System.Drawing.SystemColors.Info;
            this.btnCollapse.Location = new System.Drawing.Point(108, 247);
            this.btnCollapse.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(29, 18);
            this.btnCollapse.TabIndex = 14;
            this.btnCollapse.Text = "-";
            this.btnCollapse.UseVisualStyleBackColor = false;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.BackColor = System.Drawing.SystemColors.Info;
            this.btnExpand.Location = new System.Drawing.Point(108, 210);
            this.btnExpand.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(29, 27);
            this.btnExpand.TabIndex = 13;
            this.btnExpand.Text = "+";
            this.btnExpand.UseVisualStyleBackColor = false;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.SystemColors.Info;
            this.btnUp.Location = new System.Drawing.Point(108, 182);
            this.btnUp.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(29, 25);
            this.btnUp.TabIndex = 12;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnUpFar
            // 
            this.btnUpFar.BackColor = System.Drawing.SystemColors.Info;
            this.btnUpFar.Location = new System.Drawing.Point(108, 147);
            this.btnUpFar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnUpFar.Name = "btnUpFar";
            this.btnUpFar.Size = new System.Drawing.Size(29, 25);
            this.btnUpFar.TabIndex = 11;
            this.btnUpFar.Text = " ↟ ";
            this.btnUpFar.UseVisualStyleBackColor = false;
            this.btnUpFar.Click += new System.EventHandler(this.btnUpFar_Click);
            // 
            // btnDownFar
            // 
            this.btnDownFar.BackColor = System.Drawing.SystemColors.Info;
            this.btnDownFar.Location = new System.Drawing.Point(108, 316);
            this.btnDownFar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDownFar.Name = "btnDownFar";
            this.btnDownFar.Size = new System.Drawing.Size(29, 25);
            this.btnDownFar.TabIndex = 10;
            this.btnDownFar.Text = "↡";
            this.btnDownFar.UseVisualStyleBackColor = false;
            this.btnDownFar.Click += new System.EventHandler(this.btnDownFar_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.SystemColors.Info;
            this.btnDown.Location = new System.Drawing.Point(108, 279);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(29, 25);
            this.btnDown.TabIndex = 9;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRightFar
            // 
            this.btnRightFar.BackColor = System.Drawing.SystemColors.Info;
            this.btnRightFar.Location = new System.Drawing.Point(181, 210);
            this.btnRightFar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRightFar.Name = "btnRightFar";
            this.btnRightFar.Size = new System.Drawing.Size(55, 25);
            this.btnRightFar.TabIndex = 8;
            this.btnRightFar.Text = ">>";
            this.btnRightFar.UseVisualStyleBackColor = false;
            this.btnRightFar.Click += new System.EventHandler(this.btnRightFar_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.SystemColors.Info;
            this.btnRight.Location = new System.Drawing.Point(146, 210);
            this.btnRight.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(18, 25);
            this.btnRight.TabIndex = 7;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeftFar
            // 
            this.btnLeftFar.BackColor = System.Drawing.SystemColors.Info;
            this.btnLeftFar.Location = new System.Drawing.Point(4, 210);
            this.btnLeftFar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnLeftFar.Name = "btnLeftFar";
            this.btnLeftFar.Size = new System.Drawing.Size(53, 25);
            this.btnLeftFar.TabIndex = 6;
            this.btnLeftFar.Text = "<<";
            this.btnLeftFar.UseVisualStyleBackColor = false;
            this.btnLeftFar.Click += new System.EventHandler(this.btnLeftFar_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.SystemColors.Info;
            this.btnLeft.Location = new System.Drawing.Point(72, 210);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(19, 25);
            this.btnLeft.TabIndex = 5;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(36, 100);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(114, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Показати об\'єкт";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(36, 75);
            this.btnHide.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(128, 23);
            this.btnHide.TabIndex = 3;
            this.btnHide.Text = "Приховати об\'єкт";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(36, 50);
            this.btnCreateNew.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(165, 23);
            this.btnCreateNew.TabIndex = 2;
            this.btnCreateNew.Text = "Створити новий об\'єкт";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.ClientSizeChanged += new System.EventHandler(this.btnCreateNew_ClientSizeChanged);
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // cbCircles
            // 
            this.cbCircles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCircles.FormattingEnabled = true;
            this.cbCircles.Location = new System.Drawing.Point(36, 25);
            this.cbCircles.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbCircles.Name = "cbCircles";
            this.cbCircles.Size = new System.Drawing.Size(137, 23);
            this.cbCircles.TabIndex = 1;
            this.cbCircles.SelectedIndexChanged += new System.EventHandler(this.cbCircles_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Перелік об\'єктів";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 351);
            this.Controls.Add(this.pnTools);
            this.Controls.Add(this.pnMain);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LR#11";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.pnTools.ResumeLayout(false);
            this.pnTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnTools;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnUpFar;
        private System.Windows.Forms.Button btnDownFar;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRightFar;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeftFar;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.ComboBox cbCircles;
        private System.Windows.Forms.Label label1;
    }
}

