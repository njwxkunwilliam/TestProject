namespace TestProject
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainerMain.Panel1.Controls.Add(this.button3);
            this.splitContainerMain.Panel1.Controls.Add(this.button2);
            this.splitContainerMain.Panel1.Controls.Add(this.button1);
            this.splitContainerMain.Panel1.Controls.Add(this.btnFina);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainerMain.Size = new System.Drawing.Size(742, 460);
            this.splitContainerMain.SplitterDistance = 134;
            this.splitContainerMain.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 36);
            this.button3.TabIndex = 0;
            this.button3.Text = "帐务处理";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 36);
            this.button2.TabIndex = 0;
            this.button2.Text = "帐务处理";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "帐务处理";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnFina
            // 
            this.btnFina.Location = new System.Drawing.Point(12, 47);
            this.btnFina.Name = "btnFina";
            this.btnFina.Size = new System.Drawing.Size(98, 36);
            this.btnFina.TabIndex = 0;
            this.btnFina.Text = "帐务处理";
            this.btnFina.UseVisualStyleBackColor = true;
            this.btnFina.Click += new System.EventHandler(this.btnFina_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 460);
            this.Controls.Add(this.splitContainerMain);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "主界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Button btnFina;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;


    }
}

