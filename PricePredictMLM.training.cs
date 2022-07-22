﻿﻿// This file was auto-generated by ML.NET Model Builder. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers.FastTree;
using Microsoft.ML.Trainers;
using Microsoft.ML;

namespace HousePricePrediction
{
    public partial class PricePredictMLM
    {
        public static ITransformer RetrainPipeline(MLContext context, IDataView trainData)
        {
            var pipeline = BuildPipeline(context);
            var model = pipeline.Fit(trainData);

            return model;
        }

        /// <summary>
        /// build the pipeline that is used from model builder. Use this function to retrain model.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <returns></returns>
        public static IEstimator<ITransformer> BuildPipeline(MLContext mlContext)
        {
            // Data process configuration with pipeline data transformations
            var pipeline = mlContext.Transforms.Categorical.OneHotEncoding(new []{new InputOutputColumnPair(@"Type", @"Type"),new InputOutputColumnPair(@"District", @"District"),new InputOutputColumnPair(@"Address", @"Address"),new InputOutputColumnPair(@"Townhouse", @"Townhouse"),new InputOutputColumnPair(@"Amenity", @"Amenity"),new InputOutputColumnPair(@"Centrality", @"Centrality"),new InputOutputColumnPair(@"Transportation", @"Transportation")})      
                                    .Append(mlContext.Transforms.ReplaceMissingValues(new []{new InputOutputColumnPair(@"Area", @"Area"),new InputOutputColumnPair(@"LegalDocument", @"LegalDocument")}))      
                                    .Append(mlContext.Transforms.Concatenate(@"Features", new []{@"Type",@"District",@"Address",@"Townhouse",@"Amenity",@"Centrality",@"Transportation",@"Area",@"LegalDocument"}))      
                                    .Append(mlContext.Regression.Trainers.FastForest(new FastForestRegressionTrainer.Options(){NumberOfTrees=4,FeatureFraction=0.871241541909295F,LabelColumnName=@"SellPrice",FeatureColumnName=@"Features"}));

            return pipeline;
        }
    }
}
