using System;
using System.ComponentModel;
using Foundation;
using PdfExample;
using PdfExample.iOS.Renderer;
using PdfKit;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(PdfViewer), typeof(PdfRenderer))]
namespace PdfExample.iOS.Renderer
{
    public class PdfRenderer : ViewRenderer<PdfViewer,PdfView>
    {
        public PdfRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<PdfViewer> e)
        {
            base.OnElementChanged(e);

            if(this.Control == null)
            {
                var pdfView = new PdfView();
                this.SetNativeControl(pdfView);
            }
        }


        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if(e.PropertyName == "Data" && this.Control != null)
            {
                this.Control.Document = new PdfDocument(NSData.FromArray(this.Element.Data));
            }
        }
    }
}
