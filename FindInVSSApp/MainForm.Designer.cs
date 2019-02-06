namespace FindInVSSApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LbPattern = new System.Windows.Forms.Label();
            this.TbPattern = new System.Windows.Forms.TextBox();
            this.BtFindOne = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LbResult = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BtAddRoot = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.NUDDepth = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // LbPattern
            // 
            this.LbPattern.AutoSize = true;
            this.LbPattern.Location = new System.Drawing.Point(11, 30);
            this.LbPattern.Name = "LbPattern";
            this.LbPattern.Size = new System.Drawing.Size(49, 13);
            this.LbPattern.TabIndex = 0;
            this.LbPattern.Text = "Шаблон:";
            // 
            // TbPattern
            // 
            this.TbPattern.Location = new System.Drawing.Point(63, 27);
            this.TbPattern.Name = "TbPattern";
            this.TbPattern.Size = new System.Drawing.Size(124, 20);
            this.TbPattern.TabIndex = 1;
            // 
            // BtFindOne
            // 
            this.BtFindOne.Location = new System.Drawing.Point(14, 53);
            this.BtFindOne.Name = "BtFindOne";
            this.BtFindOne.Size = new System.Drawing.Size(173, 23);
            this.BtFindOne.TabIndex = 2;
            this.BtFindOne.Text = "Найти первый";
            this.BtFindOne.UseVisualStyleBackColor = true;
            this.BtFindOne.Click += new System.EventHandler(this.BtFindOne_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Найти все";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 95);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 212);
            this.textBox1.TabIndex = 4;
            // 
            // LbResult
            // 
            this.LbResult.AutoSize = true;
            this.LbResult.Location = new System.Drawing.Point(11, 79);
            this.LbResult.Name = "LbResult";
            this.LbResult.Size = new System.Drawing.Size(62, 13);
            this.LbResult.TabIndex = 5;
            this.LbResult.Text = "Результат:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtAddRoot});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(358, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "MainMenu";
            // 
            // BtAddRoot
            // 
            this.BtAddRoot.Name = "BtAddRoot";
            this.BtAddRoot.Size = new System.Drawing.Size(164, 20);
            this.BtAddRoot.Text = "Добавить корневые папки";
            this.BtAddRoot.Click += new System.EventHandler(this.BtAddRoot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Глубина поиска:";
            // 
            // NUDDepth
            // 
            this.NUDDepth.Location = new System.Drawing.Point(292, 27);
            this.NUDDepth.Name = "NUDDepth";
            this.NUDDepth.Size = new System.Drawing.Size(45, 20);
            this.NUDDepth.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 315);
            this.Controls.Add(this.NUDDepth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbResult);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtFindOne);
            this.Controls.Add(this.TbPattern);
            this.Controls.Add(this.LbPattern);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Найти в VSS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDepth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbPattern;
        private System.Windows.Forms.TextBox TbPattern;
        private System.Windows.Forms.Button BtFindOne;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LbResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BtAddRoot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUDDepth;
    }
}

