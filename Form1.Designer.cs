namespace Take_Home_w3
{
    partial class main
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
            this.nama = new System.Windows.Forms.Label();
            this.artis = new System.Windows.Forms.Label();
            this.inputnama = new System.Windows.Forms.TextBox();
            this.inputartis = new System.Windows.Forms.TextBox();
            this.cek = new System.Windows.Forms.CheckBox();
            this.submit = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.Location = new System.Drawing.Point(13, 13);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(78, 29);
            this.nama.TabIndex = 0;
            this.nama.Text = "Name";
            // 
            // artis
            // 
            this.artis.AutoSize = true;
            this.artis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artis.Location = new System.Drawing.Point(12, 72);
            this.artis.Name = "artis";
            this.artis.Size = new System.Drawing.Size(196, 29);
            this.artis.TabIndex = 1;
            this.artis.Text = "My Favorite Artist";
            // 
            // inputnama
            // 
            this.inputnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputnama.Location = new System.Drawing.Point(255, 15);
            this.inputnama.Name = "inputnama";
            this.inputnama.Size = new System.Drawing.Size(198, 30);
            this.inputnama.TabIndex = 2;
            // 
            // inputartis
            // 
            this.inputartis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputartis.Location = new System.Drawing.Point(255, 71);
            this.inputartis.Name = "inputartis";
            this.inputartis.Size = new System.Drawing.Size(198, 30);
            this.inputartis.TabIndex = 3;
            // 
            // cek
            // 
            this.cek.AutoSize = true;
            this.cek.Location = new System.Drawing.Point(18, 153);
            this.cek.Name = "cek";
            this.cek.Size = new System.Drawing.Size(289, 24);
            this.cek.TabIndex = 4;
            this.cek.Text = "All of the content I put above is true!";
            this.cek.UseVisualStyleBackColor = true;
            this.cek.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cek_MouseClick);
            // 
            // submit
            // 
            this.submit.Enabled = false;
            this.submit.Location = new System.Drawing.Point(18, 200);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(119, 57);
            this.submit.TabIndex = 5;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.submit_MouseClick);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(188, 200);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(119, 57);
            this.open.TabIndex = 6;
            this.open.Text = "Open Next Form";
            this.open.UseVisualStyleBackColor = true;
            this.open.MouseClick += new System.Windows.Forms.MouseEventHandler(this.open_MouseClick);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 278);
            this.Controls.Add(this.open);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.cek);
            this.Controls.Add(this.inputartis);
            this.Controls.Add(this.inputnama);
            this.Controls.Add(this.artis);
            this.Controls.Add(this.nama);
            this.Name = "main";
            this.Text = "Main Windows Form";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.Label artis;
        private System.Windows.Forms.TextBox inputnama;
        private System.Windows.Forms.TextBox inputartis;
        private System.Windows.Forms.CheckBox cek;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button open;
    }
}

