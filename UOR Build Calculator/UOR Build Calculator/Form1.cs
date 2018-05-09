using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace UOR_Build_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SkillsCounter()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 166);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(268, 42);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.trackBar1);
            this.Name = "Skill Amount";
            this.Text = "Skill Amount";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trackBar1, trackBar1.Value.ToString());
        }

        private void btnAddSkill_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }

            var item = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            string tbval = trackBar1.Value.ToString();
            int cap = 700;
            int newsum = Convert.ToInt32(sum);
            int newtbval = Convert.ToInt32(tbval);
            int pttot = (newsum += newtbval);
            int ptrem = (cap -= pttot);

            if (Convert.ToInt32(tbval) == 0)
            {
                MessageBox.Show("This must be greater than 0!");
                return;
            }

            if (item != "")
            {
                for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
                {
                    for (int col = 0; col < dataGridView1.Rows[rows].Cells.Count; col++)
                    {
                        string value = dataGridView1.Rows[rows].Cells[col].Value.ToString();
                        if (value == item)
                        {
                            MessageBox.Show("You already have " + value + ". Try another?");
                            return;
                        }
                    }
                }

                if (pttot <= 700)
                {
                    //System.Windows.Forms.MessageBox.Show(string.Format("Skill {0} has been added at {1} points. {2} points remain.", item, tbval, ptrem));
                    this.dataGridView1.Rows.Add(item, tbval);
                    label2.Text = string.Format("Current Skill Total: {0}", pttot.ToString());
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("You would exceed the 700 Skill Cap with your current selection.");
                }
            }
            else
                System.Windows.Forms.MessageBox.Show("You did not select a skill.");

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CellValidation();
            CheckSkills();
        }
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CellValidation();
            CheckSkills();
        }
        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            CellValidation();
            CheckSkills();

        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            CellValidation();
            CheckSkills();
        }

        private void CellValidation()
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                if (sum > 100)
                {
                    dataGridView1.Rows[i].Cells[1].Value = "100";
                }
                else if (sum < 1)
                {
                    dataGridView1.Rows[i].Cells[1].Value = "1";
                }
            }
            int skt = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                skt += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }
            label2.Text = string.Format("Current Skill Total: {0}", skt.ToString());
        }

        private void CheckSkills()
        {
            //concussion = anat + swords
            //crush = mace + anat
            //para = fening + anat
            //stun =  wrestling + anat
            //disarm = wrestling + lore
            string[] column0Array = new string[dataGridView1.Rows.Count];
            string[] column1Array = new string[dataGridView1.Rows.Count];

            int i = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                column0Array[i] = row.Cells[0].Value != null ? row.Cells[0].Value.ToString() : string.Empty;
                column1Array[i] = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : string.Empty;
                i++;
            }
            string anatomy = "Anatomy";
            string swordsmanship = "Swordsmanship";
            string macefighting = "Mace Fighting";
            string fencing = "Fencing";
            string wrestlingstun = "Wrestling";
            string wrestlingdisarm = "Wrestling";
            string armslore = "Arms Lore";
            string magery = "Magery";

            int arms = Array.IndexOf(column0Array, armslore);
            int anat = Array.IndexOf(column0Array, anatomy);
            if (anat > -1 && arms >= -1)
            {
                int swrd = Array.IndexOf(column0Array, swordsmanship);
                if (swrd > -1)
                {
                    cbConcussion.Checked = true;
                }
                else { cbConcussion.Checked = false; }
                int mace = Array.IndexOf(column0Array, macefighting);
                if (mace > -1)
                {
                    cbCrush.Checked = true;
                }
                else { cbCrush.Checked = false; }
                int fence = Array.IndexOf(column0Array, fencing);
                if (fence > -1)
                {
                    cbParablow.Checked = true;
                }
                else { cbParablow.Checked = false; }
                int wrestle = Array.IndexOf(column0Array, wrestlingstun);
                if (wrestle > -1)
                {
                    cbStun.Checked = true;
                }
                else { cbStun.Checked = false; }
            }
            else
            {
                cbConcussion.Checked = false;
                cbCrush.Checked = false;
                cbParablow.Checked = false;
                cbStun.Checked = false;
            }
            if (arms > -1 && anat >= -1)
            {
                int wrstle = Array.IndexOf(column0Array, wrestlingdisarm);
                if (wrstle > -1)
                {
                    cbDisarm.Checked = true;
                }
                else { cbDisarm.Checked = false; }
            }
            else { cbDisarm.Checked = false; }
            //end special ability skill checks
            int magic = Array.IndexOf(column0Array, magery);
            if (magic > -1)
            {

            }


        }

        private void tbStatStr_TextChanged(object sender, EventArgs e) //4 str
        {
            Stat_Validation(tbStatStr, lblStrErr);
        }
        private void tbStatDex_TextChanged(object sender, EventArgs e) //3 dex
        {
            Stat_Validation(tbStatDex, lblDexErr);
        }

        private void tbStatInt_TextChanged(object sender, EventArgs e) //2 int
        {
            Stat_Validation(tbStatInt, lblIntErr);
        }

        private void Stat_Validation(TextBox tb, Label lbl)
        {
            //(A) below is the most hackish crap ive had to do so far... (see: B)
            tbStatTotal.Text = " ";
            if (tb.Text == "")//(tbStatStr.Text == "" || tbStatDex.Text == "" || tbStatInt.Text == "")
            {
                tb.BackColor = Color.Yellow;
                lbl.Text = "Invalid!";
            }

            else
            {
                int parsedValue;
                if (tb.Text != "")
                {
                    if (!int.TryParse(tb.Text, out parsedValue))
                    {
                        lbl.Text = "Numbers Only!";
                    }
                    else
                    {
                        if (Convert.ToInt32(tb.Text.ToString()) > 100)
                        {
                            tb.BackColor = Color.Red;
                            lbl.Text = "Over 100";
                        }
                        if (Convert.ToInt32(tb.Text.ToString()) < 10)
                        {
                            tb.BackColor = Color.Red;
                            lbl.Text = "Under 10";
                        }
                        if (Convert.ToInt32(tb.Text.ToString()) >= 10 && Convert.ToInt32(tb.Text.ToString()) <= 100)
                        {
                            tb.BackColor = Color.White;
                            lbl.Text = "";
                        }
                    }
                }
            }
        }


        private void btnSkillInfo_Click(object sender, EventArgs e)
        {
            var item = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            webBrowser1.Navigate("http://www.uorenaissance.com/info/" + Regex.Replace(item, @"\s+", "_"));
            //webBrowser1.Navigate("http://www.google.com");
        }


        private void tbExportPath_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderName = folderBrowserDialog1.SelectedPath;
                tbExportPath.Text = folderName + "\\";
                return;
            }
        }

        private void btnExportBuild_Click(object sender, EventArgs e)
        {
            int Str = Convert.ToInt32(tbStatStr.Text);
            int Dex = Convert.ToInt32(tbStatDex.Text);
            int Int = Convert.ToInt32(tbStatInt.Text);
            int statsum = Str + Dex + Int;
            int skillsum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                skillsum += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }
            if (tbExportPath.Text != "" && tbBuildName.Text != "")
            {
                if(skillsum != 700 || statsum != 225)
                {
string weakmessage = string.Format("This build is not at it's full potential. \r\n Skill Cap is 700, you have {0} \r\n Stat Cap is 225, you have {1} \r\n Continue?", skillsum.ToString(), statsum.ToString());
DialogResult result = MessageBox.Show(weakmessage, "Warning",
MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        DoExport();
                    }
                    else if (result == DialogResult.No)
                    {
                        return;
                    }

                }


            }
            else
            {
                MessageBox.Show("You need a file path and/or name.");
                return;
            }
        }

        private void tbBuildName_TextChanged(object sender, EventArgs e)
        {
        }

        private void DoExport()
        {
            //string illegal = "\"M\"\\a/ry/ h**ad:>> a\\/:*?\"| li*tt|le|| la\"mb.?";
            string invalid = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());

            foreach (char c in invalid)
            {
                tbBuildName.Text = tbBuildName.Text.Replace(c.ToString(), "");
            }
            //Build the CSV file data as a Comma separated string.
            string csv = string.Empty;

            var delim = "\t";
            //Add the Header row for CSV file.
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                csv += column.HeaderText + delim;
            }

            //Add new line.
            csv += "\r\n";

            //Adding the Rows
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    //Add the Data rows.
                    csv += cell.Value.ToString().Replace(",", ";") + delim;
                }

                //Add new line.
                csv += "\r\n";
            }

            csv += "\r\n";
            csv += "Str:" + delim + tbStatStr.Text;
            csv += "\r\n";
            csv += "Dex:" + delim + tbStatDex.Text;
            csv += "\r\n";
            csv += "Int:" + delim + tbStatInt.Text;

            //Exporting to CSV.
            string totalPath = (tbExportPath.Text + tbBuildName.Text);
            using (StreamWriter w = File.AppendText(totalPath + ".csv")) ;
            File.WriteAllText(totalPath + ".csv", csv);
        }

        private void btnClearBuild_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            this.Opacity = 1;
            tbStatStr.Text = "10";
            tbStatDex.Text = "10";
            tbStatInt.Text = "10";
        }


        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }


        private void tbStatTotal_TextChanged(object sender, EventArgs e)
        {
            if (tbStatStr.Text != "" && tbStatDex.Text != "" && tbStatInt.Text != "")
            {
                int Str = Convert.ToInt32(tbStatStr.Text);
                int Dex = Convert.ToInt32(tbStatDex.Text);
                int Int = Convert.ToInt32(tbStatInt.Text);
                int High = Math.Max(Str, Math.Max(Dex, Int)); ;
                int Low = Math.Min(Str, Math.Min(Dex, Int));

                tbStatTotal.Text = (Str + Dex + Int).ToString();
                if (Convert.ToInt32(tbStatTotal.Text) > 225)
                {
                    tbStatTotal.BackColor = Color.Yellow;
                    lblStatTot.Text = "Invalid";
                }
                else
                {
                    tbStatTotal.BackColor = Color.White;
                    lblStatTot.Text = "";
                    lblHits.Text = "Hits:    " + (50 + (Str / 2)).ToString();
                    lblStam.Text = "Stam:  " + (Dex).ToString();
                    lblMana.Text = "Mana: " + (Int).ToString();
                    lblBlast.Text = "min/max mind blast:   " + (((High - Low) / 2) / 2).ToString() + " / " + ((High - Low) / 2).ToString();// + High.ToString() + " / " + Low.ToString() ;
                    //Thanks to Cirque for checking stat-to-weight ratios
                    lblWeight.Text = "max carrying capcity: " + Math.Round(((Str * 3.5) + 40), 0) + " stones";
                    lblHealtime.Text = "bandage self time: " + (8 + (.5 * ((120 - Dex) / 10))) + " seconds";
                    /* //this was removed 4/30/2018... possible implement again later.
                    lblDmg.Text = "Dmg:%" + (Str * (.2)).ToString();
                    //todo! add a toggle for weapons so that swing shows by weap
                    lblSwing.Text = "Swing: " + (15000 / (Dex + 100)).ToString();
                    */
                }
            }
            else
                //(B) below is the most hackish crap ive had to do so far... (see: A)
                tbStatTotal.Text = "";
        }

 
        #region builds
        private void btnPremade_Click(object sender, EventArgs e)
        {
            var selection = this.comboPremade.GetItemText(this.comboPremade.Text);
            if (selection == "Bard Mage")
            {
                bardmage();
            }
            else if (selection == "Thief")
            {
                thief();
            }
            else if (selection == "Tamer")
            {
                tamer();
            }
            else if (selection == "Axe Mage")
            {
                axemage();
            }
            else if (selection == "Fishing Archer")
            {
                fisharcher();
            }
            else if (selection == "Alchemist Scribe")
            {
                alchscribe();
            }
            else if (selection == "Crafter")
            {
                crafter();
            }
            else if (selection == "Telamon")
            {
                MessageBox.Show("You cannot possibly fathom the power of this build...");
                this.Opacity = .95;
            }
            else
            {
                MessageBox.Show("the spell fizzles.");
            }
        }

        private void bardmage()
        {
            dataGridView1.Rows.Clear();
            tbStatStr.Text = "90";
            tbStatDex.Text = "45";
            tbStatInt.Text = "90";
            this.dataGridView1.Rows.Add("Evaluating Intelligence", "100");
            this.dataGridView1.Rows.Add("Magery", "100");
            this.dataGridView1.Rows.Add("Meditation", "100");
            this.dataGridView1.Rows.Add("Musicianship", "100");
            this.dataGridView1.Rows.Add("Peacemaking", "100");
            this.dataGridView1.Rows.Add("Provocation", "100");
            this.dataGridView1.Rows.Add("Resisting Spells", "100");
        }
        private void thief()
        {
            dataGridView1.Rows.Clear();
            tbStatStr.Text = "80";
            tbStatDex.Text = "90";
            tbStatInt.Text = "55";
            this.dataGridView1.Rows.Add("Detecting Hidden", "100");
            this.dataGridView1.Rows.Add("Hiding", "100");
            this.dataGridView1.Rows.Add("Magery", "100");
            this.dataGridView1.Rows.Add("Resisting Spells", "100");
            this.dataGridView1.Rows.Add("Snooping", "100");
            this.dataGridView1.Rows.Add("Stealing", "100");
            this.dataGridView1.Rows.Add("Stealth", "100");
        }
        private void tamer()
        {
            dataGridView1.Rows.Clear();
            tbStatStr.Text = "90";
            tbStatDex.Text = "45";
            tbStatInt.Text = "90";
            this.dataGridView1.Rows.Add("Animal Lore", "100");
            this.dataGridView1.Rows.Add("Animal Taming", "100");
            this.dataGridView1.Rows.Add("Evaluating Intelligence", "100");
            this.dataGridView1.Rows.Add("Magery", "100");
            this.dataGridView1.Rows.Add("Meditation", "100");
            this.dataGridView1.Rows.Add("Resisting Spells", "100");
            this.dataGridView1.Rows.Add("Veterinary", "100");
        }
        private void axemage()
        {
            dataGridView1.Rows.Clear();
            tbStatStr.Text = "90";
            tbStatDex.Text = "90";
            tbStatInt.Text = "45";
            this.dataGridView1.Rows.Add("Anatomy", "100");
            this.dataGridView1.Rows.Add("Healing", "100");
            this.dataGridView1.Rows.Add("Lumberjacking", "100");
            this.dataGridView1.Rows.Add("Magery", "100");
            this.dataGridView1.Rows.Add("Resisting Spells", "100");
            this.dataGridView1.Rows.Add("Swordsmanship", "100");
            this.dataGridView1.Rows.Add("Tactics", "100");
        }
        private void fisharcher()
        {
            dataGridView1.Rows.Clear();
            tbStatStr.Text = "90";
            tbStatDex.Text = "90";
            tbStatInt.Text = "45";
            this.dataGridView1.Rows.Add("Anatomy", "100");
            this.dataGridView1.Rows.Add("Archery", "100");
            this.dataGridView1.Rows.Add("Fishing", "100");
            this.dataGridView1.Rows.Add("Magery", "100");
            this.dataGridView1.Rows.Add("Healing", "100");
            this.dataGridView1.Rows.Add("Resisting Spells", "100");
            this.dataGridView1.Rows.Add("Tactics", "100");
        }
        private void alchscribe()
        {
            dataGridView1.Rows.Clear();
            tbStatStr.Text = "80";
            tbStatDex.Text = "55";
            tbStatInt.Text = "90";
            this.dataGridView1.Rows.Add("Alchemy", "100");
            this.dataGridView1.Rows.Add("Evaluating Intelligence", "100");
            this.dataGridView1.Rows.Add("Inscription", "100");
            this.dataGridView1.Rows.Add("Magery", "100");
            this.dataGridView1.Rows.Add("Meditation", "100");
            this.dataGridView1.Rows.Add("Poisoning", "100");
            this.dataGridView1.Rows.Add("Resisting Spells", "100");
        }
        private void crafter()
        {
            dataGridView1.Rows.Clear();
            tbStatStr.Text = "90";
            tbStatDex.Text = "55";
            tbStatInt.Text = "80";
            this.dataGridView1.Rows.Add("Blacksmithy", "100");
            this.dataGridView1.Rows.Add("Carpentry", "100");
            this.dataGridView1.Rows.Add("Lumberjacking", "100");
            this.dataGridView1.Rows.Add("Magery", "100");
            this.dataGridView1.Rows.Add("Mining", "100");
            this.dataGridView1.Rows.Add("Tailoring", "100");
            this.dataGridView1.Rows.Add("Tinkering", "100");
        }
        #endregion

        #region unused
        private void Show_Message(string msg)
        {
            MessageBox.Show(msg, "UOR Build Calculator");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void tbExportPath_TextChanged(object sender, EventArgs e)
        {
        }
        private void lblHits_Click(object sender, EventArgs e)
        {
        }

        private void lblStam_Click(object sender, EventArgs e)
        {
        }

        private void lblMana_Click(object sender, EventArgs e)
        {
        }

        private void lblBlast_Click(object sender, EventArgs e)
        {
        }

        private void cbConcussion_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cbCrush_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cbParablow_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cbStun_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cbDisarm_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
        }
        private void lblWeight_Click(object sender, EventArgs e)
        {
        }
        private void comboPremade_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblHealtime_Click(object sender, EventArgs e)
        {
        }

        #endregion
    }
}
