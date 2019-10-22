using System;
using Xamarin.Forms;

namespace PdfExample
{
    public class PdfViewer : View
    {
        public PdfViewer()
        {
        }

        public static readonly BindableProperty DataProperty = BindableProperty.Create("Data", typeof(byte[]), typeof(PdfViewer),default(byte[]));

        public byte[] Data
        {
            get { return (byte[])GetValue(DataProperty); }
            set { SetValue(DataProperty, value); }
        }
    }
}
