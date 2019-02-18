using System.Collections.Generic;

using NUnit.Framework;
using Predictions.Models;

namespace DomainTests {
    public class EightBallTests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void Can_Construct_EightBall() {
            var eightBall = new EightBall();

            Assert.IsNotNull(eightBall);
        }

        [Test]
        public void Shaking_EightBall_Returns_Answer() {
            var eightBall = new EightBall();
            var answer = eightBall.Shake();

            Assert.IsInstanceOf<string>(answer);
            Assert.IsFalse(string.IsNullOrWhiteSpace(answer));
        }

        [Test]
        public void All_Predictions_Provided_Within_100_Requests() {
            const int MaxAttempts = 100;

            var eightBall = new EightBall();
            var answersReceived = new HashSet<string>();
            var attempts = 0;

            while (answersReceived.Count < EightBall.Predictions.Length 
                && attempts < MaxAttempts) {
                var currentAnswer = eightBall.Shake();
                answersReceived.Add(currentAnswer);
                attempts++;
            }

            if (attempts < MaxAttempts) {
                Assert.Pass($"All possible answers received in {attempts} iterations.");
            } else {
                Assert.Fail($"Did not receive all possible answers within {MaxAttempts} attempts.");
            }
        }
    }
}