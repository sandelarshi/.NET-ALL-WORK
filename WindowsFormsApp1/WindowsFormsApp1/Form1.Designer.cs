namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this._txt1 = new System.Windows.Forms.TextBox();
            this._txt2 = new System.Windows.Forms.TextBox();
            this._result = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "School Management system";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "CLick Me!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _txt1
            // 
            this._txt1.Location = new System.Drawing.Point(109, 114);
            this._txt1.Name = "_txt1";
            this._txt1.Size = new System.Drawing.Size(100, 20);
            this._txt1.TabIndex = 2;
            this._txt1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // _txt2
            // 
            this._txt2.Location = new System.Drawing.Point(109, 140);
            this._txt2.Name = "_txt2";
            this._txt2.Size = new System.Drawing.Size(100, 20);
            this._txt2.TabIndex = 3;
            // 
            // _result
            // 
            this._result.AutoSize = true;
            this._result.Location = new System.Drawing.Point(119, 167);
            this._result.Name = "_result";
            this._result.Size = new System.Drawing.Size(0, 13);
            this._result.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(143, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this._result);
            this.Controls.Add(this._txt2);
            this.Controls.Add(this._txt1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox _txt1;
        private System.Windows.Forms.TextBox _txt2;
        private System.Windows.Forms.Label _result;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

