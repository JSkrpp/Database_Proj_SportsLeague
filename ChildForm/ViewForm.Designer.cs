namespace Liga.ChildForm
{
    partial class ViewForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableCB = new System.Windows.Forms.ComboBox();
            this.dataList = new System.Windows.Forms.ListBox();
            this.tableName = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.TeamBox = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(221, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zaladuj dane z tabeli";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn1_click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(221, 539);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(345, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Pełne dane ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn2_click);
            // 
            // tableCB
            // 
            this.tableCB.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableCB.FormattingEnabled = true;
            this.tableCB.Items.AddRange(new object[] {
            "Drużyny",
            "Kontrakty",
            "Pracownicy",
            "Sponsorzy",
            "Stadiony",
            "Zawodnicy"});
            this.tableCB.Location = new System.Drawing.Point(221, 62);
            this.tableCB.Name = "tableCB";
            this.tableCB.Size = new System.Drawing.Size(345, 25);
            this.tableCB.TabIndex = 2;
            // 
            // dataList
            // 
            this.dataList.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataList.FormattingEnabled = true;
            this.dataList.ItemHeight = 20;
            this.dataList.Location = new System.Drawing.Point(221, 201);
            this.dataList.Name = "dataList";
            this.dataList.Size = new System.Drawing.Size(345, 304);
            this.dataList.TabIndex = 3;
            // 
            // tableName
            // 
            this.tableName.AutoSize = true;
            this.tableName.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableName.Location = new System.Drawing.Point(221, 162);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(0, 25);
            this.tableName.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(766, 199);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(360, 304);
            this.listBox1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(766, 537);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(360, 30);
            this.button3.TabIndex = 6;
            this.button3.Text = "Posortuj malejaco";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TeamBox
            // 
            this.TeamBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamBox.FormattingEnabled = true;
            this.TeamBox.Location = new System.Drawing.Point(766, 62);
            this.TeamBox.Name = "TeamBox";
            this.TeamBox.Size = new System.Drawing.Size(360, 25);
            this.TeamBox.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(766, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(360, 30);
            this.button4.TabIndex = 8;
            this.button4.Text = "Wybierz Druzyne";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn4_click);
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1344, 727);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.TeamBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tableName);
            this.Controls.Add(this.dataList);
            this.Controls.Add(this.tableCB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ViewForm";
            this.Text = "ViewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox tableCB;
        private System.Windows.Forms.ListBox dataList;
        private System.Windows.Forms.Label tableName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox TeamBox;
        private System.Windows.Forms.Button button4;
    }
}