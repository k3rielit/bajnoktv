namespace televizioxd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.channelList = new System.Windows.Forms.ListBox();
            this.selectChannel = new System.Windows.Forms.TrackBar();
            this.AddChannelBTN = new System.Windows.Forms.Button();
            this.AddCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ChannelInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CanSeeAdult = new System.Windows.Forms.CheckBox();
            this.HasPremium = new System.Windows.Forms.CheckBox();
            this.WatchBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.selectChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCount)).BeginInit();
            this.SuspendLayout();
            // 
            // channelList
            // 
            this.channelList.Dock = System.Windows.Forms.DockStyle.Left;
            this.channelList.FormattingEnabled = true;
            this.channelList.Location = new System.Drawing.Point(0, 0);
            this.channelList.Name = "channelList";
            this.channelList.Size = new System.Drawing.Size(624, 450);
            this.channelList.TabIndex = 0;
            // 
            // selectChannel
            // 
            this.selectChannel.Dock = System.Windows.Forms.DockStyle.Left;
            this.selectChannel.Location = new System.Drawing.Point(624, 0);
            this.selectChannel.Name = "selectChannel";
            this.selectChannel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.selectChannel.Size = new System.Drawing.Size(45, 450);
            this.selectChannel.TabIndex = 1;
            this.selectChannel.Scroll += new System.EventHandler(this.selectChannel_Scroll);
            // 
            // AddChannelBTN
            // 
            this.AddChannelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddChannelBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddChannelBTN.Location = new System.Drawing.Point(678, 49);
            this.AddChannelBTN.Name = "AddChannelBTN";
            this.AddChannelBTN.Size = new System.Drawing.Size(88, 26);
            this.AddChannelBTN.TabIndex = 2;
            this.AddChannelBTN.Text = "Add channel";
            this.AddChannelBTN.UseVisualStyleBackColor = true;
            this.AddChannelBTN.Click += new System.EventHandler(this.AddChannelBTN_Click);
            // 
            // AddCount
            // 
            this.AddCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddCount.Location = new System.Drawing.Point(678, 23);
            this.AddCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.AddCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AddCount.Name = "AddCount";
            this.AddCount.Size = new System.Drawing.Size(88, 20);
            this.AddCount.TabIndex = 4;
            this.AddCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(675, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add channels:";
            // 
            // ChannelInfo
            // 
            this.ChannelInfo.AutoSize = true;
            this.ChannelInfo.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ChannelInfo.Location = new System.Drawing.Point(675, 116);
            this.ChannelInfo.Name = "ChannelInfo";
            this.ChannelInfo.Size = new System.Drawing.Size(121, 13);
            this.ChannelInfo.TabIndex = 6;
            this.ChannelInfo.Text = "Channel information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(833, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Preferences:";
            // 
            // CanSeeAdult
            // 
            this.CanSeeAdult.AutoSize = true;
            this.CanSeeAdult.ForeColor = System.Drawing.Color.OrangeRed;
            this.CanSeeAdult.Location = new System.Drawing.Point(841, 29);
            this.CanSeeAdult.Name = "CanSeeAdult";
            this.CanSeeAdult.Size = new System.Drawing.Size(50, 17);
            this.CanSeeAdult.TabIndex = 8;
            this.CanSeeAdult.Text = "Adult";
            this.CanSeeAdult.UseVisualStyleBackColor = true;
            this.CanSeeAdult.CheckedChanged += new System.EventHandler(this.CanSeeAdult_CheckedChanged);
            // 
            // HasPremium
            // 
            this.HasPremium.AutoSize = true;
            this.HasPremium.ForeColor = System.Drawing.Color.Orange;
            this.HasPremium.Location = new System.Drawing.Point(841, 54);
            this.HasPremium.Name = "HasPremium";
            this.HasPremium.Size = new System.Drawing.Size(66, 17);
            this.HasPremium.TabIndex = 9;
            this.HasPremium.Text = "Premium";
            this.HasPremium.UseVisualStyleBackColor = true;
            this.HasPremium.CheckedChanged += new System.EventHandler(this.HasPremium_CheckedChanged);
            // 
            // WatchBTN
            // 
            this.WatchBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WatchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WatchBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WatchBTN.ForeColor = System.Drawing.Color.OliveDrab;
            this.WatchBTN.Location = new System.Drawing.Point(669, 382);
            this.WatchBTN.Name = "WatchBTN";
            this.WatchBTN.Size = new System.Drawing.Size(464, 68);
            this.WatchBTN.TabIndex = 10;
            this.WatchBTN.Text = "WATCH";
            this.WatchBTN.UseVisualStyleBackColor = true;
            this.WatchBTN.Click += new System.EventHandler(this.WatchBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 450);
            this.Controls.Add(this.WatchBTN);
            this.Controls.Add(this.HasPremium);
            this.Controls.Add(this.CanSeeAdult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChannelInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddCount);
            this.Controls.Add(this.AddChannelBTN);
            this.Controls.Add(this.selectChannel);
            this.Controls.Add(this.channelList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1149, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BajnokTV";
            ((System.ComponentModel.ISupportInitialize)(this.selectChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox channelList;
        private System.Windows.Forms.TrackBar selectChannel;
        private System.Windows.Forms.Button AddChannelBTN;
        private System.Windows.Forms.NumericUpDown AddCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ChannelInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CanSeeAdult;
        private System.Windows.Forms.CheckBox HasPremium;
        private System.Windows.Forms.Button WatchBTN;
    }
}

