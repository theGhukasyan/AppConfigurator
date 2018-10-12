namespace AppConfigurator
{
    partial class IntroForm
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
            this.AppList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AppList
            // 
            this.AppList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AppList.FormattingEnabled = true;
            this.AppList.Location = new System.Drawing.Point(286, 178);
            this.AppList.Name = "AppList";
            this.AppList.Size = new System.Drawing.Size(121, 21);
            this.AppList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Application Configurator";
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(424, 178);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(79, 23);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(424, 237);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(79, 48);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add new Application";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppList);
            this.Name = "IntroForm";
            this.Text = "Application Configurator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AppList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
    }
}

