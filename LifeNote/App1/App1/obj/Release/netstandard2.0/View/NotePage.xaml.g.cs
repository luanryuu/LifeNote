//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("LifeNote.View.NotePage.xaml", "View/NotePage.xaml", typeof(global::App1.NotePage))]

namespace App1 {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("View\\NotePage.xaml")]
    public partial class NotePage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Syncfusion.XForms.PopupLayout.SfPopupLayout popupLayout;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label date_label;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Syncfusion.SfRating.XForms.SfRating rating;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Syncfusion.XForms.RichTextEditor.SfRichTextEditor content_editor;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(NotePage));
            popupLayout = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Syncfusion.XForms.PopupLayout.SfPopupLayout>(this, "popupLayout");
            date_label = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "date_label");
            rating = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Syncfusion.SfRating.XForms.SfRating>(this, "rating");
            content_editor = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Syncfusion.XForms.RichTextEditor.SfRichTextEditor>(this, "content_editor");
        }
    }
}