namespace OpenPhotoViewer.UI
{
    partial class MainForm
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
            this.ImageBox = new OpenPhotoViewer.UI.Controls.ImageBox.ImageBox();
            this.Left = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImageBox
            // 
            this.ImageBox.AllowUnfocusedMouseWheel = true;
            this.ImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ImageBox.HorizontalScrollBarStyle = OpenPhotoViewer.UI.Controls.ImageBox.ImageBoxScrollBarStyle.Hide;
            this.ImageBox.Location = new System.Drawing.Point(12, 12);
            this.ImageBox.MaxFitZoom = 100;
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(776, 374);
            this.ImageBox.SizeMode = OpenPhotoViewer.UI.Controls.ImageBox.ImageBoxSizeMode.Fit;
            this.ImageBox.TabIndex = 0;
            this.ImageBox.Text = "Loading...";
            this.ImageBox.VerticalScrollBarStyle = OpenPhotoViewer.UI.Controls.ImageBox.ImageBoxScrollBarStyle.Hide;
            this.ImageBox.Zoomed += new System.EventHandler<OpenPhotoViewer.UI.Controls.ImageBox.ImageBoxZoomEventArgs>(this.ImageBox_Zoomed);
            this.ImageBox.SizeChanged += new System.EventHandler(this.ImageBox_SizeChanged);
            // 
            // Left
            // 
            this.Left.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Left.Location = new System.Drawing.Point(320, 392);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(75, 54);
            this.Left.TabIndex = 1;
            this.Left.Text = "<";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Right
            // 
            this.Right.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Right.Location = new System.Drawing.Point(401, 392);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(75, 54);
            this.Right.TabIndex = 2;
            this.Right.Text = ">";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.ImageBox);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Open Photo Viewer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ImageBox.ImageBox ImageBox;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Right;
    }
}

