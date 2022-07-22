using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ML;
using System;
using static HousePricePrediction.PricePredictMLM;

namespace HousePricePrediction.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("[controller]")]
    public class PredictController : ControllerBase
    {
        private readonly PredictionEnginePool<ModelInput, ModelOutput> _predictionEnginePool;

        public PredictController(PredictionEnginePool<ModelInput, ModelOutput> predictionEnginePool)
        {
            _predictionEnginePool = predictionEnginePool;
        }

        [Route("~/api/Predict/PriceHousePredict")]
        [HttpPost]
        public ActionResult<string> PriceHousePredict([FromBody] ModelInput input)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            ModelOutput prediction = _predictionEnginePool.Predict(input);

            return Ok(Math.Round( prediction.Score, 2).ToString());
        }
    }
}
