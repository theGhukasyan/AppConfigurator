namespace AppConfigurator
{
    partial class NewAppForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.winServiceAddBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.winServicePathField = new System.Windows.Forms.TextBox();
            this.winServiceNameField = new System.Windows.Forms.TextBox();
            this.winServiceListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.apiAddBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.apiPathField = new System.Windows.Forms.TextBox();
            this.apiNameField = new System.Windows.Forms.TextBox();
            this.apiListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.appAddBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.appPathField = new System.Windows.Forms.TextBox();
            this.appNameField = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.winServiceAddBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.winServicePathField);
            this.groupBox1.Controls.Add(this.winServiceNameField);
            this.groupBox1.Controls.Add(this.winServiceListView);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Windows Services";
            // 
            // winServiceAddBtn
            // 
            this.winServiceAddBtn.Location = new System.Drawing.Point(866, 195);
            this.winServiceAddBtn.Name = "winServiceAddBtn";
            this.winServiceAddBtn.Size = new System.Drawing.Size(75, 23);
            this.winServiceAddBtn.TabIndex = 5;
            this.winServiceAddBtn.Text = "Add";
            this.winServiceAddBtn.UseVisualStyleBackColor = true;
            this.winServiceAddBtn.Click += new System.EventHandler(this.winServiceAddBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(903, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(894, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // winServicePathField
            // 
            this.winServicePathField.Location = new System.Drawing.Point(713, 117);
            this.winServicePathField.Name = "winServicePathField";
            this.winServicePathField.Size = new System.Drawing.Size(228, 20);
            this.winServicePathField.TabIndex = 2;
            // 
            // winServiceNameField
            // 
            this.winServiceNameField.Location = new System.Drawing.Point(713, 46);
            this.winServiceNameField.Name = "winServiceNameField";
            this.winServiceNameField.Size = new System.Drawing.Size(228, 20);
            this.winServiceNameField.TabIndex = 1;
            // 
            // winServiceListView
            // 
            this.winServiceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.winServiceListView.HideSelection = false;
            this.winServiceListView.Location = new System.Drawing.Point(6, 19);
            this.winServiceListView.Name = "winServiceListView";
            this.winServiceListView.Size = new System.Drawing.Size(701, 200);
            this.winServiceListView.TabIndex = 0;
            this.winServiceListView.UseCompatibleStateImageBehavior = false;
            this.winServiceListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Path";
            this.columnHeader2.Width = 567;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.apiAddBtn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.apiPathField);
            this.groupBox2.Controls.Add(this.apiNameField);
            this.groupBox2.Controls.Add(this.apiListView);
            this.groupBox2.Location = new System.Drawing.Point(13, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(947, 225);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "API";
            // 
            // apiAddBtn
            // 
            this.apiAddBtn.Location = new System.Drawing.Point(866, 195);
            this.apiAddBtn.Name = "apiAddBtn";
            this.apiAddBtn.Size = new System.Drawing.Size(75, 23);
            this.apiAddBtn.TabIndex = 5;
            this.apiAddBtn.Text = "Add";
            this.apiAddBtn.UseVisualStyleBackColor = true;
            this.apiAddBtn.Click += new System.EventHandler(this.apiAddBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(903, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(894, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // apiPathField
            // 
            this.apiPathField.Location = new System.Drawing.Point(713, 117);
            this.apiPathField.Name = "apiPathField";
            this.apiPathField.Size = new System.Drawing.Size(228, 20);
            this.apiPathField.TabIndex = 2;
            // 
            // apiNameField
            // 
            this.apiNameField.Location = new System.Drawing.Point(713, 46);
            this.apiNameField.Name = "apiNameField";
            this.apiNameField.Size = new System.Drawing.Size(228, 20);
            this.apiNameField.TabIndex = 1;
            // 
            // apiListView
            // 
            this.apiListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.apiListView.HideSelection = false;
            this.apiListView.Location = new System.Drawing.Point(6, 19);
            this.apiListView.Name = "apiListView";
            this.apiListView.Size = new System.Drawing.Size(701, 200);
            this.apiListView.TabIndex = 0;
            this.apiListView.UseCompatibleStateImageBehavior = false;
            this.apiListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Path";
            this.columnHeader4.Width = 567;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.appAddBtn);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.appPathField);
            this.groupBox3.Controls.Add(this.appNameField);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(244, 475);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(445, 225);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Application";
            // 
            // appAddBtn
            // 
            this.appAddBtn.Location = new System.Drawing.Point(272, 174);
            this.appAddBtn.Name = "appAddBtn";
            this.appAddBtn.Size = new System.Drawing.Size(75, 23);
            this.appAddBtn.TabIndex = 5;
            this.appAddBtn.Text = "Add";
            this.appAddBtn.UseVisualStyleBackColor = true;
            this.appAddBtn.Click += new System.EventHandler(this.appAddBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Path";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(300, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Name";
            // 
            // appPathField
            // 
            this.appPathField.Location = new System.Drawing.Point(119, 134);
            this.appPathField.Name = "appPathField";
            this.appPathField.Size = new System.Drawing.Size(228, 20);
            this.appPathField.TabIndex = 2;
            // 
            // appNameField
            // 
            this.appNameField.Location = new System.Drawing.Point(119, 63);
            this.appNameField.Name = "appNameField";
            this.appNameField.Size = new System.Drawing.Size(228, 20);
            this.appNameField.TabIndex = 1;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(363, 714);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(88, 38);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(509, 714);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(88, 38);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // NewAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 764);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewAppForm";
            this.Text = "Application Configurator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button winServiceAddBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox winServicePathField;
        private System.Windows.Forms.TextBox winServiceNameField;
        private System.Windows.Forms.ListView winServiceListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button apiAddBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox apiPathField;
        private System.Windows.Forms.TextBox apiNameField;
        private System.Windows.Forms.ListView apiListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button appAddBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox appPathField;
        private System.Windows.Forms.TextBox appNameField;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}