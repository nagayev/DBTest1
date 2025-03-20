namespace DBTest1
{
    partial class fmAddVIDSTIP3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            horizontalLine = new Label();
            NSTUDENT = new ComboBox();
            sumstip = new Label();
            label5 = new Label();
            label6 = new Label();
            IMYA = new TextBox();
            OTCHESTVO = new TextBox();
            FAMILIYA = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(202, 77);
            label1.Name = "label1";
            label1.Size = new Size(241, 24);
            label1.TabIndex = 0;
            label1.Text = "Идентификатор студента";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(202, 149);
            label2.Name = "label2";
            label2.Size = new Size(104, 24);
            label2.TabIndex = 1;
            label2.Text = "Фамилия1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(202, 223);
            label3.Name = "label3";
            label3.Size = new Size(0, 24);
            label3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(316, 356);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(631, 356);
            button2.Name = "button2";
            button2.Size = new Size(97, 29);
            button2.TabIndex = 7;
            button2.Text = "Отменить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // horizontalLine
            // 
            horizontalLine.BorderStyle = BorderStyle.Fixed3D;
            horizontalLine.Location = new Point(-2, 331);
            horizontalLine.Name = "horizontalLine";
            horizontalLine.Size = new Size(760, 2);
            horizontalLine.TabIndex = 8;
            // 
            // NSTUDENT
            // 
            NSTUDENT.FormattingEnabled = true;
            NSTUDENT.Location = new Point(449, 77);
            NSTUDENT.Name = "NSTUDENT";
            NSTUDENT.Size = new Size(151, 28);
            NSTUDENT.TabIndex = 9;
            NSTUDENT.SelectedIndexChanged += NSTUDENT_SelectedIndexChanged;
            NSTUDENT.SelectedValueChanged += vidstip_SelectedValueChanged;
            // 
            // sumstip
            // 
            sumstip.AutoSize = true;
            sumstip.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sumstip.Location = new Point(446, 149);
            sumstip.Name = "sumstip";
            sumstip.Size = new Size(40, 24);
            sumstip.TabIndex = 11;
            sumstip.Text = "     ";
            sumstip.Click += sumstip_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(202, 212);
            label5.Name = "label5";
            label5.Size = new Size(47, 24);
            label5.TabIndex = 12;
            label5.Text = "Имя";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(202, 286);
            label6.Name = "label6";
            label6.Size = new Size(94, 24);
            label6.TabIndex = 13;
            label6.Text = "Отчество";
            // 
            // IMYA
            // 
            IMYA.Location = new Point(446, 220);
            IMYA.Name = "IMYA";
            IMYA.ReadOnly = true;
            IMYA.Size = new Size(125, 27);
            IMYA.TabIndex = 14;
            // 
            // OTCHESTVO
            // 
            OTCHESTVO.Location = new Point(446, 283);
            OTCHESTVO.Name = "OTCHESTVO";
            OTCHESTVO.ReadOnly = true;
            OTCHESTVO.Size = new Size(125, 27);
            OTCHESTVO.TabIndex = 15;
            // 
            // FAMILIYA
            // 
            FAMILIYA.Location = new Point(449, 150);
            FAMILIYA.Name = "FAMILIYA";
            FAMILIYA.ReadOnly = true;
            FAMILIYA.Size = new Size(125, 27);
            FAMILIYA.TabIndex = 16;
            // 
            // fmAddVIDSTIP3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 423);
            Controls.Add(FAMILIYA);
            Controls.Add(OTCHESTVO);
            Controls.Add(IMYA);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(sumstip);
            Controls.Add(NSTUDENT);
            Controls.Add(horizontalLine);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fmAddVIDSTIP3";
            Text = "Добавить запись";
            Load += fmAddVIDSTIP3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label horizontalLine;
        private ComboBox NSTUDENT;
        private Label sumstip;
        private Label label5;
        private Label label6;
        private TextBox IMYA;
        private TextBox OTCHESTVO;
        private TextBox FAMILIYA;
    }
}