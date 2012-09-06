﻿using System.Collections.Generic;
using com.careerbuilder.api.models;
using com.careerbuilder.api.models.service;
using com.careerbuilder.api.models.responses;

namespace com.careerbuilder.api.framework.requests
{
    internal class JobReportRequest : GetRequest
    {
        private string _JobDID = "";
        public JobReportRequest(string jobDID, string key, string domain, string cobrand, string siteid)
            : base (key, domain, cobrand, siteid)
        {
            _JobDID = jobDID;
        }

        public override string BaseURL
        {
            get { return "/v1/jobreport"; }
        }

        public ResponseJobReport GetReport()
        {
            base.BeforeRequest();
            _request.AddParameter("JobDID", _JobDID);
            var response = _client.Execute<ResponseJobReport>(_request);
            return response.Data;
        }
    }
}