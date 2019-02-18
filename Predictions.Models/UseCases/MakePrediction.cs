using Predictions.Models;

namespace Predictions.UseCases {
    public class MakePrediction {
        public string AskQuestion(string question) {
            if (string.IsNullOrEmpty(question)) {
                return "Please ask a question.";
            }

            return new EightBall().Shake();
        }
    }
}
