namespace DZ_PTCA
{
    public partial class Form1 : Form
    {
        private string currentCondition = "Sleeping";
        private static Image catEating = new Bitmap(200, 200);
        private static Image catSleeping = new Bitmap(200, 200);
        private static Image catStudying = new Bitmap(200, 200);
        private static Image catWatching = new Bitmap(200, 200);
        private string happy;
        private string sad;
        private string Eating;
        private string Sleeping;
        private string Studying;
        private string Watching;


       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pictures();
            Condition();
            Happiness();
            myPictureBox.Image = catSleeping;
        }

        private void Pictures()
        {
            catEating = Image.FromFile(@"C:\Users\Maria\OneDrive\Рабочий стол\C#\DZ_PTCA\DZ_PTCA\Resources\cat_eating.jpg");
            catSleeping = Image.FromFile(@"C:\Users\Maria\OneDrive\Рабочий стол\C#\DZ_PTCA\DZ_PTCA\Resources\cat_sleeping.jpg");
            catStudying = Image.FromFile(@"C:\Users\Maria\OneDrive\Рабочий стол\C#\DZ_PTCA\DZ_PTCA\Resources\cat_studying.jpg");
            catWatching = Image.FromFile(@"C:\Users\Maria\OneDrive\Рабочий стол\C#\DZ_PTCA\DZ_PTCA\Resources\cat_watching.jpg");

        }

        private void Happiness()
        {
            happy = "Счастлива";
            sad = "Грущу";
        }

        private void Condition()
        {
            Eating = "Кушаю";
            Sleeping = "Сплю";
            Studying = "Учусь";
            Watching = "Смотрю сериал";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentCondition == "Studying")
            {
                myCondition.Text = Watching;
                currentCondition = "Watching";
                myHappiness.Text = happy;
                myPictureBox.Image = catWatching;
                panel1.BackColor = Color.Lime;
            }
            else
            {
                myCondition.Text = Eating;
                currentCondition = "Eating";
                myHappiness.Text = happy;
                myPictureBox.Image = catEating;
                panel1.BackColor = Color.Lime;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (currentCondition)
            {
                case "Sleeping":
                    myCondition.Text = Sleeping;
                    myHappiness.Text = happy;
                    myPictureBox.Image = catSleeping;
                    panel1.BackColor = Color.Lime;
                    break;
                case "Eating":
                    myCondition.Text = Studying;
                    currentCondition = "Studying";
                    myHappiness.Text = sad;
                    myPictureBox.Image = catStudying;
                    panel1.BackColor = Color.Red;
                    break;
                case "Studying":
                    myCondition.Text = Watching;
                    currentCondition = "Watching";
                    myHappiness.Text = happy;
                    myPictureBox.Image = catWatching;
                    panel1.BackColor = Color.Lime;
                    break;
                case "Watching":
                    myCondition.Text = Sleeping;
                    currentCondition = "Sleeping";
                    myHappiness.Text = happy;
                    myPictureBox.Image = catSleeping;
                    panel1.BackColor = Color.Lime;
                    break;
                default: break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            switch (currentCondition)
            {
                case "Sleeping":
                    myCondition.Text = Studying;
                    currentCondition = "Studying";
                    myHappiness.Text = sad;
                    myPictureBox.Image = catStudying;
                    panel1.BackColor = Color.Red;
                    break;
                case "Eating":
                    myCondition.Text = Watching;
                    currentCondition = "Watching";
                    myHappiness.Text = happy;
                    myPictureBox.Image = catWatching;
                    panel1.BackColor = Color.Lime;
                    break;
                case "Studying":
                    myCondition.Text = Studying;
                    currentCondition = "Studying";
                    myHappiness.Text = happy;
                    myPictureBox.Image = catStudying;
                    panel1.BackColor = Color.Lime;
                    break;
                case "Watching":
                    myCondition.Text = Eating;
                    currentCondition = "Eating";
                    myHappiness.Text = sad;
                    myPictureBox.Image = catEating;
                    panel1.BackColor = Color.Red;
                    break;
                default: break;
            }
        }
    }
}