using System;
using System.Drawing;
using System.Windows.Forms;

namespace System.Windows.Forms
{
    /// <summary>
    /// A windows form control for search dialog functionality
    /// </summary>
    internal partial class FormSearchDialog : Form
    {
        #region Members

        private readonly SearchableRichTextBox _Owner;

        #endregion

        #region Initialization

        /// <summary>
        /// Initialize a new instance of this class with the provided <see cref="SearchableRichTextBox"/>
        /// </summary>
        public FormSearchDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialize a new instance of this class with the provided <see cref="SearchableRichTextBox"/>
        /// </summary>
        /// <param name="owner">The <see cref="SearchableRichTextBox"/> control which search will be applied on</param>
        public FormSearchDialog(SearchableRichTextBox owner) : this()
        {
            _Owner = owner;

            var ownerForm = _Owner.FindForm();
            if (ownerForm != null)
            {
                Owner = ownerForm;
            }
            else
            {
                TopMost = true;
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Initialize control with the given search text
        /// </summary>
        /// <param name="searchText">The search text</param>
        public void Show(string searchText)
        {
            txtSearchText.Text = searchText;
            Show();
            txtSearchText.Select(searchText.Length, 0);
            txtSearchText.Focus();
        }

        /// <summary>
        /// Applies search operation
        /// </summary>
        public void Find()
        {
            var text = _Owner.Text;
            if (string.IsNullOrEmpty(text))
            {
                return;
            }
            var flags = RichTextBoxFinds.None;
            foreach (var ctrl in Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox chkBox = ctrl as CheckBox;
                    if (chkBox.Checked) {
                        flags |= (RichTextBoxFinds)Convert.ToInt32(chkBox.Tag);
                    }
                }
            }
            var start = _Owner.SelectionStart + _Owner.SelectionLength;
            var index = _Owner.Find(txtSearchText.Text, start, flags);
            if (index < 0)
            {
                lblResult.Text = "No item found";
            }
            else
            {
                var point = _Owner.GetPositionFromCharIndex(index);
                point = _Owner.PointToScreen(point);
                if (Bounds.Contains(point))
                {
                    Location = new Point(Location.X, point.Y + 30);
                    point = btnFind.Location;
                    point.Offset(5, 5);
                    Cursor.Position = PointToScreen(point);
                }
                var line = _Owner.GetLineFromCharIndex(index) + 1;
                lblResult.Text = string.Format("Item founded at, Line: {0}, CharIndex: {1}", line, index);
            }
        }

        #endregion

        #region Protected Methods

        /// <inheritdoc />
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            Opacity = 1f;
        }

        /// <inheritdoc />
        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            if (Visible)
            {
                Opacity = .7f;
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Handles find button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            Find();
        }

        /// <summary>
        /// Handles Close button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        #endregion
    }
}
