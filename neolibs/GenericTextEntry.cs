using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sema.Dialogs
{
    /// <summary>
    /// generic text entry dialog
    /// </summary>
    public partial class GenericTextEntry : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public GenericTextEntry()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Value of edited string
        /// </summary>
        public string EditString
        {
            get
            {
                return tbEditText.Text;
            }
            set
            {
                tbEditText.Text = value;
            }
        }

        /// <summary>
        /// Show the text entry form
        /// </summary>
        /// <param name="Title">Title of the dialog</param>
        /// <param name="prompt">text prompt to show</param>
        /// <param name="StringToEdit">Value of the string</param>
        /// <returns>DialogResult</returns>
        public System.Windows.Forms.DialogResult ShowTextEntry(string Title, string prompt, string StringToEdit)
        {
            this.Text = Title;
            TextEntryLabel.Text = prompt;
            tbEditText.Text = StringToEdit;

            return ShowDialog();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
