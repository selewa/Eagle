﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using Eagle.Tests.DataObjects;
using Eagle.Tests.Domain.Models;

namespace Eagle.Tests.ServiceContracts
{
    [ServiceContract()]
    public interface IQueryService
    {
        [OperationContract()]
        [WebInvoke(UriTemplate = "Posts/All", Method = "GET", ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<PostDataObject> GetPosts();

        [OperationContract()]
        [WebInvoke(UriTemplate = "Posts/Query", Method = "Post", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<PostDataObject> GetPostsByQueryRequest(PostQueryRequest request);
    }
}
