using System.Collections.Generic;


public class PromptMe{
    public List<string> _prompt;

        public string[] promptTexts = {
        "What did you learn today?",
        "What are you grateful for?",
        "Describe a challenge you faced today.",
        "What are your goals for tomorrow?",
        "Share a happy memory."
         };

        private Random random = new Random();

        public string GetRandomPromptText()
        {
            int index = random.Next(promptTexts.Length);
            return promptTexts[index];
        }
}