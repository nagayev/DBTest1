namespace DBTest1
{
    partial class fmEditSTUDENT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmEditSTUDENT));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            familiya = new TextBox();
            imia = new TextBox();
            otchestvo = new TextBox();
            okButton = new Button();
            cancelButton = new Button();
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
            // okButton
            // 
            okButton.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            okButton.Location = new Point(311, 351);
            okButton.Name = "okButton";
            okButton.Size = new Size(94, 29);
            okButton.TabIndex = 6;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cancelButton.Location = new Point(632, 351);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(97, 29);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Отменить";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // horizontalLine
            // 
            horizontalLine.BorderStyle = BorderStyle.Fixed3D;
            horizontalLine.Location = new Point(-2, 327);
            horizontalLine.Name = "horizontalLine";
            horizontalLine.Size = new Size(760, 2);
            horizontalLine.TabIndex = 8;
            // 
            // fmEditSTUDENT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 400);
            Controls.Add(horizontalLine);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(otchestvo);
            Controls.Add(imia);
            Controls.Add(familiya);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fmEditSTUDENT";
            Text = "Редактировать запись";
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
        private Button okButton;
        private Button cancelButton;
        private Label horizontalLine;
    }
}