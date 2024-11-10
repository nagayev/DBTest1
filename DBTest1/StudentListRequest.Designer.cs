namespace DBTest1
{
    partial class StudentListRequest
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            studentsGridView = new DataGridView();
            FAMILYA = new DataGridViewTextBoxColumn();
            IMYA = new DataGridViewTextBoxColumn();
            OTCHESTVO = new DataGridViewTextBoxColumn();
            studentBindingSource = new BindingSource(components);
            printButton = new Button();
            quitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)studentsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // studentsGridView
            // 
            studentsGridView.AllowUserToAddRows = false;
            studentsGridView.AllowUserToDeleteRows = false;
            studentsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentsGridView.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            studentsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            studentsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentsGridView.Columns.AddRange(new DataGridViewColumn[] { FAMILYA, IMYA, OTCHESTVO });
            studentsGridView.Location = new Point(2, 3);
            studentsGridView.Name = "studentsGridView";
            studentsGridView.RowHeadersWidth = 20;
            studentsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentsGridView.Size = new Size(971, 462);
            studentsGridView.TabIndex = 0;
            // 
            // FAMILYA
            // 
            FAMILYA.HeaderText = "Фамилия";
            FAMILYA.MinimumWidth = 6;
            FAMILYA.Name = "FAMILYA";
            // 
            // IMYA
            // 
            IMYA.HeaderText = "Имя";
            IMYA.MinimumWidth = 6;
            IMYA.Name = "IMYA";
            // 
            // OTCHESTVO
            // 
            OTCHESTVO.HeaderText = "Отчество";
            OTCHESTVO.MinimumWidth = 6;
            OTCHESTVO.Name = "OTCHESTVO";
            // 
            // printButton
            // 
            printButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            printButton.Location = new Point(394, 490);
            printButton.Name = "printButton";
            printButton.Size = new Size(94, 29);
            printButton.TabIndex = 4;
            printButton.Text = "Вывести";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += updateButton_Click;
            // 
            // quitButton
            // 
            quitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            quitButton.Location = new Point(831, 490);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(94, 29);
            quitButton.TabIndex = 5;
            quitButton.Text = "Отменить";
            quitButton.UseVisualStyleBackColor = true;
            quitButton.Click += quitButton_Click;
            // 
            // StudentListRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 549);
            Controls.Add(quitButton);
            Controls.Add(printButton);
            Controls.Add(studentsGridView);
            Name = "StudentListRequest";
            Text = "Список студентов в алфавитном порядке";
            Load += StudentListRequest_Load;
            ((System.ComponentModel.ISupportInitialize)studentsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView studentsGridView;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Button printButton;
        private Button quitButton;
        private BindingSource studentBindingSource;
        private DataGridViewTextBoxColumn FAMILYA;
        private DataGridViewTextBoxColumn IMYA;
        private DataGridViewTextBoxColumn OTCHESTVO;
    }
}