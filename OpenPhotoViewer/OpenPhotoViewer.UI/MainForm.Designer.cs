using OpenPhotoViewer.UI.Controls;

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
            this.LeftButton = new OpenPhotoViewer.UI.Controls.CustomButton();
            this.RightButton = new OpenPhotoViewer.UI.Controls.CustomButton();
            this.GridSwitch = new OpenPhotoViewer.UI.Controls.CustomButtonSwitch();
            this.FitToWindowButton = new OpenPhotoViewer.UI.Controls.CustomDisableButton();
            this.ImageBox = new OpenPhotoViewer.UI.Controls.ImageBox.ImageBox();
            this.GrayGradientPanel = new OpenPhotoViewer.UI.Controls.GrayGradientPanel();
            this.ActualSizeButton = new OpenPhotoViewer.UI.Controls.CustomButton();
            this.GrayGradientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftButton
            // 
            this.LeftButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LeftButton.BackColor = System.Drawing.Color.Transparent;
            this.LeftButton.ClickImage = global::OpenPhotoViewer.UI.Properties.Resources.Left;
            this.LeftButton.FlatAppearance.BorderSize = 0;
            this.LeftButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LeftButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftButton.HoverImage = global::OpenPhotoViewer.UI.Properties.Resources.LeftHover;
            this.LeftButton.Image = global::OpenPhotoViewer.UI.Properties.Resources.Left;
            this.LeftButton.Location = new System.Drawing.Point(320, 21);
            this.LeftButton.MainImage = global::OpenPhotoViewer.UI.Properties.Resources.Left;
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(75, 64);
            this.LeftButton.TabIndex = 1;
            this.LeftButton.UseVisualStyleBackColor = false;
            this.LeftButton.Click += new System.EventHandler(this.Left_Click);
            // 
            // RightButton
            // 
            this.RightButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RightButton.BackColor = System.Drawing.Color.Transparent;
            this.RightButton.ClickImage = global::OpenPhotoViewer.UI.Properties.Resources.Right;
            this.RightButton.FlatAppearance.BorderSize = 0;
            this.RightButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RightButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightButton.HoverImage = global::OpenPhotoViewer.UI.Properties.Resources.RightHover;
            this.RightButton.Image = global::OpenPhotoViewer.UI.Properties.Resources.Right;
            this.RightButton.Location = new System.Drawing.Point(401, 21);
            this.RightButton.MainImage = global::OpenPhotoViewer.UI.Properties.Resources.Right;
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(75, 64);
            this.RightButton.TabIndex = 2;
            this.RightButton.UseVisualStyleBackColor = false;
            this.RightButton.Click += new System.EventHandler(this.Right_Click);
            // 
            // GridSwitch
            // 
            this.GridSwitch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GridSwitch.Appearance = System.Windows.Forms.Appearance.Button;
            this.GridSwitch.BackColor = System.Drawing.Color.Transparent;
            this.GridSwitch.ClickImage = global::OpenPhotoViewer.UI.Properties.Resources.Checkers;
            this.GridSwitch.FlatAppearance.BorderSize = 0;
            this.GridSwitch.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.GridSwitch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GridSwitch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GridSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GridSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridSwitch.HoverImage = global::OpenPhotoViewer.UI.Properties.Resources.CheckersHover;
            this.GridSwitch.Image = global::OpenPhotoViewer.UI.Properties.Resources.Checkers;
            this.GridSwitch.Location = new System.Drawing.Point(482, 21);
            this.GridSwitch.MainImage = global::OpenPhotoViewer.UI.Properties.Resources.Checkers;
            this.GridSwitch.Name = "GridSwitch";
            this.GridSwitch.Size = new System.Drawing.Size(69, 64);
            this.GridSwitch.TabIndex = 3;
            this.GridSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GridSwitch.UseVisualStyleBackColor = false;
            this.GridSwitch.CheckedChanged += new System.EventHandler(this.GridSwitch_CheckedChanged);
            // 
            // FitToWindowButton
            // 
            this.FitToWindowButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FitToWindowButton.BackColor = System.Drawing.Color.Transparent;
            this.FitToWindowButton.ClickImage = global::OpenPhotoViewer.UI.Properties.Resources.Fit;
            this.FitToWindowButton.DisabledImage = global::OpenPhotoViewer.UI.Properties.Resources.FitDisabled;
            this.FitToWindowButton.FlatAppearance.BorderSize = 0;
            this.FitToWindowButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FitToWindowButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FitToWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FitToWindowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FitToWindowButton.HoverImage = global::OpenPhotoViewer.UI.Properties.Resources.FitHover;
            this.FitToWindowButton.Image = global::OpenPhotoViewer.UI.Properties.Resources.Fit;
            this.FitToWindowButton.Location = new System.Drawing.Point(239, 21);
            this.FitToWindowButton.MainImage = global::OpenPhotoViewer.UI.Properties.Resources.Fit;
            this.FitToWindowButton.Name = "FitToWindowButton";
            this.FitToWindowButton.Size = new System.Drawing.Size(75, 64);
            this.FitToWindowButton.TabIndex = 4;
            this.FitToWindowButton.UseVisualStyleBackColor = false;
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
            // GrayGradientPanel
            // 
            this.GrayGradientPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.GrayGradientPanel.Angle = 270;
            this.GrayGradientPanel.AngleScales = false;
            this.GrayGradientPanel.Controls.Add(this.FitToWindowButton);
            this.GrayGradientPanel.Controls.Add(this.RightButton);
            this.GrayGradientPanel.Controls.Add(this.GridSwitch);
            this.GrayGradientPanel.Controls.Add(this.ActualSizeButton);
            this.GrayGradientPanel.Controls.Add(this.LeftButton);
            this.GrayGradientPanel.Location = new System.Drawing.Point(0, 365);
            this.GrayGradientPanel.Name = "GrayGradientPanel";
            this.GrayGradientPanel.Size = new System.Drawing.Size(800, 92);
            this.GrayGradientPanel.TabIndex = 5;
            // 
            // ActualSizeButton
            // 
            this.ActualSizeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ActualSizeButton.BackColor = System.Drawing.Color.Transparent;
            this.ActualSizeButton.ClickImage = global::OpenPhotoViewer.UI.Properties.Resources.ActualSize;
            this.ActualSizeButton.FlatAppearance.BorderSize = 0;
            this.ActualSizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ActualSizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ActualSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActualSizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualSizeButton.HoverImage = global::OpenPhotoViewer.UI.Properties.Resources.ActualSizeHover;
            this.ActualSizeButton.Image = global::OpenPhotoViewer.UI.Properties.Resources.ActualSize;
            this.ActualSizeButton.Location = new System.Drawing.Point(239, 21);
            this.ActualSizeButton.MainImage = global::OpenPhotoViewer.UI.Properties.Resources.ActualSize;
            this.ActualSizeButton.Name = "ActualSizeButton";
            this.ActualSizeButton.Size = new System.Drawing.Size(75, 64);
            this.ActualSizeButton.TabIndex = 1;
            this.ActualSizeButton.UseVisualStyleBackColor = false;
            this.ActualSizeButton.Click += new System.EventHandler(this.ActualSizeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.GrayGradientPanel);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(424, 370);
            this.Name = "MainForm";
            this.Text = "Open Photo Viewer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Move += new System.EventHandler(this.MainForm_Move);
            this.GrayGradientPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private OpenPhotoViewer.UI.Controls.CustomButton ActualSizeButton;

        private OpenPhotoViewer.UI.Controls.CustomDisableButton FitToWindowButton;

        private OpenPhotoViewer.UI.Controls.CustomButtonSwitch GridSwitch;

        #endregion

        private OpenPhotoViewer.UI.Controls.ImageBox.ImageBox ImageBox;
        private OpenPhotoViewer.UI.Controls.CustomButton LeftButton;
        private OpenPhotoViewer.UI.Controls.CustomButton RightButton;
        private OpenPhotoViewer.UI.Controls.GrayGradientPanel GrayGradientPanel;
    }
}

