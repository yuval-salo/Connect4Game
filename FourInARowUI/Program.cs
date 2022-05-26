using FourInARowLogic;

// $G$ SFN-012 (+11) Bonus: Events in the Logic layer are handled by the UI.

namespace FourInARowUI
{
    public static class Program
    {
        public static void Main()
        {
            GameSettingsForm gameSettings = new GameSettingsForm();
            gameSettings.ShowDialog();
        }
    }
}
