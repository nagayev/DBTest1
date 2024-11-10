namespace DBTest1
{
    partial class fmEditVIDSTIP
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
            vidstip = new TextBox();
            sumstip = new TextBox();
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
            label1.Size = new Size(145, 24);
            label1.TabIndex = 0;
            label1.Text = "Вид стипендии";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(202, 149);
            label2.Name = "label2";
            label2.Size = new Size(230, 24);
            label2.TabIndex = 1;
            label2.Text = "Сумма стипендии (руб.)";
            // 
            // vidstip
            // 
            vidstip.Location = new Point(439, 74);
            vidstip.Name = "vidstip";
            vidstip.Size = new Size(125, 27);
            vidstip.TabIndex = 3;
            // 
            // sumstip
            // 
            sumstip.Location = new Point(439, 150);
            sumstip.Name = "sumstip";
            sumstip.Size = new Size(125, 27);
            sumstip.TabIndex = 4;
            // 
            // okButton
            // 
            okButton.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            okButton.Location = new Point(311, 290);
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
            cancelButton.Location = new Point(632, 290);
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
            horizontalLine.Location = new Point(-2, 247);
            horizontalLine.Name = "horizontalLine";
            horizontalLine.Size = new Size(760, 2);
            horizontalLine.TabIndex = 8;
            // 
            // fmEditVIDSTIP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 349);
            Controls.Add(horizontalLine);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(sumstip);
            Controls.Add(vidstip);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fmEditVIDSTIP";
            Text = "Редактировать запись";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox vidstip;
        private TextBox sumstip;
        private Button okButton;
        private Button cancelButton;
        private Label horizontalLine;
    }
}