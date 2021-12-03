
namespace TeatroSistema.View
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panelContent = new System.Windows.Forms.Panel();
            this.SubContent = new System.Windows.Forms.Panel();
            this.Content = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Sidebar = new System.Windows.Forms.Panel();
            this.Flecha = new System.Windows.Forms.PictureBox();
            this.btnSegu = new System.Windows.Forms.Button();
            this.btnRepo = new System.Windows.Forms.Button();
            this.btnOpe = new System.Windows.Forms.Button();
            this.btnCata = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Header = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Button();
            this.Maximize = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.panelContent.SuspendLayout();
            this.SubContent.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Flecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.SubContent);
            this.panelContent.Controls.Add(this.Sidebar);
            this.panelContent.Controls.Add(this.Header);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1386, 788);
            this.panelContent.TabIndex = 2;
            // 
            // SubContent
            // 
            this.SubContent.Controls.Add(this.Content);
            this.SubContent.Controls.Add(this.Menu);
            this.SubContent.Controls.Add(this.button1);
            this.SubContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubContent.Location = new System.Drawing.Point(137, 29);
            this.SubContent.Name = "SubContent";
            this.SubContent.Size = new System.Drawing.Size(1249, 759);
            this.SubContent.TabIndex = 2;
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(0, 33);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(1249, 726);
            this.Content.TabIndex = 2;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1249, 33);
            this.Menu.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Sidebar.Controls.Add(this.Flecha);
            this.Sidebar.Controls.Add(this.btnSegu);
            this.Sidebar.Controls.Add(this.btnRepo);
            this.Sidebar.Controls.Add(this.btnOpe);
            this.Sidebar.Controls.Add(this.btnCata);
            this.Sidebar.Controls.Add(this.label1);
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 29);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(137, 759);
            this.Sidebar.TabIndex = 1;
            // 
            // Flecha
            // 
            this.Flecha.Image = ((System.Drawing.Image)(resources.GetObject("Flecha.Image")));
            this.Flecha.Location = new System.Drawing.Point(119, 158);
            this.Flecha.Name = "Flecha";
            this.Flecha.Size = new System.Drawing.Size(20, 20);
            this.Flecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flecha.TabIndex = 0;
            this.Flecha.TabStop = false;
            // 
            // btnSegu
            // 
            this.btnSegu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSegu.ForeColor = System.Drawing.Color.White;
            this.btnSegu.Location = new System.Drawing.Point(30, 280);
            this.btnSegu.Name = "btnSegu";
            this.btnSegu.Size = new System.Drawing.Size(75, 23);
            this.btnSegu.TabIndex = 5;
            this.btnSegu.Text = "Seguridad";
            this.btnSegu.UseVisualStyleBackColor = true;
            this.btnSegu.Click += new System.EventHandler(this.btnSegu_Click);
            // 
            // btnRepo
            // 
            this.btnRepo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepo.ForeColor = System.Drawing.Color.White;
            this.btnRepo.Location = new System.Drawing.Point(30, 239);
            this.btnRepo.Name = "btnRepo";
            this.btnRepo.Size = new System.Drawing.Size(75, 23);
            this.btnRepo.TabIndex = 4;
            this.btnRepo.Text = "Reportes";
            this.btnRepo.UseVisualStyleBackColor = true;
            this.btnRepo.Click += new System.EventHandler(this.btnRepo_Click);
            // 
            // btnOpe
            // 
            this.btnOpe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpe.ForeColor = System.Drawing.Color.White;
            this.btnOpe.Location = new System.Drawing.Point(30, 197);
            this.btnOpe.Name = "btnOpe";
            this.btnOpe.Size = new System.Drawing.Size(75, 23);
            this.btnOpe.TabIndex = 3;
            this.btnOpe.Text = "Operaciones";
            this.btnOpe.UseVisualStyleBackColor = true;
            this.btnOpe.Click += new System.EventHandler(this.btnOpe_Click);
            // 
            // btnCata
            // 
            this.btnCata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCata.ForeColor = System.Drawing.Color.White;
            this.btnCata.Location = new System.Drawing.Point(30, 155);
            this.btnCata.Name = "btnCata";
            this.btnCata.Size = new System.Drawing.Size(75, 23);
            this.btnCata.TabIndex = 2;
            this.btnCata.Text = "Catálogo";
            this.btnCata.UseVisualStyleBackColor = true;
            this.btnCata.Click += new System.EventHandler(this.btnCata_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(27, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teatro Sistema";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Header.Controls.Add(this.Minimize);
            this.Header.Controls.Add(this.Maximize);
            this.Header.Controls.Add(this.Exit);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1386, 29);
            this.Header.TabIndex = 0;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // Minimize
            // 
            this.Minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimize.BackgroundImage")));
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Minimize.Location = new System.Drawing.Point(1295, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(32, 29);
            this.Minimize.TabIndex = 6;
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Maximize
            // 
            this.Maximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Maximize.BackgroundImage")));
            this.Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Maximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Maximize.Location = new System.Drawing.Point(1327, 0);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(29, 29);
            this.Maximize.TabIndex = 5;
            this.Maximize.UseVisualStyleBackColor = true;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // Exit
            // 
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(1356, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(30, 29);
            this.Exit.TabIndex = 3;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelContent.ResumeLayout(false);
            this.SubContent.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Flecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel SubContent;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Maximize;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Button btnSegu;
        private System.Windows.Forms.Button btnRepo;
        private System.Windows.Forms.Button btnOpe;
        private System.Windows.Forms.Button btnCata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Flecha;
    }
}