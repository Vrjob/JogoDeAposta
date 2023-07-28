using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public partial class Form1 : Form
    {
        public static int racetrackLength = 420;
        Dog dog1;
        Dog dog2;
        Dog dog3;
        Dog dog4;
        public static bool corrida;
        public int posicao;
        public static List<Dog> dogsList = new List<Dog>();
        private int intervalo = 100;
        public bool corridaAndamento = false;
        public int NdeCorrida = 1;
        public bool CorrerOuResultado = true;
        public int CaoCampeao;

        // guys NAMES
        public string nameJoe = "Joe";
        public string nameAl = "Al";
        public string nameBob = "Bob";
        // guys InitialMONEY
        public int initialMoneyJoe = 50;
        public int initialMoneyAl = 75;
        public int initialMoneyBob = 45;
        // guys CurrentMONEY
        public int moneyJoe = 50;
        public int moneyAl = 75;
        public int moneyBob = 45;
        // guys BET
        public int betJoe = 0;
        public int betAl = 0;
        public int betBob = 0;
        // guys DOG
        public int dogJoe = 0;
        public int dogAl = 0;
        public int dogBob = 0;

        private int caoCampeaoID = -1;

        public Form1()
        {
            InitializeComponent();
            button2.BackColor = Color.Blue;
            nrc_Bucks.Value = 5;
            nrc_DogNum.Value = 1;
            corrida = false;
            dog1 = new Dog()
            {
                ID = 1,
                MyPictureBox = img_Dog1, 
                PrimaryColor = Color.Red, 
                SecondaryColor = Color.Yellow,
            };
            dog2 = new Dog()
            {
                ID = 2,
                MyPictureBox = img_Dog2,
                PrimaryColor = Color.Teal,
                SecondaryColor = Color.GreenYellow,
            };
            dog3 = new Dog()
            {
                ID = 3,
                MyPictureBox = img_Dog3,
                PrimaryColor = Color.Blue,
                SecondaryColor = Color.HotPink,
            };
            dog4 = new Dog()
            {
                ID = 4,
                MyPictureBox = img_Dog4,
                PrimaryColor = Color.Black,
                SecondaryColor = Color.OrangeRed,
            };

            dogsList.Add(dog1);
            dogsList.Add(dog2);
            dogsList.Add(dog3);
            dogsList.Add(dog4);
            progressBar.Minimum = 0;
            progressBar.Maximum = 800;

        }
        private void button2_Click(object sender, EventArgs e)
        {
        if ((dogAl == 0) || (dogBob == 0) || (dogJoe == 0))
           {
                MessageBox.Show("Everybody needs to Select a Chien!");
           }
            else if((betAl == 0) || (betBob == 0) || (betJoe == 0))
                {
                MessageBox.Show("Everybody needs to Choose your bet!");
            }
            else { 
            if (!corridaAndamento)
            {

                posicao = 0;
                corrida = true;
                dog1.Run();
                dog2.Run();
                dog3.Run();
                dog4.Run();
                CarregarCorrida();

                if (NdeCorrida > 1 && !CorrerOuResultado)
                {
                    int maiorX = 0;
                    
                    foreach (var dog in dogsList)
                    {
                        if (dog.MyPictureBox.Location.X > maiorX)
                        {
                            maiorX = dog.MyPictureBox.Location.X;
                            caoCampeaoID = dog.ID;
                            
                        }
                    }

                    // Se algum cão chegou ao ponto final, exiba uma mensagem com o cão campeão
                    if (caoCampeaoID != -1)
                    {
                        MessageBox.Show("La magasin de paris' values ​​have been distributed!");
                        

                    }
                        Aposta();
                }
                }
            }
        }


            // Pare todos os cães
            
        private async Task CarregarCorrida()
        {
            int duracaoEspera;
            if (!CorrerOuResultado)
            {
                progressBar.Maximum = 1500;
                progressBar.Value = 0;
                duracaoEspera = 1500;


                button2.BackColor = Color.Gray;
                button2.Text = "Wait";
                

                corridaAndamento = true;
                while (progressBar.Value < progressBar.Maximum)
                {
                    await Task.Delay(10); // Um pequeno atraso para não travar a interface do usuário

                    // Atualiza o valor da barra de progresso de acordo com o tempo decorrido
                    progressBar.Value += 10; // O valor pode ser ajustado de acordo com a velocidade desejada da barra de carregamento
                }
                corridaAndamento = false;
                button2.Text = "Start Race nº" + NdeCorrida + " !";
                CorrerOuResultado = true;
                button2.BackColor = Color.Blue;
                lbl_AlBet.Text = "Al bets nothing...";
                lbl_JoeBet.Text = "Joe bets nothing...";
                lbl_BobBet.Text = "Bob bets nothing...";

                nrc_Bucks.Value = 5;
                nrc_DogNum.Value = 1;

            } else
            {
                progressBar.Maximum = 6500;
                progressBar.Value = 0;
                duracaoEspera = 6500;


                button2.BackColor = Color.Gray;
                button2.Text = "Wait";
                corridaAndamento = true;
                while (progressBar.Value < progressBar.Maximum)
                {
                    await Task.Delay(10); // Um pequeno atraso para não travar a interface do usuário

                    // Atualiza o valor da barra de progresso de acordo com o tempo decorrido
                    progressBar.Value += 10; // O valor pode ser ajustado de acordo com a velocidade desejada da barra de carregamento
                }
                corridaAndamento = false;
                button2.Text = "Results";
                NdeCorrida++;
                CorrerOuResultado = false;
                button2.BackColor = Color.Blue;
            }

        }

        private void img_Dog2_Click(object sender, EventArgs e)
        {
            nrc_DogNum.Value = 2;
        }
        public void Aposta()
        {

            MessageBox.Show("Joe bets  $" + betJoe + " Bucks on dog nº: " + dogJoe);
            if (dogJoe == caoCampeaoID)
            {
                betJoe *= 2;
                moneyJoe += betJoe;
                MessageBox.Show("Joe won:" + '$' + betJoe + " and now he has:" + '$' + moneyJoe);
            } else{
                moneyJoe -= betJoe;
                MessageBox.Show("Joe lost and now he has: " + '$' + moneyJoe);
            }

            MessageBox.Show("Bob bets  $" + betBob + " Bucks on dog nº: " + dogBob);
            if (dogBob == caoCampeaoID)
            {
                betBob *= 2;
                moneyBob += betBob;
                MessageBox.Show("Bob won:" + '$' + betBob + " and now he has:" + '$' + moneyBob);

            }else{
                moneyBob -= betBob;
                MessageBox.Show("Bob lost and now he has: " + '$' + moneyBob);

            }

            MessageBox.Show("Al bets  $" + betAl + " Bucks on dog nº: " + dogAl);
            if (dogAl == caoCampeaoID)
            {
                betAl *= 2;
                moneyAl += betAl;
                MessageBox.Show("Al won:" + '$' + betAl + " and now he has:" + '$' + moneyAl);

            }else{
                moneyAl -= betAl;
                MessageBox.Show("Al  lost and now he has: " + '$' + moneyAl);
            }
            betJoe = 0;
            betAl = 0;
            betBob = 0;

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Name1.Text = "Joe";
            lbl_Name2.Text = "Joe";
            nrc_Bucks.Value = 5;
            nrc_DogNum.Value = 1;
            lbl_InitialMoney.Text = '$' + Convert.ToString(initialMoneyJoe);
            lbl_CurrentMoney.Text = '$' + Convert.ToString(moneyJoe);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Name1.Text = "Al";
            lbl_Name2.Text = "Al";
            nrc_Bucks.Value = 5;
            nrc_DogNum.Value = 1;
            lbl_InitialMoney.Text = '$' + Convert.ToString(initialMoneyAl);
            lbl_CurrentMoney.Text = '$' + Convert.ToString(moneyAl);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btn_Bet_Click(object sender, EventArgs e)
        {
         if (!corridaAndamento && CorrerOuResultado) {    
            if (btn_Joe.Checked)
            {
                betJoe = (int)nrc_Bucks.Value;
                dogJoe = (int)nrc_DogNum.Value;
                lbl_JoeBet.Text = "Joe bets $" + betJoe + " on dog " + dogJoe;

            }
            if (btn_Al.Checked)
            {
                betAl = (int)nrc_Bucks.Value;
                dogAl = (int)nrc_DogNum.Value;
                lbl_AlBet.Text = "Al bets $"+ betAl +" on dog " + dogAl ;
            }
            if (btn_Bob.Checked)
            {
                betBob = (int)nrc_Bucks.Value;
                dogBob = (int)nrc_DogNum.Value;
                lbl_BobBet.Text = "Bob bets $" + betBob + " on dog " + dogBob;
            }
            }
        }

        private void btn_Bob_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Name1.Text = "Bob";
            lbl_Name2.Text = "Bob";
            nrc_Bucks.Value = 5;
            nrc_DogNum.Value = 1;
            lbl_InitialMoney.Text = '$'+Convert.ToString(initialMoneyBob);
            lbl_CurrentMoney.Text = '$' + Convert.ToString(moneyBob);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Add a random key to the ListBox
           timer1.Stop();
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void img_Dog1_Click(object sender, EventArgs e)
        {
            nrc_DogNum.Value = 1;
        }

        private void img_Dog3_Click(object sender, EventArgs e)
        {
            nrc_DogNum.Value = 3;
        }

        private void img_Dog4_Click(object sender, EventArgs e)
        {
            nrc_DogNum.Value = 4;
        }
    }
}
