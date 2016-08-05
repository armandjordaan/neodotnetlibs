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
    /// Generic list selection form
    /// </summary>
    public partial class GenericListSelectionForm : Form
    {
        /// <summary>
        /// constructor
        /// </summary>
        public GenericListSelectionForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// clear the list
        /// </summary>
        public void ClearList()
        {
            lbMainListBox.Items.Clear();
        }

        /// <summary>
        /// add to the list
        /// </summary>
        /// <param name="s"></param>
        public void AddToList(string s)
        {
            lbMainListBox.Items.Add(s);
        }

        /// <summary>
        /// return the selected item (string)
        /// </summary>
        /// <returns>string method</returns>
        public string GetSelected()
        {
            object sel = lbMainListBox.SelectedItem;

            if (sel != null)
            {
                if (sel is string)
                {
                    return sel as string;
                }
            }

            return "";
        }
    }
}
