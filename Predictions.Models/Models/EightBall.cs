using System;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("UnitTests.Domain.Predictions")]

namespace Predictions.Models {
    internal class EightBall {
        internal static readonly string[] Predictions = { "Yes", "No", "Perhaps", "Try again later", "Unclear, shake again" };
        private static Random random = new Random();

        internal string Shake() {
            return Predictions[random.Next(Predictions.Length)];
        }
    }
}
