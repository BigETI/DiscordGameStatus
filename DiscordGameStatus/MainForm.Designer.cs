namespace DiscordGameStatus
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gameStatusSingleLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.gameStatusSingleLineTextField);
            this.panel1.Location = new System.Drawing.Point(12, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 44);
            this.panel1.TabIndex = 0;
            // 
            // gameStatusSingleLineTextField
            // 
            this.gameStatusSingleLineTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameStatusSingleLineTextField.Depth = 0;
            this.gameStatusSingleLineTextField.Hint = "Enter your game status here...";
            this.gameStatusSingleLineTextField.Location = new System.Drawing.Point(3, 3);
            this.gameStatusSingleLineTextField.MaxLength = 32767;
            this.gameStatusSingleLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.gameStatusSingleLineTextField.Name = "gameStatusSingleLineTextField";
            this.gameStatusSingleLineTextField.PasswordChar = '\0';
            this.gameStatusSingleLineTextField.SelectedText = "";
            this.gameStatusSingleLineTextField.SelectionLength = 0;
            this.gameStatusSingleLineTextField.SelectionStart = 0;
            this.gameStatusSingleLineTextField.Size = new System.Drawing.Size(370, 23);
            this.gameStatusSingleLineTextField.TabIndex = 0;
            this.gameStatusSingleLineTextField.TabStop = false;
            this.gameStatusSingleLineTextField.UseSystemPasswordChar = false;
            this.gameStatusSingleLineTextField.TextChanged += new System.EventHandler(this.gameStatusSingleLineTextField_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 120);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(10000, 120);
            this.MinimumSize = new System.Drawing.Size(400, 120);
            this.Name = "MainForm";
            this.Text = "Discord game status";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField gameStatusSingleLineTextField;
    }
}

