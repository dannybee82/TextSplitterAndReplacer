using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextSplitterAndReplacer.Dialogs
{
    /// <summary>
    /// ShowDialog - This class uses enums to show a specific dialog. The dialogs returns an int value.
    /// </summary>
    /// <example>
    /// Usage:
    /// ShowDialog dialog = new ShowDialog();
    /// dialog.Show("message to show", "dialog title", ShowDialog.DialogButtons.YES_NO_CANCEL, ShowDialog.DialogTypes.WARNING );
    /// 
    /// Or use alternatively int:
    /// dialog.Show("message to show", "dialog title", 3, 2 );
    /// 
    /// </example>
    /// <returns>
    /// Integer values:
    /// -1 = unknown
    /// 0 = No/Cancel/Abort
    /// 1 = Ok/Yes/Retry
    /// 2 = Ignore
    /// </returns>

    /// <value>
    /// DialogButtons = enum with predefined buttons.
    /// </value>

    public enum DialogButtons { OK = 0, YES_NO = 1, OK_CANCEL = 2, YES_NO_CANCEL = 3, ABORT_RETRY_IGNORE = 4, RETRY_CANCEL = 5 };

    /// <value>
    /// DialogTypes = enum with predefined dialog types.
    /// </value>

    public enum DialogTypes { NONE = 0, INFORMATION = 1, WARNING = 2, ERROR = 3, EXCLAMATION = 4, STOP = 5, QUESTION = 6, ASTERISK_INFORMATION = 7 };

    public class ShowDialog
    {
        /// <summary>
        /// Show() - Method to show a specific dialog.
        /// </summary>
        /// <returns>
        /// @return int value => -1 = unknown, 0 = No/Cancel/Abort, 1 = Ok/Yes/Retry, 2 = Ignore.
        /// </returns>

        public int Show(string message, string title, DialogButtons button, DialogTypes type)
        {
            DialogResult dialogResult;

            MessageBoxButtons b;
            MessageBoxIcon icon;

            switch (button)
            {
                case DialogButtons.OK:
                    b = MessageBoxButtons.OK;
                    break;
                case DialogButtons.YES_NO:
                    b = MessageBoxButtons.YesNo;
                    break;
                case DialogButtons.OK_CANCEL:
                    b = MessageBoxButtons.OKCancel;
                    break;
                case DialogButtons.YES_NO_CANCEL:
                    b = MessageBoxButtons.YesNoCancel;
                    break;
                case DialogButtons.ABORT_RETRY_IGNORE:
                    b = MessageBoxButtons.AbortRetryIgnore;
                    break;
                case DialogButtons.RETRY_CANCEL:
                    b = MessageBoxButtons.RetryCancel;
                    break;
                default:
                    b = MessageBoxButtons.OK;
                    break;
            }

            switch (type)
            {
                case DialogTypes.NONE:
                    icon = MessageBoxIcon.None;
                    break;
                case DialogTypes.INFORMATION:
                    icon = MessageBoxIcon.Information;
                    break;
                case DialogTypes.WARNING:
                    icon = MessageBoxIcon.Warning;
                    break;
                case DialogTypes.ERROR:
                    icon = MessageBoxIcon.Error;
                    break;
                case DialogTypes.EXCLAMATION:
                    icon = MessageBoxIcon.Exclamation;
                    break;
                case DialogTypes.STOP:
                    icon = MessageBoxIcon.Stop;
                    break;
                case DialogTypes.QUESTION:
                    icon = MessageBoxIcon.Question;
                    break;
                case DialogTypes.ASTERISK_INFORMATION:
                    icon = MessageBoxIcon.Asterisk;
                    break;
                default:
                    icon = MessageBoxIcon.None;
                    break;
            }

            dialogResult = MessageBox.Show(message, title, b, icon);

            int result = -1;

            switch (dialogResult)
            {
                case DialogResult.OK:
                    result = 1;
                    break;
                case DialogResult.Yes:
                    result = 1;
                    break;
                case DialogResult.No:
                    result = 0;
                    break;
                case DialogResult.Cancel:
                    result = 0;
                    break;
                case DialogResult.Abort:
                    result = 0;
                    break;
                case DialogResult.Retry:
                    result = 1;
                    break;
                case DialogResult.Ignore:
                    result = 2;
                    break;
                default:
                    result = -1;
                    break;
            }

            return result;
        }

        /// <summary>
        /// Show() - Method to show a specific dialog. Overloaded method.
        /// </summary>
        /// <returns>
        /// @return int value => -1 = unknown, 0 = No/Cancel/Abort, 1 = Ok/Yes/Retry, 2 = Ignore.
        /// </returns>

        public int Show(string message, string title, int button, int type)
        {
            DialogResult dialogResult;

            MessageBoxButtons b;
            MessageBoxIcon icon;

            switch (button)
            {
                case 0:
                    b = MessageBoxButtons.OK;
                    break;
                case 1:
                    b = MessageBoxButtons.YesNo;
                    break;
                case 2:
                    b = MessageBoxButtons.OKCancel;
                    break;
                case 3:
                    b = MessageBoxButtons.YesNoCancel;
                    break;
                case 4:
                    b = MessageBoxButtons.AbortRetryIgnore;
                    break;
                case 5:
                    b = MessageBoxButtons.RetryCancel;
                    break;
                default:
                    b = MessageBoxButtons.OK;
                    break;
            }

            switch (type)
            {
                case 0:
                    icon = MessageBoxIcon.None;
                    break;
                case 1:
                    icon = MessageBoxIcon.Information;
                    break;
                case 2:
                    icon = MessageBoxIcon.Warning;
                    break;
                case 3:
                    icon = MessageBoxIcon.Error;
                    break;
                case 4:
                    icon = MessageBoxIcon.Exclamation;
                    break;
                case 5:
                    icon = MessageBoxIcon.Stop;
                    break;
                case 6:
                    icon = MessageBoxIcon.Question;
                    break;
                case 7:
                    icon = MessageBoxIcon.Asterisk;
                    break;
                default:
                    icon = MessageBoxIcon.None;
                    break;
            }

            dialogResult = MessageBox.Show(message, title, b, icon);

            int result = -1;

            switch (dialogResult)
            {
                case DialogResult.OK:
                    result = 1;
                    break;
                case DialogResult.Yes:
                    result = 1;
                    break;
                case DialogResult.No:
                    result = 0;
                    break;
                case DialogResult.Cancel:
                    result = 0;
                    break;
                case DialogResult.Abort:
                    result = 0;
                    break;
                case DialogResult.Retry:
                    result = 1;
                    break;
                case DialogResult.Ignore:
                    result = 2;
                    break;
                default:
                    result = -1;
                    break;
            }

            return result;
        }

    }
}