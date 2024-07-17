namespace TemperatureConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_InputTemperature = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton_Celsius = new System.Windows.Forms.RadioButton();
            this.radioButton_Fahrenheit = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_InputTemperature
            // 
            this.textBox_InputTemperature.Location = new System.Drawing.Point(17, 36);
            this.textBox_InputTemperature.Name = "textBox_InputTemperature";
            this.textBox_InputTemperature.Size = new System.Drawing.Size(150, 20);
            this.textBox_InputTemperature.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperature:";
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(17, 120);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ReadOnly = true;
            this.textBox_Result.Size = new System.Drawing.Size(150, 20);
            this.textBox_Result.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(219, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Convert!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton_Celsius
            // 
            this.radioButton_Celsius.AutoSize = true;
            this.radioButton_Celsius.Checked = true;
            this.radioButton_Celsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Celsius.Location = new System.Drawing.Point(209, 28);
            this.radioButton_Celsius.Name = "radioButton_Celsius";
            this.radioButton_Celsius.Size = new System.Drawing.Size(89, 28);
            this.radioButton_Celsius.TabIndex = 5;
            this.radioButton_Celsius.TabStop = true;
            this.radioButton_Celsius.Text = "Celsius";
            this.radioButton_Celsius.UseVisualStyleBackColor = true;
            // 
            // radioButton_Fahrenheit
            // 
            this.radioButton_Fahrenheit.AutoSize = true;
            this.radioButton_Fahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Fahrenheit.Location = new System.Drawing.Point(209, 62);
            this.radioButton_Fahrenheit.Name = "radioButton_Fahrenheit";
            this.radioButton_Fahrenheit.Size = new System.Drawing.Size(119, 28);
            this.radioButton_Fahrenheit.TabIndex = 6;
            this.radioButton_Fahrenheit.Text = "Fahrenheit";
            this.radioButton_Fahrenheit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(341, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 140);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 161);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioButton_Fahrenheit);
            this.Controls.Add(this.radioButton_Celsius);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_InputTemperature);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Temperature Converter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_InputTemperature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton_Celsius;
        private System.Windows.Forms.RadioButton radioButton_Fahrenheit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

