namespace DBTest1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            таблицыToolStripMenuItem = new ToolStripMenuItem();
            studentsMenuItem = new ToolStripMenuItem();
            stipsMenuItem = new ToolStripMenuItem();
            studentStipsMenuItem = new ToolStripMenuItem();
            видСтипендииНазначаемаяToolStripMenuItem = new ToolStripMenuItem();
            студентВыплатыСтудентаToolStripMenuItem = new ToolStripMenuItem();
            запросыToolStripMenuItem = new ToolStripMenuItem();
            requestStudentsListMenuItem = new ToolStripMenuItem();
            списокВидовСтидендийВУказанномДипазонеСуммыСтипендииToolStripMenuItem = new ToolStripMenuItem();
            списокВыплатУказанногоСтудентаЗаУказанныйПериодToolStripMenuItem = new ToolStripMenuItem();
            отчетыToolStripMenuItem = new ToolStripMenuItem();
            report1MenuItem = new ToolStripMenuItem();
            report2MenuItem = new ToolStripMenuItem();
            report3MenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            aboutDeveloperMenu = new ToolStripMenuItem();
            quitMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { таблицыToolStripMenuItem, запросыToolStripMenuItem, отчетыToolStripMenuItem, toolStripMenuItem1, aboutDeveloperMenu, quitMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(957, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            таблицыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { studentsMenuItem, stipsMenuItem, studentStipsMenuItem, видСтипендииНазначаемаяToolStripMenuItem, студентВыплатыСтудентаToolStripMenuItem });
            таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            таблицыToolStripMenuItem.Size = new Size(85, 24);
            таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // studentsMenuItem
            // 
            studentsMenuItem.Name = "studentsMenuItem";
            studentsMenuItem.Size = new Size(453, 26);
            studentsMenuItem.Text = "\"Студенты\"";
            studentsMenuItem.Click += studentsMenuItem_Click;
            // 
            // stipsMenuItem
            // 
            stipsMenuItem.Name = "stipsMenuItem";
            stipsMenuItem.Size = new Size(453, 26);
            stipsMenuItem.Text = "\"Стипендии\"";
            stipsMenuItem.Click += stipsMenuItem_Click;
            // 
            // studentStipsMenuItem
            // 
            studentStipsMenuItem.Name = "studentStipsMenuItem";
            studentStipsMenuItem.Size = new Size(453, 26);
            studentStipsMenuItem.Text = "\"Студент - назначаемая студенту стипендия\"";
            // 
            // видСтипендииНазначаемаяToolStripMenuItem
            // 
            видСтипендииНазначаемаяToolStripMenuItem.Name = "видСтипендииНазначаемаяToolStripMenuItem";
            видСтипендииНазначаемаяToolStripMenuItem.Size = new Size(453, 26);
            видСтипендииНазначаемаяToolStripMenuItem.Text = "\"Вид стипендии - назначаемая студенту стипендия\"";
            // 
            // студентВыплатыСтудентаToolStripMenuItem
            // 
            студентВыплатыСтудентаToolStripMenuItem.Name = "студентВыплатыСтудентаToolStripMenuItem";
            студентВыплатыСтудентаToolStripMenuItem.Size = new Size(453, 26);
            студентВыплатыСтудентаToolStripMenuItem.Text = "\"Студент - выплаты студента\"";
            // 
            // запросыToolStripMenuItem
            // 
            запросыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { requestStudentsListMenuItem, списокВидовСтидендийВУказанномДипазонеСуммыСтипендииToolStripMenuItem, списокВыплатУказанногоСтудентаЗаУказанныйПериодToolStripMenuItem });
            запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            запросыToolStripMenuItem.Size = new Size(84, 24);
            запросыToolStripMenuItem.Text = "Запросы";
            // 
            // requestStudentsListMenuItem
            // 
            requestStudentsListMenuItem.Name = "requestStudentsListMenuItem";
            requestStudentsListMenuItem.Size = new Size(556, 26);
            requestStudentsListMenuItem.Text = "Список студентов по алфавиту";
            requestStudentsListMenuItem.Click += requestStudentsListMenuItem_Click;
            // 
            // списокВидовСтидендийВУказанномДипазонеСуммыСтипендииToolStripMenuItem
            // 
            списокВидовСтидендийВУказанномДипазонеСуммыСтипендииToolStripMenuItem.Name = "списокВидовСтидендийВУказанномДипазонеСуммыСтипендииToolStripMenuItem";
            списокВидовСтидендийВУказанномДипазонеСуммыСтипендииToolStripMenuItem.Size = new Size(556, 26);
            списокВидовСтидендийВУказанномДипазонеСуммыСтипендииToolStripMenuItem.Text = "Список видов стидендий в указанном дипазоне суммы стипендии";
            списокВидовСтидендийВУказанномДипазонеСуммыСтипендииToolStripMenuItem.Click += списокВидовСтидендийВУказанномДипазонеСуммыСтипендииToolStripMenuItem_Click;
            // 
            // списокВыплатУказанногоСтудентаЗаУказанныйПериодToolStripMenuItem
            // 
            списокВыплатУказанногоСтудентаЗаУказанныйПериодToolStripMenuItem.Name = "списокВыплатУказанногоСтудентаЗаУказанныйПериодToolStripMenuItem";
            списокВыплатУказанногоСтудентаЗаУказанныйПериодToolStripMenuItem.Size = new Size(556, 26);
            списокВыплатУказанногоСтудентаЗаУказанныйПериодToolStripMenuItem.Text = "Список выплат указанного студента за указанный период";
            // 
            // отчетыToolStripMenuItem
            // 
            отчетыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { report1MenuItem, report2MenuItem, report3MenuItem });
            отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            отчетыToolStripMenuItem.Size = new Size(73, 24);
            отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // report1MenuItem
            // 
            report1MenuItem.Name = "report1MenuItem";
            report1MenuItem.Size = new Size(496, 26);
            report1MenuItem.Text = "Список видов стипендий по алфавиту";
            report1MenuItem.Click += report1MenuItem_Click;
            // 
            // report2MenuItem
            // 
            report2MenuItem.Name = "report2MenuItem";
            report2MenuItem.Size = new Size(496, 26);
            report2MenuItem.Text = "Список студентов, получающих указанный вид стипендии";
            // 
            // report3MenuItem
            // 
            report3MenuItem.Name = "report3MenuItem";
            report3MenuItem.Size = new Size(496, 26);
            report3MenuItem.Text = "Список выплат указанного студента";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 24);
            // 
            // aboutDeveloperMenu
            // 
            aboutDeveloperMenu.Name = "aboutDeveloperMenu";
            aboutDeveloperMenu.Size = new Size(230, 24);
            aboutDeveloperMenu.Text = "Информация о разработчике";
            aboutDeveloperMenu.Click += aboutDeveloperMenu_Click;
            // 
            // quitMenuItem
            // 
            quitMenuItem.Name = "quitMenuItem";
            quitMenuItem.Size = new Size(67, 24);
            quitMenuItem.Text = "Выход";
            quitMenuItem.Click += quitMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._87890;
            ClientSize = new Size(957, 523);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Приложение для управления базой данных деканата";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem таблицыToolStripMenuItem;
        private ToolStripMenuItem запросыToolStripMenuItem;
        private ToolStripMenuItem отчетыToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem aboutDeveloperMenu;
        private ToolStripMenuItem quitMenuItem;
        private ToolStripMenuItem studentsMenuItem;
        private ToolStripMenuItem stipsMenuItem;
        private ToolStripMenuItem studentStipsMenuItem;
        private ToolStripMenuItem видСтипендииНазначаемаяToolStripMenuItem;
        private ToolStripMenuItem студентВыплатыСтудентаToolStripMenuItem;
        private ToolStripMenuItem requestStudentsListMenuItem;
        private ToolStripMenuItem списокВидовСтидендийВУказанномДипазонеСуммыСтипендииToolStripMenuItem;
        private ToolStripMenuItem списокВыплатУказанногоСтудентаЗаУказанныйПериодToolStripMenuItem;
        private ToolStripMenuItem report1MenuItem;
        private ToolStripMenuItem report2MenuItem;
        private ToolStripMenuItem report3MenuItem;
    }
}
