﻿using System;
using System.Drawing;

namespace PGS
{
    internal class Forms
    {
        // The various dialogs.
        public static Form_MainMenu   MainDialog  = null;
        public static Form_ShortMenu  ShortDialog = null;
        public static Form_WaitMenu   WaitDialog  = null;
        public static Form_ScreenInfo InfoDialog  = null;
        public static Form_ErrorMenu  ErrorDialog = null;

        // Keeps track of the whether or not the arguments are visible.
        private static bool ArgumentsHidden = false;

        public static void ShowShortcutGUI()
        {
            // Create the dialog.
            Forms.ShortDialog = new Form_ShortMenu();

            // Scale the shortcut dialog.
            ScaleShortcutDialog();

            // Hide the arguments by default.
            ArgumentsToggle();

            // Show the shortcut dialog.
            Forms.ShortDialog.ShowDialog();
        }
        public static void ShowGameLaunchGUI(string[] Arguments)
        {
            // The very first argument should be the game path.
            Globals.GamePath = Arguments[0];

            // Test the game path and make sure it exists.
            if (!Paths.Test(Globals.GamePath))
            {
                // If it doesn't exist, show the error dialog.
                Forms.ErrorDialog = new Form_ErrorMenu();

                // Scale it for DPI.
                ScaleErrorDialog();

                // Show the shortcut dialog.
                Forms.ErrorDialog.ShowDialog();

                // Escape now there is nothing left.
                return;
            }
            // Builds arguments list for game and assesses special arguments to skip GUI or disable timer.
            Functions.BuildAndAssessArguments(Arguments);

            // If the user skipped the GUI.
            if (Globals.NoGUI)
            {
                // Just go for it. Load the game now.
                Functions.SetPrimaryAndLaunch();

                // The GUI is but a myth, the game is awaiting launch.
                return;
            }
            // Try to get the icon from the executable.
            Icon FormIcon = Functions.IconFromFilePath(Globals.GamePath);

            // Create the dialogs.
            Forms.MainDialog = new Form_MainMenu();
            Forms.InfoDialog = new Form_ScreenInfo();
            Forms.WaitDialog = new Form_WaitMenu();

            // Set the icon to the form.
            Forms.MainDialog.Icon = FormIcon;

            // Scale the dialogs with DPI.
            ScaleMainDialog();
            ScaleWaitDialog();
            ScaleInfoDialog();

            // Update the info form to show screen information.
            Functions.UpdateScreenInfo();

            // Put in its own method to cut down on fat.
            Functions.UpdateMonitorValues();

            // Get the file as an item.
            FileItem GameItem = new FileItem(Globals.GamePath);

            // Set the textbox to executable and args.
            Forms.MainDialog.GameTextBox.Text = GameItem.Name + " " + Globals.GameArgs;

            // If the user did not skip the timer then start it now.
            if (!Globals.NoTimer)
            {
                // Countdown to the end of time.
                StartTimer.Start();

                // Add the event handlers for stopping the timer so VS2022 doesn't delete them.
                StartTimer.AddStopTimerEvents();
            }
            // If the user did skip the timer then blank out the text.
            else
            {
                // No timer means no need to display this label.
                Forms.MainDialog.TimerLabel.Text = "";
            }
            // Show the main dialog.
            Forms.MainDialog.ShowDialog();
        }
        public static void ArgumentsToggle()
        {
            // Store the tooltip in a string.
            string TipString = "";

            // If the arguments is hidden then hide it.
            if (ArgumentsHidden)
            {
                // Extend the dialog to a larger size.
                Forms.ShortDialog.ClientSize = DPI.Scale(new System.Drawing.Size(198, 230));
                Forms.ShortDialog.MaximumSize = DPI.Scale(new System.Drawing.Size(214, 269));
                Forms.ShortDialog.MinimumSize = DPI.Scale(new System.Drawing.Size(214, 269));

                // Move the buttons back down.
                Forms.ShortDialog.ArgsToggleButton.Location = DPI.Scale(new System.Drawing.Point(10, 199));
                Forms.ShortDialog.CloseButton.Location = DPI.Scale(new System.Drawing.Point(89, 199));

                // Swap the image on the button.
                Forms.ShortDialog.ArgsToggleButton.Image = global::PGS.Properties.Resources.arrowup;

                // Set the tooltip string.
                TipString = "Hide the textbox to add game arguments.";
            }
            // If the arguments is extended then hide it.
            else
            {
                // Shrink the dialog to standard size.
                Forms.ShortDialog.ClientSize = DPI.Scale(new System.Drawing.Size(198, 175));
                Forms.ShortDialog.MaximumSize = DPI.Scale(new System.Drawing.Size(214, 214));
                Forms.ShortDialog.MinimumSize = DPI.Scale(new System.Drawing.Size(214, 214));

                // Move the buttons up a bit.
                Forms.ShortDialog.ArgsToggleButton.Location = DPI.Scale(new System.Drawing.Point(10, 144));
                Forms.ShortDialog.CloseButton.Location = DPI.Scale(new System.Drawing.Point(89, 144));

                // Swap the image on the button.
                Forms.ShortDialog.ArgsToggleButton.Image = global::PGS.Properties.Resources.arrowdown;

                // Set the tooltip string.
                TipString = "Show a textbox to add arguments to the \r\nselected executable. Arguments must be \r\nentered before creating the shortcut.";
            }
            // Toggle the groupbox and textbox.
            Forms.ShortDialog.ArgumentsTextBox.Visible = ArgumentsHidden;
            Forms.ShortDialog.ArgumentsGroupBox.Visible = ArgumentsHidden;

            // Swap the tooltip with the updated message.
            Forms.ShortDialog.GlobalToolTip.SetToolTip(Forms.ShortDialog.ArgsToggleButton, null);
            Forms.ShortDialog.GlobalToolTip.SetToolTip(Forms.ShortDialog.ArgsToggleButton, TipString);

            // Keep track of the toggled state.
            ArgumentsHidden = !ArgumentsHidden;
        }
        private static void ScaleShortcutDialog()
        {
            Forms.ShortDialog.ClientSize = DPI.Scale(new System.Drawing.Size(198, 230));
            Forms.ShortDialog.MaximumSize = DPI.Scale(new System.Drawing.Size(214, 269));
            Forms.ShortDialog.MinimumSize = DPI.Scale(new System.Drawing.Size(214, 269));
            Forms.ShortDialog.ShortcutGroupBox.Location = DPI.Scale(new System.Drawing.Point(10, 2));
            Forms.ShortDialog.ShortcutGroupBox.Size = DPI.Scale(new System.Drawing.Size(178, 138));
            Forms.ShortDialog.ShortcutLabel.Location = DPI.Scale(new System.Drawing.Point(8, 22));
            Forms.ShortDialog.ShortcutLabel.Size = DPI.Scale(new System.Drawing.Size(164, 81));
            Forms.ShortDialog.ShortcutButton.Location = DPI.Scale(new System.Drawing.Point(26, 103));
            Forms.ShortDialog.ShortcutButton.Size = DPI.Scale(new System.Drawing.Size(125, 25));
            Forms.ShortDialog.ArgumentsGroupBox.Location = DPI.Scale(new System.Drawing.Point(13, 143));
            Forms.ShortDialog.ArgumentsGroupBox.Size = DPI.Scale(new System.Drawing.Size(175, 50));
            Forms.ShortDialog.ArgumentsTextBox.Location = DPI.Scale(new System.Drawing.Point(6, 19));
            Forms.ShortDialog.ArgumentsTextBox.Size = DPI.Scale(new System.Drawing.Size(163, 20));
            Forms.ShortDialog.CloseButton.Location = DPI.Scale(new System.Drawing.Point(89, 199));
            Forms.ShortDialog.CloseButton.Size = DPI.Scale(new System.Drawing.Size(100, 25));
            Forms.ShortDialog.ArgsToggleButton.Location = DPI.Scale(new System.Drawing.Point(10, 199));
            Forms.ShortDialog.ArgsToggleButton.Size = DPI.Scale(new System.Drawing.Size(28, 25));
        }
        private static void ScaleErrorDialog()
        {
            Forms.ErrorDialog.ClientSize = DPI.Scale(new System.Drawing.Size(198, 175));
            Forms.ErrorDialog.MaximumSize = DPI.Scale(new System.Drawing.Size(214, 214));
            Forms.ErrorDialog.MinimumSize = DPI.Scale(new System.Drawing.Size(214, 214));
            Forms.ErrorDialog.ErrorGroupBox.Location = DPI.Scale(new System.Drawing.Point(10, 2));
            Forms.ErrorDialog.ErrorGroupBox.Size = DPI.Scale(new System.Drawing.Size(178, 138));
            Forms.ErrorDialog.ErrorLabel.Location = DPI.Scale(new System.Drawing.Point(10, 31));
            Forms.ErrorDialog.ErrorLabel.Size = DPI.Scale(new System.Drawing.Size(156, 97));
            Forms.ErrorDialog.ErrorButton.Location = DPI.Scale(new System.Drawing.Point(89, 144));
            Forms.ErrorDialog.ErrorButton.Size = DPI.Scale(new System.Drawing.Size(100, 25));
        }
        private static void ScaleInfoDialog()
        {
            Forms.InfoDialog.ClientSize = DPI.Scale(new System.Drawing.Size(346, 369));
            Forms.InfoDialog.MaximumSize = DPI.Scale(new System.Drawing.Size(362, 408));
            Forms.InfoDialog.MinimumSize = DPI.Scale(new System.Drawing.Size(362, 408));
            Forms.InfoDialog.InfoGroupBox.Location = DPI.Scale(new System.Drawing.Point(12, 12));
            Forms.InfoDialog.InfoGroupBox.Size = DPI.Scale(new System.Drawing.Size(322, 320));
            Forms.InfoDialog.InfoRichTextBox.Location = DPI.Scale(new System.Drawing.Point(6, 19));
            Forms.InfoDialog.InfoRichTextBox.Size = DPI.Scale(new System.Drawing.Size(310, 295));
            Forms.InfoDialog.CloseButton.Location = DPI.Scale(new System.Drawing.Point(234, 338));
            Forms.InfoDialog.CloseButton.Size = DPI.Scale(new System.Drawing.Size(100, 25));
        }
        private static void ScaleMainDialog()
        {
            Forms.MainDialog.ClientSize = DPI.Scale(new System.Drawing.Size(198, 175));
            Forms.MainDialog.MaximumSize = DPI.Scale(new System.Drawing.Size(214, 214));
            Forms.MainDialog.MinimumSize = DPI.Scale(new System.Drawing.Size(214, 214));
            Forms.MainDialog.MainGroupBox.Location = DPI.Scale(new System.Drawing.Point(10, 2));
            Forms.MainDialog.MainGroupBox.Size = DPI.Scale(new System.Drawing.Size(178, 80));
            Forms.MainDialog.Monitor01NumBox.Location = DPI.Scale(new System.Drawing.Point(126, 20));
            Forms.MainDialog.Monitor01NumBox.Size = DPI.Scale(new System.Drawing.Size(40, 20));
            Forms.MainDialog.Monitor02NumBox.Location = DPI.Scale(new System.Drawing.Point(126, 45));
            Forms.MainDialog.Monitor02NumBox.Size = DPI.Scale(new System.Drawing.Size(40, 20));
            Forms.MainDialog.Monitor01Label.Location = DPI.Scale(new System.Drawing.Point(6, 22));
            Forms.MainDialog.Monitor01Label.Size = DPI.Scale(new System.Drawing.Size(100, 18));
            Forms.MainDialog.Monitor02Label.Location = DPI.Scale(new System.Drawing.Point(6, 47));
            Forms.MainDialog.Monitor02Label.Size = DPI.Scale(new System.Drawing.Size(110, 18));
            Forms.MainDialog.GameGroupBox.Location = DPI.Scale(new System.Drawing.Point(10, 86));
            Forms.MainDialog.GameGroupBox.Size = DPI.Scale(new System.Drawing.Size(178, 54));
            Forms.MainDialog.GameTextBox.Location = DPI.Scale(new System.Drawing.Point(10, 22));
            Forms.MainDialog.GameTextBox.Size = DPI.Scale(new System.Drawing.Size(158, 20));
            Forms.MainDialog.GameButton.Location = DPI.Scale(new System.Drawing.Point(89, 144));
            Forms.MainDialog.GameButton.Size = DPI.Scale(new System.Drawing.Size(100, 25));
            Forms.MainDialog.TimerLabel.Location = DPI.Scale(new System.Drawing.Point(56, 148));
            Forms.MainDialog.TimerLabel.Size = DPI.Scale(new System.Drawing.Size(16, 17));
            Forms.MainDialog.InfoButton.Location = DPI.Scale(new System.Drawing.Point(10, 144));
            Forms.MainDialog.InfoButton.Size = DPI.Scale(new System.Drawing.Size(30, 25));
        }
        private static void ScaleWaitDialog()
        {
            Forms.WaitDialog.ClientSize = DPI.Scale(new System.Drawing.Size(198, 175));
            Forms.WaitDialog.MaximumSize = DPI.Scale(new System.Drawing.Size(214, 214));
            Forms.WaitDialog.MinimumSize = DPI.Scale(new System.Drawing.Size(214, 214));
            Forms.WaitDialog.WaitLabel.Location = DPI.Scale(new System.Drawing.Point(27, 72));
            Forms.WaitDialog.WaitLabel.Size = DPI.Scale(new System.Drawing.Size(136, 100));
        }
    }
}