namespace Doyohim_DictionaryProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.examBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lexicalRelBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.defBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.wordLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.displayWord = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.displayBox = new System.Windows.Forms.RichTextBox();
            this.functionName = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.examBtn);
            this.panel1.Controls.Add(this.lexicalRelBtn);
            this.panel1.Controls.Add(this.defBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 513);
            this.panel1.TabIndex = 0;
            // 
            // clearBtn
            // 
            this.clearBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.clearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearBtn.BorderRadius = 0;
            this.clearBtn.ButtonText = "Clear";
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.DisabledColor = System.Drawing.Color.Gray;
            this.clearBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.clearBtn.Iconimage = null;
            this.clearBtn.Iconimage_right = null;
            this.clearBtn.Iconimage_right_Selected = null;
            this.clearBtn.Iconimage_Selected = null;
            this.clearBtn.IconMarginLeft = 0;
            this.clearBtn.IconMarginRight = 0;
            this.clearBtn.IconRightVisible = true;
            this.clearBtn.IconRightZoom = 0D;
            this.clearBtn.IconVisible = true;
            this.clearBtn.IconZoom = 90D;
            this.clearBtn.IsTab = false;
            this.clearBtn.Location = new System.Drawing.Point(46, 439);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.clearBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.clearBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.clearBtn.selected = false;
            this.clearBtn.Size = new System.Drawing.Size(158, 33);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clearBtn.Textcolor = System.Drawing.Color.White;
            this.clearBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBtn.BorderRadius = 0;
            this.searchBtn.ButtonText = "Search";
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.DisabledColor = System.Drawing.Color.Gray;
            this.searchBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.searchBtn.Iconimage = null;
            this.searchBtn.Iconimage_right = null;
            this.searchBtn.Iconimage_right_Selected = null;
            this.searchBtn.Iconimage_Selected = null;
            this.searchBtn.IconMarginLeft = 0;
            this.searchBtn.IconMarginRight = 0;
            this.searchBtn.IconRightVisible = true;
            this.searchBtn.IconRightZoom = 0D;
            this.searchBtn.IconVisible = true;
            this.searchBtn.IconZoom = 90D;
            this.searchBtn.IsTab = false;
            this.searchBtn.Location = new System.Drawing.Point(76, 111);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.searchBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.searchBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.searchBtn.selected = false;
            this.searchBtn.Size = new System.Drawing.Size(108, 40);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchBtn.Textcolor = System.Drawing.Color.White;
            this.searchBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.BorderColor = System.Drawing.Color.SeaGreen;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(12, 57);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(234, 48);
            this.searchBox.TabIndex = 4;
            // 
            // examBtn
            // 
            this.examBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.examBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.examBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.examBtn.BorderRadius = 0;
            this.examBtn.ButtonText = "Example";
            this.examBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.examBtn.DisabledColor = System.Drawing.Color.Gray;
            this.examBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.examBtn.Iconimage = null;
            this.examBtn.Iconimage_right = null;
            this.examBtn.Iconimage_right_Selected = null;
            this.examBtn.Iconimage_Selected = null;
            this.examBtn.IconMarginLeft = 0;
            this.examBtn.IconMarginRight = 0;
            this.examBtn.IconRightVisible = true;
            this.examBtn.IconRightZoom = 0D;
            this.examBtn.IconVisible = true;
            this.examBtn.IconZoom = 90D;
            this.examBtn.IsTab = false;
            this.examBtn.Location = new System.Drawing.Point(36, 358);
            this.examBtn.Name = "examBtn";
            this.examBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.examBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.examBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.examBtn.selected = false;
            this.examBtn.Size = new System.Drawing.Size(179, 47);
            this.examBtn.TabIndex = 2;
            this.examBtn.Text = "Example";
            this.examBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.examBtn.Textcolor = System.Drawing.Color.White;
            this.examBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examBtn.Click += new System.EventHandler(this.examBtn_Click);
            // 
            // lexicalRelBtn
            // 
            this.lexicalRelBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.lexicalRelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.lexicalRelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lexicalRelBtn.BorderRadius = 0;
            this.lexicalRelBtn.ButtonText = "Lexical Relationship (Synonym Antonym)";
            this.lexicalRelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lexicalRelBtn.DisabledColor = System.Drawing.Color.Gray;
            this.lexicalRelBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.lexicalRelBtn.Iconimage = null;
            this.lexicalRelBtn.Iconimage_right = null;
            this.lexicalRelBtn.Iconimage_right_Selected = null;
            this.lexicalRelBtn.Iconimage_Selected = null;
            this.lexicalRelBtn.IconMarginLeft = 0;
            this.lexicalRelBtn.IconMarginRight = 0;
            this.lexicalRelBtn.IconRightVisible = true;
            this.lexicalRelBtn.IconRightZoom = 0D;
            this.lexicalRelBtn.IconVisible = true;
            this.lexicalRelBtn.IconZoom = 90D;
            this.lexicalRelBtn.IsTab = false;
            this.lexicalRelBtn.Location = new System.Drawing.Point(36, 285);
            this.lexicalRelBtn.Name = "lexicalRelBtn";
            this.lexicalRelBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.lexicalRelBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.lexicalRelBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.lexicalRelBtn.selected = false;
            this.lexicalRelBtn.Size = new System.Drawing.Size(179, 57);
            this.lexicalRelBtn.TabIndex = 1;
            this.lexicalRelBtn.Text = "Lexical Relationship (Synonym Antonym)";
            this.lexicalRelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lexicalRelBtn.Textcolor = System.Drawing.Color.White;
            this.lexicalRelBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lexicalRelBtn.Click += new System.EventHandler(this.lexicalRelBtn_Click);
            // 
            // defBtn
            // 
            this.defBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.defBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.defBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.defBtn.BorderRadius = 0;
            this.defBtn.ButtonText = "Definition";
            this.defBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.defBtn.DisabledColor = System.Drawing.Color.Gray;
            this.defBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.defBtn.Iconimage = null;
            this.defBtn.Iconimage_right = null;
            this.defBtn.Iconimage_right_Selected = null;
            this.defBtn.Iconimage_Selected = null;
            this.defBtn.IconMarginLeft = 0;
            this.defBtn.IconMarginRight = 0;
            this.defBtn.IconRightVisible = true;
            this.defBtn.IconRightZoom = 0D;
            this.defBtn.IconVisible = true;
            this.defBtn.IconZoom = 90D;
            this.defBtn.IsTab = false;
            this.defBtn.Location = new System.Drawing.Point(36, 222);
            this.defBtn.Name = "defBtn";
            this.defBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.defBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.defBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.defBtn.selected = false;
            this.defBtn.Size = new System.Drawing.Size(179, 48);
            this.defBtn.TabIndex = 0;
            this.defBtn.Text = "Definition";
            this.defBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.defBtn.Textcolor = System.Drawing.Color.White;
            this.defBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defBtn.Click += new System.EventHandler(this.defBtn_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(173)))), ((int)(((byte)(155)))));
            this.exit.Image = global::Doyohim_DictionaryProject.Properties.Resources.icons8_exit_48;
            this.exit.ImageActive = null;
            this.exit.Location = new System.Drawing.Point(771, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(48, 32);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 2;
            this.exit.TabStop = false;
            this.exit.Zoom = 10;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Location = new System.Drawing.Point(423, 57);
            this.wordLabel.MaximumSize = new System.Drawing.Size(20, 20);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(0, 13);
            this.wordLabel.TabIndex = 3;
            this.wordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayWord
            // 
            this.displayWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.displayWord.BorderColor = System.Drawing.Color.SeaGreen;
            this.displayWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayWord.Location = new System.Drawing.Point(414, 40);
            this.displayWord.Multiline = true;
            this.displayWord.Name = "displayWord";
            this.displayWord.ReadOnly = true;
            this.displayWord.Size = new System.Drawing.Size(289, 43);
            this.displayWord.TabIndex = 4;
            this.displayWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // displayBox
            // 
            this.displayBox.Location = new System.Drawing.Point(302, 134);
            this.displayBox.Name = "displayBox";
            this.displayBox.ReadOnly = true;
            this.displayBox.Size = new System.Drawing.Size(488, 366);
            this.displayBox.TabIndex = 5;
            this.displayBox.Text = "";
            // 
            // functionName
            // 
            this.functionName.AutoSize = true;
            this.functionName.Location = new System.Drawing.Point(311, 109);
            this.functionName.Name = "functionName";
            this.functionName.Size = new System.Drawing.Size(0, 13);
            this.functionName.TabIndex = 6;
            this.functionName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(173)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(818, 512);
            this.Controls.Add(this.functionName);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.displayWord);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton defBtn;
        private Bunifu.Framework.UI.BunifuFlatButton examBtn;
        private Bunifu.Framework.UI.BunifuFlatButton lexicalRelBtn;
        private Bunifu.Framework.UI.BunifuImageButton exit;
        private Bunifu.Framework.UI.BunifuFlatButton searchBtn;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox searchBox;
        private Bunifu.Framework.UI.BunifuCustomLabel wordLabel;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox displayWord;
        private System.Windows.Forms.RichTextBox displayBox;
        private Bunifu.Framework.UI.BunifuFlatButton clearBtn;
        private System.Windows.Forms.Label functionName;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

