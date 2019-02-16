using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cost_estimating.controlPlus
{
    public partial class buttonPlus : Button
    {
        #region 变量

        //三种不同状态下字体的颜色
        Color _normalForeColor;
        Color _moveForeColor;
        Color _downForeColor;
        //三种不同状态下背景的颜色
        Color _normalBackColor;
        Color _moveBackColor;
        Color _downBackColor;
        Color _transparentColor = Color.FromArgb(255, 0, 255);

        #endregion

        #region 属性

        /// <summary>
        /// 控件在正常状态下字体的颜色
        /// </summary>
        [CategoryAttribute("自定义"), DescriptionAttribute("控件在正常状态下字体的颜色")]
        public Color NormalForeColor
        {
            get
            {
                return _normalForeColor;

            }
            set
            {
                _normalForeColor = value;
            }
        }

        /// <summary>
        /// 鼠标在控件上方按下按钮时字体的颜色
        /// </summary>
        [CategoryAttribute("自定义"), DescriptionAttribute("鼠标在控件上方按下按钮时字体的颜色")]
        public Color DownForeColor
        {
            get { return _downForeColor; }
            set
            {
                _downForeColor = value;
            }
        }

        /// <summary>
        /// 鼠标移过控件时按钮的颜色
        /// </summary>
        [CategoryAttribute("自定义"), DescriptionAttribute("鼠标指针移过控件时按钮的颜色")]
        public Color MoveBackColor
        {
            get { return _moveBackColor; }
            set
            {
                _moveBackColor = value;
            }
        }

        /// <summary>
        /// 控件在正常状态下按钮的颜色
        /// </summary>
        [CategoryAttribute("自定义"), DescriptionAttribute("控件在正常状态下按钮的颜色")]
        public Color NormalBackColor
        {
            get
            {
                return _normalBackColor;

            }
            set
            {
                _normalBackColor = value;
            }
        }

        /// <summary>
        /// 鼠标在控件上方按下按钮时按钮的颜色
        /// </summary>
        [CategoryAttribute("自定义"), DescriptionAttribute("鼠标在控件上方按下按钮时按钮的颜色")]
        public Color DownBackColor
        {
            get { return _downBackColor; }
            set
            {
                _downBackColor = value;
            }
        }

        /// <summary>
        /// 鼠标移过控件时字体的颜色
        /// </summary>
        [CategoryAttribute("自定义"), DescriptionAttribute("鼠标指针移过控件时字体的颜色")]
        public Color MoveForeColor
        {
            get { return _moveForeColor; }
            set
            {
                _moveForeColor = value;
            }
        }

        
        #endregion

        #region 构造函数

        public buttonPlus()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            _normalForeColor = Color.Black;
            _moveForeColor = System.Drawing.SystemColors.HighlightText;
            _downForeColor = Color.DarkGray;
            _normalBackColor = BackColor;
            _moveBackColor = System.Drawing.SystemColors.Highlight;
            _downBackColor = BackColor;
            InitializeComponent();
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Size = new System.Drawing.Size(30, 30);
            this.ForeColor = _normalForeColor;
            AddBtnEvent(this);
        }
        #endregion

        #region 事件
        /// <summary>
        /// 添加按钮上鼠标 移入、移出、按下、弹起 事件
        /// </summary>
        /// <param name="btn">操作的按钮</param>
        private void AddBtnEvent(Button btn)
        {
            btn.MouseEnter += delegate(object sender, EventArgs e)
            {
                ((Button)sender).ForeColor = _moveForeColor;
                ((Button)sender).BackColor = _moveBackColor;
            };
            btn.MouseLeave += delegate(object sender, EventArgs e)
            {
                ((Button)sender).ForeColor = _normalForeColor;
                ((Button)sender).BackColor = _normalBackColor;
            };
            btn.MouseDown += delegate(object sender, MouseEventArgs e)
            {
                ((Button)sender).ForeColor = _downForeColor;
                ((Button)sender).BackColor = _downBackColor;
            };
            btn.MouseUp += delegate(object sender, MouseEventArgs e)
            {
                ((Button)sender).ForeColor = _normalForeColor;
                ((Button)sender).BackColor = _normalBackColor;
            };
        }
        #endregion
    }
}
