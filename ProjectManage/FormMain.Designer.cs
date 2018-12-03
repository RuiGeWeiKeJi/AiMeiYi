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
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemMemoEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemMemoEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemMemoEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemMemoEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.HDB961 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HBB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HDA960 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DGA002 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HDA041 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HDB960 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.textLine5 = new ProjectManageControlUI.TextLine();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textLine4 = new ProjectManageControlUI.TextLine();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textLine3 = new ProjectManageControlUI.TextLine();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textLine2 = new ProjectManageControlUI.TextLine();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textLine1 = new ProjectManageControlUI.TextLine();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textLine6 = new ProjectManageControlUI.TextLine();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textLine7 = new ProjectManageControlUI.TextLine();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
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
            // gridControl2
            // 
            this.gridControl2.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1250, 335);
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
            this.HDB961,
            this.HBB,
            this.HDA960,
            this.DGA002,
            this.HDA041,
            this.HDB960});
            this.gridView1.GridControl = this.gridControl2;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // HDB961
            // 
            this.HDB961.Caption = "商品名称";
            this.HDB961.FieldName = "HDB961";
            this.HDB961.Name = "HDB961";
            this.HDB961.OptionsColumn.AllowEdit = false;
            this.HDB961.Visible = true;
            this.HDB961.VisibleIndex = 0;
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
            this.HDA041.DisplayFormat.FormatString = "0.##";
            this.HDA041.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.HDA041.FieldName = "HDA041";
            this.HDA041.Name = "HDA041";
            this.HDA041.OptionsColumn.AllowEdit = false;
            this.HDA041.Visible = true;
            this.HDA041.VisibleIndex = 4;
            // 
            // HDB960
            // 
            this.HDB960.Caption = "到货情况";
            this.HDB960.FieldName = "HDB960";
            this.HDB960.Name = "HDB960";
            this.HDB960.Visible = true;
            this.HDB960.VisibleIndex = 6;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.textLine6);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainerControl1.Panel1.Controls.Add(this.textLine7);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainerControl1.Panel1.Controls.Add(this.textLine5);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainerControl1.Panel1.Controls.Add(this.textLine4);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainerControl1.Panel1.Controls.Add(this.textLine3);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainerControl1.Panel1.Controls.Add(this.textLine2);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.textLine1);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1250, 427);
            this.splitContainerControl1.SplitterPosition = 80;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // textLine5
            // 
            this.textLine5.BackColor = System.Drawing.SystemColors.Control;
            this.textLine5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLine5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLine5.LineColor = System.Drawing.Color.Black;
            this.textLine5.Location = new System.Drawing.Point(766, 47);
            this.textLine5.Name = "textLine5";
            this.textLine5.ReadOnly = true;
            this.textLine5.Size = new System.Drawing.Size(109, 19);
            this.textLine5.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(662, 46);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(98, 20);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "外协件总金额：";
            // 
            // textLine4
            // 
            this.textLine4.BackColor = System.Drawing.SystemColors.Control;
            this.textLine4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLine4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLine4.LineColor = System.Drawing.Color.Black;
            this.textLine4.Location = new System.Drawing.Point(766, 14);
            this.textLine4.Name = "textLine4";
            this.textLine4.ReadOnly = true;
            this.textLine4.Size = new System.Drawing.Size(109, 19);
            this.textLine4.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(662, 13);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(98, 20);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "外购件总金额：";
            // 
            // textLine3
            // 
            this.textLine3.BackColor = System.Drawing.SystemColors.Control;
            this.textLine3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLine3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLine3.LineColor = System.Drawing.Color.Black;
            this.textLine3.Location = new System.Drawing.Point(1033, 47);
            this.textLine3.Name = "textLine3";
            this.textLine3.ReadOnly = true;
            this.textLine3.Size = new System.Drawing.Size(109, 19);
            this.textLine3.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(943, 46);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 20);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "合同总金额：";
            // 
            // textLine2
            // 
            this.textLine2.BackColor = System.Drawing.SystemColors.Control;
            this.textLine2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLine2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLine2.LineColor = System.Drawing.Color.Black;
            this.textLine2.Location = new System.Drawing.Point(186, 47);
            this.textLine2.Name = "textLine2";
            this.textLine2.ReadOnly = true;
            this.textLine2.Size = new System.Drawing.Size(109, 19);
            this.textLine2.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(168, 20);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "所有外协件是否全部采购：";
            // 
            // textLine1
            // 
            this.textLine1.BackColor = System.Drawing.SystemColors.Control;
            this.textLine1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLine1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLine1.LineColor = System.Drawing.Color.Black;
            this.textLine1.Location = new System.Drawing.Point(186, 13);
            this.textLine1.Name = "textLine1";
            this.textLine1.ReadOnly = true;
            this.textLine1.Size = new System.Drawing.Size(109, 19);
            this.textLine1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(168, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "所有外购件是否全部采购：";
            // 
            // textLine6
            // 
            this.textLine6.BackColor = System.Drawing.SystemColors.Control;
            this.textLine6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLine6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLine6.LineColor = System.Drawing.Color.Black;
            this.textLine6.Location = new System.Drawing.Point(504, 47);
            this.textLine6.Name = "textLine6";
            this.textLine6.ReadOnly = true;
            this.textLine6.Size = new System.Drawing.Size(109, 19);
            this.textLine6.TabIndex = 13;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(330, 46);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(168, 20);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "所有外协件是否全部到货：";
            // 
            // textLine7
            // 
            this.textLine7.BackColor = System.Drawing.SystemColors.Control;
            this.textLine7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLine7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLine7.LineColor = System.Drawing.Color.Black;
            this.textLine7.Location = new System.Drawing.Point(504, 13);
            this.textLine7.Name = "textLine7";
            this.textLine7.ReadOnly = true;
            this.textLine7.Size = new System.Drawing.Size(109, 19);
            this.textLine7.TabIndex = 11;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(330, 12);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(168, 20);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "所有外购件是否全部到货：";
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress . XtraEditors . Repository . RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress . XtraEditors . Repository . RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress . XtraEditors . Repository . RepositoryItemMemoEdit repositoryItemMemoEdit3;
        private DevExpress . XtraEditors . Repository . RepositoryItemMemoEdit repositoryItemMemoEdit4;
        private DevExpress . XtraEditors . Repository . RepositoryItemMemoEdit repositoryItemMemoEdit5;
        private DevExpress . XtraEditors . Repository . RepositoryItemMemoEdit repositoryItemMemoEdit6;
        private DevExpress . XtraGrid . GridControl gridControl2;
        private DevExpress . XtraGrid . Views . Grid . GridView gridView1;
        private DevExpress . XtraGrid . Columns . GridColumn HDB961;
        private DevExpress . XtraGrid . Columns . GridColumn HBB;
        private DevExpress . XtraGrid . Columns . GridColumn HDA960;
        private DevExpress . XtraGrid . Columns . GridColumn DGA002;
        private DevExpress . XtraGrid . Columns . GridColumn HDA041;
        private DevExpress . XtraGrid . Columns . GridColumn HDB960;
        private System . Windows . Forms . ContextMenuStrip contextMenuStrip1;
        private System . Windows . Forms . ToolStripMenuItem save;
        private DevExpress . XtraEditors . SplitContainerControl splitContainerControl1;
        private DevExpress . XtraEditors . LabelControl labelControl1;
        private ProjectManageControlUI . TextLine textLine1;
        private ProjectManageControlUI . TextLine textLine2;
        private DevExpress . XtraEditors . LabelControl labelControl2;
        private ProjectManageControlUI . TextLine textLine3;
        private DevExpress . XtraEditors . LabelControl labelControl3;
        private ProjectManageControlUI . TextLine textLine4;
        private DevExpress . XtraEditors . LabelControl labelControl4;
        private ProjectManageControlUI . TextLine textLine5;
        private DevExpress . XtraEditors . LabelControl labelControl5;
        private ProjectManageControlUI . TextLine textLine6;
        private DevExpress . XtraEditors . LabelControl labelControl6;
        private ProjectManageControlUI . TextLine textLine7;
        private DevExpress . XtraEditors . LabelControl labelControl7;
    }
}