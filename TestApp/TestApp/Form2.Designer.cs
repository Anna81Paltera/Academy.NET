namespace TestApp
{
    partial class Form2
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
            this.lblSaluto = new System.Windows.Forms.Label();
            this.btnCliccami = new System.Windows.Forms.Button();
            this.txtGroups = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSaluto
            // 
            this.lblSaluto.AutoSize = true;
            this.lblSaluto.Location = new System.Drawing.Point(39, 62);
            this.lblSaluto.Name = "lblSaluto";
            this.lblSaluto.Size = new System.Drawing.Size(46, 17);
            this.lblSaluto.TabIndex = 0;
            this.lblSaluto.Text = "label1";
            // 
            // btnCliccami
            // 
            this.btnCliccami.Location = new System.Drawing.Point(22, 12);
            this.btnCliccami.Name = "btnCliccami";
            this.btnCliccami.Size = new System.Drawing.Size(112, 37);
            this.btnCliccami.TabIndex = 1;
            this.btnCliccami.Text = "CLICCAMI";
            this.btnCliccami.UseVisualStyleBackColor = true;
            this.btnCliccami.Click += new System.EventHandler(this.btnCliccami_Click);
            // 
            // txtGroups
            // 
            this.txtGroups.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroups.Location = new System.Drawing.Point(156, 12);
            this.txtGroups.Multiline = true;
            this.txtGroups.Name = "txtGroups";
            this.txtGroups.Size = new System.Drawing.Size(664, 363);
            this.txtGroups.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 387);
            this.Controls.Add(this.txtGroups);
            this.Controls.Add(this.btnCliccami);
            this.Controls.Add(this.lblSaluto);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaluto;
        private System.Windows.Forms.Button btnCliccami;
        private System.Windows.Forms.TextBox txtGroups;
    }
}