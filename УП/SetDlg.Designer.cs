namespace mosaic
{
    partial class SetDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetDlg));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_7x7 = new System.Windows.Forms.RadioButton();
            this.radioButton_5x5 = new System.Windows.Forms.RadioButton();
            this.radioButton_4x4 = new System.Windows.Forms.RadioButton();
            this.radioButton_3x3 = new System.Windows.Forms.RadioButton();
            this.radioButton_8x8 = new System.Windows.Forms.RadioButton();
            this.radioButton_6x6 = new System.Windows.Forms.RadioButton();
            this.radioButton_10x10 = new System.Windows.Forms.RadioButton();
            this.radioButton_9x9 = new System.Windows.Forms.RadioButton();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton_7x7);
            this.groupBox1.Controls.Add(this.radioButton_5x5);
            this.groupBox1.Controls.Add(this.radioButton_4x4);
            this.groupBox1.Controls.Add(this.radioButton_3x3);
            this.groupBox1.Controls.Add(this.radioButton_8x8);
            this.groupBox1.Controls.Add(this.radioButton_6x6);
            this.groupBox1.Controls.Add(this.radioButton_10x10);
            this.groupBox1.Controls.Add(this.radioButton_9x9);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сложность";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(173, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Высокая";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(95, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Средняя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Низкая";
            // 
            // radioButton_7x7
            // 
            this.radioButton_7x7.AutoSize = true;
            this.radioButton_7x7.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_7x7.Location = new System.Drawing.Point(98, 69);
            this.radioButton_7x7.Name = "radioButton_7x7";
            this.radioButton_7x7.Size = new System.Drawing.Size(50, 21);
            this.radioButton_7x7.TabIndex = 0;
            this.radioButton_7x7.TabStop = true;
            this.radioButton_7x7.Text = "7 x 7";
            this.radioButton_7x7.UseVisualStyleBackColor = true;
            this.radioButton_7x7.CheckedChanged += new System.EventHandler(this.radioButton_3x3_CheckedChanged);
            // 
            // radioButton_5x5
            // 
            this.radioButton_5x5.AutoSize = true;
            this.radioButton_5x5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_5x5.Location = new System.Drawing.Point(17, 96);
            this.radioButton_5x5.Name = "radioButton_5x5";
            this.radioButton_5x5.Size = new System.Drawing.Size(50, 21);
            this.radioButton_5x5.TabIndex = 0;
            this.radioButton_5x5.TabStop = true;
            this.radioButton_5x5.Text = "5 x 5";
            this.radioButton_5x5.UseVisualStyleBackColor = true;
            this.radioButton_5x5.CheckedChanged += new System.EventHandler(this.radioButton_3x3_CheckedChanged);
            // 
            // radioButton_4x4
            // 
            this.radioButton_4x4.AutoSize = true;
            this.radioButton_4x4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_4x4.Location = new System.Drawing.Point(17, 69);
            this.radioButton_4x4.Name = "radioButton_4x4";
            this.radioButton_4x4.Size = new System.Drawing.Size(50, 21);
            this.radioButton_4x4.TabIndex = 0;
            this.radioButton_4x4.TabStop = true;
            this.radioButton_4x4.Text = "4 x 4";
            this.radioButton_4x4.UseVisualStyleBackColor = true;
            this.radioButton_4x4.CheckedChanged += new System.EventHandler(this.radioButton_3x3_CheckedChanged);
            // 
            // radioButton_3x3
            // 
            this.radioButton_3x3.AutoSize = true;
            this.radioButton_3x3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_3x3.Location = new System.Drawing.Point(17, 46);
            this.radioButton_3x3.Name = "radioButton_3x3";
            this.radioButton_3x3.Size = new System.Drawing.Size(50, 21);
            this.radioButton_3x3.TabIndex = 0;
            this.radioButton_3x3.TabStop = true;
            this.radioButton_3x3.Text = "3 x 3";
            this.radioButton_3x3.UseVisualStyleBackColor = true;
            this.radioButton_3x3.CheckedChanged += new System.EventHandler(this.radioButton_3x3_CheckedChanged);
            // 
            // radioButton_8x8
            // 
            this.radioButton_8x8.AutoSize = true;
            this.radioButton_8x8.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_8x8.Location = new System.Drawing.Point(98, 96);
            this.radioButton_8x8.Name = "radioButton_8x8";
            this.radioButton_8x8.Size = new System.Drawing.Size(50, 21);
            this.radioButton_8x8.TabIndex = 0;
            this.radioButton_8x8.TabStop = true;
            this.radioButton_8x8.Text = "8 x 8";
            this.radioButton_8x8.UseVisualStyleBackColor = true;
            this.radioButton_8x8.CheckedChanged += new System.EventHandler(this.radioButton_3x3_CheckedChanged);
            // 
            // radioButton_6x6
            // 
            this.radioButton_6x6.AutoSize = true;
            this.radioButton_6x6.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_6x6.Location = new System.Drawing.Point(98, 46);
            this.radioButton_6x6.Name = "radioButton_6x6";
            this.radioButton_6x6.Size = new System.Drawing.Size(50, 21);
            this.radioButton_6x6.TabIndex = 0;
            this.radioButton_6x6.TabStop = true;
            this.radioButton_6x6.Text = "6 x 6";
            this.radioButton_6x6.UseVisualStyleBackColor = true;
            this.radioButton_6x6.CheckedChanged += new System.EventHandler(this.radioButton_3x3_CheckedChanged);
            // 
            // radioButton_10x10
            // 
            this.radioButton_10x10.AutoSize = true;
            this.radioButton_10x10.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_10x10.Location = new System.Drawing.Point(176, 69);
            this.radioButton_10x10.Name = "radioButton_10x10";
            this.radioButton_10x10.Size = new System.Drawing.Size(62, 21);
            this.radioButton_10x10.TabIndex = 0;
            this.radioButton_10x10.TabStop = true;
            this.radioButton_10x10.Text = "10 x 10";
            this.radioButton_10x10.UseVisualStyleBackColor = true;
            this.radioButton_10x10.CheckedChanged += new System.EventHandler(this.radioButton_3x3_CheckedChanged);
            // 
            // radioButton_9x9
            // 
            this.radioButton_9x9.AutoSize = true;
            this.radioButton_9x9.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_9x9.Location = new System.Drawing.Point(176, 46);
            this.radioButton_9x9.Name = "radioButton_9x9";
            this.radioButton_9x9.Size = new System.Drawing.Size(50, 21);
            this.radioButton_9x9.TabIndex = 0;
            this.radioButton_9x9.TabStop = true;
            this.radioButton_9x9.Text = "9 x 9";
            this.radioButton_9x9.UseVisualStyleBackColor = true;
            this.radioButton_9x9.CheckedChanged += new System.EventHandler(this.radioButton_3x3_CheckedChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(9, 135);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(176, 135);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // SetDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(260, 162);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.SetDlg_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.RadioButton radioButton_5x5;
        private System.Windows.Forms.RadioButton radioButton_4x4;
        private System.Windows.Forms.RadioButton radioButton_3x3;
        private System.Windows.Forms.RadioButton radioButton_8x8;
        private System.Windows.Forms.RadioButton radioButton_7x7;
        private System.Windows.Forms.RadioButton radioButton_6x6;
        private System.Windows.Forms.RadioButton radioButton_10x10;
        private System.Windows.Forms.RadioButton radioButton_9x9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}