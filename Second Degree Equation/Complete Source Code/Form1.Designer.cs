namespace Equation2degre
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.result = new System.Windows.Forms.Label();
            this.aText = new System.Windows.Forms.TextBox();
            this.bText = new System.Windows.Forms.TextBox();
            this.cText = new System.Windows.Forms.TextBox();
            this.labelx2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(484, 91);
            this.button1.TabIndex = 1;
            this.button1.Text = "CALCULER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 201);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.result);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(484, 110);
            this.panel3.TabIndex = 0;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.result.Location = new System.Drawing.Point(45, 45);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 26);
            this.result.TabIndex = 6;
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aText
            // 
            this.aText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.aText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aText.ForeColor = System.Drawing.Color.Black;
            this.aText.Location = new System.Drawing.Point(50, 44);
            this.aText.Name = "aText";
            this.aText.Size = new System.Drawing.Size(54, 31);
            this.aText.TabIndex = 0;
            this.aText.Text = "0";
            this.aText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bText
            // 
            this.bText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bText.ForeColor = System.Drawing.Color.Black;
            this.bText.Location = new System.Drawing.Point(188, 44);
            this.bText.Name = "bText";
            this.bText.Size = new System.Drawing.Size(54, 31);
            this.bText.TabIndex = 1;
            this.bText.Text = "0";
            this.bText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cText
            // 
            this.cText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cText.ForeColor = System.Drawing.Color.Black;
            this.cText.Location = new System.Drawing.Point(320, 44);
            this.cText.Name = "cText";
            this.cText.Size = new System.Drawing.Size(54, 31);
            this.cText.TabIndex = 2;
            this.cText.Text = "0";
            this.cText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelx2
            // 
            this.labelx2.AutoSize = true;
            this.labelx2.Font = new System.Drawing.Font("Swis721 BT", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelx2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelx2.Location = new System.Drawing.Point(114, 46);
            this.labelx2.Name = "labelx2";
            this.labelx2.Size = new System.Drawing.Size(68, 27);
            this.labelx2.TabIndex = 3;
            this.labelx2.Text = "x²   +";
            this.labelx2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 BT", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(248, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "x    +";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(380, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "= 0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelx2);
            this.panel1.Controls.Add(this.cText);
            this.panel1.Controls.Add(this.bText);
            this.panel1.Controls.Add(this.aText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 110);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Equation 2eme Degré";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox aText;
        private System.Windows.Forms.TextBox bText;
        private System.Windows.Forms.TextBox cText;
        private System.Windows.Forms.Label labelx2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}

