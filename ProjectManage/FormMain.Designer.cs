namespace ProjectManage
{
    partial class FormMain
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
                components . Dispose ( );
            }
            base . Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            this.components = new System.ComponentModel.Container();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemMemoEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemMemoEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemMemoEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemMemoEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.DKA002 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DKA001 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.HBB004 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HBB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HDA960 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DGA002 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HDA041 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HDB010 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HDB960 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // repositoryItemMemoEdit3
            // 
            this.repositoryItemMemoEdit3.Name = "repositoryItemMemoEdit3";
            // 
            // repositoryItemMemoEdit4
            // 
            this.repositoryItemMemoEdit4.Name = "repositoryItemMemoEdit4";
            // 
            // repositoryItemMemoEdit5
            // 
            this.repositoryItemMemoEdit5.Name = "repositoryItemMemoEdit5";
            // 
            // repositoryItemMemoEdit6
            // 
            this.repositoryItemMemoEdit6.Name = "repositoryItemMemoEdit6";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1250, 427);
            this.splitContainerControl1.SplitterPosition = 109;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.cardView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1250, 109);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            // 
            // cardView1
            // 
            this.cardView1.Appearance.Card.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.cardView1.Appearance.Card.Options.UseFont = true;
            this.cardView1.CardWidth = 170;
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DKA002,
            this.DKA001});
            this.cardView1.DetailHeight = 150;
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsBehavior.Editable = false;
            this.cardView1.OptionsBehavior.FieldAutoHeight = true;
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            this.cardView1.CustomDrawCardCaption += new DevExpress.XtraGrid.Views.Card.CardCaptionCustomDrawEventHandler(this.cardView1_CustomDrawCardCaption);
            this.cardView1.Click += new System.EventHandler(this.cardView1_Click);
            // 
            // DKA002
            // 
            this.DKA002.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(191)))), ((int)(((byte)(208)))));
            this.DKA002.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(191)))), ((int)(((byte)(208)))));
            this.DKA002.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(191)))), ((int)(((byte)(208)))));
            this.DKA002.AppearanceCell.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.DKA002.AppearanceCell.ForeColor = System.Drawing.Color.White;
            this.DKA002.AppearanceCell.Options.UseBackColor = true;
            this.DKA002.AppearanceCell.Options.UseBorderColor = true;
            this.DKA002.AppearanceCell.Options.UseFont = true;
            this.DKA002.AppearanceCell.Options.UseForeColor = true;
            this.DKA002.AppearanceCell.Options.UseTextOptions = true;
            this.DKA002.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.DKA002.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(191)))), ((int)(((byte)(208)))));
            this.DKA002.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(191)))), ((int)(((byte)(208)))));
            this.DKA002.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(191)))), ((int)(((byte)(208)))));
            this.DKA002.AppearanceHeader.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.DKA002.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.DKA002.AppearanceHeader.Options.UseBackColor = true;
            this.DKA002.AppearanceHeader.Options.UseBorderColor = true;
            this.DKA002.AppearanceHeader.Options.UseFont = true;
            this.DKA002.AppearanceHeader.Options.UseForeColor = true;
            this.DKA002.Caption = "项目名称";
            this.DKA002.FieldName = "DKA002";
            this.DKA002.Name = "DKA002";
            this.DKA002.Visible = true;
            this.DKA002.VisibleIndex = 0;
            // 
            // DKA001
            // 
            this.DKA001.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(191)))), ((int)(((byte)(208)))));
            this.DKA001.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(191)))), ((int)(((byte)(208)))));
            this.DKA001.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(191)))), ((int)(((byte)(208)))));
            this.DKA001.AppearanceCell.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.DKA001.AppearanceCell.ForeColor = System.Drawing.Color.White;
            this.DKA001.AppearanceCell.Options.UseBackColor = true;
            this.DKA001.AppearanceCell.Options.UseBorderColor = true;
            this.DKA001.AppearanceCell.Options.UseFont = true;
            this.DKA001.AppearanceCell.Options.UseForeColor = true;
            this.DKA001.AppearanceCell.Options.UseTextOptions = true;
            this.DKA001.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.DKA001.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(191)))), ((int)(((byte)(208)))));
            this.DKA001.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(191)))), ((int)(((byte)(208)))));
            this.DKA001.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(191)))), ((int)(((byte)(208)))));
            this.DKA001.AppearanceHeader.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.DKA001.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.DKA001.AppearanceHeader.Options.UseBackColor = true;
            this.DKA001.AppearanceHeader.Options.UseBorderColor = true;
            this.DKA001.AppearanceHeader.Options.UseFont = true;
            this.DKA001.AppearanceHeader.Options.UseForeColor = true;
            this.DKA001.Caption = "项目编号";
            this.DKA001.FieldName = "DKA001";
            this.DKA001.Name = "DKA001";
            this.DKA001.Visible = true;
            this.DKA001.VisibleIndex = 1;
            // 
            // gridControl2
            // 
            this.gridControl2.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1250, 313);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.save});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 28);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(105, 24);
            this.save.Text = "保存";
            // 
            // gridView1
            // 
            this.gridView1.ColumnPanelRowHeight = 30;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.HBB004,
            this.HBB,
            this.HDA960,
            this.DGA002,
            this.HDA041,
            this.HDB010,
            this.HDB960});
            this.gridView1.GridControl = this.gridControl2;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // HBB004
            // 
            this.HBB004.Caption = "商品名称";
            this.HBB004.FieldName = "HBB004";
            this.HBB004.Name = "HBB004";
            this.HBB004.OptionsColumn.AllowEdit = false;
            this.HBB004.Visible = true;
            this.HBB004.VisibleIndex = 0;
            // 
            // HBB
            // 
            this.HBB.Caption = "采购情况";
            this.HBB.FieldName = "HBB";
            this.HBB.Name = "HBB";
            this.HBB.OptionsColumn.AllowEdit = false;
            this.HBB.Visible = true;
            this.HBB.VisibleIndex = 1;
            // 
            // HDA960
            // 
            this.HDA960.Caption = "合同号";
            this.HDA960.FieldName = "HDA960";
            this.HDA960.Name = "HDA960";
            this.HDA960.OptionsColumn.AllowEdit = false;
            this.HDA960.Visible = true;
            this.HDA960.VisibleIndex = 2;
            // 
            // DGA002
            // 
            this.DGA002.Caption = "供应商简称";
            this.DGA002.FieldName = "DGA002";
            this.DGA002.Name = "DGA002";
            this.DGA002.OptionsColumn.AllowEdit = false;
            this.DGA002.Visible = true;
            this.DGA002.VisibleIndex = 3;
            // 
            // HDA041
            // 
            this.HDA041.Caption = "总金额";
            this.HDA041.FieldName = "HDA041";
            this.HDA041.Name = "HDA041";
            this.HDA041.OptionsColumn.AllowEdit = false;
            this.HDA041.Visible = true;
            this.HDA041.VisibleIndex = 4;
            // 
            // HDB010
            // 
            this.HDB010.Caption = "计划到货时间";
            this.HDB010.FieldName = "HDB010";
            this.HDB010.Name = "HDB010";
            this.HDB010.OptionsColumn.AllowEdit = false;
            this.HDB010.Visible = true;
            this.HDB010.VisibleIndex = 5;
            // 
            // HDB960
            // 
            this.HDB960.Caption = "到货情况";
            this.HDB960.FieldName = "HDB960";
            this.HDB960.Name = "HDB960";
            this.HDB960.Visible = true;
            this.HDB960.VisibleIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 427);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FormMain";
            this.Text = "项目管理";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress . XtraEditors . Repository . RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress . XtraEditors . Repository . RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress . XtraEditors . Repository . RepositoryItemMemoEdit repositoryItemMemoEdit3;
        private DevExpress . XtraEditors . Repository . RepositoryItemMemoEdit repositoryItemMemoEdit4;
        private DevExpress . XtraEditors . Repository . RepositoryItemMemoEdit repositoryItemMemoEdit5;
        private DevExpress . XtraEditors . Repository . RepositoryItemMemoEdit repositoryItemMemoEdit6;
        private DevExpress . XtraEditors . SplitContainerControl splitContainerControl1;
        private DevExpress . XtraGrid . GridControl gridControl1;
        private DevExpress . XtraGrid . Views . Card . CardView cardView1;
        private DevExpress . XtraGrid . Columns . GridColumn DKA002;
        private DevExpress . XtraGrid . Columns . GridColumn DKA001;
        private DevExpress . XtraGrid . GridControl gridControl2;
        private DevExpress . XtraGrid . Views . Grid . GridView gridView1;
        private DevExpress . XtraGrid . Columns . GridColumn HBB004;
        private DevExpress . XtraGrid . Columns . GridColumn HBB;
        private DevExpress . XtraGrid . Columns . GridColumn HDA960;
        private DevExpress . XtraGrid . Columns . GridColumn DGA002;
        private DevExpress . XtraGrid . Columns . GridColumn HDA041;
        private DevExpress . XtraGrid . Columns . GridColumn HDB010;
        private DevExpress . XtraGrid . Columns . GridColumn HDB960;
        private System . Windows . Forms . ContextMenuStrip contextMenuStrip1;
        private System . Windows . Forms . ToolStripMenuItem save;
    }
}