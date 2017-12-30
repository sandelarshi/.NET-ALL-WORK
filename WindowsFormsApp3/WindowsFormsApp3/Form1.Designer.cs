namespace WindowsFormsApp3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sec = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.min = new System.Windows.Forms.Label();
            this.hou = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.t2 = new System.Windows.Forms.Timer(this.components);
            this.t3 = new System.Windows.Forms.Timer(this.components);
            this.b1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // sec
            // 
            this.sec.AutoSize = true;
            this.sec.Location = new System.Drawing.Point(30, 22);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(13, 13);
            this.sec.TabIndex = 0;
            this.sec.Text = "0";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Location = new System.Drawing.Point(67, 22);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(13, 13);
            this.min.TabIndex = 1;
            this.min.Text = "0";
            // 
            // hou
            // 
            this.hou.AutoSize = true;
            this.hou.Location = new System.Drawing.Point(112, 22);
            this.hou.Name = "hou";
            this.hou.Size = new System.Drawing.Size(13, 13);
            this.hou.TabIndex = 2;
            this.hou.Text = "0";
            // 
            // t1
            // 
            this.t1.Enabled = true;
            this.t1.Tick += new System.EventHandler(this.t1_Tick);
            // 
            // t2
            // 
            this.t2.Enabled = true;
            this.t2.Interval = 70;
            this.t2.Tick += new System.EventHandler(this.t2_Tick);
            // 
            // t3
            // 
            this.t3.Enabled = true;
            this.t3.Interval = 50;
            this.t3.Tick += new System.EventHandler(this.t3_Tick);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(50, 63);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 3;
            this.b1.Text = "stop";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.hou);
            this.Controls.Add(this.min);
            this.Controls.Add(this.sec);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label sec;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label hou;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.Timer t2;
        private System.Windows.Forms.Timer t3;
        private System.Windows.Forms.Button b1;
    }
}

