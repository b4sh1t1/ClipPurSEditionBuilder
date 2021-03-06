﻿namespace ClipPurSEditionBuilder.ControlsSE
{
    partial class InfoSE
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoSE));
            this.BitPicture = new System.Windows.Forms.PictureBox();
            this.BitWallet = new System.Windows.Forms.Label();
            this.LinePanelDown = new System.Windows.Forms.Panel();
            this.InfoTwo = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.ShowMessage = new System.Windows.Forms.Label();
            this.InfoText = new System.Windows.Forms.Label();
            this.LinePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowHelperBuildSE = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BitPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BitPicture
            // 
            this.BitPicture.Image = global::ClipPurSEditionBuilder.Properties.Resources.Bitcoin;
            resources.ApplyResources(this.BitPicture, "BitPicture");
            this.BitPicture.Name = "BitPicture";
            this.BitPicture.TabStop = false;
            // 
            // BitWallet
            // 
            resources.ApplyResources(this.BitWallet, "BitWallet");
            this.BitWallet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BitWallet.Name = "BitWallet";
            this.BitWallet.Click += new System.EventHandler(this.BitWallet_Click);
            // 
            // LinePanelDown
            // 
            this.LinePanelDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            resources.ApplyResources(this.LinePanelDown, "LinePanelDown");
            this.LinePanelDown.Name = "LinePanelDown";
            // 
            // InfoTwo
            // 
            resources.ApplyResources(this.InfoTwo, "InfoTwo");
            this.InfoTwo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InfoTwo.Name = "InfoTwo";
            this.ShowHelperBuildSE.SetToolTip(this.InfoTwo, resources.GetString("InfoTwo.ToolTip"));
            this.InfoTwo.DoubleClick += new System.EventHandler(this.InfoTwo_DoubleClick);
            // 
            // Info
            // 
            resources.ApplyResources(this.Info, "Info");
            this.Info.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Info.Name = "Info";
            // 
            // ShowMessage
            // 
            resources.ApplyResources(this.ShowMessage, "ShowMessage");
            this.ShowMessage.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ShowMessage.Name = "ShowMessage";
            // 
            // InfoText
            // 
            resources.ApplyResources(this.InfoText, "InfoText");
            this.InfoText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InfoText.Name = "InfoText";
            // 
            // LinePanel
            // 
            this.LinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            resources.ApplyResources(this.LinePanel, "LinePanel");
            this.LinePanel.Name = "LinePanel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Name = "label2";
            // 
            // ShowHelperBuildSE
            // 
            this.ShowHelperBuildSE.AutomaticDelay = 100;
            this.ShowHelperBuildSE.AutoPopDelay = 2000;
            this.ShowHelperBuildSE.InitialDelay = 100;
            this.ShowHelperBuildSE.ReshowDelay = 20;
            // 
            // InfoSE
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoText);
            this.Controls.Add(this.LinePanel);
            this.Controls.Add(this.ShowMessage);
            this.Controls.Add(this.BitPicture);
            this.Controls.Add(this.BitWallet);
            this.Controls.Add(this.LinePanelDown);
            this.Controls.Add(this.InfoTwo);
            this.Controls.Add(this.Info);
            this.Name = "InfoSE";
            ((System.ComponentModel.ISupportInitialize)(this.BitPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BitPicture;
        private System.Windows.Forms.Label BitWallet;
        private System.Windows.Forms.Panel LinePanelDown;
        private System.Windows.Forms.Label InfoTwo;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label ShowMessage;
        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.Panel LinePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip ShowHelperBuildSE;
    }
}
