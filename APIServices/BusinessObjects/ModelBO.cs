using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Web;

namespace APIServices.BusinessObjects
{
    public class ModelBO
    {
        public int Id { get; set; }

        public string model_name { get; set; }

        public string model_version { get; set; }
        public string model_author { get; set; }
        public string model_url { get; set; }
        public string model_deployment_environment { get; set; }
        public string model_input_features { get; set; }
        public string model_dataset_location { get; set; }
        public string model_code_location { get; set; }
        public string model_environment_status { get; set; }
        public string model_artifacts { get; set; }
    }
}
