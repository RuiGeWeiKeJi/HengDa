namespace HengDaOther
{
    partial class FormMainQuery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SHD001 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DFA002 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SHD003 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SHD004 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SHD005 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SHD006 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SHD009 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.lookUpEdit3 = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.lookUpEdit4 = new DevExpress.XtraEditors.LookUpEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.lookUpEdit5 = new DevExpress.XtraEditors.LookUpEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lookUpEdit6 = new DevExpress.XtraEditors.LookUpEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit6.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.lookUpEdit6);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.lookUpEdit5);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.lookUpEdit4);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.lookUpEdit3);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.lookUpEdit2);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.lookUpEdit1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1240, 463);
            this.splitContainer1.SplitterDistance = 64;
            // 
            // splitContainer2
            // 
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gridControl1);
            this.splitContainer2.Size = new System.Drawing.Size(1240, 395);
            this.splitContainer2.SplitterDistance = 328;
            // 
            // userControl11
            // 
            this.userControl11.Size = new System.Drawing.Size(824, 63);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1240, 328);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ColumnPanelRowHeight = 25;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SHD001,
            this.DFA002,
            this.SHD003,
            this.SHD004,
            this.SHD005,
            this.SHD006,
            this.SHD009});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // SHD001
            // 
            this.SHD001.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SHD001.AppearanceCell.Options.UseFont = true;
            this.SHD001.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SHD001.AppearanceHeader.Options.UseFont = true;
            this.SHD001.Caption = "单号";
            this.SHD001.FieldName = "SHD001";
            this.SHD001.Name = "SHD001";
            this.SHD001.Visible = true;
            this.SHD001.VisibleIndex = 0;
            // 
            // DFA002
            // 
            this.DFA002.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DFA002.AppearanceCell.Options.UseFont = true;
            this.DFA002.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DFA002.AppearanceHeader.Options.UseFont = true;
            this.DFA002.Caption = "收货单位";
            this.DFA002.FieldName = "DFA002";
            this.DFA002.Name = "DFA002";
            this.DFA002.Visible = true;
            this.DFA002.VisibleIndex = 1;
            // 
            // SHD003
            // 
            this.SHD003.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SHD003.AppearanceCell.Options.UseFont = true;
            this.SHD003.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SHD003.AppearanceHeader.Options.UseFont = true;
            this.SHD003.Caption = "采购单号";
            this.SHD003.FieldName = "SHD003";
            this.SHD003.Name = "SHD003";
            this.SHD003.Visible = true;
            this.SHD003.VisibleIndex = 2;
            // 
            // SHD004
            // 
            this.SHD004.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SHD004.AppearanceCell.Options.UseFont = true;
            this.SHD004.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SHD004.AppearanceHeader.Options.UseFont = true;
            this.SHD004.Caption = "备料单号";
            this.SHD004.FieldName = "SHD004";
            this.SHD004.Name = "SHD004";
            this.SHD004.Visible = true;
            this.SHD004.VisibleIndex = 3;
            // 
            // SHD005
            // 
            this.SHD005.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SHD005.AppearanceCell.Options.UseFont = true;
            this.SHD005.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SHD005.AppearanceHeader.Options.UseFont = true;
            this.SHD005.Caption = "组别";
            this.SHD005.FieldName = "SHD005";
            this.SHD005.Name = "SHD005";
            this.SHD005.Visible = true;
            this.SHD005.VisibleIndex = 4;
            // 
            // SHD006
            // 
            this.SHD006.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SHD006.AppearanceCell.Options.UseFont = true;
            this.SHD006.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SHD006.AppearanceHeader.Options.UseFont = true;
            this.SHD006.Caption = "日期";
            this.SHD006.FieldName = "SHD006";
            this.SHD006.Name = "SHD006";
            this.SHD006.Visible = true;
            this.SHD006.VisibleIndex = 5;
            // 
            // SHD009
            // 
            this.SHD009.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SHD009.AppearanceCell.Options.UseFont = true;
            this.SHD009.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SHD009.AppearanceHeader.Options.UseFont = true;
            this.SHD009.Caption = "审核码";
            this.SHD009.FieldName = "SHD009";
            this.SHD009.Name = "SHD009";
            this.SHD009.Visible = true;
            this.SHD009.VisibleIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "单号";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(55, 6);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lookUpEdit1.Properties.ShowHeader = false;
            this.lookUpEdit1.Size = new System.Drawing.Size(163, 20);
            this.lookUpEdit1.TabIndex = 1;
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Location = new System.Drawing.Point(297, 6);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lookUpEdit2.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.NullText = "";
            this.lookUpEdit2.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lookUpEdit2.Properties.ShowHeader = false;
            this.lookUpEdit2.Size = new System.Drawing.Size(163, 20);
            this.lookUpEdit2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(224, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "收货单位";
            // 
            // lookUpEdit3
            // 
            this.lookUpEdit3.Location = new System.Drawing.Point(539, 6);
            this.lookUpEdit3.Name = "lookUpEdit3";
            this.lookUpEdit3.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lookUpEdit3.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit3.Properties.NullText = "";
            this.lookUpEdit3.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lookUpEdit3.Properties.ShowHeader = false;
            this.lookUpEdit3.Size = new System.Drawing.Size(163, 20);
            this.lookUpEdit3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(466, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "采购单号";
            // 
            // lookUpEdit4
            // 
            this.lookUpEdit4.Location = new System.Drawing.Point(781, 6);
            this.lookUpEdit4.Name = "lookUpEdit4";
            this.lookUpEdit4.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lookUpEdit4.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit4.Properties.NullText = "";
            this.lookUpEdit4.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lookUpEdit4.Properties.ShowHeader = false;
            this.lookUpEdit4.Size = new System.Drawing.Size(163, 20);
            this.lookUpEdit4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(708, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "备料单号";
            // 
            // lookUpEdit5
            // 
            this.lookUpEdit5.Location = new System.Drawing.Point(55, 35);
            this.lookUpEdit5.Name = "lookUpEdit5";
            this.lookUpEdit5.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lookUpEdit5.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit5.Properties.NullText = "";
            this.lookUpEdit5.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lookUpEdit5.Properties.ShowHeader = false;
            this.lookUpEdit5.Size = new System.Drawing.Size(163, 20);
            this.lookUpEdit5.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "组别";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(254, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "日期";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(297, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 26);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(297, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 26);
            this.textBox1.TabIndex = 12;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(481, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "审核码";
            // 
            // lookUpEdit6
            // 
            this.lookUpEdit6.Location = new System.Drawing.Point(539, 35);
            this.lookUpEdit6.Name = "lookUpEdit6";
            this.lookUpEdit6.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lookUpEdit6.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit6.Properties.NullText = "";
            this.lookUpEdit6.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lookUpEdit6.Properties.ShowHeader = false;
            this.lookUpEdit6.Size = new System.Drawing.Size(163, 20);
            this.lookUpEdit6.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(781, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 15;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(862, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 16;
            this.button2.Text = "清空";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormMainQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 463);
            this.Name = "FormMainQuery";
            this.Text = "信息查询";
            this.Load += new System.EventHandler(this.FormMainQuery_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit6.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn SHD001;
        private DevExpress.XtraGrid.Columns.GridColumn DFA002;
        private DevExpress.XtraGrid.Columns.GridColumn SHD003;
        private DevExpress.XtraGrid.Columns.GridColumn SHD004;
        private DevExpress.XtraGrid.Columns.GridColumn SHD005;
        private DevExpress.XtraGrid.Columns.GridColumn SHD006;
        private DevExpress.XtraGrid.Columns.GridColumn SHD009;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit3;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit4;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}