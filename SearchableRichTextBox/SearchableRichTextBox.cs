using System.Drawing;

namespace System.Windows.Forms
{
    /// <summary>
    /// A richtextbox wrapper control which provides search functionality
    /// </summary>
    public class SearchableRichTextBox : RichTextBox
    {
        #region Members

        private FormSearchDialog _SearchDialog;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the <see cref="FormSearchDialog"/> which provides search functionalty
        /// </summary>
        private FormSearchDialog SearchDialog
        {
            get
            {
                if (_SearchDialog == null)
                {
                    _SearchDialog = new FormSearchDialog(this);
                    var x = (Width - _SearchDialog.Width) / 2;
                    var y = (Height - _SearchDialog.Height) / 2;
                    var point = PointToScreen(new Point(x, y));
                    _SearchDialog.Location = point;
                }
                return _SearchDialog;
            }
        }

        #endregion

        #region Initialization

        /// <summary>
        /// Initialize a new instance of this class
        /// </summary>
        public SearchableRichTextBox()
        {
            HideSelection = false;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Shows search dialog box
        /// </summary>
        /// <remarks>If <see cref="RichTextBox.SelectedText"/> is not <c>null</c>, then it will be set as the search text</remarks>
        public void ShowSearchDialog()
        {
            ShowSearchDialog(SelectedText);
        }

        /// <summary>
        /// Shows search dialog box with the given search text
        /// </summary>
        /// <param name="searchText">The search text</param>
        public void ShowSearchDialog(string searchText)
        {
            SearchDialog.Show(searchText);
        }

        /// <summary>
        /// Hides search dialog box if it is shown
        /// </summary>
        public void HideSearchDialog()
        {
            if (_SearchDialog != null)
            {
                _SearchDialog.Hide();
            }
        }

        #endregion

        #region Protected Methods

        /// <inheritdoc />
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                ShowSearchDialog();
            }
            base.OnKeyDown(e);
        }

        /// <inheritdoc />
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_SearchDialog != null)
                {
                    _SearchDialog.Close();
                    _SearchDialog.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #endregion
    }
}
