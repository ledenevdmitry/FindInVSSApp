namespace FindInVSSApp
{
    partial class AddRootsForm
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
            this.TbRoots = new System.Windows.Forms.TextBox();
            this.BtConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbRoots
            // 
            this.TbRoots.Location = new System.Drawing.Point(12, 12);
            this.TbRoots.Multiline = true;
            this.TbRoots.Name = "TbRoots";
            this.TbRoots.Size = new System.Drawing.Size(387, 205);
            this.TbRoots.TabIndex = 0;
            // 
            // BtConfirm
            // 
            this.BtConfirm.Location = new System.Drawing.Point(166, 223);
            this.BtConfirm.Name = "BtConfirm";
            this.BtConfirm.Size = new System.Drawing.Size(75, 23);
            this.BtConfirm.TabIndex = 1;
            this.BtConfirm.Text = "OK";
            this.BtConfirm.UseVisualStyleBackColor = true;
            this.BtConfirm.Click += new System.EventHandler(this.BtConfirm_Click);
            // 
            // AddRootsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 257);
            this.Controls.Add(this.BtConfirm);
            this.Controls.Add(this.TbRoots);
            this.Name = "AddRootsForm";
            this.Text = "AddRootsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbRoots;
        private System.Windows.Forms.Button BtConfirm;
    }
}