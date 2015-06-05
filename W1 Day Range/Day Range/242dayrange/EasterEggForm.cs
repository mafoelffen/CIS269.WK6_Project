using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Reflection;
using System.IO;
using System.Resources;
using System.Diagnostics;

/*
 * Created by Mike Ferreira and Max Potter
 * Spring 2015
 * CIS269
 * 
 * The GitHubRepo for this is at https://github.com/mafoelffen/CIS269.WK6_Project
 */


namespace _42dayrange
{
    public partial class EasterEggForm : Form
    {
        public EasterEggForm()
        {
            InitializeComponent();
        }

        private Scene scene = Scene.One;
        private enum Scene 
        { 
            One,
            Two,
            Three,
            Four,
            Five
        }

        private Assembly assembly;
        private Stream soundStream;
        private SoundPlayer sp;

        // distance to move label
        private const int DISTANCE_TO_MOVE = 25;

        // variable for distance to move
        private int distance = 25;

        private int counter = 0; // counter for scene2

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (scene == Scene.One)
            {
                
                if (pbPacman.Right < this.Width / 2 + pbPacman.Width)
                {
                    pbPacman.Left += distance;
                }
                else
                    pbPacman.Visible = false;

                if (pbMinion.Left > this.Width / 2 + pbMinion.Width / 2)
                {
                    pbMinion.Left -= distance;
                    sp.Dispose();
                    assembly = Assembly.GetExecutingAssembly();
                    sp = new SoundPlayer(assembly.GetManifestResourceStream
                        ("_42dayrange._chomp.wav"));
                    sp.Play();
                }
                else
                {
                    counter = 0;
                    pbPacman.BackgroundImage = null;
                    scene = Scene.Two;
                }
            }
            else if (scene == Scene.Two) // Play Scene Two
            {

                if (counter < 3)
                { 
                    //wait and show just the yellow minion
                }
                else if (counter < 4)
                {
                    // trade picture to explosion
                    this.pbMinion.BackgroundImage = global::_42dayrange.Properties.Resources.ex1;
                    sp.Dispose();
                    assembly = Assembly.GetExecutingAssembly();
                    sp = new SoundPlayer(assembly.GetManifestResourceStream
                        ("_42dayrange.Bomb.wav"));
                    sp.Play();
                }
                else if (counter < 5)
                {
                    // trade picture to explosion
                    this.pbMinion.BackgroundImage = global::_42dayrange.Properties.Resources.ex2;
                }
                else if (counter < 6)
                {
                    // trade picture to explosion
                    this.pbMinion.BackgroundImage = global::_42dayrange.Properties.Resources.ex3;
                }
                else if (counter < 7)
                {
                    // trade picture to explosion
                    this.pbMinion.BackgroundImage = global::_42dayrange.Properties.Resources.ex4;
                }
                else if (counter < 8)
                {
                    // trade picture to explosion
                    this.pbMinion.BackgroundImage = global::_42dayrange.Properties.Resources.ex5;
                }
                else if (counter < 9)
                {
                    // trade picture to explosion
                    this.pbMinion.BackgroundImage = global::_42dayrange.Properties.Resources.ex6;
                }
                else if (counter < 10)
                {
                    // trade picture to explosion
                    this.pbMinion.BackgroundImage = global::_42dayrange.Properties.Resources.PurpleMinion;
                    scene = Scene.Three;
                }
            }
            else if (scene == Scene.Three) // Play Scene Three
            {
                if (counter < 12)
                {
                    // wait
                }
                else if (counter == 12)
                {
                    sp.Dispose();
                    assembly = Assembly.GetExecutingAssembly();
                    sp = new SoundPlayer(assembly.GetManifestResourceStream
                        ("_42dayrange._death.wav"));
                    sp.Play();
                }
                else
                {
                    // display end message
                    lblNotice.Text = "No minions were harmed during the";
                    lblNotice2.Text = "construction of this animation...";
                    lblNotice.Visible = true;
                    lblNotice2.Visible = true;
                }
            }
            counter++;
        }

        private void EasterEggForm_Load(object sender, EventArgs e)
        {
            pbPacman.Left = 0 - pbPacman.Width;
            pbMinion.Left = this.Width + pbMinion.Width;
            lblNotice.Visible = false;
            lblNotice2.Visible = false;
            assembly = Assembly.GetExecutingAssembly();
            sp = new SoundPlayer(assembly.GetManifestResourceStream
                ("_42dayrange._chomp.wav"));
            sp.Play();  

        }


    }
}
