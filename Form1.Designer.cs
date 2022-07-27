
namespace TextSplitterAndReplacer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.l_char_or_regex = new System.Windows.Forms.Label();
            this.tb_char_or_regex = new System.Windows.Forms.TextBox();
            this.l_replace_text = new System.Windows.Forms.Label();
            this.tb_replace_text = new System.Windows.Forms.TextBox();
            this.cb_remove_empty_lines = new System.Windows.Forms.CheckBox();
            this.ta_input = new System.Windows.Forms.TextBox();
            this.btn_execute = new System.Windows.Forms.Button();
            this.ta_output = new System.Windows.Forms.TextBox();
            this.cb_use_regex = new System.Windows.Forms.CheckBox();
            this.rb_split_text = new System.Windows.Forms.RadioButton();
            this.rb_replace_text = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // l_char_or_regex
            // 
            this.l_char_or_regex.AutoSize = true;
            this.l_char_or_regex.Location = new System.Drawing.Point(12, 55);
            this.l_char_or_regex.Name = "l_char_or_regex";
            this.l_char_or_regex.Size = new System.Drawing.Size(107, 15);
            this.l_char_or_regex.TabIndex = 2;
            this.l_char_or_regex.Text = "Character or RegEx";
            // 
            // tb_char_or_regex
            // 
            this.tb_char_or_regex.Location = new System.Drawing.Point(127, 52);
            this.tb_char_or_regex.Name = "tb_char_or_regex";
            this.tb_char_or_regex.Size = new System.Drawing.Size(276, 23);
            this.tb_char_or_regex.TabIndex = 3;
            // 
            // l_replace_text
            // 
            this.l_replace_text.AutoSize = true;
            this.l_replace_text.Location = new System.Drawing.Point(12, 113);
            this.l_replace_text.Name = "l_replace_text";
            this.l_replace_text.Size = new System.Drawing.Size(98, 15);
            this.l_replace_text.TabIndex = 4;
            this.l_replace_text.Text = "Replace with Text";
            // 
            // tb_replace_text
            // 
            this.tb_replace_text.Enabled = false;
            this.tb_replace_text.Location = new System.Drawing.Point(127, 110);
            this.tb_replace_text.Name = "tb_replace_text";
            this.tb_replace_text.Size = new System.Drawing.Size(276, 23);
            this.tb_replace_text.TabIndex = 5;
            // 
            // cb_remove_empty_lines
            // 
            this.cb_remove_empty_lines.AutoSize = true;
            this.cb_remove_empty_lines.Location = new System.Drawing.Point(267, 85);
            this.cb_remove_empty_lines.Name = "cb_remove_empty_lines";
            this.cb_remove_empty_lines.Size = new System.Drawing.Size(136, 19);
            this.cb_remove_empty_lines.TabIndex = 6;
            this.cb_remove_empty_lines.Text = "Remove Empty Lines";
            this.cb_remove_empty_lines.UseVisualStyleBackColor = true;
            // 
            // ta_input
            // 
            this.ta_input.Location = new System.Drawing.Point(13, 154);
            this.ta_input.Multiline = true;
            this.ta_input.Name = "ta_input";
            this.ta_input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ta_input.Size = new System.Drawing.Size(390, 188);
            this.ta_input.TabIndex = 7;
            // 
            // btn_execute
            // 
            this.btn_execute.Location = new System.Drawing.Point(176, 360);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(87, 33);
            this.btn_execute.TabIndex = 8;
            this.btn_execute.Text = "Execute";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new System.EventHandler(this.btn_execute_Click);
            // 
            // ta_output
            // 
            this.ta_output.Location = new System.Drawing.Point(12, 413);
            this.ta_output.Multiline = true;
            this.ta_output.Name = "ta_output";
            this.ta_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ta_output.Size = new System.Drawing.Size(391, 211);
            this.ta_output.TabIndex = 9;
            // 
            // cb_use_regex
            // 
            this.cb_use_regex.AutoSize = true;
            this.cb_use_regex.Location = new System.Drawing.Point(12, 85);
            this.cb_use_regex.Name = "cb_use_regex";
            this.cb_use_regex.Size = new System.Drawing.Size(147, 19);
            this.cb_use_regex.TabIndex = 10;
            this.cb_use_regex.Text = "Use Regular Expression";
            this.cb_use_regex.UseVisualStyleBackColor = true;
            // 
            // rb_split_text
            // 
            this.rb_split_text.AutoSize = true;
            this.rb_split_text.Checked = true;
            this.rb_split_text.Location = new System.Drawing.Point(12, 12);
            this.rb_split_text.Name = "rb_split_text";
            this.rb_split_text.Size = new System.Drawing.Size(72, 19);
            this.rb_split_text.TabIndex = 11;
            this.rb_split_text.TabStop = true;
            this.rb_split_text.Text = "Split Text";
            this.rb_split_text.UseVisualStyleBackColor = true;
            this.rb_split_text.CheckedChanged += new System.EventHandler(this.rb_split_text_CheckedChanged);
            // 
            // rb_replace_text
            // 
            this.rb_replace_text.AutoSize = true;
            this.rb_replace_text.Location = new System.Drawing.Point(244, 12);
            this.rb_replace_text.Name = "rb_replace_text";
            this.rb_replace_text.Size = new System.Drawing.Size(159, 19);
            this.rb_replace_text.TabIndex = 12;
            this.rb_replace_text.Text = "Replace Text (with RegEx)";
            this.rb_replace_text.UseVisualStyleBackColor = true;
            this.rb_replace_text.CheckedChanged += new System.EventHandler(this.rb_replace_text_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 636);
            this.Controls.Add(this.rb_replace_text);
            this.Controls.Add(this.rb_split_text);
            this.Controls.Add(this.cb_use_regex);
            this.Controls.Add(this.ta_output);
            this.Controls.Add(this.btn_execute);
            this.Controls.Add(this.ta_input);
            this.Controls.Add(this.cb_remove_empty_lines);
            this.Controls.Add(this.tb_replace_text);
            this.Controls.Add(this.l_replace_text);
            this.Controls.Add(this.tb_char_or_regex);
            this.Controls.Add(this.l_char_or_regex);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Text Splitter and Replacer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label l_char_or_regex;
        private System.Windows.Forms.TextBox tb_char_or_regex;
        private System.Windows.Forms.Label l_replace_text;
        private System.Windows.Forms.TextBox tb_replace_text;
        private System.Windows.Forms.CheckBox cb_remove_empty_lines;
        private System.Windows.Forms.TextBox ta_input;
        private System.Windows.Forms.Button btn_execute;
        private System.Windows.Forms.TextBox ta_output;
        private System.Windows.Forms.CheckBox cb_use_regex;
        private System.Windows.Forms.RadioButton rb_split_text;
        private System.Windows.Forms.RadioButton rb_replace_text;
    }
}

