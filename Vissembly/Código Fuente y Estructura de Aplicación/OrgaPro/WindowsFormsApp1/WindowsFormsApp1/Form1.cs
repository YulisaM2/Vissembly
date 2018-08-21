using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        string lineaOfCode;
        string lineaOfCodeS;
        string[] line = new string[1000];
        int resource = 0;
        int IR = 0;
        int PC = 1;
        int AC = 0;
        int MAR = 0;
        int MDR = 0;
        int[] MM = new int[999]; // left direction right data
        string test;
        int LengthMemory;


        public Form1()
        {
            InitializeComponent();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // RESET VARIABLES
             resource = 0;
             IR = 0;
             PC = 1;
             AC = 0;
             MAR = 0;
             MDR = 0;
            lineaOfCode = richTextBox1.Text;
            lineaOfCodeS = lineaOfCode;
            lineaOfCode = lineaOfCode.Replace(" ", "");
            string[] line = lineaOfCode.Split('\n');
            int pointer = line.Length;
   
            MARBox.Text = MAR.ToString();
            ACBox.Text = AC.ToString();
            MDRBox.Text = MDR.ToString();

            richTextBox3.Text = "";
            for (int i = 0; i < pointer; i++)
            { 
                IR = i;
                PC = IR + 1;
                PCBox.Text = PC.ToString();
                IRBox.Text = IR.ToString();
                LengthMemory = line[i].Length;
                richTextBox3.Text += " " + i.ToString() + "\n";




                if (LengthMemory != 6 && LengthMemory != 3 && LengthMemory != 9)
                {
                    // display message error 
                    MessageBox.Show("CHECK error in line:" + i);
                    break;
                }
                else
                {
                    test = line[i].Substring(0, 3);

                    if (LengthMemory == 6) // if has 6
                    {
                        if (test.ToUpper() == "ORG")
                        {
                            test = line[i].Substring(3, 3);
                            i = Int32.Parse(test);
                            IR = i;

                        }
                        else
                        {
                            MessageBox.Show("type error line: " + i);
                            break;
                        }


                    }
                    else if (LengthMemory == 9) // if has 9
                    {
                        // microoperation of lda
                         if (test.ToUpper() == "LDA")
                        {
                            test = line[i].Substring(3, 3);
                            if (test == "ABS")
                            {
                                MAR = Int32.Parse(line[i].Substring(6, 3));
                                AC = MM[MAR];
                                ACBox.Text = AC.ToString();
                                MARBox.Text = MAR.ToString();
                                MDRBox.Text = MM[MAR].ToString();

                            }
                            else if (test.ToUpper() == "IND")
                            {

                                MAR = Int32.Parse(line[i].Substring(6, 3));
                                
                                resource = MM[MAR];
                                AC = MM[resource];
                                ACBox.Text = AC.ToString();
                                MAR = resource;
                                MDR = MM[resource];
                                MARBox.Text = MAR.ToString();
                                MDRBox.Text = MM[MAR].ToString();

                            }
                            else if (test.ToUpper() == "REL")
                            {

                                resource = Int32.Parse(line[i].Substring(6, 3));

                                resource = PC + resource;
                                AC = MM[resource];
                                MAR = resource;
                                MDR = MM[MAR];
                                MARBox.Text = MAR.ToString();
                                MDRBox.Text = MM[MAR].ToString();
                                ACBox.Text = AC.ToString();

                            }
                            else if (test.ToUpper() == "INM")
                            {
                                AC = Int32.Parse(line[i].Substring(6, 3));
                                ACBox.Text = AC.ToString();


                            }
                            else
                            {
                                MessageBox.Show("type error line: " + i);
                                break;
                            }

                        }
                        // microopretaion of add
                        else if (test.ToUpper() == "ADD")
                        {
                            test = line[i].Substring(3, 3);
                            if (test == "ABS")
                            {
                                MAR = Int32.Parse(line[i].Substring(6, 3));
                                resource = Int32.Parse(ACBox.Text);
                                AC = MM[MAR] + resource;
                                MDR = MM[MAR];
                                if (AC > 999 || AC < -999)
                                {
                                    MessageBox.Show("Overflow in line: " + (1 + i).ToString());
                                    break;

                                }
                                else
                                {
                                    ACBox.Text = AC.ToString();
                                    MARBox.Text = MAR.ToString();
                                    MDRBox.Text = MM[MAR].ToString();

                                }

                            }
                            else if (test.ToUpper() == "IND")
                            {

                                MAR = Int32.Parse(line[i].Substring(6, 3));

                                resource = MM[MAR];
                                AC = AC + MM[resource];
                                MDR = MM[MAR];
                                if (AC > 999 || AC < -999)
                                {
                                    MessageBox.Show("Overflow in line: " + (1 + i).ToString());
                                    break;

                                }
                                else
                                {
                                    ACBox.Text = AC.ToString();
                                    MARBox.Text = MAR.ToString();
                                    MDRBox.Text = MM[MAR].ToString();

                                }

                            }
                            else if (test.ToUpper() == "REL")
                            {

                                resource = Int32.Parse(line[i].Substring(6, 3));

                                MAR = PC + resource;
                                AC = AC + MM[MAR];
                                MDR = MM[MAR];
                                if (AC > 999 || AC < -999)
                                {
                                    MessageBox.Show("Overflow in line: " + (1 + i).ToString());
                                    break;

                                }
                                else
                                {
                                    ACBox.Text = AC.ToString();
                                    MARBox.Text = MAR.ToString();
                                    MDRBox.Text = MM[MAR].ToString();

                                }

                            }
                            else if (test.ToUpper() == "INM")
                            {
                                AC = AC + Int32.Parse(line[i].Substring(6, 3));
                                if (AC > 999 || AC < -999)
                                {
                                    MessageBox.Show("Overflow in line: " + (1 + i).ToString());
                                    break;

                                }
                                else
                                {
                                    ACBox.Text = AC.ToString();

                                }



                            }
                            else
                            {
                                MessageBox.Show("type error line: " + i);
                                break;
                            }
                        }
                        // MICROOPERATION of STA
                        else if (test.ToUpper() == "STA")
                        {
                            test = line[i].Substring(3, 3);
                            if (test == "ABS")
                            {
                                MAR = Int32.Parse(line[i].Substring(6, 3));
                                MM[MAR] = AC;
                                MDR = MM[MAR];
                                MDRBox.Text = MDR.ToString();
                                MARBox.Text = MAR.ToString();



                            }
                            else if (test.ToUpper() == "IND")
                            {

                                MAR = Int32.Parse(line[i].Substring(6, 3));

                                resource = MM[MAR];
                                MM[resource] = AC;

                            }
                            else if (test.ToUpper() == "REL")
                            {

                                resource = Int32.Parse(line[i].Substring(6, 3));

                                resource = PC + resource;
                                MM[resource] = AC;
                                MAR = resource;
                                MDR = MM[resource];
                                MARBox.Text = MAR.ToString();
                                MDRBox.Text = MM[MAR].ToString();

                            }
                            else
                            {
                                MessageBox.Show("type error line: " + i);
                                break;
                            }
                        }
                        // Microoperation SUB //Subway <3
                        else if (test.ToUpper() == "SUB")
                        {
                            test = line[i].Substring(3, 3);
                            if (test == "ABS")
                            {
                                MAR = Int32.Parse(line[i].Substring(6, 3));
                                resource = Int32.Parse(ACBox.Text);
                                AC = resource - MM[MAR];
                                if (AC > 999 || AC < -999)
                                {
                                    MessageBox.Show("Overflow in line: " + (1+ i).ToString());
                                    break;

                                }
                                else
                                {
                                    ACBox.Text = AC.ToString();
                                    MARBox.Text = MAR.ToString();
                                    MDRBox.Text = MM[MAR].ToString();

                                }


                            }
                            else if (test.ToUpper() == "IND")
                            {

                                MAR = Int32.Parse(line[i].Substring(6, 3));

                                resource = MM[MAR];
                                AC = AC - MM[resource];
                                if (AC > 999 || AC < -999)
                                {
                                    MessageBox.Show("Overflow in line: " + (1 + i).ToString());
                                    break;

                                }
                                else
                                {
                                    ACBox.Text = AC.ToString();
                                    MARBox.Text = MAR.ToString();
                                    MDRBox.Text = MM[MAR].ToString();

                                }


                            }
                            else if (test.ToUpper() == "REL")
                            {

                                resource = Int32.Parse(line[i].Substring(6, 3));
                                resource = PC + resource;
                                AC = AC - MM[resource];
                                if (AC > 999 || AC < -999)
                                {
                                    MessageBox.Show("Overflow in line: " + (1 + i).ToString());
                                    break;

                                }
                                else
                                {
                                    ACBox.Text = AC.ToString();
                                    MARBox.Text = MAR.ToString();
                                    MDRBox.Text = MM[MAR].ToString();

                                }

                            }
                            else if (test.ToUpper() == "INM")
                            {
                                AC = AC - Int32.Parse(line[i].Substring(6, 3));
                                if (AC > 999 || AC < -999)
                                {
                                    MessageBox.Show("Overflow in line: " + (1 + i).ToString());
                                    break;

                                }
                                else
                                {
                                    ACBox.Text = AC.ToString();

                                }




                            }
                            else
                            {
                                MessageBox.Show("type error line: " + i);
                                break;
                            }

                        }
                        
                         //JMP PROCEESS

                        else if (test.ToUpper() == "JMP")
                        {
                            test = line[i].Substring(3, 3);
                            if (test == "ABS")
                            {
                                IR = Int32.Parse(line[i].Substring(6, 3));
                                i = IR-1;

                            }
                            else if (test.ToUpper() == "IND")
                            {

                                MAR = Int32.Parse(line[i].Substring(6, 3));

                                resource = MM[MAR];
                                IR = MM[resource];
                                i = IR-1;

                            }
                            else if (test.ToUpper() == "REL")
                            {

                                resource = Int32.Parse(line[i].Substring(6, 3));

                                resource = PC + resource;
                                i = resource;

                            }
                            else if (test.ToUpper() == "INM")
                            {
                                IR = Int32.Parse(line[i].Substring(6, 3));
                                i = IR-1;

                            }
                                                   else
                            {
                                MessageBox.Show("type error line: " + i);
                                break;
                            }
                        }
                    }






                    else if(LengthMemory == 3) // if has 3
                    {

                        if (test.ToUpper() == "HLT") {
                            break;
                        }
                        // microoperation CLA
                        else if (test.ToUpper() == "CLA")
                        {
                            AC = 0;
                            ACBox.Text = AC.ToString();
                        }
                        else if (test.ToUpper() == "NOP")
                        {

                        }
                        else if (test.ToUpper() == "NEG")
                        {
                            AC = AC * -1;
                            ACBox.Text = AC.ToString();

                        }
                        else
                        {
                            MessageBox.Show("type error line: " + i);
                            break;
                        }


                    }



                }

            }
            
        }
        //codigo de prueba

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged_1(object sender, EventArgs e)
        {

        }
        // BUTTON  FOR MM CHANGE
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            resource = Int32.Parse(InputMAR.Text);
            MDR = Int32.Parse(InputMDR.Text);
            if (MDR < -999 || MDR > 999)
            {
                MessageBox.Show("Overflow");

            }
            else
                MM[resource] = MDR;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
