namespace DBTest1
{
    partial class StudentTable
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            studentsGridView = new DataGridView();
            NSTUDENT = new DataGridViewTextBoxColumn();
            FAMILYA = new DataGridViewTextBoxColumn();
            IMYA = new DataGridViewTextBoxColumn();
            OTCHESTVO = new DataGridViewTextBoxColumn();
            studentBindingSource = new BindingSource(components);
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            quitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)studentsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // studentsGridView
            // 
            studentsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentsGridView.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            studentsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            studentsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentsGridView.Columns.AddRange(new DataGridViewColumn[] { NSTUDENT, FAMILYA, IMYA, OTCHESTVO });
            studentsGridView.Location = new Point(2, 3);
            studentsGridView.Name = "studentsGridView";
            studentsGridView.RowHeadersWidth = 20;
            studentsGridView.Size = new Size(971, 462);
            studentsGridView.TabIndex = 0;
            // 
            // NSTUDENT
            // 
            NSTUDENT.HeaderText = "Идентификатор студента";
            NSTUDENT.MinimumWidth = 6;
            NSTUDENT.Name = "NSTUDENT";
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
            // studentBindingSource
            // 
            //studentBindingSource.DataSource = typeof(Student);
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addButton.Location = new Point(32, 492);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 1;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            editButton.Location = new Point(172, 492);
            editButton.Name = "editButton";
            editButton.Size = new Size(94, 29);
            editButton.TabIndex = 2;
            editButton.Text = "Изменить";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteButton.Location = new Point(315, 492);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            updateButton.Location = new Point(661, 491);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(94, 29);
            updateButton.TabIndex = 4;
            updateButton.Text = "Обновить";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // quitButton
            // 
            quitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            quitButton.Location = new Point(831, 490);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(94, 29);
            quitButton.TabIndex = 5;
            quitButton.Text = "Выйти";
            quitButton.UseVisualStyleBackColor = true;
            quitButton.Click += quitButton_Click;
            // 
            // StudentTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 549);
            Controls.Add(quitButton);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(studentsGridView);
            Name = "StudentTable";
            Text = "Таблица: \"Студенты\"";
            Load += StudentTable_Load;
            ((System.ComponentModel.ISupportInitialize)studentsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView studentsGridView;
        private DataGridViewTextBoxColumn NSTUDENT;
        private DataGridViewTextBoxColumn FAMILYA;
        private DataGridViewTextBoxColumn IMYA;
        private DataGridViewTextBoxColumn OTCHESTVO;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Button updateButton;
        private Button quitButton;
        private BindingSource studentBindingSource;
    }
}