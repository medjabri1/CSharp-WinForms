namespace BinaryCode
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.resultLabel = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.binaryNumberText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.mainExitBtn = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.resultPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.contentPanel);
            this.mainPanel.Controls.Add(this.menuPanel);
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Name = "mainPanel";
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.resultPanel);
            this.contentPanel.Controls.Add(this.calculateBtn);
            this.contentPanel.Controls.Add(this.binaryNumberText);
            this.contentPanel.Controls.Add(this.label1);
            resources.ApplyResources(this.contentPanel, "contentPanel");
            this.contentPanel.Name = "contentPanel";
            // 
            // resultPanel
            // 
            this.resultPanel.Controls.Add(this.resultLabel);
            resources.ApplyResources(this.resultPanel, "resultPanel");
            this.resultPanel.Name = "resultPanel";
            // 
            // resultLabel
            // 
            resources.ApplyResources(this.resultLabel, "resultLabel");
            this.resultLabel.ForeColor = System.Drawing.Color.Cyan;
            this.resultLabel.Name = "resultLabel";
            // 
            // calculateBtn
            // 
            this.calculateBtn.BackColor = System.Drawing.Color.Silver;
            this.calculateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateBtn.FlatAppearance.BorderSize = 0;
            this.calculateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.calculateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            resources.ApplyResources(this.calculateBtn, "calculateBtn");
            this.calculateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(10)))), ((int)(((byte)(100)))));
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.UseVisualStyleBackColor = false;
            this.calculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // binaryNumberText
            // 
            this.binaryNumberText.BackColor = System.Drawing.Color.Cyan;
            resources.ApplyResources(this.binaryNumberText, "binaryNumberText");
            this.binaryNumberText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(10)))), ((int)(((byte)(150)))));
            this.binaryNumberText.Name = "binaryNumberText";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Name = "label1";
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.mainExitBtn);
            this.menuPanel.Controls.Add(this.titleLabel);
            resources.ApplyResources(this.menuPanel, "menuPanel");
            this.menuPanel.Name = "menuPanel";
            // 
            // mainExitBtn
            // 
            this.mainExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.mainExitBtn, "mainExitBtn");
            this.mainExitBtn.FlatAppearance.BorderSize = 0;
            this.mainExitBtn.Name = "mainExitBtn";
            this.mainExitBtn.UseVisualStyleBackColor = true;
            this.mainExitBtn.Click += new System.EventHandler(this.MainExitBtn_Click);
            // 
            // titleLabel
            // 
            resources.ApplyResources(this.titleLabel, "titleLabel");
            this.titleLabel.ForeColor = System.Drawing.Color.Transparent;
            this.titleLabel.Name = "titleLabel";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.resultPanel.ResumeLayout(false);
            this.resultPanel.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button mainExitBtn;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox binaryNumberText;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.Label resultLabel;
    }
}

