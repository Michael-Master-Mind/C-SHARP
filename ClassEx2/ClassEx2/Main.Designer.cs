namespace ClassEx2
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDepartementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayDepartementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.departementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1520, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.displayStudentToolStripMenuItem,
            this.updateStudentToolStripMenuItem});
            this.toolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.studentToolStripMenuItem.Text = "Register";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // displayStudentToolStripMenuItem
            // 
            this.displayStudentToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.displayStudentToolStripMenuItem.Name = "displayStudentToolStripMenuItem";
            this.displayStudentToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.displayStudentToolStripMenuItem.Text = "Display All";
            this.displayStudentToolStripMenuItem.Click += new System.EventHandler(this.displayStudentToolStripMenuItem_Click);
            // 
            // updateStudentToolStripMenuItem
            // 
            this.updateStudentToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateStudentToolStripMenuItem.Name = "updateStudentToolStripMenuItem";
            this.updateStudentToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.updateStudentToolStripMenuItem.Text = "Search";
            this.updateStudentToolStripMenuItem.Click += new System.EventHandler(this.updateStudentToolStripMenuItem_Click);
            // 
            // departementToolStripMenuItem
            // 
            this.departementToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.departementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDepartementToolStripMenuItem,
            this.displayDepartementToolStripMenuItem});
            this.departementToolStripMenuItem.Name = "departementToolStripMenuItem";
            this.departementToolStripMenuItem.Size = new System.Drawing.Size(111, 26);
            this.departementToolStripMenuItem.Text = "Departement";
            // 
            // addDepartementToolStripMenuItem
            // 
            this.addDepartementToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addDepartementToolStripMenuItem.Name = "addDepartementToolStripMenuItem";
            this.addDepartementToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.addDepartementToolStripMenuItem.Text = "Add Departement";
            // 
            // displayDepartementToolStripMenuItem
            // 
            this.displayDepartementToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.displayDepartementToolStripMenuItem.Name = "displayDepartementToolStripMenuItem";
            this.displayDepartementToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.displayDepartementToolStripMenuItem.Text = "Display Departement";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkGray;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1433, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 29);
            this.label11.TabIndex = 2;
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1345, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hello,";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1520, 630);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDepartementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayDepartementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayStudentToolStripMenuItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
    }
}