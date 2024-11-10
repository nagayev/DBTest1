namespace DBTest1
{
    partial class VIDSTIPTable
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
            vidstipGridView = new DataGridView();
            NVID = new DataGridViewTextBoxColumn();
            VIDSTIP = new DataGridViewTextBoxColumn();
            SUMSTIP = new DataGridViewTextBoxColumn();
            studentBindingSource = new BindingSource(components);
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            quitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)vidstipGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            SuspendLayout();
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
            vidstipGridView.Location = new Point(2, 3);
            vidstipGridView.Name = "vidstipGridView";
            vidstipGridView.RowHeadersWidth = 20;
            vidstipGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            vidstipGridView.Size = new Size(971, 462);
            vidstipGridView.TabIndex = 0;
            // 
            // NVID
            // 
            NVID.HeaderText = "Идентификатор стипендии";
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
            SUMSTIP.HeaderText = "Сумма стипендии";
            SUMSTIP.MinimumWidth = 6;
            SUMSTIP.Name = "SUMSTIP";
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
            // VIDSTIPTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 549);
            Controls.Add(quitButton);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(vidstipGridView);
            Name = "VIDSTIPTable";
            Text = "Таблица: \"Стипендии\"";
            Load += VIDSTIPTable_Load;
            ((System.ComponentModel.ISupportInitialize)vidstipGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView vidstipGridView;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Button updateButton;
        private Button quitButton;
        private BindingSource studentBindingSource;
        private DataGridViewTextBoxColumn NVID;
        private DataGridViewTextBoxColumn VIDSTIP;
        private DataGridViewTextBoxColumn SUMSTIP;
    }
}