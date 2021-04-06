
namespace ITPM_Project
{
    partial class FormAllLecturesTable
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
            this.panelAllLectures = new System.Windows.Forms.Panel();
            this.labelAllLecturesTT = new System.Windows.Forms.Label();
            this.panelAllLectureSideMenu = new System.Windows.Forms.Panel();
            this.btnAllLectureWorkingDays = new System.Windows.Forms.Button();
            this.btnAllLecturesLecturers = new System.Windows.Forms.Button();
            this.btnAllLecturesSubjects = new System.Windows.Forms.Button();
            this.btnAllLecturesStudents = new System.Windows.Forms.Button();
            this.btnAllLecturesTags = new System.Windows.Forms.Button();
            this.btnAllLecturesLocations = new System.Windows.Forms.Button();
            this.btnAllLecturesStatistics = new System.Windows.Forms.Button();
            this.btnAllLecturesSessionManagement = new System.Windows.Forms.Button();
            this.btnAllLecturesRoomManagement = new System.Windows.Forms.Button();
            this.btnAllLecturesGenerateTT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelAllLectures.SuspendLayout();
            this.panelAllLectureSideMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAllLectures
            // 
            this.panelAllLectures.Controls.Add(this.labelAllLecturesTT);
            this.panelAllLectures.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAllLectures.Location = new System.Drawing.Point(0, 0);
            this.panelAllLectures.Name = "panelAllLectures";
            this.panelAllLectures.Size = new System.Drawing.Size(800, 50);
            this.panelAllLectures.TabIndex = 0;
            // 
            // labelAllLecturesTT
            // 
            this.labelAllLecturesTT.AutoSize = true;
            this.labelAllLecturesTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllLecturesTT.Location = new System.Drawing.Point(265, 9);
            this.labelAllLecturesTT.Name = "labelAllLecturesTT";
            this.labelAllLecturesTT.Size = new System.Drawing.Size(316, 29);
            this.labelAllLecturesTT.TabIndex = 1;
            this.labelAllLecturesTT.Text = "Time Table Management";
            this.labelAllLecturesTT.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelAllLectureSideMenu
            // 
            this.panelAllLectureSideMenu.Controls.Add(this.btnAllLecturesGenerateTT);
            this.panelAllLectureSideMenu.Controls.Add(this.btnAllLecturesRoomManagement);
            this.panelAllLectureSideMenu.Controls.Add(this.btnAllLecturesSessionManagement);
            this.panelAllLectureSideMenu.Controls.Add(this.btnAllLecturesStatistics);
            this.panelAllLectureSideMenu.Controls.Add(this.btnAllLecturesLocations);
            this.panelAllLectureSideMenu.Controls.Add(this.btnAllLecturesTags);
            this.panelAllLectureSideMenu.Controls.Add(this.btnAllLecturesStudents);
            this.panelAllLectureSideMenu.Controls.Add(this.btnAllLecturesSubjects);
            this.panelAllLectureSideMenu.Controls.Add(this.btnAllLecturesLecturers);
            this.panelAllLectureSideMenu.Controls.Add(this.btnAllLectureWorkingDays);
            this.panelAllLectureSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAllLectureSideMenu.Location = new System.Drawing.Point(0, 50);
            this.panelAllLectureSideMenu.Name = "panelAllLectureSideMenu";
            this.panelAllLectureSideMenu.Size = new System.Drawing.Size(200, 397);
            this.panelAllLectureSideMenu.TabIndex = 1;
            // 
            // btnAllLectureWorkingDays
            // 
            this.btnAllLectureWorkingDays.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAllLectureWorkingDays.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllLectureWorkingDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllLectureWorkingDays.Location = new System.Drawing.Point(0, 0);
            this.btnAllLectureWorkingDays.Name = "btnAllLectureWorkingDays";
            this.btnAllLectureWorkingDays.Size = new System.Drawing.Size(200, 40);
            this.btnAllLectureWorkingDays.TabIndex = 0;
            this.btnAllLectureWorkingDays.Text = "Working Days && Hours\r\n";
            this.btnAllLectureWorkingDays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllLectureWorkingDays.UseVisualStyleBackColor = false;
            this.btnAllLectureWorkingDays.Click += new System.EventHandler(this.btnAllLectureWorkingDays_Click);
            // 
            // btnAllLecturesLecturers
            // 
            this.btnAllLecturesLecturers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAllLecturesLecturers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllLecturesLecturers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllLecturesLecturers.Location = new System.Drawing.Point(0, 40);
            this.btnAllLecturesLecturers.Name = "btnAllLecturesLecturers";
            this.btnAllLecturesLecturers.Size = new System.Drawing.Size(200, 40);
            this.btnAllLecturesLecturers.TabIndex = 1;
            this.btnAllLecturesLecturers.Text = "Lecturers";
            this.btnAllLecturesLecturers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllLecturesLecturers.UseVisualStyleBackColor = false;
            // 
            // btnAllLecturesSubjects
            // 
            this.btnAllLecturesSubjects.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAllLecturesSubjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllLecturesSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllLecturesSubjects.Location = new System.Drawing.Point(0, 80);
            this.btnAllLecturesSubjects.Name = "btnAllLecturesSubjects";
            this.btnAllLecturesSubjects.Size = new System.Drawing.Size(200, 40);
            this.btnAllLecturesSubjects.TabIndex = 2;
            this.btnAllLecturesSubjects.Text = "Subjects";
            this.btnAllLecturesSubjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllLecturesSubjects.UseVisualStyleBackColor = false;
            // 
            // btnAllLecturesStudents
            // 
            this.btnAllLecturesStudents.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAllLecturesStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllLecturesStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllLecturesStudents.Location = new System.Drawing.Point(0, 120);
            this.btnAllLecturesStudents.Name = "btnAllLecturesStudents";
            this.btnAllLecturesStudents.Size = new System.Drawing.Size(200, 40);
            this.btnAllLecturesStudents.TabIndex = 3;
            this.btnAllLecturesStudents.Text = "Students";
            this.btnAllLecturesStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllLecturesStudents.UseVisualStyleBackColor = false;
            // 
            // btnAllLecturesTags
            // 
            this.btnAllLecturesTags.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAllLecturesTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllLecturesTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllLecturesTags.Location = new System.Drawing.Point(0, 160);
            this.btnAllLecturesTags.Name = "btnAllLecturesTags";
            this.btnAllLecturesTags.Size = new System.Drawing.Size(200, 40);
            this.btnAllLecturesTags.TabIndex = 4;
            this.btnAllLecturesTags.Text = "Tags";
            this.btnAllLecturesTags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllLecturesTags.UseVisualStyleBackColor = false;
            // 
            // btnAllLecturesLocations
            // 
            this.btnAllLecturesLocations.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAllLecturesLocations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllLecturesLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllLecturesLocations.Location = new System.Drawing.Point(0, 200);
            this.btnAllLecturesLocations.Name = "btnAllLecturesLocations";
            this.btnAllLecturesLocations.Size = new System.Drawing.Size(200, 40);
            this.btnAllLecturesLocations.TabIndex = 5;
            this.btnAllLecturesLocations.Text = "Locations";
            this.btnAllLecturesLocations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllLecturesLocations.UseVisualStyleBackColor = false;
            // 
            // btnAllLecturesStatistics
            // 
            this.btnAllLecturesStatistics.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAllLecturesStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllLecturesStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllLecturesStatistics.Location = new System.Drawing.Point(0, 240);
            this.btnAllLecturesStatistics.Name = "btnAllLecturesStatistics";
            this.btnAllLecturesStatistics.Size = new System.Drawing.Size(200, 40);
            this.btnAllLecturesStatistics.TabIndex = 6;
            this.btnAllLecturesStatistics.Text = "Statistics";
            this.btnAllLecturesStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllLecturesStatistics.UseVisualStyleBackColor = false;
            // 
            // btnAllLecturesSessionManagement
            // 
            this.btnAllLecturesSessionManagement.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAllLecturesSessionManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllLecturesSessionManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllLecturesSessionManagement.Location = new System.Drawing.Point(0, 280);
            this.btnAllLecturesSessionManagement.Name = "btnAllLecturesSessionManagement";
            this.btnAllLecturesSessionManagement.Size = new System.Drawing.Size(200, 40);
            this.btnAllLecturesSessionManagement.TabIndex = 7;
            this.btnAllLecturesSessionManagement.Text = "Session Management";
            this.btnAllLecturesSessionManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllLecturesSessionManagement.UseVisualStyleBackColor = false;
            // 
            // btnAllLecturesRoomManagement
            // 
            this.btnAllLecturesRoomManagement.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAllLecturesRoomManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllLecturesRoomManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllLecturesRoomManagement.Location = new System.Drawing.Point(0, 320);
            this.btnAllLecturesRoomManagement.Name = "btnAllLecturesRoomManagement";
            this.btnAllLecturesRoomManagement.Size = new System.Drawing.Size(200, 40);
            this.btnAllLecturesRoomManagement.TabIndex = 8;
            this.btnAllLecturesRoomManagement.Text = "Room Management";
            this.btnAllLecturesRoomManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllLecturesRoomManagement.UseVisualStyleBackColor = false;
            // 
            // btnAllLecturesGenerateTT
            // 
            this.btnAllLecturesGenerateTT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAllLecturesGenerateTT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllLecturesGenerateTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllLecturesGenerateTT.Location = new System.Drawing.Point(0, 360);
            this.btnAllLecturesGenerateTT.Name = "btnAllLecturesGenerateTT";
            this.btnAllLecturesGenerateTT.Size = new System.Drawing.Size(200, 40);
            this.btnAllLecturesGenerateTT.TabIndex = 9;
            this.btnAllLecturesGenerateTT.Text = "Generate Time Table";
            this.btnAllLecturesGenerateTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllLecturesGenerateTT.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 40);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Lecturer Details";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(200, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Edit Lecturer Details";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(400, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "View Lecturer Details";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // FormAllLecturesTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelAllLectureSideMenu);
            this.Controls.Add(this.panelAllLectures);
            this.Name = "FormAllLecturesTable";
            this.Text = "Form1";
            this.panelAllLectures.ResumeLayout(false);
            this.panelAllLectures.PerformLayout();
            this.panelAllLectureSideMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAllLectures;
        private System.Windows.Forms.Label labelAllLecturesTT;
        private System.Windows.Forms.Panel panelAllLectureSideMenu;
        private System.Windows.Forms.Button btnAllLecturesGenerateTT;
        private System.Windows.Forms.Button btnAllLecturesRoomManagement;
        private System.Windows.Forms.Button btnAllLecturesSessionManagement;
        private System.Windows.Forms.Button btnAllLecturesStatistics;
        private System.Windows.Forms.Button btnAllLecturesLocations;
        private System.Windows.Forms.Button btnAllLecturesTags;
        private System.Windows.Forms.Button btnAllLecturesStudents;
        private System.Windows.Forms.Button btnAllLecturesSubjects;
        private System.Windows.Forms.Button btnAllLecturesLecturers;
        private System.Windows.Forms.Button btnAllLectureWorkingDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

