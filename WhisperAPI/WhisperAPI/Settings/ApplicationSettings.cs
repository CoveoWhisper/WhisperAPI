﻿using System.Collections.Generic;

namespace WhisperAPI.Settings
{
    public class ApplicationSettings
    {
        public string ApiKey { get; set; }

        public string NlpApiBaseAddress { get; set; }

        public string MlApiBaseAddress { get; set; }

        public string SearchBaseAddress { get; set; }

        public List<string> IrrelevantIntents { get; set; }

        public int NumberOfResults { get; set; }

        public int NumberOfWordsIntoQ { get; set; }

        public double MinimumConfidence { get; set; }

        public double MinimumRelevantConfidence { get; set; }

        public string ContextLifeSpan { get; set; }

        public string OrganizationID { get; set; }
    }
}
