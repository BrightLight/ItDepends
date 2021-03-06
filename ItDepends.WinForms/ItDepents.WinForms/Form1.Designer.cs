﻿namespace ItDepents.WinForms
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
      Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation planeTransformation1 = new Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.uxGraphViewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.uxStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.uxOpenSolutionButton = new System.Windows.Forms.ToolStripButton();
      this.uxShowBinaryReference = new System.Windows.Forms.ToolStripButton();
      this.uxShowProjectReferences = new System.Windows.Forms.ToolStripButton();
      this.uxShowPackageReferences = new System.Windows.Forms.ToolStripButton();
      this.statusStrip1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // uxGraphViewer
      // 
      this.uxGraphViewer.ArrowheadLength = 10D;
      this.uxGraphViewer.AsyncLayout = false;
      this.uxGraphViewer.AutoScroll = true;
      this.uxGraphViewer.BackwardEnabled = false;
      this.uxGraphViewer.BuildHitTree = true;
      this.uxGraphViewer.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
      this.uxGraphViewer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uxGraphViewer.EdgeInsertButtonVisible = true;
      this.uxGraphViewer.FileName = "";
      this.uxGraphViewer.ForwardEnabled = false;
      this.uxGraphViewer.Graph = null;
      this.uxGraphViewer.InsertingEdge = false;
      this.uxGraphViewer.LayoutAlgorithmSettingsButtonVisible = true;
      this.uxGraphViewer.LayoutEditingEnabled = true;
      this.uxGraphViewer.Location = new System.Drawing.Point(0, 25);
      this.uxGraphViewer.LooseOffsetForRouting = 0.25D;
      this.uxGraphViewer.MouseHitDistance = 0.05D;
      this.uxGraphViewer.Name = "uxGraphViewer";
      this.uxGraphViewer.NavigationVisible = true;
      this.uxGraphViewer.NeedToCalculateLayout = true;
      this.uxGraphViewer.OffsetForRelaxingInRouting = 0.6D;
      this.uxGraphViewer.PaddingForEdgeRouting = 8D;
      this.uxGraphViewer.PanButtonPressed = false;
      this.uxGraphViewer.SaveAsImageEnabled = true;
      this.uxGraphViewer.SaveAsMsaglEnabled = true;
      this.uxGraphViewer.SaveButtonVisible = true;
      this.uxGraphViewer.SaveGraphButtonVisible = true;
      this.uxGraphViewer.SaveInVectorFormatEnabled = true;
      this.uxGraphViewer.Size = new System.Drawing.Size(800, 403);
      this.uxGraphViewer.TabIndex = 0;
      this.uxGraphViewer.TightOffsetForRouting = 0.125D;
      this.uxGraphViewer.ToolBarIsVisible = true;
      this.uxGraphViewer.Transform = planeTransformation1;
      this.uxGraphViewer.UndoRedoButtonsVisible = true;
      this.uxGraphViewer.WindowZoomButtonPressed = false;
      this.uxGraphViewer.ZoomF = 1D;
      this.uxGraphViewer.ZoomWindowThreshold = 0.05D;
      this.uxGraphViewer.ObjectUnderMouseCursorChanged += new System.EventHandler<Microsoft.Msagl.Drawing.ObjectUnderMouseCursorChangedEventArgs>(this.uxGraphViewer_ObjectUnderMouseCursorChanged);
      this.uxGraphViewer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.uxGraphViewer_MouseMove);
      this.uxGraphViewer.Click += new System.EventHandler(this.uxGraphViewer_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxStatusLabel});
      this.statusStrip1.Location = new System.Drawing.Point(0, 428);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(800, 22);
      this.statusStrip1.TabIndex = 1;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // uxStatusLabel
      // 
      this.uxStatusLabel.Name = "uxStatusLabel";
      this.uxStatusLabel.Size = new System.Drawing.Size(118, 17);
      this.uxStatusLabel.Text = "toolStripStatusLabel1";
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpenSolutionButton,
            this.uxShowBinaryReference,
            this.uxShowProjectReferences,
            this.uxShowPackageReferences});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(800, 25);
      this.toolStrip1.TabIndex = 2;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // uxOpenSolutionButton
      // 
      this.uxOpenSolutionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.uxOpenSolutionButton.Image = ((System.Drawing.Image)(resources.GetObject("uxOpenSolutionButton.Image")));
      this.uxOpenSolutionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.uxOpenSolutionButton.Name = "uxOpenSolutionButton";
      this.uxOpenSolutionButton.Size = new System.Drawing.Size(96, 22);
      this.uxOpenSolutionButton.Text = "Open Solution...";
      this.uxOpenSolutionButton.Click += new System.EventHandler(this.uxOpenSolutionButton_Click);
      // 
      // uxShowBinaryReference
      // 
      this.uxShowBinaryReference.Checked = true;
      this.uxShowBinaryReference.CheckOnClick = true;
      this.uxShowBinaryReference.CheckState = System.Windows.Forms.CheckState.Checked;
      this.uxShowBinaryReference.Image = ((System.Drawing.Image)(resources.GetObject("uxShowBinaryReference.Image")));
      this.uxShowBinaryReference.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.uxShowBinaryReference.Name = "uxShowBinaryReference";
      this.uxShowBinaryReference.Size = new System.Drawing.Size(149, 22);
      this.uxShowBinaryReference.Text = "Show binary references";
      this.uxShowBinaryReference.CheckedChanged += new System.EventHandler(this.uxShowReferences_CheckedChanged);
      // 
      // uxShowProjectReferences
      // 
      this.uxShowProjectReferences.Checked = true;
      this.uxShowProjectReferences.CheckOnClick = true;
      this.uxShowProjectReferences.CheckState = System.Windows.Forms.CheckState.Checked;
      this.uxShowProjectReferences.Image = ((System.Drawing.Image)(resources.GetObject("uxShowProjectReferences.Image")));
      this.uxShowProjectReferences.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.uxShowProjectReferences.Name = "uxShowProjectReferences";
      this.uxShowProjectReferences.Size = new System.Drawing.Size(153, 22);
      this.uxShowProjectReferences.Text = "Show project references";
      this.uxShowProjectReferences.CheckedChanged += new System.EventHandler(this.uxShowReferences_CheckedChanged);
      // 
      // uxShowPackageReferences
      // 
      this.uxShowPackageReferences.Checked = true;
      this.uxShowPackageReferences.CheckOnClick = true;
      this.uxShowPackageReferences.CheckState = System.Windows.Forms.CheckState.Checked;
      this.uxShowPackageReferences.Image = ((System.Drawing.Image)(resources.GetObject("uxShowPackageReferences.Image")));
      this.uxShowPackageReferences.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.uxShowPackageReferences.Name = "uxShowPackageReferences";
      this.uxShowPackageReferences.Size = new System.Drawing.Size(160, 22);
      this.uxShowPackageReferences.Text = "Show package references";
      this.uxShowPackageReferences.CheckedChanged += new System.EventHandler(this.uxShowReferences_CheckedChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.uxGraphViewer);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.statusStrip1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Microsoft.Msagl.GraphViewerGdi.GViewer uxGraphViewer;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel uxStatusLabel;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton uxOpenSolutionButton;
    private System.Windows.Forms.ToolStripButton uxShowBinaryReference;
    private System.Windows.Forms.ToolStripButton uxShowProjectReferences;
    private System.Windows.Forms.ToolStripButton uxShowPackageReferences;
  }
}

