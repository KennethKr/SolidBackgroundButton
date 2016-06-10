using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using UIKit;

namespace XamarinApp.Ios
{
    [Register("SolidBackgroundButton"), DesignTimeVisible(true)]
    public class SolidBackgroundButton : UIButton
    {
        private UIColor backgroundColorHighlight;
        private UIColor backgroundColorNormal;
        private bool highlighted;

        [Export("BackgroundColorNormal"), Browsable(true)]
        public UIColor BackgroundColorNormal
        {
            get { return backgroundColorNormal; }
            set
            {
                backgroundColorNormal = value;
                SetNeedsDisplay();
            }
        }

        [Export("BackgroundColorHightlight"), Browsable(true)]
        public UIColor BackgroundColorHighlight
        {
            get { return backgroundColorHighlight; }
            set
            {
                backgroundColorHighlight = value;
                SetNeedsDisplay();
            }
        }


        public override bool Highlighted
        {
            get { return highlighted; }
            set
            {
                highlighted = value;
                BackgroundColor = highlighted ? BackgroundColorHighlight : BackgroundColorNormal;
            }
        }

        public SolidBackgroundButton(UIButtonType type) : base(type)
        {
            Initialize();
        }

        public SolidBackgroundButton()
        {
            Initialize();
        }

        public SolidBackgroundButton(NSCoder coder) : base(coder)
        {
            Initialize();
        }

        protected SolidBackgroundButton(NSObjectFlag t) : base(t)
        {
            Initialize();
        }

        protected internal SolidBackgroundButton(IntPtr handle) : base(handle)
        {
            Initialize();
        }

        public SolidBackgroundButton(CGRect frame) : base(frame)
        {
            Initialize();
        }

        private void Initialize()
        {
            BackgroundColorNormal = UIColor.White;
            BackgroundColorHighlight = UIColor.FromRGB(241, 241, 241);
        }
    }
}
