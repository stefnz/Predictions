using Microsoft.AspNetCore.Mvc;

using Predictions.UseCases;

namespace API.Predictions.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class PredictionsController : ControllerBase {
        /// <summary>
        /// Gets a prediction to the given question
        /// </summary>
        /// <param name="question">Question to be answered</param>
        /// <returns>The answer</returns>
        /// https://172.23.133.131/api/predictions?question=%27Does%20this%20work?%27
        [HttpGet]
        public ActionResult<string> Get(string question) {
            return new MakePrediction().AskQuestion(question);
        }
    }
}

