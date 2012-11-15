﻿using System;
namespace CBApi.Models {
    [Serializable]
    public class RecommendJobResult {
        public string JobDid { get; set; }
        public string Title { get; set; }
        public double Relevancy { get; set; }
        public Location Location { get; set; }
        public Company Company { get; set; }
        public string JobDetailsUrl { get; set; }
        public string JobServiceUrl { get; set; }
        public string SimilarJobsUrl { get; set; }
        public bool CanBeQuickApplied { get; set; }
    }
}