using DevExpress . XtraEditors;
using ProjectManageUtils;
using System;
using System . Collections . Generic;
using System . ComponentModel;
using System . Data;
using System . Drawing;
using System . Linq;
using System . Text;
using System . Threading . Tasks;
using System . Windows . Forms;
using Utility;

namespace ProjectManage
{
    public partial class FormMain :FormBase
    {
        ProjectMamagerBll.Bll.MainBll _bllMain=null;
        DataTable tableViewMain,tableViewDetail;

        public FormMain ( )
        {
            InitializeComponent ( );


            GridViewMoHuSelect . SetFilter ( gridView1 );
            GrivColumnStyle . setColumnStyle ( new DevExpress . XtraGrid . Views . Grid . GridView [ ] { gridView1 } );

            cardView1 . OptionsView . ShowQuickCustomizeButton = false;

            _bllMain = new ProjectMamagerBll . Bll . MainBll ( );

            readProject ( );
        }

        void readProject ( )
        {
            tableViewMain = _bllMain . getTableForMain ( );
            gridControl1 . DataSource = tableViewMain;
        }

        void readDetail ( string number )
        {
            tableViewDetail = _bllMain . getTableForDetail ( number );
            gridControl2 . DataSource = tableViewDetail;
        }

        private void cardView1_Click ( object sender ,EventArgs e )
        {
            DataRow row = cardView1 . GetFocusedDataRow ( );
            if ( row == null )
                return;
            readDetail ( row [ "DKA001" ] . ToString ( ) );
        }

        private void cardView1_CustomDrawCardCaption ( object sender ,DevExpress . XtraGrid . Views . Card . CardCaptionCustomDrawEventArgs e )
        {
            DevExpress . XtraGrid . Views . Card . CardView view = sender as DevExpress . XtraGrid . Views . Card . CardView;

            ( e . CardInfo as DevExpress . XtraGrid . Views . Card . ViewInfo . CardInfo ) . CaptionInfo . CardCaption = view . GetRowCellDisplayText ( e . RowHandle ,view . Columns [ "DKA002" ] );
        }

        private void contextMenuStrip1_ItemClicked ( object sender ,ToolStripItemClickedEventArgs e )
        {
            gridView1 . UpdateCurrentRow ( );
            gridView1 . CloseEditor ( );

            bool result = _bllMain . save ( tableViewDetail );
            if ( result )
                XtraMessageBox . Show ( "保存成功" );
            else
                XtraMessageBox . Show ( "保存失败" );
        }

    }
}
