using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic8BallGame
{
    public partial class MagicEightBallGame : Form
    {
        // First we generate a random object for the possible answers. 
        Random random = new Random();
        // Then we create a list for storing the answers. 
        List<String> answers = new List<String>();
        public MagicEightBallGame()
        {
            InitializeComponent();
            // Then we'll add the possible outcomes to our answers list, first positives.
            answers.Add("It is certain.");
            answers.Add("It is decidedly so.");
            answers.Add("Without a doubt.");
            answers.Add("Yes definitely.");
            answers.Add("You may rely on it.");
            answers.Add("As I see it, yes.");
            answers.Add("Most likely.");
            answers.Add("Outlook good.");
            answers.Add("Yes.");
            answers.Add("Signs point to yes.");

            // And then the neutral answers.
            answers.Add("Reply hazy, try again.");
            answers.Add("Ask again later.");
            answers.Add("Better not tell you now.");
            answers.Add("Cannot predict now.");
            answers.Add("Concentrate and ask again.");

            // And finally the negatives. 
            answers.Add("Don't count on it.");
            answers.Add("My reply is no.");
            answers.Add("My sources say no.");
            answers.Add("Outlook not so good.");
            answers.Add("Very doubtful.");
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // Once button is clicked, generate a random answer from the list and show it to the user. 
            int index = random.Next(answers.Count); 
            answerLbl.Text = answers[index];
        }
    }
}
