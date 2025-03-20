namespace DBTest1
{
    partial class report2Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(report2Window));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            horizontalLine = new Label();
            vidstip = new ComboBox();
            label4 = new Label();
            sumstip = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(202, 78);
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
            label2.Size = new Size(0, 24);
            label2.TabIndex = 1;
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
            button1.Location = new Point(311, 242);
            button1.Name = "button1";
            button1.Size = new Size(135, 29);
            button1.TabIndex = 6;
            button1.Text = "Вывод отчета";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(638, 242);
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
            horizontalLine.Location = new Point(-2, 173);
            horizontalLine.Name = "horizontalLine";
            horizontalLine.Size = new Size(760, 2);
            horizontalLine.TabIndex = 8;
            // 
            // vidstip
            // 
            vidstip.FormattingEnabled = true;
            vidstip.Location = new Point(446, 79);
            vidstip.Name = "vidstip";
            vidstip.Size = new Size(174, 28);
            vidstip.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(446, 149);
            label4.Name = "label4";
            label4.Size = new Size(0, 24);
            label4.TabIndex = 10;
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
            // 
            // report2Window
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 287);
            Controls.Add(sumstip);
            Controls.Add(label4);
            Controls.Add(vidstip);
            Controls.Add(horizontalLine);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "report2Window";
            Text = "Список студентов, получающий указанный вид стипендии";
            Load += report2Window_Load;
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
        private ComboBox vidstip;
        private Label label4;
        private Label sumstip;
    }
}