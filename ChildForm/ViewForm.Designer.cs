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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(100, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zaladuj dane z tabeli";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn1_click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(100, 537);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(310, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Pełne dane ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn2_click);
            // 
            // tableCB
            // 
            this.tableCB.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableCB.FormattingEnabled = true;
            this.tableCB.Items.AddRange(new object[] {
            "Drużyny",
            "Kontrakty",
            "Pracownicy",
            "Sponsorzy",
            "Stadiony",
            "Zawodnicy"});
            this.tableCB.Location = new System.Drawing.Point(100, 60);
            this.tableCB.Name = "tableCB";
            this.tableCB.Size = new System.Drawing.Size(240, 23);
            this.tableCB.TabIndex = 2;
            // 
            // dataList
            // 
            this.dataList.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataList.FormattingEnabled = true;
            this.dataList.ItemHeight = 20;
            this.dataList.Location = new System.Drawing.Point(100, 199);
            this.dataList.Name = "dataList";
            this.dataList.Size = new System.Drawing.Size(310, 304);
            this.dataList.TabIndex = 3;
            // 
            // tableName
            // 
            this.tableName.AutoSize = true;
            this.tableName.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableName.Location = new System.Drawing.Point(100, 160);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(0, 25);
            this.tableName.TabIndex = 4;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1344, 727);
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
    }
}