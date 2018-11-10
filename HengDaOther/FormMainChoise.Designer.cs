namespace HengDaOther
{
    partial class FormMainChoise
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
            this.check = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.DEA002 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QAA001 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEA003 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEA960 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1186, 481);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            //
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.MediumSeaGreen;
            this.gridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.check,
            this.DEA002,
            this.QAA001,
            this.DEA003,
            this.DEA960});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // check
            // 
            this.check.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.check.AppearanceCell.Options.UseFont = true;
            this.check.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.check.AppearanceHeader.Options.UseFont = true;
            this.check.Caption = "选择";
            this.check.ColumnEdit = this.repositoryItemCheckEdit1;
            this.check.FieldName = "check";
            this.check.Name = "check";
            this.check.Width = 51;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // DEA002
            // 
            this.DEA002.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.DEA002.AppearanceCell.Options.UseFont = true;
            this.DEA002.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.DEA002.AppearanceHeader.Options.UseFont = true;
            this.DEA002.Caption = "料件编号";
            this.DEA002.FieldName = "DEA002";
            this.DEA002.Name = "DEA002";
            this.DEA002.Visible = true;
            this.DEA002.VisibleIndex = 0;
            this.DEA002.Width = 255;
            // 
            // QAA001
            // 
            this.QAA001.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.QAA001.AppearanceCell.Options.UseFont = true;
            this.QAA001.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.QAA001.AppearanceHeader.Options.UseFont = true;
            this.QAA001.Caption = "款号";
            this.QAA001.FieldName = "QAA001";
            this.QAA001.Name = "QAA001";
            this.QAA001.Visible = true;
            this.QAA001.VisibleIndex = 1;
            this.QAA001.Width = 255;
            // 
            // DEA003
            // 
            this.DEA003.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.DEA003.AppearanceCell.Options.UseFont = true;
            this.DEA003.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.DEA003.AppearanceHeader.Options.UseFont = true;
            this.DEA003.Caption = "单位";
            this.DEA003.FieldName = "DEA003";
            this.DEA003.Name = "DEA003";
            this.DEA003.Visible = true;
            this.DEA003.VisibleIndex = 2;
            this.DEA003.Width = 255;
            // 
            // DEA960
            // 
            this.DEA960.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.DEA960.AppearanceCell.Options.UseFont = true;
            this.DEA960.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.DEA960.AppearanceHeader.Options.UseFont = true;
            this.DEA960.Caption = "单价";
            this.DEA960.FieldName = "DEA960";
            this.DEA960.Name = "DEA960";
            this.DEA960.Visible = true;
            this.DEA960.VisibleIndex = 3;
            this.DEA960.Width = 262;
            // 
            // FormMainChoise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 481);
            this.Controls.Add(this.gridControl1);
            this.Name = "FormMainChoise";
            this.Text = "选择";
            this.Load += new System.EventHandler(this.FormMainChoise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn check;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn DEA002;
        private DevExpress.XtraGrid.Columns.GridColumn QAA001;
        private DevExpress.XtraGrid.Columns.GridColumn DEA003;
        private DevExpress.XtraGrid.Columns.GridColumn DEA960;
    }
}