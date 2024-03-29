﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StorageHub.Controllers
{
    public class AuthCallbackController : Google.Apis.Auth.OAuth2.Mvc.Controllers.AuthCallbackController
    {
        protected override Google.Apis.Auth.OAuth2.Mvc.FlowMetadata FlowData
        {
            get { return new StorageHub.Utility.DriveFlowMetadata(); }
        }

        protected override ActionResult OnTokenError(Google.Apis.Auth.OAuth2.Responses.TokenErrorResponse errorResponse)
        {
            ViewBag.Message = errorResponse.Error;
            return RedirectToAction("Manage", "StorageManagement");
        }
    }
}