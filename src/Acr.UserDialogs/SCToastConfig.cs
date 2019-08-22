using Acr.UserDialogs.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acr.UserDialogs
{
    public class SCToastConfig : ToastConfig
    {
        public SCToastConfig(
            string message
            , int leftMargin
            , int topMargin
            , int rightMargin
            , int bottomMargin)
            : base(message)
        {
            this.LeftMargin = leftMargin;
            this.TopMargin = topMargin;
            this.RightMargin = rightMargin;
            this.BottomMargin = bottomMargin;
        }

        public int LeftMargin { get; set; }
        public int TopMargin { get; set; }
        public int RightMargin { get; set; }
        public int BottomMargin { get; set; }

        public int FontSize { get; set; }

        public TypefaceStyle TextStyle { get; set; }

        public SCToastConfig SetTextStyle(TypefaceStyle textStyle)
        {
            this.TextStyle = textStyle;
            return this;
        }

        public SCToastConfig SetFontSize(int size)
        {
            this.FontSize = size;
            return this;
        }
    }
}
