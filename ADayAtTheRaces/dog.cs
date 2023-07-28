using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ADayAtTheRaces
{
    public class Dog
    {
        public Point StartingPosition;
        public PictureBox MyPictureBox;
        public Color PrimaryColor;
        public Color SecondaryColor; // Variável para a cor de fundo secundária
        public int ID;
        private static object lockObj = new object(); // Objeto usado para sincronização

        public static List<Dog> dogsList;
        public static bool cachorroCampeao;
        private Random random = new Random();
        private Timer timer = new Timer();
        private int intervalo = 100; // Intervalo de tempo entre os movimentos em milissegundos
        public int targetX = Form1.racetrackLength; // Posição X desejada (onde o cão deve parar)
        private bool isSecondaryColor = false; // Variável para alternar entre as cores de fundo
        private static bool corridaTerminou = false;
        private int posicao = 0; // Variável para armazenar a posição atual do dog
        private bool begging = true;
        private bool resultado = false;

        public Dog()
        {
            timer.Interval = intervalo;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lock (lockObj)
            {
                if (corridaTerminou)
                {
                    timer.Stop();
                    return;
                }
                // Aqui você pode colocar a lógica que deseja executar em cada intervalo do timer

                // Alterna a cor de fundo entre PrimaryColor e SecondaryColor
                MyPictureBox.BackColor = isSecondaryColor ? SecondaryColor : PrimaryColor;
                isSecondaryColor = !isSecondaryColor;

                // Move o cão horizontalmente até atingir a posição X desejada
                Point p = MyPictureBox.Location;
                if (p.X >= targetX)
                {
                    p.X += 0;
                }
                else
                {
                    Random random = new Random();
                    p.X += random.Next(1, 15);
                }

                MyPictureBox.Location = p;

                if (p.X >= targetX)
                {
                    // Caso a posição X atinja ou ultrapasse a posição desejada, paramos o Timer
                    timer.Stop();
                    StopRace();
                    Form1.corrida = false;
                    resultado = true;
                    MessageBox.Show("Le Chien with the nº:" + ID + " is our new champion!");
                    cachorroCampeao = true;

                    // Marque a corrida como terminada para todos os cães
                    corridaTerminou = true;

                    // Informe ao Form1 que a corrida terminou
                    Form1.corrida = false;

                }
            }
        }

        public void ContinueRunning()
        {
            timer.Start();
        }
        public void Run()
        {
            if (begging)
            {
                StartingPosition = MyPictureBox.Location;
                begging = false;
            }
            corridaTerminou = false;

            if (resultado)
            {
                resultado = false;
            }
            else
            {
                MyPictureBox.Location = StartingPosition;
                

                timer.Start();
                resultado = true;
            }

        }
        public void StopRunning()
        {
            timer.Stop();
        }

        public void StopRace()
        {
            // Defina a corrida como false
            Form1.corrida = false;

            // Verifique se algum cão chegou ao ponto final
            bool algumCaoChegouAoPontoFinal = false;
            foreach (var dog in Form1.dogsList)
            {

                if (dog.MyPictureBox.Location.X >= Form1.racetrackLength)
                {
                    
                    algumCaoChegouAoPontoFinal = true;
                    break;
                }
            }

            // Pare todos os cães
            foreach (var dog in Form1.dogsList)
            {
                if (algumCaoChegouAoPontoFinal)
                {
                    // Se algum cão chegou ao ponto final, pare todos os cães
                    
                    dog.StopRunning();
                }
                else
                {
                    // Se nenhum cão chegou ao ponto final, continue a corrida para os cães restantes
                    dog.ContinueRunning();
                }
            }
        }
    }
}

