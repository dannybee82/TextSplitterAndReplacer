using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextSplitterAndReplacer.ApplicationMethods;
using TextSplitterAndReplacer.CommonMethods;

namespace TextSplitterAndReplacer
{
    public partial class Form1 : Form
    {
        /// <value>
        /// splitOrReplaceText = Methods for spliting, replacing and testing Regular Expression.
        /// </value>

        private SplitOrReplaceText splitOrReplaceText = new();

        /// <summary>
        /// Fomr() - No-arg Class constructor.
        /// </summary>

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// GetOutput() - Method to get the output -> split or replace.
        /// </summary>
        /// <param name="splitText">When true, then split the text. When false, then replace the text.</param>
        /// <returns></returns>

        private string[] GetOutput(bool splitText, bool removeEmptyLines)
        {
            string[] output;

            if (splitText)
            {
                //Split text.
                output = splitOrReplaceText.SplitText(ta_input.Text, tb_char_or_regex.Text, cb_use_regex.Checked);
            }
            else
            {
                //Replace text.
                output = splitOrReplaceText.ReplaceText(ta_input.Text, tb_char_or_regex.Text, tb_replace_text.Text, cb_use_regex.Checked);
            }

            if (removeEmptyLines)
            {
                output = RemoveEmptyElements(output);
            }

            return output;
        }

        /// <summary>
        /// IsEnteredRegExValid() - Tests entered Regular Expression for validity.
        /// </summary>
        /// <param name="isRegex"></param>
        /// <param name="regex"></param>
        /// <returns></returns>

        private bool IsEnteredRegExValid(bool isRegex, string regex)
        {
            if (isRegex)
            {
                bool isValidRegex = this.splitOrReplaceText.IsValidRegex(regex);

                if(!isValidRegex)
                {
                    this.l_char_or_regex.ForeColor = Color.Red;
                    ShowMessageBoxWithError("Regex is invalid.", "Error");
                }

                return isValidRegex;
            }

            //Return true, when not using RegEx -> no test needed.
            return true;
        }

        /// <summary>
        /// IsSplitCharacterValid() - This method tests if the split character is valid/not empty.
        /// </summary>
        /// <param name="s"></param>
        /// <returns>return !isNullOrEmpty;</returns>

        private bool IsSplitCharacterValid(string s)
        {
            CommonStringMethods commonStringMethods = new();
            bool isNullOrEmpty = commonStringMethods.IsStringNullOrEmpty(s);

            if(isNullOrEmpty)
            {
                this.l_char_or_regex.ForeColor = Color.Red;
                ShowMessageBoxWithError("Character or Regex is empty.", "Error");
            }

            return !isNullOrEmpty;
        }

        /// <summary>
        /// showMessageBoxWithError()
        /// </summary>
        private void ShowMessageBoxWithError(String message, String title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// showData() - Shows data in Textbox.
        /// </summary>

        private void ShowData(String[] arr)
        {
            ta_output.Clear();

            if (arr == null)
            {
                ta_output.AppendText("Nothing to show.");
            } 
            else 
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    ta_output.AppendText(arr[i]);

                    if (i - 1 < arr.Length)
                    {
                        ta_output.AppendText(text: Environment.NewLine);
                    }
                }
            }
        }

        /// <summary>
        /// RemoveEmptyElements() - This method removes empty elements from string[] arr.
        /// </summary>
       
        private string[] RemoveEmptyElements(string[] arr)
        {
            List<String> cleared = new List<String>();

            for(int i = 0; i < arr.Length; i++)
            {
                if (!arr[i].Equals(""))
                {
                    cleared.Add(arr[i]);
                }
            }

            return cleared.ToArray();
        }


        /// <summary>
        /// btn_execute_Click() - Action Event method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btn_execute_Click(object sender, EventArgs e)
        {
            if (IsSplitCharacterValid(tb_char_or_regex.Text) && IsEnteredRegExValid(cb_use_regex.Checked, this.tb_char_or_regex.Text))
            {
                string[] data = GetOutput(rb_split_text.Checked, cb_remove_empty_lines.Checked);
                ShowData(data);

                //Below: set label color black when process is finished.
                this.l_char_or_regex.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// rb_split_text_CheckedChanged() - Changed Event method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void rb_split_text_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_split_text.Checked)
            {
                tb_replace_text.Enabled = false;
                cb_use_regex.Checked = false;
            }
        }

        /// <summary>
        /// rb_replace_text_CheckedChanged() - Changed Event method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void rb_replace_text_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_replace_text.Checked)
            {
                tb_replace_text.Enabled = true;
                cb_use_regex.Checked = true;
            }
        }
    }
}
