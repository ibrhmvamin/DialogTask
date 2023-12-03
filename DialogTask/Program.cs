namespace DialogTask
{
    public class Program
    {
        public interface IButton
        {
            void Render();
            void OnClick();

        }

        public class WindowsButton : IButton
        {
            public void OnClick()
            {
                Console.WriteLine("Clicked in Windows");
            }

            public void Render()
            {
                Console.WriteLine("Rendered in Windows");
            }
        }

        public class HTMLButton : IButton
        {
            public void OnClick()
            {
                Console.WriteLine("Clicked in HTML");
            }

            public void Render()
            {
                Console.WriteLine("Rendered in HTML");
            }
        }

        public abstract class Dialog
        {
            public void Render()
            {
                IButton? okbutton = CreateButton();
                okbutton.Render();
                okbutton.OnClick();
            }
            public virtual IButton? CreateButton() => null;
        }
        public class WindowsDialog : Dialog
        {
            public override IButton? CreateButton()
            {
                return new WindowsButton();
            }
        }


        public class WebDialog : Dialog
        {
            public override IButton? CreateButton()
            {
                return new HTMLButton();
            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}