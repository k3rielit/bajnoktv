using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace televizioxd {
    public partial class Form1 : Form {
        public List<TvChannel> channels = new List<TvChannel>();
        public Form1() {
            InitializeComponent();
            AddChannels(10);
        }
        public void AddChannels(int count) {
            Random r = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int a=0; a<count; a++) {
                string name = "";
                for (int c=0; c<10; c++) {
                    name += chars[r.Next(0,chars.Length-1)];
                }
                channels.Add( new TvChannel(name,$"The channel {name} gives You an amazing experience!",r.Next(2)>0,r.Next(2)>0) );
            }
            SetGUI();
        }
        public void SetGUI() {
            channelList.Items.Clear();
            int i=1;
            foreach (TvChannel idk in channels) {
                channelList.Items.Add( $"#{i} {idk.Name} - {idk.Description} - {(idk.IsAdult ? "Adult only" : "Unrestricted")} - {(idk.IsPremium ? "Premium" : "Non-premium")}" );
                i++;
            }
            selectChannel.Maximum = channels.Count()-1;
            RefreshInfo();
        }
        private void AddChannelBTN_Click(object sender, EventArgs e) => AddChannels((int)AddCount.Value);
        private void selectChannel_Scroll(object sender, EventArgs e) => RefreshInfo();
        private void CanSeeAdult_CheckedChanged(object sender, EventArgs e) => RefreshInfo();
        private void HasPremium_CheckedChanged(object sender, EventArgs e) => RefreshInfo();
        public void RefreshInfo() {
            ChannelInfo.Text = $"#{selectChannel.Value + 1} Channel\n[{(channels[selectChannel.Value].IsPremium ? "Premium" : "Free")},{(channels[selectChannel.Value].IsAdult ? "Adult" : "Non-adult")}]\nName: {channels[selectChannel.Value].Name}\nDescription: {channels[selectChannel.Value].Description}\n{(channels[selectChannel.Value].CanWatch(CanSeeAdult.Checked, HasPremium.Checked) ? "You can watch this channel." : "You aren't permitted to watch this channel!")}";
            WatchBTN.ForeColor = channels[selectChannel.Value].CanWatch(CanSeeAdult.Checked, HasPremium.Checked) ? Color.OliveDrab : Color.Red;
        }
        private void WatchBTN_Click(object sender, EventArgs e) {
            Random r = new Random();
            if(channels[selectChannel.Value].CanWatch(CanSeeAdult.Checked, HasPremium.Checked)) {
                WatchForm wf = new WatchForm();
                wf.BackgroundImage = r.Next(0,2)>0 ? Properties.Resources.penz : Properties.Resources.vezet;
                wf.Text = $"#{selectChannel.Value+1} {channels[selectChannel.Value].Name}";
                wf.ShowDialog();
            }
        }
    }
}
