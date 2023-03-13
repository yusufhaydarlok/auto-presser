using auto_presser.Navigation;
using System.Runtime.InteropServices;

namespace auto_presser
{
    public partial class AutoPresser : Form
    {
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private const int LEFTUP = 0x0004;
        private const int LEFTDOWN = 0x0002;
        public int intervals = 0;
        public bool click = false;

        NavigationControl navigationControl;
        NavigationButtons navigationButtons;

        Color btnDefaultColor = Color.FromKnownColor(KnownColor.ControlLight);
        Color btnSelectedColor = Color.FromKnownColor(KnownColor.ControlDark);
        public AutoPresser()
        {
            InitializeComponent();
            InitializedNavigationControl();
            InitializedNavigationButtons();
        }
        private void InitializedNavigationControl()
        {
            List<UserControl> autoPresserControls = new List<UserControl>()
            { new AutoClicker(), new AutoKeyboardPresser()};

            navigationControl = new NavigationControl(autoPresserControls,panelContainer);
            navigationControl.Display(0);
        }

        private void InitializedNavigationButtons()
        {
            List<Button> buttons = new List<Button>()
            { AutoClicker, AutoKeyboardPresser};

            navigationButtons = new NavigationButtons(buttons, btnDefaultColor, btnSelectedColor);
            navigationButtons.Highlight(AutoClicker);
        }

        private void AutoClicker_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButtons.Highlight(AutoClicker);
        }

        private void AutoKeyboardPresser_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
            navigationButtons.Highlight(AutoKeyboardPresser);
        }
    }
}