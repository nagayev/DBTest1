namespace DBTest1
{
    partial class VYPLATYRequest
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
            vyplatyGridView = new DataGridView();
            DATAVYPLATY = new DataGridViewTextBoxColumn();
            SUMVYPLATY = new DataGridViewTextBoxColumn();
            studentBindingSource = new BindingSource(components);
            printButton = new Button();
            quitButton = new Button();
            label2 = new Label();
            label3 = new Label();
            famCombo = new ComboBox();
            fromDatePicker = new DateTimePicker();
            toDatePicker = new DateTimePicker();
            label1 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)vyplatyGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // vyplatyGridView
            // 
            vyplatyGridView.AllowUserToAddRows = false;
            vyplatyGridView.AllowUserToDeleteRows = false;
            vyplatyGridView.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            vyplatyGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            vyplatyGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vyplatyGridView.Columns.AddRange(new DataGridViewColumn[] { DATAVYPLATY, SUMVYPLATY });
            vyplatyGridView.Location = new Point(2, 3);
            vyplatyGridView.Name = "vyplatyGridView";
            vyplatyGridView.RowHeadersWidth = 20;
            vyplatyGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            vyplatyGridView.Size = new Size(699, 371);
            vyplatyGridView.TabIndex = 0;
            // 
            // DATAVYPLATY
            // 
            DATAVYPLATY.HeaderText = "Дата выплаты";
            DATAVYPLATY.MinimumWidth = 6;
            DATAVYPLATY.Name = "DATAVYPLATY";
            DATAVYPLATY.Width = 339;
            // 
            // SUMVYPLATY
            // 
            SUMVYPLATY.HeaderText = "Сумма выплаты";
            SUMVYPLATY.MinimumWidth = 6;
            SUMVYPLATY.Name = "SUMVYPLATY";
            SUMVYPLATY.Width = 338;
            // 
            // printButton
            // 
            printButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            printButton.Location = new Point(271, 508);
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
            quitButton.Location = new Point(600, 508);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(94, 29);
            quitButton.TabIndex = 5;
            quitButton.Text = "Отменить";
            quitButton.UseVisualStyleBackColor = true;
            quitButton.Click += quitButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(43, 398);
            label2.Name = "label2";
            label2.Size = new Size(160, 18);
            label2.TabIndex = 7;
            label2.Text = "Фамилия студента:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(333, 398);
            label3.Name = "label3";
            label3.Size = new Size(134, 18);
            label3.TabIndex = 9;
            label3.Text = "Период выплат:";
            // 
            // famCombo
            // 
            famCombo.FormattingEnabled = true;
            famCombo.Location = new Point(55, 451);
            famCombo.Name = "famCombo";
            famCombo.Size = new Size(151, 28);
            famCombo.TabIndex = 11;
            // 
            // fromDatePicker
            // 
            fromDatePicker.Format = DateTimePickerFormat.Short;
            fromDatePicker.Location = new Point(330, 449);
            fromDatePicker.Name = "fromDatePicker";
            fromDatePicker.Size = new Size(153, 27);
            fromDatePicker.TabIndex = 12;
            // 
            // toDatePicker
            // 
            toDatePicker.Format = DateTimePickerFormat.Short;
            toDatePicker.Location = new Point(547, 449);
            toDatePicker.Name = "toDatePicker";
            toDatePicker.Size = new Size(133, 27);
            toDatePicker.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(280, 455);
            label1.Name = "label1";
            label1.Size = new Size(34, 18);
            label1.TabIndex = 14;
            label1.Text = "От:";
            label1.Click += label1_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(507, 449);
            label4.Name = "label4";
            label4.Size = new Size(34, 18);
            label4.TabIndex = 15;
            label4.Text = "До:";
            // 
            // VYPLATYRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 549);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(toDatePicker);
            Controls.Add(fromDatePicker);
            Controls.Add(famCombo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(quitButton);
            Controls.Add(printButton);
            Controls.Add(vyplatyGridView);
            Name = "VYPLATYRequest";
            Text = "Список выплат студента за указанный период";
            Load += VYPLATYRequest_Load;
            ((System.ComponentModel.ISupportInitialize)vyplatyGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView vyplatyGridView;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Button printButton;
        private Button quitButton;
        private BindingSource studentBindingSource;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn DATAVYPLATY;
        private DataGridViewTextBoxColumn SUMVYPLATY;
        private ComboBox famCombo;
        private DateTimePicker fromDatePicker;
        private DateTimePicker toDatePicker;
        private Label label1;
        private Label label4;
    }
}