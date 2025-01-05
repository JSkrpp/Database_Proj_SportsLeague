namespace Liga
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bkgPane = new System.Windows.Forms.Panel();
            this.AddBtn = new System.Windows.Forms.Button();
            this.LogBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.DeletionBtn = new System.Windows.Forms.Button();
            this.EditorBtn = new System.Windows.Forms.Button();
            this.LogoPane = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.WidokBtn = new System.Windows.Forms.Button();
            this.ScreenPane = new System.Windows.Forms.Panel();
            this.ScreenLabel = new System.Windows.Forms.Label();
            this.formPane = new System.Windows.Forms.Panel();
            this.bkgPane.SuspendLayout();
            this.LogoPane.SuspendLayout();
            this.ScreenPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // bkgPane
            // 
            this.bkgPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.bkgPane.Controls.Add(this.AddBtn);
            this.bkgPane.Controls.Add(this.LogBtn);
            this.bkgPane.Controls.Add(this.HomeBtn);
            this.bkgPane.Controls.Add(this.DeletionBtn);
            this.bkgPane.Controls.Add(this.EditorBtn);
            this.bkgPane.Controls.Add(this.LogoPane);
            this.bkgPane.Controls.Add(this.WidokBtn);
            this.bkgPane.Location = new System.Drawing.Point(0, 0);
            this.bkgPane.Name = "bkgPane";
            this.bkgPane.Size = new System.Drawing.Size(240, 867);
            this.bkgPane.TabIndex = 3;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Image = global::Liga.Properties.Resources.plus;
            this.AddBtn.Location = new System.Drawing.Point(0, 540);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(240, 100);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Dodawanie";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // LogBtn
            // 
            this.LogBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.LogBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogBtn.FlatAppearance.BorderSize = 0;
            this.LogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogBtn.ForeColor = System.Drawing.Color.White;
            this.LogBtn.Image = global::Liga.Properties.Resources.login;
            this.LogBtn.Location = new System.Drawing.Point(0, 667);
            this.LogBtn.Margin = new System.Windows.Forms.Padding(0);
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.Size = new System.Drawing.Size(240, 100);
            this.LogBtn.TabIndex = 8;
            this.LogBtn.Text = "Login";
            this.LogBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.LogBtn.UseVisualStyleBackColor = false;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Image = global::Liga.Properties.Resources.home;
            this.HomeBtn.Location = new System.Drawing.Point(0, 767);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(240, 100);
            this.HomeBtn.TabIndex = 7;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // DeletionBtn
            // 
            this.DeletionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.DeletionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletionBtn.FlatAppearance.BorderSize = 0;
            this.DeletionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletionBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeletionBtn.ForeColor = System.Drawing.Color.White;
            this.DeletionBtn.Image = global::Liga.Properties.Resources.trash;
            this.DeletionBtn.Location = new System.Drawing.Point(0, 440);
            this.DeletionBtn.Margin = new System.Windows.Forms.Padding(0);
            this.DeletionBtn.Name = "DeletionBtn";
            this.DeletionBtn.Size = new System.Drawing.Size(240, 100);
            this.DeletionBtn.TabIndex = 6;
            this.DeletionBtn.Text = "Usuwanie";
            this.DeletionBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.DeletionBtn.UseVisualStyleBackColor = false;
            this.DeletionBtn.Click += new System.EventHandler(this.deletionBtn_Click);
            // 
            // EditorBtn
            // 
            this.EditorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.EditorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditorBtn.FlatAppearance.BorderSize = 0;
            this.EditorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditorBtn.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorBtn.ForeColor = System.Drawing.Color.White;
            this.EditorBtn.Image = global::Liga.Properties.Resources.edit;
            this.EditorBtn.Location = new System.Drawing.Point(0, 340);
            this.EditorBtn.Margin = new System.Windows.Forms.Padding(0);
            this.EditorBtn.Name = "EditorBtn";
            this.EditorBtn.Size = new System.Drawing.Size(240, 100);
            this.EditorBtn.TabIndex = 5;
            this.EditorBtn.Text = "Edycja";
            this.EditorBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.EditorBtn.UseVisualStyleBackColor = false;
            this.EditorBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // LogoPane
            // 
            this.LogoPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.LogoPane.BackgroundImage = global::Liga.Properties.Resources._1490886333_37_basketball_82467;
            this.LogoPane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LogoPane.Controls.Add(this.panel1);
            this.LogoPane.Controls.Add(this.label1);
            this.LogoPane.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPane.Location = new System.Drawing.Point(0, 0);
            this.LogoPane.Name = "LogoPane";
            this.LogoPane.Size = new System.Drawing.Size(240, 240);
            this.LogoPane.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.panel1.Location = new System.Drawing.Point(240, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 100);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Liga Sportowa";
            // 
            // WidokBtn
            // 
            this.WidokBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.WidokBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WidokBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WidokBtn.FlatAppearance.BorderSize = 0;
            this.WidokBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WidokBtn.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidokBtn.ForeColor = System.Drawing.Color.White;
            this.WidokBtn.Image = global::Liga.Properties.Resources.eye;
            this.WidokBtn.Location = new System.Drawing.Point(0, 240);
            this.WidokBtn.Margin = new System.Windows.Forms.Padding(0);
            this.WidokBtn.Name = "WidokBtn";
            this.WidokBtn.Size = new System.Drawing.Size(240, 100);
            this.WidokBtn.TabIndex = 0;
            this.WidokBtn.Text = "Wyswietlanie";
            this.WidokBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.WidokBtn.UseVisualStyleBackColor = false;
            this.WidokBtn.Click += new System.EventHandler(this.widokBtn_Click);
            // 
            // ScreenPane
            // 
            this.ScreenPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ScreenPane.Controls.Add(this.ScreenLabel);
            this.ScreenPane.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(70)))));
            this.ScreenPane.Location = new System.Drawing.Point(240, 0);
            this.ScreenPane.Name = "ScreenPane";
            this.ScreenPane.Size = new System.Drawing.Size(1360, 100);
            this.ScreenPane.TabIndex = 4;
            // 
            // ScreenLabel
            // 
            this.ScreenLabel.AutoSize = true;
            this.ScreenLabel.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenLabel.ForeColor = System.Drawing.Color.White;
            this.ScreenLabel.Location = new System.Drawing.Point(570, 25);
            this.ScreenLabel.Name = "ScreenLabel";
            this.ScreenLabel.Size = new System.Drawing.Size(283, 50);
            this.ScreenLabel.TabIndex = 0;
            this.ScreenLabel.Text = "Ekran startowy";
            this.ScreenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formPane
            // 
            this.formPane.Location = new System.Drawing.Point(240, 100);
            this.formPane.Name = "formPane";
            this.formPane.Size = new System.Drawing.Size(1360, 766);
            this.formPane.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.formPane);
            this.Controls.Add(this.ScreenPane);
            this.Controls.Add(this.bkgPane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bkgPane.ResumeLayout(false);
            this.LogoPane.ResumeLayout(false);
            this.LogoPane.PerformLayout();
            this.ScreenPane.ResumeLayout(false);
            this.ScreenPane.PerformLayout();
            this.ResumeLayout(false);

        }

    
        #endregion
        private System.Windows.Forms.Panel bkgPane;
        private System.Windows.Forms.Panel LogoPane;
        private System.Windows.Forms.Button DeletionBtn;
        private System.Windows.Forms.Button EditorBtn;
        private System.Windows.Forms.Button WidokBtn;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ScreenPane;
        private System.Windows.Forms.Label ScreenLabel;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Panel formPane;
    }
}

