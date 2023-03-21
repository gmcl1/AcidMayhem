using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeteorMayhem
{


    // Every 50 seconds we want a bonus item to come down that the player can pickup


    public partial class MeteorMayhem : Form
    {

        private List<Control> acidObjects = new List<Control>();
        private List<Control> objects = new List<Control>();

        private int bonusCooldown = 0;
        private const int leftScreenMax = 10;
        private const int rightScreenMax = 300;

        private bool right = false;
        private bool left = false;
        private bool paused;
        private int points;
        private int acidSpeed = 10;

        public MeteorMayhem()
        {
            InitializeComponent();
        }


        private void MeteorMayhem_Load(object sender, EventArgs e)
        {
            Load_Controls_By_Type("acid");
            Load_Controls_By_Type("bonus");
            Reset_All_Acid();
        
            this.paused = false;
            this.tmrGameTick.Enabled = true;
            this.points = 0;
        }

       
        private void tmrGameTick_Tick(object sender, EventArgs e)
        {
            Move_Acid(); 
            Move_Bonuses();
            Move_Player();
            Update_Points(); 
        }

        private void Move_Bonuses()
        {

            foreach(Control bonus in Get_All_Controls_Of_Type("bonus"))
            {
                if (bonusCooldown > 1)
                {
                    return;
                }

                Move_Control_Down(bonus, 25);

                if (Collides_With_Player(bonus)){
                    Run_Bonus();
                }

                if (Control_Out_Of_Bounds(bonus))
                {
                    Reset_Control(bonus);
                    this.bonusCooldown = 3;
                }

            }
        }

        private void Run_Bonus()
        {
            this.points += new Random().Next(1, 1000000000);
        }



        private void Move_Acid()
        {
            foreach (Control acid in Get_All_Controls_Of_Type("acid")) 
            {
                if (Collides_With_Control(acid, "acid")) 
                {
                    Reset_Control(acid);
                    continue;
                }

                if (Collides_With_Player(acid)) 
                {
                    Reset_Control(acid);
                    continue;
                }

                Move_Control_Down(acid, this.acidSpeed);

                if (Control_Out_Of_Bounds(acid)) 
                {
                    Reset_Control(acid); 
                }

            }
        }

        private bool Control_Out_Of_Bounds(Control ctr)
        {
            return ctr.Top > 550;
        }


      
        private void Reset_All_Acid()
        {
            Get_All_Controls_Of_Type("acid").ForEach(acid =>
            {
                Reset_Control(acid);
            }
            );
        }

     
        private void Reset_Control(Control ctr)
        {
            Random r = new Random();
            ctr.Top = r.Next(-500, -100);
            ctr.Left = r.Next(leftScreenMax, rightScreenMax);
        }

     
        private bool Collides_With_Player(Control ctr)
        {
            return ctr.Bounds.IntersectsWith(this.picPlayer.Bounds);
        }


        private void Update_Points()
        {
            points += 1;
            this.lblPoints.Text = points.ToString("0,0");
        }

 
        private void Move_Player()
        {
            if (right)
            {
                if (this.picPlayer.Left + 15 > rightScreenMax) return; 
                this.picPlayer.Left += 15;
            } else if(left)
            {   
                if(this.picPlayer.Left - 15 < leftScreenMax) return;
                this.picPlayer.Left -= 15;
            }
        }

        private void MeteorMayhem_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            switch(key)
            {
                case Keys.Left:
                case Keys.A:
                    this.left = true;
                    break;
                case Keys.Right:
                case Keys.D:
                    this.right = true;
                    break;
            }
        }

        private void MeteorMayhem_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.A:
                case Keys.Left:
                    this.left = false;
                    break;
                case Keys.Right:
                case Keys.D:
                    this.right = false;
                    break;
            }
        }

        private void picResumePause_Click(object sender, EventArgs e)
        {
            if (!this.paused)
            {
                this.tmrGameTick.Enabled = false;
                this.paused = true;
            }
            else
            {
                this.tmrGameTick.Enabled = true;
                this.paused = false;
            }
        }

        private void picRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Collides_With_Control(Control ctr, string controlType)
        {
            foreach (Control collidedCtr in Get_All_Controls_Of_Type(controlType))
            {
                string collidedTag = collidedCtr.Tag.ToString();
                string currentTag = ctr.Tag.ToString();

                if (!collidedTag.Equals(currentTag) && ctr.Bounds.IntersectsWith(collidedCtr.Bounds))
                {
                    return true;
                }
            }
            return false;
        }

        private void Move_Control_Down(Control ctr, int amount)
        {
            ctr.Top += amount;
        }

        private void Load_Controls_By_Type(string controlType)
        {
            foreach (Control crt in this.Controls)
            {
                if (Is_Control_Type(controlType, crt))
                    this.objects.Add(crt);
            }
        }

        private bool Is_Control_Type(string controlType, Control crt)
        {
            object data = crt.Tag;
            return data != null && data.ToString().Contains(controlType);
        }

        private List<Control> Get_All_Controls_Of_Type(string controlType)
        {
            List<Control> controls = new List<Control>();
            foreach (Control crt in this.objects)
            {
                if (Is_Control_Type(controlType, crt))
                    controls.Add(crt);
            }
            return controls;
        }

        private void tmrSecond_Tick(object sender, EventArgs e)
        {
            this.bonusCooldown--;
        }

        private void tmr5Second_Tick(object sender, EventArgs e)
        {
            this.acidSpeed += 1;
        }
    }

}
