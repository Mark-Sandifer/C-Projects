using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FishDictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Dictionary<string, Dictionary<string, FishImageDescrip>> Fish = new Dictionary<string, Dictionary<string, FishImageDescrip>>{};

        public void Form1_Load(object sender, EventArgs e)
        {
            string lines = File.ReadAllText("KindsOfFish.txt");
            string[] data = lines.Split(',');

            for (int i = 0; i < data.Length-1; i += 5)
            {
                FishImageDescrip insertInfo = new FishImageDescrip();
                data[i] = data[i].Replace("\n", "").Replace("\r", "");
                if (Fish.ContainsKey(data[i]) == false)
                {
                    Fish.Add(data[i], new Dictionary<string,FishImageDescrip>());
                }
                Fish[data[i]].Add(data[i + 1], insertInfo);
                insertInfo.Name = data[i + 2];
                insertInfo.Image = data[i + 3];
                insertInfo.Description = data[i + 4];
            }
            foreach (KeyValuePair<string, Dictionary<string, FishImageDescrip>> waterTypes in Fish)
            {
                TreeNode node = new TreeNode();
                node.Text = waterTypes.Key;
                foreach (KeyValuePair<string, FishImageDescrip> fish in waterTypes.Value)
                {
                    TreeNode node2 = new TreeNode();
                    node2.Text = fish.Key;
                    node.Nodes.Add(node2);
                    TreeNode fishNode = new TreeNode();
                    fishNode.Text = fish.Value.Name;
                    fishNode.Tag = fish.Value;
                    node2.Nodes.Add(fishNode);

                }
                treeView1.Nodes.Add(node);
            }
        }
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Node.Nodes.Count == 0)
            {
                FishImageDescrip fish = (FishImageDescrip)e.Node.Tag;
                labelFishDescrip.Text = fish.Description;
                pictureBox1.ImageLocation = fish.Image;

            }
        }
    }
    public class FishImageDescrip
    {
        public string Name;
        public string Image;
        public string Description;
    }
}