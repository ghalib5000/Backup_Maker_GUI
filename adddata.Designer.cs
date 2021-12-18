namespace Backup_Maker_GUI
{
    partial class adddata
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
            this.back_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.source_folder = new System.Windows.Forms.TextBox();
            this.add_folder = new System.Windows.Forms.Button();
            this.dest_folder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hidden = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(838, 377);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(166, 36);
            this.back_btn.TabIndex = 0;
            this.back_btn.Text = "Go Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Folder:";
            // 
            // source_folder
            // 
            this.source_folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.source_folder.Location = new System.Drawing.Point(241, 148);
            this.source_folder.Name = "source_folder";
            this.source_folder.Size = new System.Drawing.Size(763, 30);
            this.source_folder.TabIndex = 2;
            this.source_folder.DoubleClick += new System.EventHandler(this.source_folder_DoubleClick);
            // 
            // add_folder
            // 
            this.add_folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_folder.Location = new System.Drawing.Point(241, 377);
            this.add_folder.Name = "add_folder";
            this.add_folder.Size = new System.Drawing.Size(96, 36);
            this.add_folder.TabIndex = 3;
            this.add_folder.Text = "Add Folder";
            this.add_folder.UseVisualStyleBackColor = true;
            this.add_folder.Click += new System.EventHandler(this.add_folder_Click);
            // 
            // dest_folder
            // 
            this.dest_folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dest_folder.Location = new System.Drawing.Point(240, 201);
            this.dest_folder.Name = "dest_folder";
            this.dest_folder.Size = new System.Drawing.Size(764, 30);
            this.dest_folder.TabIndex = 5;
            this.dest_folder.DoubleClick += new System.EventHandler(this.dest_folder_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination Folder:";
            // 
            // hidden
            // 
            this.hidden.AutoSize = true;
            this.hidden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidden.Location = new System.Drawing.Point(269, 44);
            this.hidden.Name = "hidden";
            this.hidden.Size = new System.Drawing.Size(0, 25);
            this.hidden.TabIndex = 6;
            // 
            // adddata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.hidden);
            this.Controls.Add(this.dest_folder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add_folder);
            this.Controls.Add(this.source_folder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_btn);
            this.Name = "adddata";
            this.Text = "adddata";
            this.Load += new System.EventHandler(this.adddata_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox source_folder;
        private System.Windows.Forms.Button add_folder;
        private System.Windows.Forms.TextBox dest_folder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hidden;
    }
}