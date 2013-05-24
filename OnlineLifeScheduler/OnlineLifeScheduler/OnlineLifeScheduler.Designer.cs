namespace OnlineLifeScheduler
{
    partial class OnlineLifeScheduler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlineLifeScheduler));
            this.menuStripOnlineLife = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceToShutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startWhenSystemStartedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxScheduleYourLife = new System.Windows.Forms.GroupBox();
            this.tabControlScheduler = new System.Windows.Forms.TabControl();
            this.tabPageOnLineScheduler = new System.Windows.Forms.TabPage();
            this.groupBoxWorkScheduler = new System.Windows.Forms.GroupBox();
            this.groupBoxScheduler = new System.Windows.Forms.GroupBox();
            this.comboBoxEndTime = new System.Windows.Forms.ComboBox();
            this.groupBoxForceComputer = new System.Windows.Forms.GroupBox();
            this.labelForceYourComputer = new System.Windows.Forms.Label();
            this.labelTimeTotally = new System.Windows.Forms.Label();
            this.labelTimeInTotal = new System.Windows.Forms.Label();
            this.labelStartWorkTime = new System.Windows.Forms.Label();
            this.buttonEndWork = new System.Windows.Forms.Button();
            this.buttonStartWork = new System.Windows.Forms.Button();
            this.groupBoxDateTime = new System.Windows.Forms.GroupBox();
            this.groupBoxTimeLeft = new System.Windows.Forms.GroupBox();
            this.labelTimeLeft = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelWeekDate = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.tabPageStudyScheduler = new System.Windows.Forms.TabPage();
            this.groupBoxStudyScheduler = new System.Windows.Forms.GroupBox();
            this.timerClickTime = new System.Windows.Forms.Timer(this.components);
            this.timerClickEvent = new System.Windows.Forms.Timer(this.components);
            this.menuStripOnlineLife.SuspendLayout();
            this.groupBoxScheduleYourLife.SuspendLayout();
            this.tabControlScheduler.SuspendLayout();
            this.tabPageOnLineScheduler.SuspendLayout();
            this.groupBoxWorkScheduler.SuspendLayout();
            this.groupBoxScheduler.SuspendLayout();
            this.groupBoxForceComputer.SuspendLayout();
            this.groupBoxDateTime.SuspendLayout();
            this.groupBoxTimeLeft.SuspendLayout();
            this.tabPageStudyScheduler.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripOnlineLife
            // 
            this.menuStripOnlineLife.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStripOnlineLife.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripOnlineLife.Location = new System.Drawing.Point(0, 0);
            this.menuStripOnlineLife.Name = "menuStripOnlineLife";
            this.menuStripOnlineLife.Size = new System.Drawing.Size(484, 24);
            this.menuStripOnlineLife.TabIndex = 0;
            this.menuStripOnlineLife.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forceToShutdownToolStripMenuItem,
            this.startWhenSystemStartedToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.editToolStripMenuItem.Text = "Settings";
            // 
            // forceToShutdownToolStripMenuItem
            // 
            this.forceToShutdownToolStripMenuItem.Name = "forceToShutdownToolStripMenuItem";
            this.forceToShutdownToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.forceToShutdownToolStripMenuItem.Text = "Force your computer";
            this.forceToShutdownToolStripMenuItem.Click += new System.EventHandler(this.forceToShutdownToolStripMenuItem_Click);
            // 
            // startWhenSystemStartedToolStripMenuItem
            // 
            this.startWhenSystemStartedToolStripMenuItem.Name = "startWhenSystemStartedToolStripMenuItem";
            this.startWhenSystemStartedToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.startWhenSystemStartedToolStripMenuItem.Text = "Start when system started";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactToolStripMenuItem,
            this.explationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.contactToolStripMenuItem.Text = "Contact";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // explationToolStripMenuItem
            // 
            this.explationToolStripMenuItem.Name = "explationToolStripMenuItem";
            this.explationToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.explationToolStripMenuItem.Text = "Explanation";
            this.explationToolStripMenuItem.Click += new System.EventHandler(this.explationToolStripMenuItem_Click);
            // 
            // groupBoxScheduleYourLife
            // 
            this.groupBoxScheduleYourLife.Controls.Add(this.tabControlScheduler);
            this.groupBoxScheduleYourLife.Location = new System.Drawing.Point(5, 30);
            this.groupBoxScheduleYourLife.Name = "groupBoxScheduleYourLife";
            this.groupBoxScheduleYourLife.Size = new System.Drawing.Size(472, 252);
            this.groupBoxScheduleYourLife.TabIndex = 1;
            this.groupBoxScheduleYourLife.TabStop = false;
            this.groupBoxScheduleYourLife.Text = "Schedule Your Life";
            // 
            // tabControlScheduler
            // 
            this.tabControlScheduler.Controls.Add(this.tabPageOnLineScheduler);
            this.tabControlScheduler.Controls.Add(this.tabPageStudyScheduler);
            this.tabControlScheduler.Location = new System.Drawing.Point(6, 19);
            this.tabControlScheduler.Name = "tabControlScheduler";
            this.tabControlScheduler.SelectedIndex = 0;
            this.tabControlScheduler.Size = new System.Drawing.Size(461, 228);
            this.tabControlScheduler.TabIndex = 3;
            // 
            // tabPageOnLineScheduler
            // 
            this.tabPageOnLineScheduler.Controls.Add(this.groupBoxWorkScheduler);
            this.tabPageOnLineScheduler.Location = new System.Drawing.Point(4, 22);
            this.tabPageOnLineScheduler.Name = "tabPageOnLineScheduler";
            this.tabPageOnLineScheduler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOnLineScheduler.Size = new System.Drawing.Size(453, 202);
            this.tabPageOnLineScheduler.TabIndex = 0;
            this.tabPageOnLineScheduler.Text = "On Line Life";
            this.tabPageOnLineScheduler.UseVisualStyleBackColor = true;
            // 
            // groupBoxWorkScheduler
            // 
            this.groupBoxWorkScheduler.Controls.Add(this.groupBoxScheduler);
            this.groupBoxWorkScheduler.Controls.Add(this.groupBoxDateTime);
            this.groupBoxWorkScheduler.Location = new System.Drawing.Point(0, 0);
            this.groupBoxWorkScheduler.Name = "groupBoxWorkScheduler";
            this.groupBoxWorkScheduler.Size = new System.Drawing.Size(450, 202);
            this.groupBoxWorkScheduler.TabIndex = 0;
            this.groupBoxWorkScheduler.TabStop = false;
            // 
            // groupBoxScheduler
            // 
            this.groupBoxScheduler.Controls.Add(this.comboBoxEndTime);
            this.groupBoxScheduler.Controls.Add(this.groupBoxForceComputer);
            this.groupBoxScheduler.Controls.Add(this.labelTimeTotally);
            this.groupBoxScheduler.Controls.Add(this.labelTimeInTotal);
            this.groupBoxScheduler.Controls.Add(this.labelStartWorkTime);
            this.groupBoxScheduler.Controls.Add(this.buttonEndWork);
            this.groupBoxScheduler.Controls.Add(this.buttonStartWork);
            this.groupBoxScheduler.Location = new System.Drawing.Point(152, 8);
            this.groupBoxScheduler.Name = "groupBoxScheduler";
            this.groupBoxScheduler.Size = new System.Drawing.Size(293, 193);
            this.groupBoxScheduler.TabIndex = 1;
            this.groupBoxScheduler.TabStop = false;
            this.groupBoxScheduler.Text = "Scheduler";
            // 
            // comboBoxEndTime
            // 
            this.comboBoxEndTime.BackColor = System.Drawing.SystemColors.HotTrack;
            this.comboBoxEndTime.FormattingEnabled = true;
            this.comboBoxEndTime.Items.AddRange(new object[] {
            "17:00:00",
            "17:30:00",
            "18:00:00",
            "18:30:00",
            "19:00:00",
            "19:30:00",
            "20:00:00",
            "20:30:00",
            "21:00:00",
            "21:30:00",
            "22:00:00",
            "22:30:00",
            "23:00:00",
            "23:30:00"});
            this.comboBoxEndTime.Location = new System.Drawing.Point(98, 54);
            this.comboBoxEndTime.Name = "comboBoxEndTime";
            this.comboBoxEndTime.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEndTime.TabIndex = 2;
            // 
            // groupBoxForceComputer
            // 
            this.groupBoxForceComputer.Controls.Add(this.labelForceYourComputer);
            this.groupBoxForceComputer.Location = new System.Drawing.Point(3, 84);
            this.groupBoxForceComputer.Name = "groupBoxForceComputer";
            this.groupBoxForceComputer.Size = new System.Drawing.Size(287, 106);
            this.groupBoxForceComputer.TabIndex = 6;
            this.groupBoxForceComputer.TabStop = false;
            this.groupBoxForceComputer.Text = "Force Your Computer";
            // 
            // labelForceYourComputer
            // 
            this.labelForceYourComputer.AutoSize = true;
            this.labelForceYourComputer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelForceYourComputer.Location = new System.Drawing.Point(5, 27);
            this.labelForceYourComputer.Name = "labelForceYourComputer";
            this.labelForceYourComputer.Size = new System.Drawing.Size(281, 54);
            this.labelForceYourComputer.TabIndex = 0;
            this.labelForceYourComputer.Text = "Your computer will be forced to be down when time is up, \r\nif you have choose to " +
    "use the Ice virus, the resources of \r\nyour computer will be cost up and shutdown" +
    ", your \r\ncomputer will be crashed.";
            // 
            // labelTimeTotally
            // 
            this.labelTimeTotally.AutoSize = true;
            this.labelTimeTotally.BackColor = System.Drawing.Color.Gainsboro;
            this.labelTimeTotally.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTimeTotally.Location = new System.Drawing.Point(155, 28);
            this.labelTimeTotally.Name = "labelTimeTotally";
            this.labelTimeTotally.Size = new System.Drawing.Size(70, 15);
            this.labelTimeTotally.TabIndex = 5;
            this.labelTimeTotally.Text = "Time in Total";
            // 
            // labelTimeInTotal
            // 
            this.labelTimeInTotal.AutoSize = true;
            this.labelTimeInTotal.BackColor = System.Drawing.Color.LightSeaGreen;
            this.labelTimeInTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTimeInTotal.Location = new System.Drawing.Point(230, 28);
            this.labelTimeInTotal.Name = "labelTimeInTotal";
            this.labelTimeInTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTimeInTotal.Size = new System.Drawing.Size(51, 15);
            this.labelTimeInTotal.TabIndex = 4;
            this.labelTimeInTotal.Text = "00:00:00";
            // 
            // labelStartWorkTime
            // 
            this.labelStartWorkTime.AutoSize = true;
            this.labelStartWorkTime.BackColor = System.Drawing.Color.LightSeaGreen;
            this.labelStartWorkTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStartWorkTime.Location = new System.Drawing.Point(98, 28);
            this.labelStartWorkTime.Name = "labelStartWorkTime";
            this.labelStartWorkTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelStartWorkTime.Size = new System.Drawing.Size(51, 15);
            this.labelStartWorkTime.TabIndex = 3;
            this.labelStartWorkTime.Text = "00:00:00";
            // 
            // buttonEndWork
            // 
            this.buttonEndWork.Location = new System.Drawing.Point(7, 52);
            this.buttonEndWork.Name = "buttonEndWork";
            this.buttonEndWork.Size = new System.Drawing.Size(85, 23);
            this.buttonEndWork.TabIndex = 1;
            this.buttonEndWork.Text = "End At";
            this.buttonEndWork.UseVisualStyleBackColor = true;
            this.buttonEndWork.Click += new System.EventHandler(this.buttonEndWork_Click);
            // 
            // buttonStartWork
            // 
            this.buttonStartWork.BackColor = System.Drawing.Color.DarkRed;
            this.buttonStartWork.ForeColor = System.Drawing.Color.White;
            this.buttonStartWork.Location = new System.Drawing.Point(6, 23);
            this.buttonStartWork.Name = "buttonStartWork";
            this.buttonStartWork.Size = new System.Drawing.Size(86, 23);
            this.buttonStartWork.TabIndex = 0;
            this.buttonStartWork.Text = "Start At";
            this.buttonStartWork.UseVisualStyleBackColor = false;
            this.buttonStartWork.Click += new System.EventHandler(this.buttonStartWork_Click);
            // 
            // groupBoxDateTime
            // 
            this.groupBoxDateTime.Controls.Add(this.groupBoxTimeLeft);
            this.groupBoxDateTime.Controls.Add(this.labelTime);
            this.groupBoxDateTime.Controls.Add(this.labelWeekDate);
            this.groupBoxDateTime.Controls.Add(this.labelMonth);
            this.groupBoxDateTime.Controls.Add(this.labelDay);
            this.groupBoxDateTime.Controls.Add(this.labelYear);
            this.groupBoxDateTime.Location = new System.Drawing.Point(2, 8);
            this.groupBoxDateTime.Name = "groupBoxDateTime";
            this.groupBoxDateTime.Size = new System.Drawing.Size(148, 190);
            this.groupBoxDateTime.TabIndex = 0;
            this.groupBoxDateTime.TabStop = false;
            this.groupBoxDateTime.Text = "Date And Time";
            // 
            // groupBoxTimeLeft
            // 
            this.groupBoxTimeLeft.Controls.Add(this.labelTimeLeft);
            this.groupBoxTimeLeft.Location = new System.Drawing.Point(6, 98);
            this.groupBoxTimeLeft.Name = "groupBoxTimeLeft";
            this.groupBoxTimeLeft.Size = new System.Drawing.Size(136, 86);
            this.groupBoxTimeLeft.TabIndex = 13;
            this.groupBoxTimeLeft.TabStop = false;
            this.groupBoxTimeLeft.Text = "Time Left";
            // 
            // labelTimeLeft
            // 
            this.labelTimeLeft.AutoSize = true;
            this.labelTimeLeft.BackColor = System.Drawing.Color.LimeGreen;
            this.labelTimeLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeLeft.Location = new System.Drawing.Point(4, 30);
            this.labelTimeLeft.Name = "labelTimeLeft";
            this.labelTimeLeft.Size = new System.Drawing.Size(129, 35);
            this.labelTimeLeft.TabIndex = 13;
            this.labelTimeLeft.Text = "00:00:00";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(10, 53);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(129, 35);
            this.labelTime.TabIndex = 12;
            this.labelTime.Text = "00:00:00";
            // 
            // labelWeekDate
            // 
            this.labelWeekDate.AutoSize = true;
            this.labelWeekDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelWeekDate.Location = new System.Drawing.Point(96, 28);
            this.labelWeekDate.Name = "labelWeekDate";
            this.labelWeekDate.Size = new System.Drawing.Size(47, 15);
            this.labelWeekDate.TabIndex = 11;
            this.labelWeekDate.Text = "Monday";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMonth.Location = new System.Drawing.Point(42, 28);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(21, 15);
            this.labelMonth.TabIndex = 8;
            this.labelMonth.Text = "00";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDay.Location = new System.Drawing.Point(69, 28);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(21, 15);
            this.labelDay.TabIndex = 9;
            this.labelDay.Text = "00";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelYear.Location = new System.Drawing.Point(3, 28);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(33, 15);
            this.labelYear.TabIndex = 7;
            this.labelYear.Text = "0000";
            // 
            // tabPageStudyScheduler
            // 
            this.tabPageStudyScheduler.Controls.Add(this.groupBoxStudyScheduler);
            this.tabPageStudyScheduler.Location = new System.Drawing.Point(4, 22);
            this.tabPageStudyScheduler.Name = "tabPageStudyScheduler";
            this.tabPageStudyScheduler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudyScheduler.Size = new System.Drawing.Size(453, 202);
            this.tabPageStudyScheduler.TabIndex = 1;
            this.tabPageStudyScheduler.Text = "On Line Study";
            this.tabPageStudyScheduler.UseVisualStyleBackColor = true;
            // 
            // groupBoxStudyScheduler
            // 
            this.groupBoxStudyScheduler.Location = new System.Drawing.Point(0, 3);
            this.groupBoxStudyScheduler.Name = "groupBoxStudyScheduler";
            this.groupBoxStudyScheduler.Size = new System.Drawing.Size(450, 199);
            this.groupBoxStudyScheduler.TabIndex = 1;
            this.groupBoxStudyScheduler.TabStop = false;
            // 
            // timerClickTime
            // 
            this.timerClickTime.Enabled = true;
            this.timerClickTime.Tick += new System.EventHandler(this.timerClickTime_Tick);
            // 
            // timerClickEvent
            // 
            this.timerClickEvent.Tick += new System.EventHandler(this.timerClickEvent_Tick);
            // 
            // OnlineLifeScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 291);
            this.Controls.Add(this.groupBoxScheduleYourLife);
            this.Controls.Add(this.menuStripOnlineLife);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripOnlineLife;
            this.Name = "OnlineLifeScheduler";
            this.Text = "Online Life Scheduler";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OnlineLifeScheduler_Load);
            this.menuStripOnlineLife.ResumeLayout(false);
            this.menuStripOnlineLife.PerformLayout();
            this.groupBoxScheduleYourLife.ResumeLayout(false);
            this.tabControlScheduler.ResumeLayout(false);
            this.tabPageOnLineScheduler.ResumeLayout(false);
            this.groupBoxWorkScheduler.ResumeLayout(false);
            this.groupBoxScheduler.ResumeLayout(false);
            this.groupBoxScheduler.PerformLayout();
            this.groupBoxForceComputer.ResumeLayout(false);
            this.groupBoxForceComputer.PerformLayout();
            this.groupBoxDateTime.ResumeLayout(false);
            this.groupBoxDateTime.PerformLayout();
            this.groupBoxTimeLeft.ResumeLayout(false);
            this.groupBoxTimeLeft.PerformLayout();
            this.tabPageStudyScheduler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripOnlineLife;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explationToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxScheduleYourLife;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceToShutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startWhenSystemStartedToolStripMenuItem;
        private System.Windows.Forms.Timer timerClickTime;
        private System.Windows.Forms.Timer timerClickEvent;
        private System.Windows.Forms.TabControl tabControlScheduler;
        private System.Windows.Forms.TabPage tabPageOnLineScheduler;
        private System.Windows.Forms.GroupBox groupBoxWorkScheduler;
        private System.Windows.Forms.GroupBox groupBoxScheduler;
        private System.Windows.Forms.ComboBox comboBoxEndTime;
        private System.Windows.Forms.GroupBox groupBoxForceComputer;
        private System.Windows.Forms.Label labelTimeTotally;
        private System.Windows.Forms.Label labelTimeInTotal;
        private System.Windows.Forms.Label labelStartWorkTime;
        private System.Windows.Forms.Button buttonEndWork;
        private System.Windows.Forms.Button buttonStartWork;
        private System.Windows.Forms.GroupBox groupBoxDateTime;
        private System.Windows.Forms.GroupBox groupBoxTimeLeft;
        private System.Windows.Forms.Label labelTimeLeft;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelWeekDate;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TabPage tabPageStudyScheduler;
        private System.Windows.Forms.GroupBox groupBoxStudyScheduler;
        private System.Windows.Forms.Label labelForceYourComputer;
    }
}

