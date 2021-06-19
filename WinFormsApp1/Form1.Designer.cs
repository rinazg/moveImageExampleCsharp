
namespace WinFormsApp1
{
    partial class frmMovImg
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
            this.components = new System.ComponentModel.Container();
            this.picB1 = new System.Windows.Forms.PictureBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.picB2 = new System.Windows.Forms.PictureBox();
            this.timerImageMove = new System.Windows.Forms.Timer(this.components);
            this.btnStopMove = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblClickCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB2)).BeginInit();
            this.SuspendLayout();
            // 
            // picB1
            // 
            this.picB1.Image = global::WinFormsApp1.Properties.Resources.hypo;
            this.picB1.Location = new System.Drawing.Point(1, 104);
            this.picB1.Name = "picB1";
            this.picB1.Size = new System.Drawing.Size(156, 179);
            this.picB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picB1.TabIndex = 0;
            this.picB1.TabStop = false;
            this.picB1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picB1_MouseClick);
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.Color.Lime;
            this.btnMove.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMove.Location = new System.Drawing.Point(80, 377);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(211, 38);
            this.btnMove.TabIndex = 1;
            this.btnMove.Text = "Click to move image";
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // picB2
            // 
            this.picB2.Image = global::WinFormsApp1.Properties.Resources.dog;
            this.picB2.Location = new System.Drawing.Point(364, 104);
            this.picB2.Name = "picB2";
            this.picB2.Size = new System.Drawing.Size(156, 179);
            this.picB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picB2.TabIndex = 2;
            this.picB2.TabStop = false;
            // 
            // timerImageMove
            // 
            this.timerImageMove.Tick += new System.EventHandler(this.timerImageMove_Tick);
            // 
            // btnStopMove
            // 
            this.btnStopMove.BackColor = System.Drawing.Color.Red;
            this.btnStopMove.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStopMove.Location = new System.Drawing.Point(321, 377);
            this.btnStopMove.Name = "btnStopMove";
            this.btnStopMove.Size = new System.Drawing.Size(224, 37);
            this.btnStopMove.TabIndex = 3;
            this.btnStopMove.Text = "Stop moving";
            this.btnStopMove.UseVisualStyleBackColor = false;
            this.btnStopMove.Click += new System.EventHandler(this.btnStopMove_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Yellow;
            this.btnRestart.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRestart.Location = new System.Drawing.Point(590, 376);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(178, 37);
            this.btnRestart.TabIndex = 4;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblClickCount
            // 
            this.lblClickCount.AutoSize = true;
            this.lblClickCount.Location = new System.Drawing.Point(281, 9);
            this.lblClickCount.Name = "lblClickCount";
            this.lblClickCount.Size = new System.Drawing.Size(164, 25);
            this.lblClickCount.TabIndex = 5;
            this.lblClickCount.Text = "number of clicks = ";
            this.lblClickCount.Visible = false;
            // 
            // frmMovImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblClickCount);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStopMove);
            this.Controls.Add(this.picB2);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.picB1);
            this.Name = "frmMovImg";
            this.Text = "Moving image example";
            ((System.ComponentModel.ISupportInitialize)(this.picB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picB1;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.PictureBox picB2;
        private System.Windows.Forms.Timer timerImageMove;
        private System.Windows.Forms.Button btnStopMove;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblClickCount;
    }
}

