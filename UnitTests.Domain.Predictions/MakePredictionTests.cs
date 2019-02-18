using System.Linq;

using NUnit.Framework;

using Predictions.UseCases;
using Predictions.Models;

namespace UseCaseTests {
    public class MakePredictionTests {
        [Test]
        public void Can_Construct_UseCase() {
            var makePrediction = new MakePrediction();

            Assert.IsNotNull(makePrediction);
        }

        [Test]
        public void Asking_Questions_Provides_Answer() {
            var makePrediction = new MakePrediction();
            var answer = makePrediction.AskQuestion("Will this work?");

            Assert.IsTrue(EightBall.Predictions.Contains(answer));
        }
    }
}
