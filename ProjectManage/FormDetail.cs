using System;
using System . Data;
using System . Drawing;
using System . Windows . Forms;
using System . Drawing . Drawing2D;

namespace ProjectManage
{
    public partial class FormDetail :FormBase
    {
        ProjectMamagerBll.Bll.MainBll _bllMain=null;
        DataTable tableViewMain;

        public FormDetail ( )
        {
            InitializeComponent ( );

            this . StartPosition = FormStartPosition . CenterParent;

            _bllMain = new ProjectMamagerBll . Bll . MainBll ( );

            readProject ( );
        }

        void readProject ( )
        {
            tableViewMain = _bllMain . getTableForMain ( );
            if ( tableViewMain == null || tableViewMain . Rows . Count < 1 )
                return;
            string text, tag;
            for ( int i = 0 ; i < tableViewMain . Rows . Count ; i++ )
            {
                DataRow row = tableViewMain . Rows [ i ];
                if ( row == null )
                    continue;
                text = row [ "DKA002" ] . ToString ( ) + "\n\r" + row [ "DKA001" ] . ToString ( );
                tag = row [ "DKA001" ] . ToString ( );
                addButton ( i ,text ,tag );
            }
        }

        void addButton ( int num,string text,string tag )
        {
            //每行5个
            int x = 0, y = 0, width = 120, height = 89;
            if ( num == 0 )
            {
                //第一个
                x = 29;
                y = 23;
            }
            else if ( num != 0 && num / 5 < 1 )
            {
                //第一行  2-5
                x = ( num + 1 ) * 29 + num * 120;
                y = 23;
            }
            else if ( num != 0 && num / 5 >= 1 )
            {
                //其它行  从第二行开始
                x = ( num % 5 + 1 ) * 29 + num % 5 * 120;
                y = ( num / 5 + 1 ) * 23 + num / 5 * 89;
            }
            string name = "btn" + num;
            Button btn = new Button ( );
            btn . FlatAppearance . BorderColor = System . Drawing . Color . FromArgb ( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) ,( ( int ) ( ( ( byte ) ( 0 ) ) ) ) ,( ( int ) ( ( ( byte ) ( 0 ) ) ) ) ,( ( int ) ( ( ( byte ) ( 0 ) ) ) ) );
            btn . FlatAppearance . BorderSize = 0;
            btn . FlatAppearance . MouseDownBackColor = System . Drawing . Color . Transparent;
            btn . FlatAppearance . MouseOverBackColor = System . Drawing . Color . Transparent;
            btn . FlatStyle = System . Windows . Forms . FlatStyle . Flat;
            btn . Location = new System . Drawing . Point ( x ,y );
            btn . Name = name;
            btn . Size = new System . Drawing . Size ( width ,height );
            btn . Text = text;
            btn . Tag = tag;
            btn . UseVisualStyleBackColor = true;
            btn . Click += new System . EventHandler ( this . btn_Click );
            btn . Paint += new System . Windows . Forms . PaintEventHandler ( this . btn_Paint );
            this . Controls . Add ( btn );
        }

        private void btn_Click ( object sender ,EventArgs e )
        {
            Button btn = sender as Button;
            if ( btn . Tag == null )
                return;
            string num = btn . Tag . ToString ( );
            FormMain from = new FormMain ( num );
            from . WindowState = FormWindowState . Maximized;
            from . Show ( );
        }

        private void btn_Paint ( object sender ,PaintEventArgs e )
        {
            Draw ( e . ClipRectangle ,e . Graphics ,18 ,false ,Color . White ,Color . LightGreen );

            base . OnPaint ( e );

            Graphics g = e . Graphics;

            Button btn = sender as Button;
            StringFormat strF = new StringFormat ( );
            strF . Alignment = StringAlignment . Center;
            strF . LineAlignment = StringAlignment . Center;
            g . DrawString ( btn . Text ,new Font ( "微软雅黑" ,14 ,FontStyle . Regular ) ,new SolidBrush ( Color . Black ) ,btn . ClientRectangle ,strF );
        }

        private void Draw ( Rectangle rectangle ,Graphics g ,int _radius ,bool cusp ,Color begin_color ,Color end_color )
        {
            int span = 2;
            //抗锯齿
            g . SmoothingMode = SmoothingMode . AntiAlias;
            //渐变填充
            LinearGradientBrush myLinearGradientBrush = new LinearGradientBrush ( rectangle ,begin_color ,end_color ,LinearGradientMode . Vertical );
            //填充
            g . FillPath ( myLinearGradientBrush ,DrawRoundRect ( rectangle . X ,rectangle . Y ,rectangle . Width - span ,rectangle . Height - 1 ,_radius ) );
        }

        public static GraphicsPath DrawRoundRect ( int x ,int y ,int width ,int height ,int radius )
        {
            //四边圆角
            GraphicsPath gp = new GraphicsPath ( );
            gp . AddArc ( x ,y ,radius ,radius ,180 ,90 );
            gp . AddArc ( width - radius ,y ,radius ,radius ,270 ,90 );
            gp . AddArc ( width - radius ,height - radius ,radius ,radius ,0 ,90 );
            gp . AddArc ( x ,height - radius ,radius ,radius ,90 ,90 );
            gp . CloseAllFigures ( );
            return gp;
        }

    }
}