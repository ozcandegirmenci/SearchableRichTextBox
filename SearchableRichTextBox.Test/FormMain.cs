using System;
using System.Windows.Forms;

namespace SearchableRichTextBox.Test
{
    /// <summary>
    /// Test application main form
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// Initialize a new instance of this class
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Shows search dialog with the written search term
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBeginSearch_Click(object sender, EventArgs e)
        {
            txtSearchTextbox.ShowSearchDialog(txtSearch.Text);
        }

        /// <summary>
        /// Hides search dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHideSearch_Click(object sender, EventArgs e)
        {
            txtSearchTextbox.HideSearchDialog();
        }
    }
}
