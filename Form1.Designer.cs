namespace Backup_Maker_GUI
{
    partial class Form1
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
            this.add_btn = new System.Windows.Forms.Button();
            this.show_all = new System.Windows.Forms.Button();
            this.start_backup = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(751, 247);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(203, 116);
            this.add_btn.TabIndex = 0;
            this.add_btn.Text = "Add backup folder";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // show_all
            // 
            this.show_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_all.Location = new System.Drawing.Point(748, 51);
            this.show_all.Name = "show_all";
            this.show_all.Size = new System.Drawing.Size(206, 116);
            this.show_all.TabIndex = 3;
            this.show_all.Text = "Show all backup folders";
            this.show_all.UseVisualStyleBackColor = true;
            this.show_all.Click += new System.EventHandler(this.show_all_Click);
            // 
            // start_backup
            // 
            this.start_backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_backup.Location = new System.Drawing.Point(751, 468);
            this.start_backup.Name = "start_backup";
            this.start_backup.Size = new System.Drawing.Size(203, 116);
            this.start_backup.TabIndex = 4;
            this.start_backup.Text = "Start Backup";
            this.start_backup.UseVisualStyleBackColor = true;
            this.start_backup.Click += new System.EventHandler(this.start_backup_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(665, 584);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 624);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.start_backup);
            this.Controls.Add(this.show_all);
            this.Controls.Add(this.add_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button show_all;
        private System.Windows.Forms.Button start_backup;
        private System.Windows.Forms.ListBox listBox1;
    }
}

