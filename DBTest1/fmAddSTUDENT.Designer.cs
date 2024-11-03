namespace DBTest1
{
    partial class fmAddSTUDENT
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
            familiya = new TextBox();
            imia = new TextBox();
            otchestvo = new TextBox();
            button1 = new Button();
            button2 = new Button();
            horizontalLine = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(202, 77);
            label1.Name = "label1";
            label1.Size = new Size(93, 24);
            label1.TabIndex = 0;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(202, 149);
            label2.Name = "label2";
            label2.Size = new Size(47, 24);
            label2.TabIndex = 1;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(202, 223);
            label3.Name = "label3";
            label3.Size = new Size(94, 24);
            label3.TabIndex = 2;
            label3.Text = "Отчество";
            // 
            // familiya
            // 
            familiya.Location = new Point(360, 78);
            familiya.Name = "familiya";
            familiya.Size = new Size(125, 27);
            familiya.TabIndex = 3;
            // 
            // imia
            // 
            imia.Location = new Point(360, 150);
            imia.Name = "imia";
            imia.Size = new Size(125, 27);
            imia.TabIndex = 4;
            // 
            // otchestvo
            // 
            otchestvo.Location = new Point(360, 224);
            otchestvo.Name = "otchestvo";
            otchestvo.Size = new Size(125, 27);
            otchestvo.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(311, 351);
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
            button2.Location = new Point(632, 351);
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
            horizontalLine.Location = new Point(-2, 327);
            horizontalLine.Name = "horizontalLine";
            horizontalLine.Size = new Size(760, 2);
            horizontalLine.TabIndex = 8;
            // 
            // fmAddSTUDENT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 400);
            Controls.Add(horizontalLine);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(otchestvo);
            Controls.Add(imia);
            Controls.Add(familiya);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fmAddSTUDENT";
            Text = "Добавить запись";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox familiya;
        private TextBox imia;
        private TextBox otchestvo;
        private Button button1;
        private Button button2;
        private Label horizontalLine;
    }
}