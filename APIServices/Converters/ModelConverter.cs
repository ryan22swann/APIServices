using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIServices.BusinessObjects;
using APIServices.Entities;


namespace APIServices.Converters
{
    class ModelConverter
    {

        internal Model Convert(ModelBO model)
        {
            return new Model()
            {
                Id = model.Id,
                model_name = model.model_name,
                model_version = model.model_version,
                model_author = model.model_author,
                model_url = model.model_url,
                model_deployment_environment = model.model_deployment_environment,
                model_input_features = model.model_input_features,
                model_dataset_location = model.model_dataset_location,
                model_code_location = model.model_code_location,
                model_environment_status = model.model_environment_status,
                model_artifacts = model.model_artifacts
            };
        }

        internal ModelBO Convert(Model model)
        {
            return new ModelBO()
            {
                Id = model.Id,
                model_name = model.model_name,
                model_version = model.model_version,
                model_author = model.model_author,
                model_url = model.model_url,
                model_deployment_environment = model.model_deployment_environment,
                model_input_features = model.model_input_features,
                model_dataset_location = model.model_dataset_location,
                model_code_location = model.model_code_location,
                model_environment_status = model.model_environment_status,
                model_artifacts = model.model_artifacts
            };
        
        }
    }
}