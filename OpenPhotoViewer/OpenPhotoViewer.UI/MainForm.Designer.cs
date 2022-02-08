using OpenPhotoViewer.UI.Controls.GradientPanel;

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
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.GridSwitch = new System.Windows.Forms.CheckBox();
            this.FitToWindowButton = new System.Windows.Forms.Button();
            this.ImageBox = new OpenPhotoViewer.UI.Controls.ImageBox.ImageBox();
            this._bottomGrayGradient = new GrayGradientPanel();
            this.SuspendLayout();
            // 
            // LeftButton
            // 
            this.LeftButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftButton.Location = new System.Drawing.Point(320, 392);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(75, 54);
            this.LeftButton.TabIndex = 1;
            this.LeftButton.Text = "◀";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.Left_Click);
            // 
            // RightButton
            // 
            this.RightButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightButton.Location = new System.Drawing.Point(401, 392);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(75, 54);
            this.RightButton.TabIndex = 2;
            this.RightButton.Text = "▶";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.Right_Click);
            // 
            // GridSwitch
            // 
            this.GridSwitch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GridSwitch.Appearance = System.Windows.Forms.Appearance.Button;
            this.GridSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridSwitch.Location = new System.Drawing.Point(164, 392);
            this.GridSwitch.Name = "GridSwitch";
            this.GridSwitch.Size = new System.Drawing.Size(69, 54);
            this.GridSwitch.TabIndex = 3;
            this.GridSwitch.Text = "▞";
            this.GridSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GridSwitch.UseVisualStyleBackColor = true;
            this.GridSwitch.CheckedChanged += new System.EventHandler(this.GridSwitch_CheckedChanged);
            // 
            // FitToWindowButton
            // 
            this.FitToWindowButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FitToWindowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FitToWindowButton.Location = new System.Drawing.Point(239, 392);
            this.FitToWindowButton.Name = "FitToWindowButton";
            this.FitToWindowButton.Size = new System.Drawing.Size(75, 54);
            this.FitToWindowButton.TabIndex = 4;
            this.FitToWindowButton.Text = "↙";
            this.FitToWindowButton.UseVisualStyleBackColor = true;
            this.FitToWindowButton.Click += new System.EventHandler(this.FitToWindow_Click);
            // 
            // ImageBox
            // 
            this.ImageBox.AllowUnfocusedMouseWheel = true;
            this.ImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.ImageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ImageBox.GridDisplayMode = OpenPhotoViewer.UI.Controls.ImageBox.ImageBoxGridDisplayMode.None;
            this.ImageBox.HorizontalScrollBarStyle = OpenPhotoViewer.UI.Controls.ImageBox.ImageBoxScrollBarStyle.Hide;
            this.ImageBox.Location = new System.Drawing.Point(0, 0);
            this.ImageBox.MaxFitZoom = 100;
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(800, 386);
            this.ImageBox.SizeMode = OpenPhotoViewer.UI.Controls.ImageBox.ImageBoxSizeMode.Fit;
            this.ImageBox.TabIndex = 0;
            this.ImageBox.Text = "Loading...";
            this.ImageBox.VerticalScrollBarStyle = OpenPhotoViewer.UI.Controls.ImageBox.ImageBoxScrollBarStyle.Hide;
            this.ImageBox.SizeModeChanged += new System.EventHandler(this.ImageBox_SizeModeChanged);
            this.ImageBox.Zoomed += new System.EventHandler<OpenPhotoViewer.UI.Controls.ImageBox.ImageBoxZoomEventArgs>(this.ImageBox_Zoomed);
            this.ImageBox.SizeChanged += new System.EventHandler(this.ImageBox_SizeChanged);
            // 
            // _bottomGrayGradient
            // 
            this._bottomGrayGradient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this._bottomGrayGradient.Angle = 270;
            this._bottomGrayGradient.AngleScales = false;
            this._bottomGrayGradient.Location = new System.Drawing.Point(0, 365);
            this._bottomGrayGradient.Name = "_bottomGrayGradient";
            this._bottomGrayGradient.Size = new System.Drawing.Size(800, 92);
            this._bottomGrayGradient.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FitToWindowButton);
            this.Controls.Add(this.GridSwitch);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this._bottomGrayGradient);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(424, 370);
            this.Name = "MainForm";
            this.Text = "Open Photo Viewer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button FitToWindowButton;

        private System.Windows.Forms.CheckBox GridSwitch;

        #endregion

        private OpenPhotoViewer.UI.Controls.ImageBox.ImageBox ImageBox;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RightButton;
        private GrayGradientPanel _bottomGrayGradient;
    }
}

