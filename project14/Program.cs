namespace project14
{
    interface IButton
    {
        void Render();
    }

    interface ITextBox
    {
        void Render();
    }

    interface IUIFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }

    class LightButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render light button");
        }
    }

    class LightTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Render light textbox");
        }
    }

    class LightUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new LightButton();
        }

        public ITextBox CreateTextBox()
        {
            return new LightTextBox();
        }
    }

    class DarkButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render dark button");
        }
    }

    class DarkTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Render dark textbox");
        }
    }

    class DarkUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new DarkButton();
        }

        public ITextBox CreateTextBox()
        {
            return new DarkTextBox();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IUIFactory factory = new DarkUIFactory();

            IButton button = factory.CreateButton();
            ITextBox textBox = factory.CreateTextBox();


            button.Render();
            textBox.Render();
        }
    }
}

