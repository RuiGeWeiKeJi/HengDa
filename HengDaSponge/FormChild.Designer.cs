namespace HengDaSponge
{
    partial class FormChild
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent ( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChild));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolSelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolExmine = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolSelete,
            this.toolStripSeparator1,
            this.toolAdd,
            this.toolStripSeparator2,
            this.toolDelete,
            this.toolStripSeparator3,
            this.toolUpdate,
            this.toolStripSeparator4,
            this.toolSave,
            this.toolStripSeparator5,
            this.toolCancel,
            this.toolStripSeparator6,
            this.toolExmine,
            this.toolStripSeparator7,
            this.toolPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(565, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolSelete
            // 
            this.ToolSelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolSelete.Image = ((System.Drawing.Image)(resources.GetObject("ToolSelete.Image")));
            this.ToolSelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolSelete.Name = "ToolSelete";
            this.ToolSelete.Size = new System.Drawing.Size(41, 22);
            this.ToolSelete.Text = "查询";
            this.ToolSelete.Click += new System.EventHandler(this.ToolSelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolAdd
            // 
            this.toolAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolAdd.Image")));
            this.toolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(41, 22);
            this.toolAdd.Text = "新增";
            this.toolAdd.Click += new System.EventHandler(this.toolAdd_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolDelete
            // 
            this.toolDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolDelete.Image")));
            this.toolDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDelete.Name = "toolDelete";
            this.toolDelete.Size = new System.Drawing.Size(41, 22);
            this.toolDelete.Text = "删除";
            this.toolDelete.Click += new System.EventHandler(this.toolDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolUpdate
            // 
            this.toolUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolUpdate.Image = ((System.Drawing.Image)(resources.GetObject("toolUpdate.Image")));
            this.toolUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUpdate.Name = "toolUpdate";
            this.toolUpdate.Size = new System.Drawing.Size(41, 22);
            this.toolUpdate.Text = "更改";
            this.toolUpdate.Click += new System.EventHandler(this.toolUpdate_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolSave
            // 
            this.toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSave.Image = ((System.Drawing.Image)(resources.GetObject("toolSave.Image")));
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(41, 22);
            this.toolSave.Text = "保存";
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolCancel
            // 
            this.toolCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolCancel.Image")));
            this.toolCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCancel.Name = "toolCancel";
            this.toolCancel.Size = new System.Drawing.Size(41, 22);
            this.toolCancel.Text = "取消";
            this.toolCancel.Click += new System.EventHandler(this.toolCancel_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolExmine
            // 
            this.toolExmine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolExmine.Image = ((System.Drawing.Image)(resources.GetObject("toolExmine.Image")));
            this.toolExmine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExmine.Name = "toolExmine";
            this.toolExmine.Size = new System.Drawing.Size(41, 22);
            this.toolExmine.Text = "审核";
            this.toolExmine.Click += new System.EventHandler(this.toolExmine_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolPrint
            // 
            this.toolPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolPrint.Image")));
            this.toolPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPrint.Name = "toolPrint";
            this.toolPrint.Size = new System.Drawing.Size(41, 22);
            this.toolPrint.Text = "打印";
            this.toolPrint.Click += new System.EventHandler(this.toolPrint_Click);
            // 
            // FormChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 253);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormChild";
            this.Text = "FormChild";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        public System.Windows.Forms.ToolStripButton ToolSelete;
        public System.Windows.Forms.ToolStripButton toolDelete;
        public System.Windows.Forms.ToolStripButton toolAdd;
        public System.Windows.Forms.ToolStripButton toolUpdate;
        public System.Windows.Forms.ToolStripButton toolSave;
        public System.Windows.Forms.ToolStripButton toolCancel;
        public System.Windows.Forms.ToolStripButton toolExmine;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        public System.Windows.Forms.ToolStripButton toolPrint;
    }
}

