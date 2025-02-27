﻿using System;
using System . Data;
using System . Drawing;
using System . Windows . Forms;
using System . Drawing . Drawing2D;
using System.Collections.Generic;
using DevExpress.Office.Utils;

namespace ProjectManage
{
    public partial class FormDetail :FormBase
    {
        ProjectMamagerBll.Bll.MainBll _bllMain=null;
        DataTable tableViewMain;
        string aaa = string.Empty;
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
            int x = 0, y = 0, width = 150, height = 89;
            if ( num == 0 )
            {
                //第一个
                x = 29;
                y = 5 * 2 + 89;
            }
            else if ( num != 0 && num / 5 < 1 )
            {
                //第一行  2-5
                x = ( num + 1 ) * 29 + num * 150;
                y = 5 * 2 + 89;
            }
            else if ( num != 0 && num / 5 >= 1 )
            {
                //其它行  从第二行开始
                x = ( num % 5 + 1 ) * 29 + num % 5 * 150;
                y = ( num / 5 + 1 ) * 5 * 2+89 + num / 5 * 89;
            }
            string name = "btn" + num;
            Button btn = new Button ( );
            btn . FlatAppearance . BorderColor = System . Drawing . Color . FromArgb ( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) ,( ( int ) ( ( ( byte ) ( 0 ) ) ) ) ,( ( int ) ( ( ( byte ) ( 0 ) ) ) ) ,( ( int ) ( ( ( byte ) ( 0 ) ) ) ) );
            btn . FlatAppearance . BorderSize = 0;
            btn . FlatAppearance . MouseDownBackColor = System . Drawing . Color . Transparent;
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

        private void btn_Paint(object sender, PaintEventArgs e)
        {




            Draw(e.ClipRectangle, e.Graphics, 18, false, Color.WhiteSmoke, Color.WhiteSmoke);



            Graphics g = e.Graphics;

            Button btn = sender as Button;
            StringFormat strF = new StringFormat();
            strF.Alignment = StringAlignment.Center;
            strF.LineAlignment = StringAlignment.Center;
            g.DrawString(btn.Text, new Font("微软雅黑", 14, FontStyle.Regular), new SolidBrush(Color.Black), btn.ClientRectangle, strF);

            base.OnPaint(e);
        }
        private void btn_Paints(object sender, PaintEventArgs e)
        {

           
                Draw(e.ClipRectangle, e.Graphics, 18, false, Color.LightGreen, Color.LightGreen);
           
           
           

            Graphics g = e.Graphics;

            Button btn = sender as Button;
            StringFormat strF = new StringFormat();
            strF.Alignment = StringAlignment.Center;
            strF.LineAlignment = StringAlignment.Center;
            g.DrawString(btn.Text, new Font("微软雅黑", 14, FontStyle.Regular), new SolidBrush(Color.Red), btn.ClientRectangle, strF);

            base.OnPaint(e);
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

            //ControlPaint . DrawBorder ( g ,rectangle ,
            //    Color . LightSalmon ,1 ,ButtonBorderStyle . Solid ,
            //    Color . LightSalmon ,1 ,ButtonBorderStyle . Solid ,
            //    Color . LightSalmon ,1 ,ButtonBorderStyle . Solid ,
            //    Color . LightSalmon ,1 ,ButtonBorderStyle . Solid
            //    );
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

        private void DrawLine ( Graphics graphics ,Control control )
        {
            float X = float . Parse ( control . Width . ToString ( ) ) - 1;
            float Y = float . Parse ( control . Height . ToString ( ) ) - 1;
            PointF [ ] pointfs = {
                new PointF(8,     0),
                new PointF(X-8,   0),
                new PointF(X-4,   4),
                new PointF(X,     8),
                new PointF(X,     Y-8),
                new PointF(X-4,   Y-4),
                new PointF(X-8,   Y),
                new PointF(8,     Y),
                new PointF(4,     Y-4),
                new PointF(0,     Y-8),
                new PointF(0,     8),
                new PointF(4,     4)
                };

            GraphicsPath path = new GraphicsPath ( );
            path . AddLines ( pointfs );

            Pen pen = new Pen ( Color . FromArgb ( 150 ,Color . Blue ) ,1 );
            pen . DashStyle = DashStyle . Solid;
            graphics . DrawPath ( pen ,path );
        }

        private void panel1_Paint ( object sender ,PaintEventArgs e )
        {

        }
        public class Datas
        {
            public string name;
            public string ID;
        }
            private void Button1_Click(object sender, EventArgs e)
        {
            



            //PointToScreen(button1.Location);
            //Button btn = sender as Button;
            //if (btn.Tag == null)
            //    return;
            //string num = btn.Tag.ToString();
        }
        void button_Enter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Red;
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
            string aa = textBox1.Text;
         
            List<Datas> scoreList = new List<Datas>();//创建了一个空列表

            //遍历窗体所有控件，
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {

                    //遍历后的操作...
                    string aass = control.Text;
                    string aasss = control.Name;
                    Datas datas = new Datas();
                    datas.name = aass;
                    datas.ID = aasss;
                    scoreList.Add(datas);
                }
            }
            //遍历窗体所有控件，
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {

                    if (string.IsNullOrEmpty(aa))
                    {
                        control.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Paint);

                        (control as Button).FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                    }

                     

                   else if (control.Text.IndexOf(aa) != -1)
                    {
                        //aaa = "1";

                        //control.BackColor = System.Drawing.Color.Red;
                        //control.ForeColor = System.Drawing.Color.Red;
                        control.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Paints);
                        //control.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Paint(Color.Yellow));
                        //control.ForeColor = System.Drawing.Color.Yellow;
                        //control.BackColor = System.Drawing.Color.Yellow;

                    }
                    else
                    {
                        control.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Paint);
                        (control as Button).FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                        // aaa= null;
                        //  control.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Paint);
                    }


                }
            }

            this.Refresh();
        }
    }
}