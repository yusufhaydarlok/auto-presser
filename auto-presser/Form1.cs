namespace auto_presser
{
    public partial class AutoPresser : Form
    {
        NavigationControl navigationControl;
        public AutoPresser()
        {
            InitializeComponent();
            InitializedNavigationControl();
        }
        private void InitializedNavigationControl()
        {
            List<UserControl> autoPresserControls = new List<UserControl>()
            { new AutoClicker(), new AutoKeyboardPresser()};

            navigationControl = new NavigationControl(autoPresserControls,panelContainer);
            navigationControl.Display(0);
        }

        private void AutoClicker_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
        }

        private void AutoKeyboardPresser_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
        }
    }
}