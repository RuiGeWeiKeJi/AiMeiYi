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
        DataTable tableViewDetail,tableOne,tableTwo,tableTre;

        public FormMain ( string number )
        {
            InitializeComponent ( );

            this . StartPosition = FormStartPosition . CenterParent;

            GridViewMoHuSelect . SetFilter ( gridView1 );
            GrivColumnStyle . setColumnStyle ( new DevExpress . XtraGrid . Views . Grid . GridView [ ] { gridView1 } );

            _bllMain = new ProjectMamagerBll . Bll . MainBll ( );
            readDetail ( number );
        }

        void readDetail ( string number )
        {
            tableViewDetail = _bllMain . getTableForDetail ( number );
            gridControl2 . DataSource = tableViewDetail;

            tableOne = _bllMain . tableOne ( number );
            if ( tableOne != null && tableOne . Rows . Count > 0 )
            {
                textLine1 . Text = tableOne . Rows [ 0 ] [ "X" ] . ToString ( );
                textLine7 . Text = tableOne . Rows [ 0 ] [ "Y" ] . ToString ( );
                textLine4 . Text = tableOne . Rows [ 0 ] [ "Z" ] . ToString ( );
            }
            tableTwo = _bllMain . tableTwo ( number );
            if ( tableTwo != null && tableTwo . Rows . Count > 0 )
            {
                textLine2 . Text = tableTwo . Rows [ 0 ] [ "X" ] . ToString ( );
                textLine6 . Text = tableTwo . Rows [ 0 ] [ "Y" ] . ToString ( );
                textLine5 . Text = tableTwo . Rows [ 0 ] [ "Z" ] . ToString ( );
            }
            tableTre = _bllMain . tableTre ( number );
            if ( tableTre != null && tableTre . Rows . Count > 0 )
            {
                textLine3 . Text = tableTre . Rows [ 0 ] [ "X" ] . ToString ( ) == "0" ? null : tableTre . Rows [ 0 ] [ "X" ] . ToString ( );
            }
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
