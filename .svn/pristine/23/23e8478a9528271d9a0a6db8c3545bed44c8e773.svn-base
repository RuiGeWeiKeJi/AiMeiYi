using System;
using System . Collections . Generic;
using System . ComponentModel;
using System . Drawing;
using System . Data;
using System . Linq;
using System . Text;
using System . Windows . Forms;
using System . Drawing . Drawing2D;

namespace ProjectManageUtils
{
    public partial class ButtonEx :Button
    {
        Rectangle r;
        private Brush _myBrush = null;
        private Color _colorStart = System.Drawing.Color.FromArgb(255, 255, 192);
        private Color _colorEnd = System.Drawing.Color.FromArgb(0, 0, 192);
        private Color _colorBorder=Color.Green;
        private Color colorOne;
        private Color colorTwo;

        [Category("设置"),Description("渐变色开始")]
        public Color colorStart
        {
            get
            {
                return _colorStart;
            }
            set
            {
                _colorStart = value;
            }
        }

        [Category("设置"),Description("渐变色结束")]
        public Color colorEnd
        {
            get
            {
                return _colorEnd;
            }
            set
            {
                _colorEnd = value;
            }
        }

        [Category("设置"),Description("边框颜色")]
        public Color colorBorder
        {
            get
            {
                return _colorBorder;
            }
            set
            {
                _colorBorder = value;
            }
        }

        public void ButtonNew ( )
        {
            r = new Rectangle ( 0 ,0 ,150 ,80 );
            _myBrush = new LinearGradientBrush ( r ,colorStart ,colorEnd ,LinearGradientMode . Vertical );
        }

        public Brush MyBrush
        {
            get
            {
                return _myBrush;
            }
            set
            {
                _myBrush = value;
            }
        }

        protected override void OnResize ( EventArgs e )
        {
            base . OnResize ( e );

            r = new Rectangle ( 0 ,0 ,this . Width ,this . Height );
            MyBrush = new LinearGradientBrush ( r ,colorStart ,colorEnd ,LinearGradientMode . Vertical );
        }

        private void Draw ( Rectangle rectangle,Graphics g,float _radius )
        {
            int span = 2;
            //抗锯齿
            g . SmoothingMode = SmoothingMode . AntiAlias;
            //填充
            g . FillPath ( MyBrush ,DrawRoundRect ( rectangle . X ,rectangle . Y ,rectangle . Width - span ,rectangle . Height - 1 ,_radius ) );
        }

        //画圆角
        public static GraphicsPath DrawRoundRect ( int x ,int y ,int width,int height,float radius )
        {
            //四边圆角
            GraphicsPath graphicsPath = new GraphicsPath ( );
            graphicsPath . AddArc ( x ,y ,radius ,radius ,180 ,90 );
            graphicsPath . AddArc ( width - radius ,y ,radius ,radius ,720 ,90 );
            graphicsPath . AddArc ( width - radius ,height - radius ,radius ,radius ,0 ,90 );
            graphicsPath . AddArc ( x ,height - radius ,radius ,radius ,90 ,90 );
            graphicsPath . CloseAllFigures ( );
            return graphicsPath;
        }

        protected override void OnPaint ( PaintEventArgs pevent )
        {

            ButtonNew ( );

            //Graphics g1 = pevent . Graphics;
            //Draw ( this . ClientRectangle ,g1 ,18 );

            base . OnPaint ( pevent );

            Graphics g = pevent . Graphics;
            
            
            g . FillRectangle ( MyBrush ,this . ClientRectangle );
            StringFormat strF = new StringFormat ( );
            strF . Alignment = StringAlignment . Center;
            strF . LineAlignment = StringAlignment . Center;

            g . DrawString ( this . Text ,this . Font ,new SolidBrush ( Color . Black ) ,this . ClientRectangle ,strF );
            ControlPaint . DrawBorder ( g ,ClientRectangle ,colorBorder ,ButtonBorderStyle . Solid );

        }

    }
}
