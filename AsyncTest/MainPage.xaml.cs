using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading;
using System.Threading.Tasks;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace AsyncTest
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public static class MainTask
    {
        public static async Task<int> DoCompute()
        {
            int i = 0, sum = 0;
//            int[] a = new int[Int32.MaxValue];
            for(i=0;i<int.MaxValue;i++)
            {
//                a[i] = i;
                sum += i*(i%2);
            }
            return sum;

        }
    }

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Title.Text = Convert.ToString(Int32.MaxValue);
        }

        private async void Action_Click(object sender, RoutedEventArgs e)
        {
            int Result = 0;
            Result=await MainTask.DoCompute();
            Title.Text = Convert.ToString(Result);


        }
    }
}
