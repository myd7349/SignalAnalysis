﻿namespace SignalAnalysis;

partial class FrmMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.plotFFT = new ScottPlot.FormsPlotCrossHair();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.plotOriginal = new ScottPlot.FormsPlotCrossHair();
            this.plotWindow = new ScottPlot.FormsPlotCrossHair();
            this.plotApplied = new ScottPlot.FormsPlotCrossHair();
            this.txtStats = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.plotFractal = new ScottPlot.FormsPlotCrossHair();
            this.plotFractalDistribution = new ScottPlot.FormsPlotCrossHair();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.plotFFT, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtStats, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(860, 620);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.TabStop = true;
            // 
            // plotFFT
            // 
            this.plotFFT.BackColor = System.Drawing.Color.Transparent;
            this.plotFFT.CrossHairColor = System.Drawing.Color.Red;
            this.plotFFT.CultureUI = new System.Globalization.CultureInfo("en-US");
            this.plotFFT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotFFT.Location = new System.Drawing.Point(4, 349);
            this.plotFFT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plotFFT.Name = "plotFFT";
            this.plotFFT.ShowCrossHair = false;
            this.plotFFT.ShowCrossHairHorizontal = false;
            this.plotFFT.ShowCrossHairVertical = false;
            this.plotFFT.Size = new System.Drawing.Size(852, 167);
            this.plotFFT.SnapToPoint = false;
            this.plotFFT.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.plotOriginal, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.plotWindow, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.plotApplied, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(860, 173);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // plotOriginal
            // 
            this.plotOriginal.BackColor = System.Drawing.Color.Transparent;
            this.plotOriginal.CrossHairColor = System.Drawing.Color.Red;
            this.plotOriginal.CultureUI = new System.Globalization.CultureInfo("en-US");
            this.plotOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotOriginal.Location = new System.Drawing.Point(4, 3);
            this.plotOriginal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plotOriginal.Name = "plotOriginal";
            this.plotOriginal.ShowCrossHair = false;
            this.plotOriginal.ShowCrossHairHorizontal = false;
            this.plotOriginal.ShowCrossHairVertical = false;
            this.plotOriginal.Size = new System.Drawing.Size(278, 167);
            this.plotOriginal.SnapToPoint = false;
            this.plotOriginal.TabIndex = 2;
            // 
            // plotWindow
            // 
            this.plotWindow.BackColor = System.Drawing.Color.Transparent;
            this.plotWindow.CrossHairColor = System.Drawing.Color.Red;
            this.plotWindow.CultureUI = new System.Globalization.CultureInfo("en-US");
            this.plotWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotWindow.Location = new System.Drawing.Point(290, 3);
            this.plotWindow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plotWindow.Name = "plotWindow";
            this.plotWindow.ShowCrossHair = false;
            this.plotWindow.ShowCrossHairHorizontal = false;
            this.plotWindow.ShowCrossHairVertical = false;
            this.plotWindow.Size = new System.Drawing.Size(278, 167);
            this.plotWindow.SnapToPoint = false;
            this.plotWindow.TabIndex = 3;
            // 
            // plotApplied
            // 
            this.plotApplied.BackColor = System.Drawing.Color.Transparent;
            this.plotApplied.CrossHairColor = System.Drawing.Color.Red;
            this.plotApplied.CultureUI = new System.Globalization.CultureInfo("en-US");
            this.plotApplied.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotApplied.Location = new System.Drawing.Point(576, 3);
            this.plotApplied.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plotApplied.Name = "plotApplied";
            this.plotApplied.ShowCrossHair = false;
            this.plotApplied.ShowCrossHairHorizontal = false;
            this.plotApplied.ShowCrossHairVertical = false;
            this.plotApplied.Size = new System.Drawing.Size(280, 167);
            this.plotApplied.SnapToPoint = false;
            this.plotApplied.TabIndex = 4;
            // 
            // txtStats
            // 
            this.txtStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStats.Location = new System.Drawing.Point(3, 522);
            this.txtStats.Multiline = true;
            this.txtStats.Name = "txtStats";
            this.txtStats.ReadOnly = true;
            this.txtStats.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStats.Size = new System.Drawing.Size(854, 95);
            this.txtStats.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.plotFractal, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.plotFractalDistribution, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 173);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(860, 173);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // plotFractal
            // 
            this.plotFractal.BackColor = System.Drawing.Color.Transparent;
            this.plotFractal.CrossHairColor = System.Drawing.Color.Red;
            this.plotFractal.CultureUI = new System.Globalization.CultureInfo("en-US");
            this.plotFractal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotFractal.Location = new System.Drawing.Point(4, 3);
            this.plotFractal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plotFractal.Name = "plotFractal";
            this.plotFractal.ShowCrossHair = false;
            this.plotFractal.ShowCrossHairHorizontal = false;
            this.plotFractal.ShowCrossHairVertical = false;
            this.plotFractal.Size = new System.Drawing.Size(594, 167);
            this.plotFractal.SnapToPoint = false;
            this.plotFractal.TabIndex = 4;
            // 
            // plotFractalDistribution
            // 
            this.plotFractalDistribution.CrossHairColor = System.Drawing.Color.Red;
            this.plotFractalDistribution.CultureUI = new System.Globalization.CultureInfo("en-US");
            this.plotFractalDistribution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotFractalDistribution.Location = new System.Drawing.Point(606, 3);
            this.plotFractalDistribution.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plotFractalDistribution.Name = "plotFractalDistribution";
            this.plotFractalDistribution.ShowCrossHair = false;
            this.plotFractalDistribution.ShowCrossHairHorizontal = false;
            this.plotFractalDistribution.ShowCrossHairVertical = false;
            this.plotFractalDistribution.Size = new System.Drawing.Size(250, 167);
            this.plotFractalDistribution.SnapToPoint = false;
            this.plotFractalDistribution.TabIndex = 5;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 721);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(900, 760);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signal analysis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmMain_KeyPress);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion
    private TableLayoutPanel tableLayoutPanel1;
    private ScottPlot.FormsPlotCrossHair plotOriginal;
    private TableLayoutPanel tableLayoutPanel2;
    private ScottPlot.FormsPlotCrossHair plotWindow;
    private ScottPlot.FormsPlotCrossHair plotApplied;
    private ScottPlot.FormsPlotCrossHair plotFFT;
    private TextBox txtStats;
    private TableLayoutPanel tableLayoutPanel3;
    private ScottPlot.FormsPlotCrossHair plotFractal;
    private ScottPlot.FormsPlotCrossHair plotFractalDistribution;
}
