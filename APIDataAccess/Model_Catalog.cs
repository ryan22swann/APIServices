//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Model_Catalog
    {
        public int id { get; set; }
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
