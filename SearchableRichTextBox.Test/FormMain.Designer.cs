namespace SearchableRichTextBox.Test
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBeginSearch = new System.Windows.Forms.Button();
            this.txtSearchTextbox = new System.Windows.Forms.SearchableRichTextBox();
            this.btnHideSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Press CTRL + F to show the search dialog";
            // 
            // btnBeginSearch
            // 
            this.btnBeginSearch.Location = new System.Drawing.Point(461, 8);
            this.btnBeginSearch.Name = "btnBeginSearch";
            this.btnBeginSearch.Size = new System.Drawing.Size(115, 23);
            this.btnBeginSearch.TabIndex = 2;
            this.btnBeginSearch.Text = "Show Search";
            this.btnBeginSearch.UseVisualStyleBackColor = true;
            this.btnBeginSearch.Click += new System.EventHandler(this.btnBeginSearch_Click);
            // 
            // txtSearchTextbox
            // 
            this.txtSearchTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchTextbox.HideSelection = false;
            this.txtSearchTextbox.Location = new System.Drawing.Point(12, 45);
            this.txtSearchTextbox.Name = "txtSearchTextbox";
            this.txtSearchTextbox.Size = new System.Drawing.Size(725, 513);
            this.txtSearchTextbox.TabIndex = 0;
            this.txtSearchTextbox.Text = resources.GetString("txtSearchTextbox.Text");
            // 
            // btnHideSearch
            // 
            this.btnHideSearch.Location = new System.Drawing.Point(582, 8);
            this.btnHideSearch.Name = "btnHideSearch";
            this.btnHideSearch.Size = new System.Drawing.Size(103, 23);
            this.btnHideSearch.TabIndex = 3;
            this.btnHideSearch.Text = "Hide Search";
            this.btnHideSearch.UseVisualStyleBackColor = true;
            this.btnHideSearch.Click += new System.EventHandler(this.btnHideSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(282, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(173, 20);
            this.txtSearch.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 570);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnHideSearch);
            this.Controls.Add(this.btnBeginSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchTextbox);
            this.Name = "FormMain";
            this.Text = "Searchable Richtextbox Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBeginSearch;
        private System.Windows.Forms.Button btnHideSearch;
        private System.Windows.Forms.SearchableRichTextBox txtSearchTextbox;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

