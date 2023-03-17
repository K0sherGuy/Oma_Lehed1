using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Oma_Lehed
{
    public class Start:ContentPage
    {
        public List<Button> buttons { get; set; }
        List<ContentPage> pages { get; set; }

        public Start() 
        {
            StackLayout st = new StackLayout();
            buttons=new List<Button>();
            pages=new List<ContentPage>();
            List<string> files = new List<string> { "a.jpg", "b.jpg", "c.jpg" };
            List<string> dirs = new List<string> { "a", "b", "c" };
            Random rnd= new Random();
            for(int i = 0; i < files.Count; i++)
            {
                Button b = new Button
                {
                    Text = dirs[i],
                    TabIndex = i
                };
                buttons.Add(b);
                st.Children.Add(b);
                b.Clicked += B_Clicked;
                ContentPage p = new ContentPage
                {
                    BackgroundColor = Color.FromRgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255))
                };
                pages.Add(p);

            }
        }

        private async void B_Clicked(object sender, EventArgs e)
        {
            Button b = sender as Button;
            await Navigation.PushAsync(pages[b.TabIndex]);
        }
    }
}
