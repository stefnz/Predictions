using Predictions.Models;

namespace Predictions.UseCases {
    public class MakePrediction {
        public string AskQuestion(string question) {
            return new EightBall().Shake();
        }
    }
}
