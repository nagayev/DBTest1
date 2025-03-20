namespace DBTest1
{
    partial class VIDSTIP2Table
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            studentBindingSource = new BindingSource(components);
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            quitButton = new Button();
            vidstipGridView = new DataGridView();
            NVID = new DataGridViewTextBoxColumn();
            VIDSTIP = new DataGridViewTextBoxColumn();
            SUMSTIP = new DataGridViewTextBoxColumn();
            studentGridView = new DataGridView();
            NSTUDENT = new DataGridViewTextBoxColumn();
            FAMILIYA = new DataGridViewTextBoxColumn();
            IMYA = new DataGridViewTextBoxColumn();
            OTCHESTVO = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vidstipGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentGridView).BeginInit();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addButton.Location = new Point(31, 633);
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
            editButton.Location = new Point(171, 633);
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
            deleteButton.Location = new Point(314, 633);
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
            updateButton.Location = new Point(817, 318);
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
            quitButton.Location = new Point(844, 633);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(94, 29);
            quitButton.TabIndex = 5;
            quitButton.Text = "Выйти";
            quitButton.UseVisualStyleBackColor = true;
            quitButton.Click += quitButton_Click;
            // 
            // vidstipGridView
            // 
            vidstipGridView.AllowUserToAddRows = false;
            vidstipGridView.AllowUserToDeleteRows = false;
            vidstipGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            vidstipGridView.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            vidstipGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            vidstipGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vidstipGridView.Columns.AddRange(new DataGridViewColumn[] { NVID, VIDSTIP, SUMSTIP });
            vidstipGridView.Location = new Point(0, 0);
            vidstipGridView.Name = "vidstipGridView";
            vidstipGridView.RowHeadersWidth = 20;
            vidstipGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            vidstipGridView.Size = new Size(971, 293);
            vidstipGridView.TabIndex = 6;
            vidstipGridView.SelectionChanged += vidstipGridView_SelectionChanged;
            // 
            // NVID
            // 
            NVID.HeaderText = "Номер стипендии";
            NVID.MinimumWidth = 6;
            NVID.Name = "NVID";
            // 
            // VIDSTIP
            // 
            VIDSTIP.HeaderText = "Вид стипендии";
            VIDSTIP.MinimumWidth = 6;
            VIDSTIP.Name = "VIDSTIP";
            // 
            // SUMSTIP
            // 
            SUMSTIP.HeaderText = "Сумма стипендии (руб.)";
            SUMSTIP.MinimumWidth = 6;
            SUMSTIP.Name = "SUMSTIP";
            // 
            // studentGridView
            // 
            studentGridView.AllowUserToAddRows = false;
            studentGridView.AllowUserToDeleteRows = false;
            studentGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentGridView.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            studentGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            studentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentGridView.Columns.AddRange(new DataGridViewColumn[] { NSTUDENT, FAMILIYA, IMYA, OTCHESTVO });
            studentGridView.Location = new Point(0, 367);
            studentGridView.Name = "studentGridView";
            studentGridView.RowHeadersWidth = 20;
            studentGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentGridView.Size = new Size(971, 247);
            studentGridView.TabIndex = 7;
            studentGridView.CellContentClick += studentGridView_CellContentClick;
            // 
            // NSTUDENT
            // 
            NSTUDENT.HeaderText = "Идентификатор студента";
            NSTUDENT.MinimumWidth = 6;
            NSTUDENT.Name = "NSTUDENT";
            // 
            // FAMILIYA
            // 
            FAMILIYA.HeaderText = "Фамилия";
            FAMILIYA.MinimumWidth = 6;
            FAMILIYA.Name = "FAMILIYA";
            FAMILIYA.ReadOnly = true;
            // 
            // IMYA
            // 
            IMYA.HeaderText = "Имя";
            IMYA.MinimumWidth = 6;
            IMYA.Name = "IMYA";
            IMYA.ReadOnly = true;
            // 
            // OTCHESTVO
            // 
            OTCHESTVO.HeaderText = "Отчество";
            OTCHESTVO.MinimumWidth = 6;
            OTCHESTVO.Name = "OTCHESTVO";
            OTCHESTVO.ReadOnly = true;
            // 
            // VIDSTIP2Table
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 696);
            Controls.Add(studentGridView);
            Controls.Add(vidstipGridView);
            Controls.Add(quitButton);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Name = "VIDSTIP2Table";
            Text = "Таблица: \"Вид стипендии - назначаемая студенту стипендия\"";
            Load += VIDSTIP2Table_Load;
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)vidstipGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Button updateButton;
        private Button quitButton;
        private BindingSource studentBindingSource;
        private DataGridView vidstipGridView;
        private DataGridViewTextBoxColumn NVID;
        private DataGridViewTextBoxColumn VIDSTIP;
        private DataGridViewTextBoxColumn SUMSTIP;
        private DataGridView studentGridView;
        private DataGridViewTextBoxColumn NSTUDENT;
        private DataGridViewTextBoxColumn FAMILIYA;
        private DataGridViewTextBoxColumn IMYA;
        private DataGridViewTextBoxColumn OTCHESTVO;
    }
}