using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Whisper_Music.Animations
{
    public static class AnimExtentions
    {
        public static void ResizeWidth(this Image self, double width, double duration)
        {
            DoubleAnimation anim = new DoubleAnimation();
            anim.From = self.ActualWidth;
            anim.To = width;
            anim.Duration = TimeSpan.FromSeconds(duration);
            anim.AutoReverse = false;
            self.BeginAnimation(Image.WidthProperty,anim);
        }

        public static void ResizeHeight(this Image self, double height, double duration)
        {
            DoubleAnimation anim = new DoubleAnimation();
            anim.From = self.ActualHeight;
            anim.To = height;
            anim.Duration = TimeSpan.FromSeconds(duration);
            anim.AutoReverse = false;
            self.BeginAnimation(Image.HeightProperty, anim);
        }

    }
}
