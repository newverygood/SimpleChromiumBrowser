namespace SimpleChromiumBrowser
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除cookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开发者工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看源码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.工具ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新ToolStripMenuItem,
            this.清除cookieToolStripMenuItem,
            this.开发者工具ToolStripMenuItem,
            this.查看源码ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 清除cookieToolStripMenuItem
            // 
            this.清除cookieToolStripMenuItem.Name = "清除cookieToolStripMenuItem";
            this.清除cookieToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.清除cookieToolStripMenuItem.Text = "清除cookie";
            this.清除cookieToolStripMenuItem.Click += new System.EventHandler(this.清除cookieToolStripMenuItem_Click);
            // 
            // 开发者工具ToolStripMenuItem
            // 
            this.开发者工具ToolStripMenuItem.Name = "开发者工具ToolStripMenuItem";
            this.开发者工具ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.开发者工具ToolStripMenuItem.Text = "开发者工具";
            this.开发者工具ToolStripMenuItem.Click += new System.EventHandler(this.开发者工具ToolStripMenuItem_Click);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // 查看源码ToolStripMenuItem
            // 
            this.查看源码ToolStripMenuItem.Name = "查看源码ToolStripMenuItem";
            this.查看源码ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.查看源码ToolStripMenuItem.Text = "查看源码";
            this.查看源码ToolStripMenuItem.Click += new System.EventHandler(this.查看源码ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 485);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "简单谷歌内核浏览器";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除cookieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开发者工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看源码ToolStripMenuItem;
    }
}

