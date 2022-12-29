namespace DatabaseProject
{
    partial class Form16
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
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbfirst_name = new System.Windows.Forms.TextBox();
            this.tbfirst_namel = new System.Windows.Forms.Label();
            this.tbphone_number = new System.Windows.Forms.TextBox();
            this.tbphone_numberl = new System.Windows.Forms.Label();
            this.tblast_namel = new System.Windows.Forms.Label();
            this.tblast_name = new System.Windows.Forms.TextBox();
            this.tbaddressl = new System.Windows.Forms.Label();
            this.tbaddress = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(257, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Customer Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(640, 285);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(426, 442);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(228, 45);
            this.btnInsert.TabIndex = 22;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(685, 442);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(228, 45);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbfirst_name
            // 
            this.tbfirst_name.Location = new System.Drawing.Point(141, 363);
            this.tbfirst_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbfirst_name.Name = "tbfirst_name";
            this.tbfirst_name.Size = new System.Drawing.Size(174, 26);
            this.tbfirst_name.TabIndex = 26;
            // 
            // tbfirst_namel
            // 
            this.tbfirst_namel.AutoSize = true;
            this.tbfirst_namel.Location = new System.Drawing.Point(15, 369);
            this.tbfirst_namel.Name = "tbfirst_namel";
            this.tbfirst_namel.Size = new System.Drawing.Size(86, 20);
            this.tbfirst_namel.TabIndex = 25;
            this.tbfirst_namel.Text = "First Name";
            // 
            // tbphone_number
            // 
            this.tbphone_number.Location = new System.Drawing.Point(141, 400);
            this.tbphone_number.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbphone_number.Name = "tbphone_number";
            this.tbphone_number.Size = new System.Drawing.Size(174, 26);
            this.tbphone_number.TabIndex = 30;
            // 
            // tbphone_numberl
            // 
            this.tbphone_numberl.AutoSize = true;
            this.tbphone_numberl.Location = new System.Drawing.Point(9, 406);
            this.tbphone_numberl.Name = "tbphone_numberl";
            this.tbphone_numberl.Size = new System.Drawing.Size(115, 20);
            this.tbphone_numberl.TabIndex = 29;
            this.tbphone_numberl.Text = "Phone Number";
            // 
            // tblast_namel
            // 
            this.tblast_namel.AutoSize = true;
            this.tblast_namel.Location = new System.Drawing.Point(362, 366);
            this.tblast_namel.Name = "tblast_namel";
            this.tblast_namel.Size = new System.Drawing.Size(86, 20);
            this.tblast_namel.TabIndex = 28;
            this.tblast_namel.Text = "Last Name";
            // 
            // tblast_name
            // 
            this.tblast_name.Location = new System.Drawing.Point(480, 360);
            this.tblast_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblast_name.Name = "tblast_name";
            this.tblast_name.Size = new System.Drawing.Size(174, 26);
            this.tblast_name.TabIndex = 27;
            // 
            // tbaddressl
            // 
            this.tbaddressl.AutoSize = true;
            this.tbaddressl.Location = new System.Drawing.Point(362, 400);
            this.tbaddressl.Name = "tbaddressl";
            this.tbaddressl.Size = new System.Drawing.Size(68, 20);
            this.tbaddressl.TabIndex = 32;
            this.tbaddressl.Text = "Address";
            // 
            // tbaddress
            // 
            this.tbaddress.Location = new System.Drawing.Point(480, 397);
            this.tbaddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.Size = new System.Drawing.Size(174, 26);
            this.tbaddress.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 14);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 35);
            this.button2.TabIndex = 33;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(925, 500);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbaddressl);
            this.Controls.Add(this.tbaddress);
            this.Controls.Add(this.tbphone_number);
            this.Controls.Add(this.tbphone_numberl);
            this.Controls.Add(this.tblast_namel);
            this.Controls.Add(this.tblast_name);
            this.Controls.Add(this.tbfirst_name);
            this.Controls.Add(this.tbfirst_namel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form16";
            this.Text = "Form16";
            this.Load += new System.EventHandler(this.Form16_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbfirst_name;
        private System.Windows.Forms.Label tbfirst_namel;
        private System.Windows.Forms.TextBox tbphone_number;
        private System.Windows.Forms.Label tbphone_numberl;
        private System.Windows.Forms.Label tblast_namel;
        private System.Windows.Forms.TextBox tblast_name;
        private System.Windows.Forms.Label tbaddressl;
        private System.Windows.Forms.TextBox tbaddress;
        private System.Windows.Forms.Button button2;
    }
}