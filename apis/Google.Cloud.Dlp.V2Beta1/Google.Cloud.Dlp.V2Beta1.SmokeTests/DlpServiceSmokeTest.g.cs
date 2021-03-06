// Copyright 2017, Google LLC All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Dlp.V2Beta1.SmokeTests
{
    public class DlpServiceSmokeTest
    {
        public static int Main(string[] args)
        {
            // Create client
            DlpServiceClient client = DlpServiceClient.Create();

            // Initialize request argument(s)
            InspectConfig inspectConfig = new InspectConfig
            {
                MinLikelihood = Likelihood.Possible,
            };
            IEnumerable<ContentItem> items = new[]
            {
                new ContentItem
                {
                    Type = "text/plain",
                    Value = "my phone number is 215-512-1212",
                },
            };

            // Call API method
            InspectContentResponse response = client.InspectContent(inspectConfig, items);
            // Show the result
            Console.WriteLine(response);

            // Success
            Console.WriteLine("Smoke test passed OK");
            return 0;
        }
    }
}
