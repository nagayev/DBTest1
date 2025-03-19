п»їnamespace DBTest1
{
    partial class VIDSTIPRequest
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
            VIDSTIP = new DataGridViewTextBoxColumn();
            SUMSTIP = new DataGridViewTextBoxColumn();
            studentBindingSource = new BindingSource(components);
            printButton = new Button();
            quitButton = new Button();
            label1 = new Label();
            label2 = new Label();
            minTextbox = new TextBox();
            label3 = new Label();
            maxTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)vidstipGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // vidstipGridView
            // 
            vidstipGridView.AllowUserToAddRows = false;
            vidstipGridView.AllowUserToDeleteRows = false;
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
            vidstipGridView.Columns.AddRange(new DataGridViewColumn[] { VIDSTIP, SUMSTIP });
            vidstipGridView.Location = new Point(2, 3);
            vidstipGridView.Name = "vidstipGridView";
            vidstipGridView.RowHeadersWidth = 20;
            vidstipGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            vidstipGridView.Size = new Size(699, 371);
            vidstipGridView.TabIndex = 0;
            // 
            // VIDSTIP
            // 
            VIDSTIP.HeaderText = "Р’РёРґ СЃС‚РёРїРµРЅРґРёРё";
            VIDSTIP.MinimumWidth = 6;
            VIDSTIP.Name = "VIDSTIP";
            VIDSTIP.Width = 339;
            // 
            // SUMSTIP
            // 
            SUMSTIP.HeaderText = "РЎСѓРјРјР° СЃС‚РёРїРµРЅРґРёРё";
            SUMSTIP.MinimumWidth = 6;
            SUMSTIP.Name = "SUMSTIP";
            SUMSTIP.Width = 338;
            // 
            // printButton
            // 
            printButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            printButton.Location = new Point(271, 508);
            printButton.Name = "printButton";
            printButton.Size = new Size(94, 29);
            printButton.TabIndex = 4;
            printButton.Text = "Р’С‹РІРµСЃС‚Рё";
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
            quitButton.Text = "РћС‚РјРµРЅРёС‚СЊ";
            quitButton.UseVisualStyleBackColor = true;
            quitButton.Click += quitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(287, 389);
            label1.Name = "label1";
            label1.Size = new Size(144, 18);
            label1.TabIndex = 6;
            label1.Text = "РЎСѓРјРјР° СЃС‚РёРїРµРЅРґРёРё";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(155, 445);
            label2.Name = "label2";
            label2.Size = new Size(34, 18);
            label2.TabIndex = 7;
            label2.Text = "РћС‚:";
            // 
            // minTextbox
            // 
            minTextbox.Location = new Point(215, 445);
            minTextbox.Name = "minTextbox";
            minTextbox.Size = new Size(125, 27);
            minTextbox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(496, 445);
            label3.Name = "label3";
            label3.Size = new Size(34, 18);
            label3.TabIndex = 9;
            label3.Text = "Р”Рѕ:";
            // 
            // maxTextBox
            // 
            maxTextBox.Location = new Point(558, 445);
            maxTextBox.Name = "maxTextBox";
            maxTextBox.Size = new Size(125, 27);
            maxTextBox.TabIndex = 10;
            maxTextBox.TextChanged += maxTextBox_TextChanged;
            // 
            // VIDSTIPRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 549);
            Controls.Add(maxTextBox);
            Controls.Add(label3);
            Controls.Add(minTextbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(quitButton);
            Controls.Add(printButton);
            Controls.Add(vidstipGridView);
            Name = "VIDSTIPRequest";
            Text = "РЎРїРёСЃРѕРє РІРёРґРѕРІ СЃС‚РёРїРµРЅРґРёР№ РІ СѓРєР°Р·Р°РЅРЅРѕРј РґРёР°РїРѕР·РѕРЅРµ РІС‹РїР»Р°С‚";
            Load += VIDSTIPRequest_Load;
            ((System.ComponentModel.ISupportInitialize)vidstipGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView vidstipGridView;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Button printButton;
        private Button quitButton;
        private BindingSource studentBindingSource;
        private DataGridViewTextBoxColumn VIDSTIP;
        private DataGridViewTextBoxColumn SUMSTIP;
        private Label label1;
        private Label label2;
        private TextBox minTextbox;
        private Label label3;
        private TextBox maxTextBox;
    }
}