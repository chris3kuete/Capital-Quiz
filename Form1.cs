using System.Xml.Linq;

namespace Capital_Quiz
{
    public partial class Form1 : Form
    {
        //Dictionnary of the US states and their capital
        private Dictionary<string, string> stateCap = new Dictionary<string, string>()
        {
            {"Washington", "Olympia" },
            {"Oregon", "Salem" },
            {"Michigan", "Lansing" },
            {"Pennsylvannia", "Harrisburg" },
            {"Texas", "Austin" },
            {"Georgia","Atlanta" },
            {"Indiana", "Indianapolis" },
            {"Alabama","Montgomery" },
            {"Alaska","Juneau"},
            {"Arizona", "Phoenix" },
            {"Arkansas","Little Rock" },
            {"California", "Sacramento" },
            {"Colorado","Denver" },
            {"Connecticut","Hardford" },
            {"Delaware","Dover" },
            {"Florida","Talahassee" },
            {"Hawai","Honolulu" },
            {"Idaho","Boise" },
            {"Illinois","Springfield" },
            {"Iowa","Des Moines" },
            {"Kansas","Topeka" },
            {"Kentucky","Frankfort" },
            {"Louisiana","Baton rouge" },
            {"Maine","Augusta" },
            {"Maryland","Annapolis" },
            {"Massachussetts","Boston" },
            {"Minnesota","Saint Paul" },
            {"Mississipi","Jackson" },
            {"Missouri","Jefferson city" },
            {"Montana","Helena" },
            {"Nebraska","Lincoln" },
            {"Nevada","Carson City" },
            {"New Hampshire","concord" },
            {"New Jersey","Trenton" },
            {"New Mexico","Santa Fe" },
            {"New York","Albany" },
            {"North carolina","Raleigh" },
            {"North Dakota","Bismarck" },
            {"Ohio","Columbus" },
            {"Oklahoma","Oklahoma city" },
            {"Rhode Island","Providence" },
            {"South Carolina","Columbia" },
            {"South Dakota","Pierre" },
            {"Tennessee","Nashville" },
            {"Utah","Salt lake city" },
            {"Vermont","Montpelier" },
            {"Virginia","Richmond" },
            {"West Virginia","Charlston" },
            {"Wisconsin","Madison" },
            {"Wyoming","Cheyenne" },


        };
        //Create a random object
        Random rand = new Random();

        string[] arr = new string[500];
        int index;

        int correct = 0;
        int count = 0;





        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private string getEltKey()
        {
            //Create a random number
            int ranNum = rand.Next(stateCap.Count);
            var element = stateCap.ElementAt(ranNum);
            
            return element.Key;

        }

        private string displayQuestion()
        {
           var key1 = getEltKey();
            QuestionsrichTextBox.Text = "What is the capital of " + key1 + " ?";
            return key1;
                   
        }
        private void checkAnswer()
        {
            string key2 = displayQuestion();

            foreach(var item in stateCap)
            {
                if (stateCap.ContainsKey(item.Key))
                {
                   if(item.Value == userAnswertb.Text){

                        correct++;
                        MessageBox.Show("right");

                    }
                    
                    scorelbl.Text = correct.ToString();
                    
                   
                }
                
            }
            count++;
            questionCountlbl.Text = count.ToString();
            if(stateCap.Count == count)
            {
                MessageBox.Show("END");
            }


        }

        private void nextQuestionbtn_Click(object sender, EventArgs e)
        {

            checkAnswer();
            userAnswertb.Text = "";


        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            displayQuestion();
            //checkAnswer();

        }
    }
}
