﻿using Newtonsoft.Json;

namespace YTS.Models
{
    public class MovieDetails : MovieInfo
    {
        private string pMediumScreenshot1;
        private string pMediumScreenshot2;
        private string pMediumScreenshot3;
        private string pLargeScreenshot1;
        private string pLargeScreenshot2;
        private string pLargeScreenshot3;

        [JsonProperty("medium_screenshot_image1")]
        public string MediumScreenshot1
        {
            get => pMediumScreenshot1;
            set => pMediumScreenshot1 = value.Replace("\\", string.Empty);
        }

        [JsonProperty("medium_screenshot_image2")]
        public string MediumScreenshot2
        {
            get => pMediumScreenshot2;
            set => pMediumScreenshot2 = value.Replace("\\", string.Empty);
        }

        [JsonProperty("medium_screenshot_image3")]
        public string MediumScreenshot3
        {
            get => pMediumScreenshot3;
            set => pMediumScreenshot3 = value.Replace("\\", string.Empty);
        }

        [JsonProperty("large_screenshot_image1")]
        public string LargeScreenshot1
        {
            get => pLargeScreenshot1;
            set => pLargeScreenshot1 = value.Replace("\\", string.Empty);
        }

        [JsonProperty("large_screenshot_image2")]
        public string LargeScreenshot2
        {
            get => pLargeScreenshot2;
            set => pLargeScreenshot2 = value.Replace("\\", string.Empty);
        }

        [JsonProperty("large_screenshot_image3")]
        public string LargeScreenshot3
        {
            get => pLargeScreenshot3;
            set => pLargeScreenshot3 = value.Replace("\\", string.Empty);
        }

        [JsonProperty("cast")]
        public MovieActor[] Cast;
    }
}