namespace ablak_szín_váltás
{
    partial class Ablak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ablak));
            this.lb_szoveg = new System.Windows.Forms.Label();
            this.btn_megad = new System.Windows.Forms.Button();
            this.tbx_szoveg = new System.Windows.Forms.TextBox();
            this.cb_box_szoveg = new System.Windows.Forms.ComboBox();
            this.lb_szovegszin = new System.Windows.Forms.Label();
            this.lb_hatterszin = new System.Windows.Forms.Label();
            this.cb_box_hatter = new System.Windows.Forms.ComboBox();
            this.btn_kerdes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_szoveg
            // 
            this.lb_szoveg.AutoSize = true;
            this.lb_szoveg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lb_szoveg.Font = new System.Drawing.Font("Edwardian Script ITC", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_szoveg.Location = new System.Drawing.Point(41, 32);
            this.lb_szoveg.Name = "lb_szoveg";
            this.lb_szoveg.Size = new System.Drawing.Size(570, 44);
            this.lb_szoveg.TabIndex = 0;
            this.lb_szoveg.Text = "Válaszd ki a szöveg színét és az ablak háttérszínét!";
            // 
            // btn_megad
            // 
            this.btn_megad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_megad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_megad.Font = new System.Drawing.Font("Edwardian Script ITC", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_megad.Location = new System.Drawing.Point(254, 328);
            this.btn_megad.Name = "btn_megad";
            this.btn_megad.Size = new System.Drawing.Size(146, 50);
            this.btn_megad.TabIndex = 1;
            this.btn_megad.Text = "Megad";
            this.btn_megad.UseVisualStyleBackColor = false;
            this.btn_megad.Click += new System.EventHandler(this.btn_megad_Click);
            // 
            // tbx_szoveg
            // 
            this.tbx_szoveg.Location = new System.Drawing.Point(49, 421);
            this.tbx_szoveg.Name = "tbx_szoveg";
            this.tbx_szoveg.Size = new System.Drawing.Size(556, 22);
            this.tbx_szoveg.TabIndex = 2;
            // 
            // cb_box_szoveg
            // 
            this.cb_box_szoveg.FormattingEnabled = true;
            this.cb_box_szoveg.Items.AddRange(new object[] {
            "Red",
            "LightBlue",
            "DarkSeaGreen",
            "LightGoldenrodYellow",
            "NavajoWhite",
            "Black",
            "MediumPurple",
            "DarkGray",
            "RosyBrown"});
            this.cb_box_szoveg.Location = new System.Drawing.Point(351, 137);
            this.cb_box_szoveg.Name = "cb_box_szoveg";
            this.cb_box_szoveg.Size = new System.Drawing.Size(195, 24);
            this.cb_box_szoveg.TabIndex = 3;
            // 
            // lb_szovegszin
            // 
            this.lb_szovegszin.AutoSize = true;
            this.lb_szovegszin.Font = new System.Drawing.Font("Edwardian Script ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_szovegszin.Location = new System.Drawing.Point(115, 127);
            this.lb_szovegszin.Name = "lb_szovegszin";
            this.lb_szovegszin.Size = new System.Drawing.Size(141, 36);
            this.lb_szovegszin.TabIndex = 4;
            this.lb_szovegszin.Text = "Szöveg színe:";
            // 
            // lb_hatterszin
            // 
            this.lb_hatterszin.AutoSize = true;
            this.lb_hatterszin.Font = new System.Drawing.Font("Edwardian Script ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hatterszin.Location = new System.Drawing.Point(117, 242);
            this.lb_hatterszin.Name = "lb_hatterszin";
            this.lb_hatterszin.Size = new System.Drawing.Size(139, 36);
            this.lb_hatterszin.TabIndex = 5;
            this.lb_hatterszin.Text = "Háttér színe:";
            // 
            // cb_box_hatter
            // 
            this.cb_box_hatter.FormattingEnabled = true;
            this.cb_box_hatter.Items.AddRange(new object[] {
            "IndianRed",
            "LightYellow",
            "AliceBlue",
            "Lime",
            "WhiteSmoke",
            "Black",
            "MediumPurple",
            "SandyBrown",
            "LightSlateGray"});
            this.cb_box_hatter.Location = new System.Drawing.Point(351, 254);
            this.cb_box_hatter.Name = "cb_box_hatter";
            this.cb_box_hatter.Size = new System.Drawing.Size(195, 24);
            this.cb_box_hatter.TabIndex = 6;
            // 
            // btn_kerdes
            // 
            this.btn_kerdes.BackColor = System.Drawing.Color.Maroon;
            this.btn_kerdes.Font = new System.Drawing.Font("Edwardian Script ITC", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kerdes.ForeColor = System.Drawing.Color.DarkSalmon;
            this.btn_kerdes.Location = new System.Drawing.Point(254, 449);
            this.btn_kerdes.Name = "btn_kerdes";
            this.btn_kerdes.Size = new System.Drawing.Size(146, 58);
            this.btn_kerdes.TabIndex = 7;
            this.btn_kerdes.Text = "Törlés";
            this.btn_kerdes.UseVisualStyleBackColor = false;
            this.btn_kerdes.Click += new System.EventHandler(this.btn_kerdes_Click);
            // 
            // Ablak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(666, 541);
            this.Controls.Add(this.btn_kerdes);
            this.Controls.Add(this.cb_box_hatter);
            this.Controls.Add(this.lb_hatterszin);
            this.Controls.Add(this.lb_szovegszin);
            this.Controls.Add(this.cb_box_szoveg);
            this.Controls.Add(this.tbx_szoveg);
            this.Controls.Add(this.btn_megad);
            this.Controls.Add(this.lb_szoveg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ablak";
            this.Text = "Fő Ablak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_szoveg;
        private System.Windows.Forms.Button btn_megad;
        private System.Windows.Forms.TextBox tbx_szoveg;
        private System.Windows.Forms.ComboBox cb_box_szoveg;
        private System.Windows.Forms.Label lb_szovegszin;
        private System.Windows.Forms.Label lb_hatterszin;
        private System.Windows.Forms.ComboBox cb_box_hatter;
        private System.Windows.Forms.Button btn_kerdes;
    }
}

