﻿namespace RBot
{
    partial class HotkeysForm
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
            this.lblStop = new System.Windows.Forms.Label();
            this.btnHKStartScript = new System.Windows.Forms.Button();
            this.btnHKStopScript = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.btnHKToggle = new System.Windows.Forms.Button();
            this.lblToggle = new System.Windows.Forms.Label();
            this.btnHKLoad = new System.Windows.Forms.Button();
            this.lblLoadScript = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tlpHotKeys = new System.Windows.Forms.TableLayoutPanel();
            this.tlpHotKeys.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStop
            // 
            this.lblStop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStop.AutoSize = true;
            this.lblStop.Location = new System.Drawing.Point(4, 0);
            this.lblStop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(90, 39);
            this.lblStop.TabIndex = 0;
            this.lblStop.Text = "Start Script:";
            this.lblStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnHKStartScript
            // 
            this.btnHKStartScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHKStartScript.Location = new System.Drawing.Point(102, 3);
            this.btnHKStartScript.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHKStartScript.Name = "btnHKStartScript";
            this.btnHKStartScript.Size = new System.Drawing.Size(90, 33);
            this.btnHKStartScript.TabIndex = 1;
            this.btnHKStartScript.Tag = "start";
            this.btnHKStartScript.UseVisualStyleBackColor = true;
            // 
            // btnHKStopScript
            // 
            this.btnHKStopScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHKStopScript.Location = new System.Drawing.Point(102, 42);
            this.btnHKStopScript.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHKStopScript.Name = "btnHKStopScript";
            this.btnHKStopScript.Size = new System.Drawing.Size(90, 33);
            this.btnHKStopScript.TabIndex = 3;
            this.btnHKStopScript.Tag = "stop";
            this.btnHKStopScript.UseVisualStyleBackColor = true;
            // 
            // lblStart
            // 
            this.lblStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(4, 39);
            this.lblStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(90, 39);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Stop Script:";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnHKToggle
            // 
            this.btnHKToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHKToggle.Location = new System.Drawing.Point(102, 81);
            this.btnHKToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHKToggle.Name = "btnHKToggle";
            this.btnHKToggle.Size = new System.Drawing.Size(90, 33);
            this.btnHKToggle.TabIndex = 5;
            this.btnHKToggle.Tag = "toggle";
            this.btnHKToggle.UseVisualStyleBackColor = true;
            // 
            // lblToggle
            // 
            this.lblToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToggle.AutoSize = true;
            this.lblToggle.Location = new System.Drawing.Point(4, 78);
            this.lblToggle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToggle.Name = "lblToggle";
            this.lblToggle.Size = new System.Drawing.Size(90, 39);
            this.lblToggle.TabIndex = 4;
            this.lblToggle.Text = "Toggle Script:";
            this.lblToggle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnHKLoad
            // 
            this.btnHKLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHKLoad.Location = new System.Drawing.Point(102, 120);
            this.btnHKLoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHKLoad.Name = "btnHKLoad";
            this.btnHKLoad.Size = new System.Drawing.Size(90, 33);
            this.btnHKLoad.TabIndex = 7;
            this.btnHKLoad.Tag = "load";
            this.btnHKLoad.UseVisualStyleBackColor = true;
            // 
            // lblLoadScript
            // 
            this.lblLoadScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoadScript.AutoSize = true;
            this.lblLoadScript.Location = new System.Drawing.Point(4, 117);
            this.lblLoadScript.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoadScript.Name = "lblLoadScript";
            this.lblLoadScript.Size = new System.Drawing.Size(90, 39);
            this.lblLoadScript.TabIndex = 6;
            this.lblLoadScript.Text = "Load Script:";
            this.lblLoadScript.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpHotKeys.SetColumnSpan(this.btnClose, 2);
            this.btnClose.Location = new System.Drawing.Point(4, 159);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(188, 24);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tlpHotKeys
            // 
            this.tlpHotKeys.ColumnCount = 2;
            this.tlpHotKeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHotKeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHotKeys.Controls.Add(this.lblStop, 0, 0);
            this.tlpHotKeys.Controls.Add(this.btnClose, 0, 4);
            this.tlpHotKeys.Controls.Add(this.btnHKStartScript, 1, 0);
            this.tlpHotKeys.Controls.Add(this.btnHKLoad, 1, 3);
            this.tlpHotKeys.Controls.Add(this.lblStart, 0, 1);
            this.tlpHotKeys.Controls.Add(this.btnHKStopScript, 1, 1);
            this.tlpHotKeys.Controls.Add(this.btnHKToggle, 1, 2);
            this.tlpHotKeys.Controls.Add(this.lblToggle, 0, 2);
            this.tlpHotKeys.Controls.Add(this.lblLoadScript, 0, 3);
            this.tlpHotKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHotKeys.Location = new System.Drawing.Point(0, 0);
            this.tlpHotKeys.Name = "tlpHotKeys";
            this.tlpHotKeys.RowCount = 5;
            this.tlpHotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpHotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpHotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpHotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpHotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpHotKeys.Size = new System.Drawing.Size(196, 186);
            this.tlpHotKeys.TabIndex = 9;
            // 
            // HotkeysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 186);
            this.Controls.Add(this.tlpHotKeys);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "HotkeysForm";
            this.Text = "Hotkeys";
            this.tlpHotKeys.ResumeLayout(false);
            this.tlpHotKeys.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.Button btnHKStartScript;
        private System.Windows.Forms.Button btnHKStopScript;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Button btnHKToggle;
        private System.Windows.Forms.Label lblToggle;
        private System.Windows.Forms.Button btnHKLoad;
        private System.Windows.Forms.Label lblLoadScript;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TableLayoutPanel tlpHotKeys;
    }
}