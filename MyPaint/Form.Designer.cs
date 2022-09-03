namespace MyPaint
{
    partial class PaintApplication
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintApplication));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripPalleteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLineWidthLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLineWidthTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripCurveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLineButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSquareButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripEllipseButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripFillColorButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPalleteButton,
            this.toolStripLineWidthLabel,
            this.toolStripLineWidthTextBox,
            this.toolStripSeparator2,
            this.toolStripCurveButton,
            this.toolStripLineButton,
            this.toolStripSquareButton,
            this.toolStripEllipseButton,
            this.toolStripFillColorButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(98, 561);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripPalleteButton
            // 
            this.toolStripPalleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPalleteButton.Image = global::MyPaint.Properties.Resources.palette;
            this.toolStripPalleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPalleteButton.Name = "toolStripPalleteButton";
            this.toolStripPalleteButton.Size = new System.Drawing.Size(93, 28);
            this.toolStripPalleteButton.Text = "Pallete";
            this.toolStripPalleteButton.Click += new System.EventHandler(this.toolStripPalleteButton_Click);
            // 
            // toolStripLineWidthLabel
            // 
            this.toolStripLineWidthLabel.Name = "toolStripLineWidthLabel";
            this.toolStripLineWidthLabel.Size = new System.Drawing.Size(93, 25);
            this.toolStripLineWidthLabel.Text = "Line width:";
            // 
            // toolStripLineWidthTextBox
            // 
            this.toolStripLineWidthTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripLineWidthTextBox.Name = "toolStripLineWidthTextBox";
            this.toolStripLineWidthTextBox.Size = new System.Drawing.Size(89, 31);
            this.toolStripLineWidthTextBox.ToolTipText = "Line width\r\nIf equal to zero or empty, then it will be equal to 1";
            this.toolStripLineWidthTextBox.TextChanged += new System.EventHandler(this.toolStripLineWidthTextBox_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(93, 6);
            // 
            // toolStripCurveButton
            // 
            this.toolStripCurveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCurveButton.Image = global::MyPaint.Properties.Resources.curve;
            this.toolStripCurveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCurveButton.Name = "toolStripCurveButton";
            this.toolStripCurveButton.Size = new System.Drawing.Size(93, 28);
            this.toolStripCurveButton.Text = "Curve";
            this.toolStripCurveButton.Click += new System.EventHandler(this.toolStripCurveButton_Click);
            // 
            // toolStripLineButton
            // 
            this.toolStripLineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLineButton.Image = global::MyPaint.Properties.Resources.line;
            this.toolStripLineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLineButton.Name = "toolStripLineButton";
            this.toolStripLineButton.Size = new System.Drawing.Size(93, 28);
            this.toolStripLineButton.Text = "Line";
            this.toolStripLineButton.Click += new System.EventHandler(this.toolStripLineButton_Click);
            // 
            // toolStripSquareButton
            // 
            this.toolStripSquareButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSquareButton.Image = global::MyPaint.Properties.Resources.square;
            this.toolStripSquareButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSquareButton.Name = "toolStripSquareButton";
            this.toolStripSquareButton.Size = new System.Drawing.Size(93, 28);
            this.toolStripSquareButton.Text = "Square";
            this.toolStripSquareButton.Click += new System.EventHandler(this.toolStripSquareButton_Click);
            // 
            // toolStripEllipseButton
            // 
            this.toolStripEllipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripEllipseButton.Image = global::MyPaint.Properties.Resources.ellipse;
            this.toolStripEllipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEllipseButton.Name = "toolStripEllipseButton";
            this.toolStripEllipseButton.Size = new System.Drawing.Size(93, 28);
            this.toolStripEllipseButton.Text = "Ellipse";
            this.toolStripEllipseButton.Click += new System.EventHandler(this.toolStripEllipseButton_Click);
            // 
            // toolStripFillColorButton
            // 
            this.toolStripFillColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripFillColorButton.Image = global::MyPaint.Properties.Resources.fillColor;
            this.toolStripFillColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFillColorButton.Name = "toolStripFillColorButton";
            this.toolStripFillColorButton.Size = new System.Drawing.Size(93, 28);
            this.toolStripFillColorButton.Text = "Fill color";
            this.toolStripFillColorButton.Click += new System.EventHandler(this.toolStripFillColorButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1058, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Canvas.Location = new System.Drawing.Point(3, 3);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(958, 561);
            this.Canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Canvas.TabIndex = 4;
            this.Canvas.TabStop = false;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // colorDialog
            // 
            this.colorDialog.FullOpen = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "PNG |*.png";
            this.saveFileDialog.Title = "Save Picture";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "PNG |*.png";
            this.openFileDialog.Title = "Open Picture";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.Canvas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(98, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 561);
            this.panel1.TabIndex = 5;
            // 
            // PaintApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1058, 594);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PaintApplication";
            this.Text = "MyPaint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripPalleteButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripCurveButton;
        private System.Windows.Forms.ToolStripButton toolStripLineButton;
        private System.Windows.Forms.ToolStripButton toolStripSquareButton;
        private System.Windows.Forms.ToolStripButton toolStripEllipseButton;
        private System.Windows.Forms.ToolStripLabel toolStripLineWidthLabel;
        private System.Windows.Forms.ToolStripTextBox toolStripLineWidthTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton toolStripFillColorButton;
    }
}

