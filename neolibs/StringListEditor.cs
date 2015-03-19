using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sema.Extensions;

namespace Sema.Dialogs
{
    /// <summary>
    /// Stringlist Editor form
    /// </summary>
    public partial class StringListEditor : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public StringListEditor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Stringlist (List to edit)
        /// </summary>
        public List<string> StringList { get; set; }

        /// <summary>
        /// Show form to edit list of strings
        /// </summary>
        /// <param name="title">Title of the dialog</param>
        /// <param name="s">List of strings to edit</param>
        /// <returns>DialogResult</returns>
        public System.Windows.Forms.DialogResult EditStrings(string title, List<string> s)
        {
            this.Text = title;
            StringList = s;
            UpdateList();
            return ShowDialog();
        }

        /// <summary>
        /// update the list being displayed
        /// </summary>
        public void UpdateList()
        {
            listViewStrings.ShowStringList(StringList);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string tempstr = "New Tag Type";

            GenericTextEntry gte = new GenericTextEntry();
            if (gte.ShowTextEntry("Add new","Type text:",tempstr) == System.Windows.Forms.DialogResult.OK)
            {
                StringList.Add(gte.EditString);
            }
            UpdateList();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem lvi in listViewStrings.Items)
            {
                if (lvi.Selected)
                {
                    StringList.Remove(lvi.SubItems[1].Text);
                }
            }
            UpdateList();
        }

        private void buttonMoveUp_Click(object sender, EventArgs e)
        {

        }

        private void buttonMoveDown_Click(object sender, EventArgs e)
        {

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
