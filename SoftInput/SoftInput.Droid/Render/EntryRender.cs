using Xamarin.Forms;
using SoftInput.Droid.Render;

[assembly: ExportRenderer(typeof(Entry), typeof(EntryRender))]
namespace SoftInput.Droid.Render
{
    using Android.Views.InputMethods;
    using Xamarin.Forms.Platform.Android;

    public class EntryRender : EntryRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            //if (Control != null)
            //    Control.ImeOptions = (ImeAction)ImeFlags.NoExtractUi;
        }
    }
}